using Microsoft.AspNetCore.Mvc;

namespace POC.Docker.Scale.Controllers
{
	[ApiController]
	[Route("/")]
	public class QuemEuSouController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			return Ok($"Acesse a rota /quem-eu-sou para saber o Hostname deste container");
		}
		[HttpGet("quem-eu-sou")]
		public IActionResult GetHostname()
		{
			return Ok($"Eu sou {Environment.MachineName}");
		}
	}
}