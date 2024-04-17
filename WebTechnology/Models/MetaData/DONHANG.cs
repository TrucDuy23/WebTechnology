using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(DONHANG.MetaData))]
    public partial class DONHANG
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                       ErrorMessage = "Mã Đơn hàng không được để trống")]
            public string MaDonHang { get; set; }
            
            [Required(AllowEmptyStrings = false,
                       ErrorMessage = "Trạng Thái Đơn hàng không được để trống")]
            public string TrangThai { get; set; }

            [Required(AllowEmptyStrings = false,
                       ErrorMessage = "Ngày đặt không được để trống")]
            public System.DateTime NgayDat { get; set; }

            [Required(AllowEmptyStrings = false,
                       ErrorMessage = "Mã Khách hàng không được để trống")]
            public string MaKhachHang { get; set; }
        }
    }
}