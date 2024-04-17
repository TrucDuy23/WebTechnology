using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace WebTechnology.Models.DataAccess_Object
{
    public class SANPHAM_DAO
    {
        public static List<SanPham> Read_All(string thuonghieu, string loaisanpham)
        {
            using (Data_Entities db = new Data_Entities())
            {
                List<SanPham> ketqua;
                if (loaisanpham == null)
                {
                    if (thuonghieu == null)
                    {
                        ketqua = db.SanPham.ToList();
                    }
                    else
                    {
                        ketqua = db.SanPham.Where(n => n.MaThuongHieu == thuonghieu).ToList();
                    }
                }
                else
                {
                    if (thuonghieu == null)
                    {
                        ketqua = db.SanPham.Where(n => n.MaLoai == loaisanpham).ToList();
                    }
                    else
                    {
                        ketqua = db.SanPham.Where(n => n.MaLoai == loaisanpham && n.MaLoai == thuonghieu).ToList();
                    }
                }
                return ketqua;
            }
        }

        
    }
}