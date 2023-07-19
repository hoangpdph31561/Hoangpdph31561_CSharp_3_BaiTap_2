using Hoangpdph31561_CSharp_3_BaiTap_2.Controller.Respository;
using Hoangpdph31561_CSharp_3_BaiTap_2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangpdph31561_CSharp_3_BaiTap_2.Controller.Service
{
    internal class SachService
    {
        SachRespository _res;
        public SachService()
        {
            _res = new SachRespository();
        }
        public void AddNewSach(Sach sach)
        {
            if(_res.AddSachs(sach))
            {
                MessageBox.Show("Thêm mới sách thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        
    }
}
