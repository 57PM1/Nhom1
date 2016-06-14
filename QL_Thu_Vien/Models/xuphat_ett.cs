using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Models
{
    class xuphat_ett
    {
        public int maphat { get; set; }
        public string loaiphat { get; set; }
        public decimal? giatien { get; set; }

        public xuphat_ett()
        {

        }

        public xuphat_ett(tbl_xuphat xp)
        {
            maphat = xp.maphat;
            loaiphat = xp.loaiphat;
            giatien = xp.giatien;
        }
        public xuphat_ett(int maphat, string loaiphat, decimal giatien)
        {
            this.maphat = maphat;
            this.loaiphat = loaiphat;
            this.giatien = giatien;
        }
    }
}
