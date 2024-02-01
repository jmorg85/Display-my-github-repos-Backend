using Github_React_Project_Backend_2.Models;
using System.Text.Json;

namespace Github_React_Project_Backend_2.Interfaces
{
    public class GithubRepo : IGithubRepo
    {
        public async Task<List<GithubResponse>> getRepos()
        {
            List<GithubResponse> result = new List<GithubResponse>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.github.com/users/jmorg85/repos");
                    client.DefaultRequestHeaders.Add("User-Agent", "request");

                    var response = await client.GetAsync(client.BaseAddress);
                    if (response.IsSuccessStatusCode)
                    {
                        var x = await response.Content.ReadAsStringAsync();
                        result = JsonSerializer.Deserialize<List<GithubResponse>>(x.ToString());
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return result;
            }
        }
    }
}
