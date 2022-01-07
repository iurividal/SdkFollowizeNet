using Microsoft.Extensions.Configuration;
using SdkFollowizeNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SdkFollowizeNet.Services
{
    public interface ILeadService
    {
        string GetClientKey();

        Task<LeadResult> AddLeadasync(Lead lead);
    }

    public class LeadService : ILeadService
    {
        private const string baseURL = "https://www.followize.com.br/api/v2";

        static readonly HttpClient client = new HttpClient();


        public LeadService() 
        {
            client.BaseAddress = new Uri(baseURL);
        }

        public string GetClientKey() => Utils.Config().GetSection("ClienteKey").Value;
       

        public async Task<LeadResult> AddLeadasync(Lead lead)
        {

            var json = JsonSerializer.Serialize(lead);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("/Leads", data);

            if (response.IsSuccessStatusCode)
            {

                var content = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<LeadResult>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            }
            else
            {
                throw new Exception($"Ocorreu um problema para adicionar o lead \n {response.StatusCode}");
            }

        }

    }


}
