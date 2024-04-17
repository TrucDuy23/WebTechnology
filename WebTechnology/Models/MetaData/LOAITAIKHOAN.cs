using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(LOAITAIKHOAN.MetaData))]
    public partial class LOAITAIKHOAN
    {
        sealed class MetaData
        {
            public string MaLoaiTK { get; set; }
            public string TenLoaiTK { get; set; }
        }
    }
}