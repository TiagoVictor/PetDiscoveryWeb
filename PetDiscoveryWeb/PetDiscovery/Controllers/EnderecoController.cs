using Microsoft.AspNetCore.Mvc;
using NHibernate;
using PetDiscovery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Controllers
{
    public class EnderecoController : Controller
    {

        private readonly ISession _session;

        public EnderecoController(ISession session)
        {
            _session = session;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                using(ITransaction transaction = _session.BeginTransaction())
                {
                    await _session.SaveAsync(endereco);
                    await transaction.CommitAsync();
                    return RedirectToAction(nameof(Create));
                }
            }

            return View(endereco);
        }
    }
}
