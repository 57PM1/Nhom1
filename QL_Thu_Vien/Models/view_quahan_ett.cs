using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Models
{
    public class view_quahan_ett
    {
        public int madg { get; set; }
        public string tendg { get; set; }
        public string ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string lop { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public view_quahan_ett()
        {

        }
        public view_quahan_ett(tbl_quahan_view qh)
        {
            madg = qh.madg;
            tendg = qh.tendg;
            ngaysinh = qh.ngaysinh;
            gioitinh = qh.gioitinh;
            lop = qh.lop;
            diachi = qh.diachi;
            email = qh.email;
        }
    }
}
