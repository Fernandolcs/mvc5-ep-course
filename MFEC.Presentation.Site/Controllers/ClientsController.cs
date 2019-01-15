using System;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using MFEC.Application.Services;
using MFEC.Application.ViewModels;

namespace MFEC.Presentation.Site.Controllers
{
    public class ClientsController : Controller
    {
        private ClientAppService _clientAppService { get; set; }

        public ClientsController()
        {
            _clientAppService = new ClientAppService();
        }

        // GET: Clients
        public ActionResult Index()
        {
            return View(_clientAppService.GetAllActive());
        }

        // GET: Clients/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientViewModel clientViewModel = _clientAppService.GetById(id.Value);
            if (clientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clientViewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientAddressViewModel clientAddressViewModel)
        {
            if (ModelState.IsValid)
            {
                _clientAppService.Insert(clientAddressViewModel);
                return RedirectToAction("Index");
            }

            return View(clientAddressViewModel);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientViewModel clientViewModel = _clientAppService.GetById(id.Value);
            if (clientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clientViewModel);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,CPF,BirthDate,RegisterDate,IsActive,IsExcluded")] ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                _clientAppService.Update(clientViewModel);
                return RedirectToAction("Index");
            }
            return View(clientViewModel);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientViewModel clientViewModel = _clientAppService.GetById(id.Value);
            if (clientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clientViewModel);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _clientAppService.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _clientAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
