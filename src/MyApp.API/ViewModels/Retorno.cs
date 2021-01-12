using MyApp.Business.Models;

namespace MyApp.API.ViewModels
{
    public class Retorno : RetornoAPI
    {
        public Retorno(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}
