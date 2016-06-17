using DoAnCNPM.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNPM.Controllers
{
    class baocao_tienphat_ctrl
    {
        QL_Thu_VienEntities db = new QL_Thu_VienEntities();
        public List<baocao_tienphat_ett> select_all_tienphat_month(int month, int year)
        {
            List<baocao_tienphat_ett> rs = new List<baocao_tienphat_ett>();
            try
            {
                var dt = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra where sotienphat > 0 ");

                if (dt.Count() > 0)
                {
                    foreach (var item in dt)
                    {
                        DateTime date= DateTime.ParseExact(item.ngaytra, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        if (date.Month==month && date.Year==year)
                        {
                            baocao_tienphat_ett temp = new baocao_tienphat_ett();
                            temp.sophieumuon = item.sophieumuon;
                            temp.ngaymuon = item.ngaymuon;
                            temp.ngaytra = item.ngaytra;
                            temp.ghichu = item.ghichu;
                            temp.sotienphat =(long) item.sotienphat;
                            rs.Add(temp);
                        }
                    }
                }
                return rs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Lỗi");
                return rs;
            }
        }

        public List<baocao_tienphat_ett> select_all_tienphat_year(int year)
        {
            List<baocao_tienphat_ett> rs = new List<baocao_tienphat_ett>();
            try
            {
                var dt = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra where sotienphat > 0 ");

                if (dt.Count() > 0)
                {
                    foreach (var item in dt)
                    {
                        DateTime date = DateTime.ParseExact(item.ngaytra, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        if (date.Year == year)
                        {
                            baocao_tienphat_ett temp = new baocao_tienphat_ett();
                            temp.sophieumuon = item.sophieumuon;
                            temp.ngaymuon = item.ngaymuon;
                            temp.ngaytra = item.ngaytra;
                            temp.ghichu = item.ghichu;
                            temp.sotienphat = (long)item.sotienphat;
                            rs.Add(temp);
                        }
                    }
                }
                return rs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Lỗi");
                return rs;
            }
        }
    }
}
