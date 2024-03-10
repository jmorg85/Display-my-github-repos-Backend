using Github_React_Project_Backend_2.Interfaces;
using Github_React_Project_Backend_2.Models;
using Github_React_Project_Backend_2.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Github_React_Project_Backend_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepoController : ControllerBase
    {
        private readonly IGithubService _service;

        public RepoController(IGithubService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<List<GithubResponse>> Get()
        {
            List<GithubResponse> response = await _service.GetRepos();

            return response;
        }
    }
}
