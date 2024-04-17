using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTechnology.Models.DataAccess_Object
{
    public class KHACHHANG_DAO
    {
        public static string Create_MaKH()
        {
            using (Data_Entities db = new Data_Entities())
            {
                string ma_KH = db.KhachHang.OrderByDescending(n => n.MaKhachHang).Select(n => n.TenKhachHang).First();
                int a = int.Parse(ma_KH.Substring(3) + 1);
                if (a < 1000000)
                {
                    ma_KH = "KH_" + String.Format(new string('0', 6));
                }
                else
                {
                    ma_KH = "KH_" + a;
                }
                return ma_KH;

            }
        }

        public static bool Check_TaiKhoan(string ma_TaiKhoan)
        {
            using (Data_Entities db = new Data_Entities())
            {
                if (db.TaiKhoan.Any(n => n.Username == ma_TaiKhoan))
                {
                    return false;
                }
                else
                {
                    return !(db.KhachHang.Any(n => n.TaiKhoan == ma_TaiKhoan));
                }
            }
        }

        public static int Create(KhachHang model)
        {
            using (Data_Entities db = new Data_Entities())
            {
                try
                {
                    db.KhachHang.Add(model);
                    return 0;
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }
        public static KhachHang Read(string taikhoan)
        {
            using (Data_Entities db = new Data_Entities())
            {
                KhachHang khachhang = db.KhachHang.FirstOrDefault(n => n.TaiKhoan == taikhoan);
                return khachhang;
            }
        }
    }
}