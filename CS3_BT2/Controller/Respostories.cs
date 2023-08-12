using CS3_BT2.Context;
using CS3_BT2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3_BT2.Controller
{
    internal class Respostories
    {
        DBContext db = new DBContext();
        public List<Nxb> getNhaXuatBan_res()
        {
            return db.Nxbs.ToList();
        }
        public List<Sach> getSach_res(string find)
        {
            if(find == null)
            {
                return db.Saches.ToList();
            }
            return db.Saches.Where(x => x.Ten.Trim().ToLower().Contains(find.Trim().ToLower())).ToList();
        }
        public bool AddSach_res(Sach sach)
        {
            if(sach == null)
            {
                return false;
            }
            db.Saches.Add(sach);
            db.SaveChanges();
            return true;
        }
        public bool UpDateSach_res(Guid? id, Sach sachUpdate)
        {
            var checkSachExist = db.Saches.FirstOrDefault(x => x.Id == id);
            if (sachUpdate == null || checkSachExist == null)
            {
                return false;
            }
            checkSachExist.Ma = sachUpdate.Ma;
            checkSachExist.Ten = sachUpdate.Ten;
            checkSachExist.TrangThai = sachUpdate.TrangThai;
            checkSachExist.IdNxb = sachUpdate.IdNxb;
            db.Saches.Update(checkSachExist);
            db.SaveChanges();
            return true;
        }
    }
}
