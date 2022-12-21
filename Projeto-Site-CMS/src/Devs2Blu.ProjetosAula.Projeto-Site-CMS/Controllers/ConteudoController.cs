using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Controllers
{
	public class ConteudoController : Controller
	{
		private readonly IConteudoService _service;

		public ConteudoController(IConteudoService service)
		{
			_service = service;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _service.GetAllConteudos());
		}
	}
}
