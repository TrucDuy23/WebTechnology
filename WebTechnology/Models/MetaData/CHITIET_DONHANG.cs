using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(CHITIET_DONHANG.MetaData))]
    public partial class CHITIET_DONHANG
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Đơn hàng không được để trống")]
            public string MaDonHang { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Sách không được để trống")]
            public string MaSanPham { get; set; }

            [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0")]
            public int SoLuong { get; set; }

            [Range(0, double.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn 0")]
            public decimal DonGia { get; set; }
        }
    }
}