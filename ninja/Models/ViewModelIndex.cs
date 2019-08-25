using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ninja.model;
using ninja.model.Entity;
using ninja.model.Manager;

namespace ninja.Models
{
  
    public class ViewModelIndex 
    {

        public ViewModelIndex(IList<Invoice> invoices)
        {
            // init viewmodel here or use some mapper
         this.invoices = invoices;
        }

        public IList<Invoice> invoices { get; set; }

    }

}