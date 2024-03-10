using Github_React_Project_Backend_2.Interfaces;
using Github_React_Project_Backend_2.Models;

namespace Github_React_Project_Backend_2.Services
{
    public class GithubService : IGithubService
    {
        private readonly IGithubRepo _githubRepo;
        public GithubService(IGithubRepo repo)
        {
            _githubRepo = repo;
        }

        public async Task<List<GithubResponse>> GetRepos()
        {
            var result = await _githubRepo.getRepos();

            return result;
        }
    }
}
