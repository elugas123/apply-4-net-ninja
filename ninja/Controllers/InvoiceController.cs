using System.Linq;
using System.Web.Mvc;
using ninja.model.Manager;
using ninja.model.Entity;
using ninja.Models;

namespace ninja.Controllers
{
    public class InvoiceController : Controller
    {

        InvoiceManager manager = new InvoiceManager();

        public ActionResult Index()
        {
            
            var model = new ViewModelIndex(manager.GetAll());
            return View(model);
        }
       

        public ActionResult Detail(long Id)
        {
            ViewBag.IdInvoice = Id;
            var model = new ViewModelDetail(manager.GetById(Id).GetDetail());
            return View(model);
        }

        public ActionResult CreateInvoice()
        {
            return View();
        }

        public ActionResult NewInvoice(Invoice invoice)
        {
            if (invoice != null)
                manager.Insert(invoice);
            return Redirect("Index");
        }

        public ActionResult Delete(long Id)
        {
            manager.Delete(Id);
            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult DeleteDetail(long Id, long InvoiceId)
        {
            manager.DeleteDetail(manager.GetById(InvoiceId).GetDetail().First(x => x.Id == Id));
            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult Update(long Id)
        {
            var model = new ViewModelUpdate(manager.GetById(Id));
            return View(model);
        }

    
        public ActionResult UpdateInvoice(Invoice invoice)
        {
            manager.Update(invoice);
            return Redirect("Index");
        }

        public ActionResult UpdateAddDetail(long Id, long InvoiceId)
        {
            var model = new ViewModelUpdateAddDetail(manager.GetById(InvoiceId).GetDetail().First(x => x.Id == Id));
            return View(model);
        }

        public ActionResult UpdateDetail (InvoiceDetail invoiceDetail)
        {
            manager.UpdateDetail(invoiceDetail);
            return RedirectToAction("Detail", new { Id = invoiceDetail.InvoiceId});
        }

        public ActionResult AddDetail(InvoiceDetail invoiceDetail)
        {
            var model = new ViewModelCreateDetail(invoiceDetail);
            return View(model);
        }

        public ActionResult AddInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            manager.AddInvoiceDetail(invoiceDetail);
            return RedirectToAction("Detail", new { Id = invoiceDetail.InvoiceId });
        }
    }
}


