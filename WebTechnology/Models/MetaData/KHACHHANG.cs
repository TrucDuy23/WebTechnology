using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(KHACHHANG.MetaData))]
    public partial class KHACHHANG
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã khách hàng không được để trống")]
            public string MaKhachHang { get; set; }
            
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Tên Khách Hàng không được để trống")]
            public string TenKhachHang { get; set; }
            public string TaiKhoan { get; set; }
            public string MatKhau { get; set; }
            public string Email { get; set; }
            public string DiaChi { get; set; }
            public string DienThoai { get; set; }
        }
    }
}