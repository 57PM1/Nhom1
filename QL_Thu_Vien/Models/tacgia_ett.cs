﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Models
{
    public class tacgia_ett
    {
        public int matacgia { get; set; }
        public string tentacgia { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        public string maten { get; set; }

        public tacgia_ett(int matacgia, string tentacgia)
        {
            this.matacgia = matacgia;
            this.tentacgia = tentacgia;
            this.maten = matacgia + " | " + tentacgia;
        }

        public tacgia_ett() { }
        public tacgia_ett(tbl_tacgia tg)
        {
            matacgia = tg.matg;
            tentacgia = tg.tentg;
            diachi = tg.diachi;
            gioitinh = tg.gioitinh;
            this.maten = tg.matg + " | " + tg.tentg;
        }
        public tacgia_ett(int matg, string tentg, string gt, string dc)
        {
            matacgia = matg;
            tentacgia = tentg;
            gioitinh = gt;
            diachi = dc;
            this.maten = matg + " | " + tentg;
        }
    }
}
