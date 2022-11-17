using AutomotrizBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Datos
{
    public class ClientSingleton
    {
        private static ClientSingleton instancia;
        private HttpClient cliente;

        public ClientSingleton()
        {
            cliente = new HttpClient();
        }
        public static ClientSingleton GetInstancia()
        {
            if (instancia == null)
                instancia = new ClientSingleton();
            return instancia;
        }
        public async Task<string> GetAsync(string url)
        {
            var result = await cliente.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await cliente.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> DeleteAsync(string url)
        {
            var result = await cliente.DeleteAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
    }
}
