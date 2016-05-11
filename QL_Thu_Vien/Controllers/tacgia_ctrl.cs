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
   public class tacgia_ctrl
    {
        public tacgia_ctrl() { }

        QL_Thu_VienEntities db = new QL_Thu_VienEntities();

        // Trang 
        public Result<List<tacgia_ett>> select_all_tacgia()
        {
            Result<List<tacgia_ett>> rs = new Result<List<tacgia_ett>>();
            try
            {
                List<tacgia_ett> lst = new List<tacgia_ett>();
                var dt = db.tbl_tacgia.SqlQuery("Select * from tbl_tacgia");
                if (dt.Count() > 0)
                {
                    foreach (tbl_tacgia item in dt)
                    {
                        tacgia_ett temp = new tacgia_ett(item);
                        lst.Add(temp);
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

        //Trang
        public Result<bool> insert_tacgia(tacgia_ett tacgia)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
                string sql = String.Format("Insert into tbl_tacgia(tentg, gioitinh, diachi) values(N'{0}', N'{1}', '{2}')", tacgia.tentacgia, tacgia.gioitinh, tacgia.diachi);

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

        //Trang
        public Result<bool> delete_tacgia(int matacgia)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                int dt = db.Database.ExecuteSqlCommand("Delete from tbl_tacgia where matg = " +matacgia);

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

        public Result<bool> edit_tacgia(tacgia_ett tacgia)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                // find the only row to edit
                var dt = db.tbl_tacgia.SqlQuery("Select * from tbl_tacgia where mantg = " + tacgia.matacgia).SingleOrDefault();
                // if fields are null or "" then maintaining the old data;
                if (tacgia.tentacgia != null && tacgia.tentacgia != "")
                {
                    dt.tentg = tacgia.tentacgia;
                }
                if (tacgia.gioitinh != null && tacgia.gioitinh != "")
                {
                    dt.gioitinh = tacgia.gioitinh;
                }
                if (tacgia.diachi != null && tacgia.diachi != "")
                {
                    dt.diachi = tacgia.diachi;
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

        public Result<List<tacgia_ett>> select_tacgia_fields(string input, string howtosearch)
        {
            Result<List<tacgia_ett>> rs = new Result<List<tacgia_ett>>();
            try
            {
                DbSqlQuery<tbl_tacgia> dt = null;
                List<tacgia_ett> lst = new List<tacgia_ett>();
                switch (howtosearch)
                {
                    case "tentg":
                        dt = db.tbl_tacgia.SqlQuery(string.Format("Select * from tbl_tacgia where tentg like '%{0}%'", input));
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (tbl_tacgia item in dt)
                    {
                        tacgia_ett temp = new tacgia_ett(item);
                        lst.Add(temp);
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
