using Deharo.Writter.Interfaces;
using Deharo.Writter.Models;
using Deharo.Writter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deharo.Writter
{
    public class Factory
    {
		private readonly Dictionary<EFormatTypes, IWritterFormatter> _formatList;

        public Factory(Dictionary<EFormatTypes, IWritterFormatter> formatList)
        {
			_formatList = formatList;
		}

		public IWriter CreateWritter(EFormatTypes type)
		{
			return new Writer(_formatList[type]);
		}

        public override string ToString()
        {
            return "{" + string.Join(",", _formatList.Select(kv => kv.Key + "=" + kv.Value).ToArray()) + "}"; ;
        }
    }
}
