using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(THUONGHIEU.MetaData))]
    public class THUONGHIEU
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã thương hiệu không được để trống")]
            public string MaThuongHieu { get; set; }
            
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Tên thương hiệu không được để trống")]
            public string TenThuongHieu { get; set; }

        }
    }
}