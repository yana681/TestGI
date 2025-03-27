using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGI
{
    class ClassQuection
    {
        string textQ;
        int ranswer;

        public ClassQuection(string text, int answer) 
        {
            textQ = text;
            ranswer = answer;
        }
        public string ToString()
        {
            return textQ;
        }
    }
}
