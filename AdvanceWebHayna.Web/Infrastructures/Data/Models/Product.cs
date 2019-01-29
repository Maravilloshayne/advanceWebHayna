using AdvanceWebHayna.Web.Infrastructures.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebHayna.Web.Infrastructures.Data.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? CategoryId { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PostExpiry { get; set; }
    }
}
