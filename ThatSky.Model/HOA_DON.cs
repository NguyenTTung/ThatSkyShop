using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ThatSky.Model
{
    public class HOA_DON
    {
        [Key]
        public int MaHD { get; set; }
		[Required(ErrorMessage = "Họ và tên Không được trống")]
		[MinLength(5, ErrorMessage = "Họ và tên không dưới 5 kí tự ")]
		[MaxLength(50, ErrorMessage = "Họ và tên không lớn hơn 50 kí tự ")]
		[RegularExpression(@"^[\p{L}a-zA-Z\s]*$", ErrorMessage = "Họ và tên chỉ được nhập chữ")]
		public string TenND { get; set; }

		[Required(ErrorMessage = "Địa chỉ Không được trống")]
		[MaxLength(150, ErrorMessage = "Địa chỉ không lớn hơn 150 kí tự ")]
		[MinLength(5, ErrorMessage = "Địa chỉ không dưới 5 kí tự")]
		public string DiaChi { get; set; }

		[StringLength(10, ErrorMessage = "Số Điện thoại phải có 10 kí tự")]
		[MinLength(10, ErrorMessage = "Số Điện thoại phải có 10 kí tự")]
		[RegularExpression(@"^[0-9]+$", ErrorMessage = "Số điện thoại chỉ chứa số")]
		[Required(ErrorMessage = "Không được trống")]
		public string SoDienThoai { get; set; }

		public DateTime NgayTao { get; set; } = DateTime.Now;
        public byte TrangThai { get; set; } = 0;
        [MaxLength(100, ErrorMessage = "Ghi chú không lớn hơn 100 ký tự")]
        public string? GhiChu { get; set; }
        public int MaGioHang { get; set; }
        [ForeignKey("MaGioHang")]
        [ValidateNever]
        public GIO_HANG? GIO_HANG { get; set; }
    }
}
