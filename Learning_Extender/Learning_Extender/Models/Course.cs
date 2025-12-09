using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Extender.Models
{
    class Course : MediaType
    {
        public int number_of_questions = 10;
        public List<Question> Questions= new List<Question>();
        public bool get_question_randomly = true;
    }
}
