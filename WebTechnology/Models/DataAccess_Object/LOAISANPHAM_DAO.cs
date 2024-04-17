using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTechnology.Models;
using WebTechnology.Models.MetaData;

namespace WebTechnology.Models.DataAccess_Object
{
    public class LOAISANPHAM_DAO
    {
        public static List<LOAISANPHAM> ReadAll()
        {
            using (Data_Entities db = new Data_Entities())
            {
                List<LOAISANPHAM> ketqua = db.LOAISANPHAM.ToList();
                //Đếm sách có cùng chủ để
                foreach (LOAISANPHAM lsp in ketqua)
                {
                    lsp.count = db.SanPham.Count(n => n.MaLoai == lsp.MaLoai);
                }
                return ketqua;
            }
        }
    }
}