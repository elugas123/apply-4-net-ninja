using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ninja.model;
using ninja.model.Entity;
using ninja.model.Manager;

namespace ninja.Models
{
    public class ViewModelDetail
    {
        // init viewmodel here or use some mapper

        public ViewModelDetail(IList<InvoiceDetail> invoiceDetails)
        {
            // init viewmodel here or use some mapper
            this.invoiceDetails = invoiceDetails;
        }
          
      

        public IList<InvoiceDetail> invoiceDetails { get; set; }
    }
}