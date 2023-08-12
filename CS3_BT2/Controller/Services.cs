using CS3_BT2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3_BT2.Controller
{
    internal class Services
    {
        Respostories _res = new Respostories();
        public List<Nxb> getNhaXuatBan()
        {
            return _res.getNhaXuatBan_res();
        }
        public List<Sach> getSach(string find)
        {
            return _res.getSach_res(find);
        }
        public void AddSach( Sach sach)
        {
            if(_res.AddSach_res(sach))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
           
        }
        public void UpDateSach(Guid? id , Sach sach)
        {
            if(_res.UpDateSach_res(id, sach))
            {
                MessageBox.Show("Sửa thành công !");
            }
            else
            {
                MessageBox.Show("Sửa thất bại !");
            }
           
        }
    }
}
