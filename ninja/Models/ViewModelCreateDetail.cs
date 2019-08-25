using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ninja.model;
using ninja.model.Entity;
using ninja.model.Manager;

namespace ninja.Models
{
    public class ViewModelCreateDetail
    {
     
            public ViewModelCreateDetail(InvoiceDetail invoiceDetail)
            {
                // init viewmodel here or use some mapper
                this.invoiceDetail = invoiceDetail;
            }

            public InvoiceDetail invoiceDetail { get; set; }
        
    }
}