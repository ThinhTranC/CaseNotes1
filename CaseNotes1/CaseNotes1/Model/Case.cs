using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CaseNotes1.Model
{
    class Case
    {
        public int CaseID { get; set; }
        public string CaseNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string FamilyGroup { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        public static async Task<List<Case>> Get(string userEmail)
        {
            List<Case> cases = new List<Case>();
            var url = "https://tst-integrationapi-casenotes.azurewebsites.net/api/GetData/GetCases?userEmail=" + userEmail;
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                cases = JsonConvert.DeserializeObject<List<Case>>(json);
            }
            return cases;
        }
    }
}
