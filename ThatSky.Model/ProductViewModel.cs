using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatSky.Model
{
    public class ProductViewModel
    {
        public IEnumerable<SAN_PHAM> Products { get; set; }
        public int TotalProducts { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalProducts / PageSize);
    }
}
