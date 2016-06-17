using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Models
{
    public class view_sachsaphet_ett
    {
        public int masach { get; set; }
        public string tensach { get; set; }
        public string tenlinhvuc { get; set; }
        public string tennxb { get; set; }
        public int? soluong { get; set; }
        public string ngaynhap { get; set; }
        public view_sachsaphet_ett()
        {

        }
        public view_sachsaphet_ett(tbl_sachsaphet_view sh)
        {
            masach = sh.masach;
            tensach = sh.tensach;
            tenlinhvuc = sh.tenlinhvuc;
            tennxb = sh.tennxb;
            soluong = sh.soluonghientai;
            ngaynhap = sh.ngaynhap;
        }
    }
}
