using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adyen.EcommLibrary.HttpClient.Interfaces
{
    public interface IClient
    {
        string Request(string endpoint, string json, Config config);
        string Request(string endpoint, string json, Config config, bool isApiKeyRequired);
        Task<string> RequestAsync(string endpoint, string json, Config config, bool isApiKeyRequired);
        string Post(string endpoint, Dictionary<string, string> postParameters, Config config);
    }
}