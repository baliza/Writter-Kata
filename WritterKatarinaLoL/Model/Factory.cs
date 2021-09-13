using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Factory
    {
        private readonly Dictionary<string, IFormatable> _formatList;
        public Factory(Dictionary<string, IFormatable> formatersList)
        {
            _formatList = formatersList;
        }

        public Writter GetWritter(string formater)
        {
            return new Writter(_formatList[formater]);
        }
    }
}
