using Deharo.Writter.Models;
using Deharo.Writter.Services;

namespace Deharo.Writter
{
    public interface IFactory
    {
        IWriter CreateWritter(EFormatTypes type);
        string ToString();
    }
}