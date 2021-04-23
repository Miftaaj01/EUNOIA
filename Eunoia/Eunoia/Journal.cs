using System;
using System.Collections.Generic;
using System.Text;

namespace Eunoia
{
    class Journal
    {
        public string Title;
        public string Date;
        public string Question;
        public string Answer;

        public string getTitle
        {
            get { return Title; }
            set { Title = value; }
        }

        public string getDate
        {
            get { return Date; }
        }

        public void Journaling()
        {

        }
    }
}
