using AdvanceWebHayna.Web.Infrastructures.Data.Helpers;
using AdvanceWebHayna.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebHayna.Web.ViewModels.Products
{
    public class IndexViewModel
    {
        public Page<Product> Products { get; set; }
    }
}
