using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Model;

namespace WritterJavi.Interface
{
    interface IFactory
    {
        public IWritter GetWritter(string formater);
    }
}
