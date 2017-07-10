using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServices.Models.Dtos
{
    public class ProductListDto
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
    }
}
