using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;

namespace Learning_Extender.Models
{
    public abstract class MediaType
    {
        public int Index = 0;
        public string Text = "";
        public Image _Image = null;
        public SoundPlayer _Sound = null;

        public void setImage(string _url)
        {
            _Image = Image.FromFile(_url);
        }

        public void setAudio(string _url)
        {
            _Sound = new SoundPlayer(_url);
        }
    }
}
