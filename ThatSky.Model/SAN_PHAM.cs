using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Http;

namespace ThatSky.Model
{
    public class SAN_PHAM
    {
        [Key]
        public int MaSP { get; set; }
        [MaxLength(100, ErrorMessage = "Tên sản phẩm không quá 100 kí tự")]
        [MinLength(5, ErrorMessage = "Tên sản phẩm không dưới 5 kí tự")]
        [Required(ErrorMessage = "Tên sản phẩm Không được trống")]
        [RegularExpression(@"^[\p{L}\p{M}0-9\s]*$", ErrorMessage = "Tên sản phẩm không chứa kí tự đặc biệt")]
        public string TenSP { get; set; }
        [Required(ErrorMessage = "Giá không được trống")]
        [Range(1000, 50000000, ErrorMessage = "Giá phải lớn hơn 1000 và không vượt quá 50 triệu")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Giá chỉ chấp nhận kí tự số")]
        public double Gia { get; set; }
        [Required(ErrorMessage = "Số lượng không được để trống")]
        [Range(1, 999, ErrorMessage = "Số lượng phải lớn hơn 0 và không vượt quá 999")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Số lượng chỉ chấp nhận kí tự số")]
        public int SoLuong { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public bool TrangThai { get; set; } = true;
        [MaxLength(5000, ErrorMessage = "Mô tả không quá 5000 kí tự")]
        public string? MoTa { get; set; }

        public int MaDanhMuc { get; set; }
        [ValidateNever]
        [ForeignKey("MaDanhMuc")]
        public DANH_MUC DANH_MUC { get; set; }
        public virtual ICollection<DS_HINH_ANH>? db_DS_HINH_ANH { get; set; }
		[NotMapped]
		public IFormFile? HinhAnhTaiLen { get; set; }
    }
}
