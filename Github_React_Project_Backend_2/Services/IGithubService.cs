using Github_React_Project_Backend_2.Models;

namespace Github_React_Project_Backend_2.Services
{
    public interface IGithubService
    {
        public Task<List<GithubResponse>> GetRepos();
    }
}
