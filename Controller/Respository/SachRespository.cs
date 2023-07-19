using Hoangpdph31561_CSharp_3_BaiTap_2.Context;
using Hoangpdph31561_CSharp_3_BaiTap_2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangpdph31561_CSharp_3_BaiTap_2.Controller.Respository
{
    internal class SachRespository
    {
        DBContext _db;
        public SachRespository()
        {
            _db = new DBContext();
        }
        public List<NhaXuatBan> GetNhaXuatBans()
        {
            return _db.NhaXuatBans.ToList();
        }
        public List<Sach> GetSachs()
        {
            return _db.Saches.ToList();
        }
        public List<Sach> GetSachs(string? input)
        {
            if(input == null)
            {
                return _db.Saches.ToList();
            }
            var data = _db.Saches.Where(x => x.TenSach.Trim().ToLower().StartsWith(input.Trim().ToLower())).ToList();
            return data;
        }
        public bool AddSachs(Sach sach)
        {
            if(sach == null)
            {
                return false;
            }
            _db.Saches.Add(sach);
            _db.SaveChanges();
            return true;
        }
        public string UpdateSachs(string id, Sach sach)
        {

            var data = _db.Saches.FirstOrDefault(x => x.IdSach == id);
            if (data == null) return "Sửa thất bại";
            data.TenSach = sach.TenSach;
            data.TrangThai = sach.TrangThai;
            data.IdNhaXuatBan = sach.IdNhaXuatBan;
            _db.Saches.Update(data);
            _db.SaveChanges();
            return "Sửa thành công";
        }
    }
}
