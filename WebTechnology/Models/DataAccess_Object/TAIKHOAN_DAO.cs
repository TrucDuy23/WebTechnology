using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTechnology.Models.MetaData;

namespace WebTechnology.Models.DataAccess_Object
{
    public class TAIKHOAN_DAO
    {
        public static int Create(TaiKhoan model)
        {
            try
            {
                using (Data_Entities db = new Data_Entities())
                {
                    db.TaiKhoan.Add(model);
                    return 0;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static TaiKhoan Read(string username)
        {
            using (Data_Entities db = new Data_Entities())
            {
                TaiKhoan taikhoan = db.TaiKhoan.FirstOrDefault(n => n.Username == username);
                if (taikhoan != null)
                {

                    foreach (ChucNang cn in taikhoan.LoaiTaiKhoan.ChucNang)
                    {
                        taikhoan.list_ChucNang += cn.MaChucNang + "; ";
                    }
                }
                return taikhoan;
            }
        }
        public static int Update(TaiKhoan model)
        {
            try
            {
                using (Data_Entities db = new Data_Entities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return 0;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}