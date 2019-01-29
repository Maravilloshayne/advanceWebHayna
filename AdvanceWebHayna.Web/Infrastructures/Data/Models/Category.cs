using AdvanceWebHayna.Web.Infrastructures.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebHayna.Web.Infrastructures.Data.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? ParentId { get; set; }

        public decimal Price { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PostExpiry { get; set; }

    }
}
