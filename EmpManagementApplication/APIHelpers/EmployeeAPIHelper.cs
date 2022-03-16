using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;

namespace EmpManagementApplication
{
    // <summary>
    /// API Helpers class to configure the base url and connect the server.
    /// </summary>
    /// <remarks>
    /// This Common Helper class will used the http client and connect the service layer to fetch the data.
    /// </remarks>
    /// ///<inheritdoc cref="IEmployee"/>
    public class EmployeeAPIHelper
    {
        //ReadOnly Private variable to reterieve the base url configured in appsettings.
        readonly private string _baseURL = ConfigurationManager.AppSettings["BaseURL"];

        /// <summary>
        /// In this example, this summary is visible on all the methods.
        /// </summary>
        /// <remarks>
        /// The remarks can be inherited by other methods
        /// using the xpath expression.
        /// </remarks>
        /// <returns>A boolean</returns>
        //This will return all employees data.
        public async Task<List<Employee>> GetAllEmployees()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseURL);
                HttpResponseMessage msg = await client.GetAsync("GetAllEmployees");
                msg.EnsureSuccessStatusCode();
                var result = await msg.Content.ReadAsAsync<List<Employee>>();
                return result;
            }
        }
    }
}