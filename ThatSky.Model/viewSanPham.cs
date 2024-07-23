using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatSky.Model
{
    public class viewSanPham
    {
        public SAN_PHAM SanPham { get; set; }
        public List<SAN_PHAM> SanPhamMoi { get; set; }
        public List<SAN_PHAM> SanPhamNoiBat { get; set; }
        public List<SAN_PHAM> SanPhamTuongTu { get; set; }

	}
}
