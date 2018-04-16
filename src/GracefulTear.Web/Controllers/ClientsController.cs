﻿using System.Threading.Tasks;
using GracefulTear.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace GracefulTear.Web.Controllers
{
	public class ClientsController : Controller
	{
		private IResourceService resourceService;

		public ClientsController(IResourceService resourceService)
		{
			this.resourceService = resourceService;
		}
		public async Task<IActionResult> Index()
		{
			return await Task.FromResult(View(resourceService.GetAll()));
		}
	}
}