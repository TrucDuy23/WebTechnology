using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(LOAISANPHAM.MetaData))]
    public partial class LOAISANPHAM
    {
        public int count { get; set; }
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã loại sản phẩm không được để trống")]
            public string MaLoai { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Tên loại sản phảm không được để trống")]
            public string TenLoai { get; set; }    
        }
    }
}