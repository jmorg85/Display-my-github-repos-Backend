using Github_React_Project_Backend_2.Models;

namespace Github_React_Project_Backend_2.Interfaces
{
    public interface IGithubRepo
    {
        public Task<List<GithubResponse>> getRepos();
    }
}
