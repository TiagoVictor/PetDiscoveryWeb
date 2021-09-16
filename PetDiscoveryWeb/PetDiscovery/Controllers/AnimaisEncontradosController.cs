using Microsoft.AspNetCore.Mvc;
using NHibernate;
using PetDiscovery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Controllers
{
    public class AnimaisEncontradosController : Controller
    {
        private readonly ISession _session;

        public AnimaisEncontradosController(ISession session)
        {
            _session = session;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AnimaisEncontrados animais)
        {
            if (ModelState.IsValid)
            {
                using(ITransaction transaction = _session.BeginTransaction())
                {
                    await _session.SaveAsync(animais);
                    await transaction.CommitAsync();
                    return RedirectToAction(nameof(Create));
                }
            }

            return View(animais);
        }
    }
}
