using Deharo.Writter.Models.Core;

namespace Deharo.Writter.Services
{
    public interface IWriter
    {
        void WriteBody(string fileName, VuelingUniversity vUni);
    }
}