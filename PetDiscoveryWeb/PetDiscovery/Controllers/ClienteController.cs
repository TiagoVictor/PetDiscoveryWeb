using Microsoft.AspNetCore.Mvc;
using NHibernate;
using NHibernate.Linq;
using PetDiscovery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Controllers
{
    public class ClienteController : Controller
    {

        private readonly ISession _session;

        public ClienteController(ISession session)
        {
            _session = session;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _session.Query<Cliente>().ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                using(ITransaction transaction = _session.BeginTransaction())
                {
                    await _session.SaveAsync(cliente);
                    await transaction.CommitAsync();
                    return RedirectToAction(nameof(Create));
                }
            }

            return View(cliente);
        }
    }
}
