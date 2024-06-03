using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatSky.Model
{
    public class DANH_MUC
    {
        [Key]
        public int MaDanhMuc { get; set; }
        [MaxLength(40, ErrorMessage = "Tên danh mục không quá 40 kí tự")]
        [MinLength(2, ErrorMessage = "Tên danh mục không dưới 2 kí tự")]
        [Required(ErrorMessage = "Tên danh mục Không được trống")]
        public string TenDanhMuc { get; set; }
    }
}
