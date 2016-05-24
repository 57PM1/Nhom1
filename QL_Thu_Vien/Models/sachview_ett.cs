using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Models
{
    public class sachview_ett
    {
        public int masach { get; set; }
        public string tensach { get; set; }
        public string nxb { get; set; }
        public string linhvuc { get; set; }
        public int sotrang { get; set; }
        public int soluonghientai { get; set; }
        public int soluongbandau { get; set; }
        public string ngaynhap { get; set; }

        public sachview_ett() { }
        public sachview_ett(int ma, string ten, string nxb, string lv, int sotrang, int soluonghientai, int soluongbandau, string ngaynhap)
        {
            masach = ma;
            tensach = ten;
            this.nxb = nxb;
            linhvuc = lv;
            this.sotrang = sotrang;
            this.soluonghientai = soluonghientai;
            this.soluongbandau = soluongbandau;
            this.ngaynhap = ngaynhap;
        }
    }
}
