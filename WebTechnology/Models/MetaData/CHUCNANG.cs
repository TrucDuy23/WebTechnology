using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(CHUCNANG.MetaData))]
    public partial class CHUCNANG
    {
        sealed class MetaData
        {
        [Required(AllowEmptyStrings = false,
                  ErrorMessage = "Mã chức năng không được để trống")]
        public string MaChucNang { get; set; }

        [Required(AllowEmptyStrings = false,
                  ErrorMessage = "Tên Chức Năng không được để trống")]
            public string TenChucNang { get; set; }

        }
    }
}