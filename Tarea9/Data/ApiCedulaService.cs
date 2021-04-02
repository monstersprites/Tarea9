using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Tarea9.Data
{
    public class ApiCedulaService
    {
        private HttpClient Http = new HttpClient();

        public async Task<ApiCedulaModel> GetDatosAsync(string cedula)
        {
            string str = await Http.GetStringAsync($"https://api.adamix.net/apec/cedula/{cedula}");
            
            ApiCedulaModel apiContent = JsonConvert.DeserializeObject<ApiCedulaModel>(str);

            return apiContent.ok ? apiContent : null;
        }
    }
}
