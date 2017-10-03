using System;
using Xunit;

namespace Worker.Test
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public async Task Test_Host()
        {
            System.Threading.Thread.Sleep(5000);

            using (var _client = new HttpClient())
            {
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                _client.DefaultRequestHeaders.Add("User-Agent", "XUnit");

                var url = "http://localhost:5000";

                var response = await _client.GetAsync(url);
                // Assert.IsType<HttpResponseMessage>(response);
                // Assert.Equal(expectedResponseStatusCode, response.StatusCode);
            }
        }
    }
}
