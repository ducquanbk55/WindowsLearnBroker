import bs4
import requests as rq
import pandas as pd
from tqdm import tqdm
import os
import pyautogui

def getCambrige(word):
    org_url = "https://dictionary.cambridge.org/dictionary/english/"
    homepage = "https://dictionary.cambridge.org"
    link_audio = "/media/english/uk_pron/u/uki/ukinc/ukincor012.mp3"
    
    # headers = {'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36'}
    headers = {
        "User-Agent": (
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) "
            "AppleWebKit/537.36 (KHTML, like Gecko) "
            "Chrome/116.0.0.0 Safari/537.36"
        ),
        "Accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8",
        "Accept-Language": "en-US,en;q=0.5",
        "Connection": "keep-alive",
    }
    soup = bs4.BeautifulSoup(rq.get(org_url+word, headers=headers).text, 'html')
    audios = soup.find("source", attrs={"type":"audio/mpeg"})
    audios = soup.find("source", attrs={"type":"audio/mpeg"})
    sound = ''
    link_audio =audios['src']
    link_audio = homepage+ link_audio
    try:
        define = soup.find("div", {"class": "def-block ddef_block"})
        meaning = soup.find("div", {"class": "def ddef_d db"})
        phoenic = soup.find("span", {"class": "ipa dipa lpr-2 lpl-1"})
        example = soup.find("span", {"class": "examp dexamp"})
        images = soup.find_all('amp-img')
        image = None
        
        define = define.text.replace('Add to word list', '').strip()
        meaning = meaning.text.replace('Add to word list', '').strip()
        phoenic = phoenic.text.replace('Add to word list', '').strip()
        for im in images:
            if 'picture of ' + word.lower() in im['alt']:
                image = im
            # print(im)
        filename = fr'pictures\{word}.jpg'
        if image:
            link_img = "https://dictionary.cambridge.org/"+image['src']
            if not os.path.isfile(filename):
                open(filename, 'wb').write(rq.get(link_img, headers=headers,allow_redirects=True).content)
                
        fileaudio = fr'sounds\{word}.mp3'
        if not os.path.isfile(fileaudio):
            open(fileaudio, 'wb').write(rq.get(link_audio, headers=headers,allow_redirects=True).content)
            if not os.path.isfile(fileaudio):
                sound = f'{word}.mp3'
    except Exception as ex:
        print(ex)
        define, meaning, phoenic = '','', ''
    return define, meaning, phoenic,example, sound
    
file = r"words.xlsx"
dfEnglish = pd.read_excel(file)
dfEnglish['No'] = 1
dfEnglish['Example'] = ''
dfEnglish1 = dfEnglish.to_dict(orient='records')

for i in tqdm(range(len(dfEnglish1)), desc ='Download word: '):
    try:
        define, meaning, phoenic, example, sound = getCambrige(dfEnglish1[i]['Word'])
        dfEnglish1[i]["No"] = i +1
        dfEnglish1[i]['Transcription'] = phoenic
        dfEnglish1[i]['Short Vietnamese'] = meaning
        dfEnglish['Example'] = example
        dfEnglish['Sound'] = sound
    except Exception as ex:
        print(ex)
        continue

file = r"Downloads_words.xlsx"
dfExcels = pd.DataFrame(data = dfEnglish1)
dfExcels['Suggestion'] = ''
dfExcels['Keyword'] = dfExcels['Word']
dfExcels['IMG'] = dfExcels['Word']
dfExcels['Full Vietnamese'] = dfExcels['Meaning'] + '\n'+dfExcels['Example']
dfExcels.to_excel(file)