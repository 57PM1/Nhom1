using DoAnCNPM.Models;
using DoAnCNPM.Shareds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Controllers
{
    public class chitietphieu_ctrl
    {

        public chitietphieu_ctrl() { }

        QL_Thu_VienEntities db = new QL_Thu_VienEntities();

        public Result<List<chitietphieu_ett>> select_all_chitietphieu_by_sopm(int sopm)
        {
            Result<List<chitietphieu_ett>> rs = new Result<List<chitietphieu_ett>>();
            try
            {

                //List<chitietphieu_ett> lst = new List<chitietphieu_ett>();
                //var dt = db.tbl_chitietphieus.Where(o => o.sophieumuon == sopm);
                //if (dt.Count() > 0)
                //{
                //    foreach (tbl_chitietphieu item in dt)
                //    {
                //        chitietphieu_ett temp = new chitietphieu_ett(item);
                //        lst.Add(temp);
                //    }
                //    rs.data = lst;
                //    rs.errcode = ErrorCode.sucess;
                //}
                //else
                //{
                //    rs.data = null;
                //    rs.errInfor = Constants.empty_data;
                //}
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

        public Result<bool> insert_chitietphieu(chitietphieu_ett chitietphieu)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
                // create new tbl_chitietphieu to insert to database_context
                string sql = String.Format("Insert into tbl_chitietphieu(sophieumuon, masach, trangthaisach) values({0}, {1}, N'{2}')", chitietphieu.sophieumuon, chitietphieu.masach, chitietphieu.trangthaisach);

                db.Database.ExecuteSqlCommand(sql);
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

        public Result<bool> insert_chitietphieu(string maphieumuon, List<string> masach)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
                // check whether maphieumuon exists or not

                var data = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra where sophieumuon = " + maphieumuon);

                if (data.Count() > 0)
                {
                    foreach (var item in masach)
                    {
                        string sql = String.Format("Insert into tbl_chitietphieu(sophieumuon, masach) values({0}, {1})", maphieumuon, item);
                        db.Database.ExecuteSqlCommand(sql);
                        db.SaveChanges();
                    }
                }
                else
                {
                    rs.data = false;
                    rs.errcode = ErrorCode.fail;
                    rs.errInfor = Constants.Err_SoPhieuMuon_Not_Exists;
                    return rs;
                }

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

        public Result<bool> delete_chitietphieu(int sopm, int masach)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //var dt = db.tbl_chitietphieus.Where(o => o.sophieumuon == sopm && o.masach == masach);
                //if (dt.Count() > 0)
                //{
                //    foreach (tbl_chitietphieu item in dt)
                //    {
                //        db.tbl_chitietphieus.DeleteOnSubmit(item);
                //    }
                //    db.SubmitChanges();
                //    rs.data = true;
                //    rs.errcode = ErrorCode.sucess;
                //}
                //else
                //{
                //    rs.data = false;
                //    rs.errcode = ErrorCode.NaN;
                //    rs.errInfor = Constants.empty_data;
                //}

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
    }
}
