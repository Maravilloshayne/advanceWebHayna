using AdvanceWebHayna.Web.Infrastructures.Data.Helpers;
using AdvanceWebHayna.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebHayna.Web.ViewModels.Categories
{
    public class IndexViewModel
    {
        public Page<Category> Categories { get; set; }
    }
}