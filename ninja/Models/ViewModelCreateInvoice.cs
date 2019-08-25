using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ninja.model;
using ninja.model.Entity;
using ninja.model.Manager;

namespace ninja.Models
{
    public class ViewModelCreateInvoice
    {
        public ViewModelCreateInvoice(Invoice invoice)
        {
            // init viewmodel here or use some mapper
            this.invoice = invoice;
        }

        public Invoice invoice { get; set; }

       
    }
}