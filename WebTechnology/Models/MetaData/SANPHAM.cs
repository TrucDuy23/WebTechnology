using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(SANPHAM.MetaData))]
    public partial class SANPHAM
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã sản phẩm không được để trống")]
            public string MaSanPham { get; set; }
            
            [Required(AllowEmptyStrings = false,
                  ErrorMessage = "Tên sản phẩm không được để trống")]
            public string TenSanPham { get; set; }

            [Required(AllowEmptyStrings = false,
                  ErrorMessage = "Mô tả không được để trống")]
            public string MoTa { get; set; }

            [Required(AllowEmptyStrings = false,
                  ErrorMessage = "Giá sản phẩm không được để trống")]
            public Nullable<decimal> Gia { get; set; }
            public string HinhAnh { get; set; }
            public Nullable<System.DateTime> NgayCapNhat { get; set; }
            
            [Required(AllowEmptyStrings = false,
                  ErrorMessage = "Số lượng tồn không được để trống")]
            public int SoLuongTon { get; set; }
            
            [Required(AllowEmptyStrings = false,
                  ErrorMessage = "Mã loại sản phẩm không được để trống")]
            public string MaLoai { get; set; }

            [Required(AllowEmptyStrings = false,
                  ErrorMessage = "Mã loại thương hiệu skhông được để trống")]
            public string MaThuongHieu { get; set; }
        }
    }
}