﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTechnology.Models.MetaData
{
    [MetadataType(typeof(TAIKHOAN.MetaData))]
    public partial class TAIKHOAN
    {
        public string url { get; set; }
        public bool Ghinho_Dangnhap { get; set; }
        public string New_Password { get; set; }
        public string Repeat_Password { get; set; }
        public string list_ChucNang { get; set; }

        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Tài khoản không được để trống")]
            public string Username { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mật khẩu không được để trống")]
            public string Password { get; set; }

            public string MaLoaiTK { get; set; }
        }
    }
}