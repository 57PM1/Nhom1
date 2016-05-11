using DoAnCNPM.Models;
using DoAnCNPM.Shareds;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Controllers
{
    public class phieumuontra_ctrl
    {

        public phieumuontra_ctrl() { }

        QL_Thu_VienEntities db = new QL_Thu_VienEntities();

        public Result<List<phieumuontraview_ett>> select_all_phieumuontra_view()
        {
            Result<List<phieumuontraview_ett>> rs = new Result<List<phieumuontraview_ett>>();
            try
            {
                List<phieumuontraview_ett> lst = new List<phieumuontraview_ett>();
                //var dt = from o in db.tbl_phieumuon_tra
                //         join p in db.tbl_docgia on o.madg equals p.madg
                //         join k in db.tbl_nhanvien on o.manv equals k.manv
                //         select new phieumuontraview_ett()
                //         {
                //             sophieumuon = o.sophieumuon,
                //             docgia = p.tendg,
                //             nhanvien = k.tennv,
                //             ngaymuon = o.ngaymuon,
                //             ngaytra = o.ngaytra,
                //             xacnhantra = o.xacnhantra,
                //             ghichu = o.ghichu
                //         };

                var dt = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra");

                if (dt.Count() > 0)
                {
                    foreach (var item in dt)
                    {
                        lst.Add(new phieumuontraview_ett(item));
                    }
                    rs.data = lst;
                    rs.errcode = ErrorCode.sucess;
                }
                else
                {
                    rs.data = null;
                    rs.errInfor = Constants.empty_data;
                }
                return rs;
            }
            catch (Exception e)
            {
                rs.data = null;
                rs.errInfor = e.ToString();
                rs.errcode = ErrorCode.fail;
                return rs;
            }
        }

        public Result<phieumuontra_ett> insert_phieumuontra(phieumuontra_ett phieumuontra, List<string> list_masach)
        {
            Result<phieumuontra_ett> rs = new Result<phieumuontra_ett>();

            try
            {
                string sql = String.Format("Insert into tbl_phieumuon_tra(madg, manv, ngaymuon, ngaytra, ghichu) values({0}, {1}, '{2}', '{3}', N'{4}')", phieumuontra.madg, phieumuontra.manv, phieumuontra.ngaymuon, phieumuontra.ngaytra, phieumuontra.ghichu);

                db.Database.ExecuteSqlCommand(sql);
                db.SaveChanges();

                // Get Inserted phieu muon tra
                var last_record = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra OrderBy sophieumuon DESC").Take(1);
                if (last_record.Count() > 0)
                {
                    foreach (var item in last_record)
                    {
                        phieumuontra_ett temp = new phieumuontra_ett(item);
                        rs.data = temp;
                    }
                }

                // Insert Chi tiet phieu in phieu
                if (list_masach.Count() > 0)
                {
                    chitietphieu_ctrl chitietphieu_ctrl = new chitietphieu_ctrl();

                    chitietphieu_ctrl.insert_chitietphieu(phieumuontra.sophieumuon.ToString(), list_masach);
                }

                rs.errcode = ErrorCode.sucess;
                return rs;
            }
            catch (Exception e)
            {
                rs.data = null;
                rs.errcode = ErrorCode.fail;
                rs.errInfor = e.ToString();
                return rs;
            }
        }

        public Result<bool> delete_phieumuontra(int maphieumuontra)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                int dt = db.Database.ExecuteSqlCommand("Delete from tbl_phieumuon_tra where sophieumuon = " + maphieumuontra);

                rs.data = true;
                rs.errcode = ErrorCode.sucess;
                rs.errInfor = Constants.success_insert;

                return rs;
            }
            catch (Exception e)
            {
                rs.data = false;
                rs.errcode = ErrorCode.fail;
                rs.errInfor = e.ToString();
                return rs;
            }
        }

        public Result<bool> edit_phieumuontra(phieumuontra_ett phieumuontra, List<string> list_masach)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                // find the only row to edit
                var dt = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra where sophieumuon = " + phieumuontra.sophieumuon).SingleOrDefault();
                // if fields are null or "" then maintaining the old data;
                if (phieumuontra.madg != null)
                {
                    dt.madg = phieumuontra.madg;
                }
                if (phieumuontra.manv != null)
                {
                    dt.manv = phieumuontra.manv;
                }
                if (phieumuontra.ngaymuon != null && phieumuontra.ngaymuon != "")
                {
                    dt.ngaymuon = phieumuontra.ngaymuon;
                }
                if (phieumuontra.ngaytra != null && phieumuontra.ngaytra != "")
                {
                    dt.ngaytra = phieumuontra.ngaytra;
                }
                if (phieumuontra.ghichu != null && phieumuontra.ghichu != "")
                {
                    dt.ghichu = phieumuontra.ghichu;
                }
                if (phieumuontra.xacnhantra != null)
                {
                    dt.xacnhantra = phieumuontra.xacnhantra;
                    if (phieumuontra.xacnhantra == true)
                    {
                        if (list_masach.Count() > 0)
                        {
                            foreach (string item in list_masach)
                            {
                                var data = db.tbl_sach.SqlQuery("select * from tbl_sach where masach = " + item).SingleOrDefault();
                                data.soluonghientai++;
                            }
                        }
                    }
                }

                db.SaveChanges();
                rs.data = true;
                rs.errcode = ErrorCode.sucess;
                return rs;
            }
            catch (Exception e)
            {
                rs.data = false;
                rs.errcode = ErrorCode.fail;
                rs.errInfor = e.ToString();
                return rs;
            }
        }

        public Result<List<phieumuontraview_ett>> select_phieumuontra_fields(string input, string howtosearch)
        {
            Result<List<phieumuontraview_ett>> rs = new Result<List<phieumuontraview_ett>>();
            try
            {
               
                List<phieumuontraview_ett> lst = new List<phieumuontraview_ett>();
                DbSqlQuery<tbl_phieumuon_tra> dt = null;
                switch (howtosearch)
                {
                    case "sophieumuon":
                        dt = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra where sophieumuon =" + input);
                        break;
                    case "docgia":
                        dt = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra where madg =" + input);
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (tbl_phieumuon_tra item in dt)
                    {
                        lst.Add( new phieumuontraview_ett(item));
                    }
                    rs.data = lst;
                    rs.errcode = ErrorCode.sucess;
                    return rs;
                }
                else
                {
                    rs.data = null;
                    rs.errInfor = Constants.empty_data;
                    return rs;
                }
            }
            catch (Exception e)
            {
                rs.data = null;
                rs.errInfor = e.ToString();
                rs.errcode = ErrorCode.fail;
                return rs;
            }
        }
    }
}
