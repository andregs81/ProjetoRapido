using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoRapido.Services.Interfaces;
using ProjetoRapido.Services.ViewModel;

namespace ProjetoRapido.Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: Clientes
        public IActionResult Index()
        {
            var clientes = _clienteService.GetAll();
            return View(clientes);
        }

        // GET: Clientes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = _clienteService.GetById((int)id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            //return View();
            return PartialView();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClienteViewModel cliente)
        {
            string erroMensagem = "";


            if (!ModelState.IsValid)
            {
                foreach (var item in ModelState.Values.SelectMany(v => v.Errors).ToList())
                {
                    erroMensagem += string.Format("{0}<br>", item.ErrorMessage);
                }

                return BadRequest(erroMensagem);
            }

            if (cliente.ClienteID == 0)
                _clienteService.Add(cliente);
            else
                _clienteService.Update(cliente);

            return View();
        }

        // GET: Clientes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = _clienteService.GetById((int)id);
            if (cliente == null)
            {
                return NotFound();
            }

            return PartialView(cliente);
        }



        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _clienteService.GetById(id);
            if (cliente == null)
                return NotFound();

            try
            {
                _clienteService.Delete(id);
                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest();
            }



        }

        private bool ClienteExists(int id)
        {
            return _clienteService.GetById(id).ClienteID > 0;
        }
    }
}
