using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServices.Models.Entities
{
    public class Tag
    {
        public int TagId { get; set; }
        public int ProductId { get; set; }
        public string SearchTag { get; set; }
    }
}
