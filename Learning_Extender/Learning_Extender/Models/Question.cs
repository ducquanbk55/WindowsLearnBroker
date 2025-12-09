using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Extender.Models
{
    class Question:MediaType
    {
        public bool is_repeat_allwed = true;
        public int feed_back_easy_level = 0;
        /// <summary>
        /// 0 - Hard repeat right now
        /// 1 - Hard repeat in 1 minutes
        /// 2- medium repeate in 10 minutes
        /// 3 - easy repeat in 3 days
        /// </summary>
        public DateTime repeat_day = DateTime.Now.Add(TimeSpan.FromMinutes(15));
        public List<string> subText = new List<string>();
        public List<Awnser> list_anwser = new List<Awnser>();
    }
}
