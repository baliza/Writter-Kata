using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Interfaces
{
    public interface IWriterFormatter
    {
        public string GetBody();
        public string GetExtension();
    }
}
