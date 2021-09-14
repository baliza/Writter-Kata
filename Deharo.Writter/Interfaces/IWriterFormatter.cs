using Deharo.Writter.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Interfaces
{
    public interface IWriterFormatter
    {
        public string GetBody(VuelingUniversity vUni);
        public string GetExtension();
    }
}
