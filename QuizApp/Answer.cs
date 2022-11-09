using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
   public  class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Answer()
        {
        }

        public Answer(string text, bool isCorect)
        {
            Text = text;
            IsCorrect = isCorect;

        }

        public override string ToString()
        {
            return $"{Text}";
        }
    }
}
