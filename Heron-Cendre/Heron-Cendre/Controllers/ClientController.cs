using Heron_Cendre.Data.Services.Clients;
using Microsoft.AspNetCore.Mvc;

namespace Heron_Cendre.Controllers
{
    public class ClientController : Controller
    {

        private readonly InterfClentService _services;

        public ClientController(InterfClentService service)
        {
            _service = service;
        }

        ///////////////////GET: CLIENT controller
        public async Task<IActionResult> Index()
        {
            var data = await _services.GetAll();
            return View();
        }

        //////////////////GET: CLIENT controller DETAILS
        public ActionResult Details(int id)
        {
            return view();
        }

        ////////////////// creation d'un client
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nom,Prenom,Adresse,Telephone,Email,Date_Naissance,Mot_De_Passe,Num_Compte")]Client client)
        {
            if(!ModelState.IsValid)
            {
                return View(clients);
            }

            await _services.AddAsync(clients);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

          
        }

        /////////////// Modification de client
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /////////////// Suppression de client
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
