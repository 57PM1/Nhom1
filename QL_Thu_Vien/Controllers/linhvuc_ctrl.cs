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
    public class linhvuc_ctrl
    {

        public linhvuc_ctrl() { }

        QL_Thu_VienEntities db = new QL_Thu_VienEntities();


        public Result<List<linhvuc_ett>> select_all_linhvuc()
        {
            Result<List<linhvuc_ett>> rs = new Result<List<linhvuc_ett>>();
            try
            {
                List<linhvuc_ett> lst = new List<linhvuc_ett>();
                var dt = db.tbl_linhvuc.SqlQuery("Select * from tbl_linhvuc");
                if (dt.Count() > 0)
                {
                    foreach (tbl_linhvuc item in dt)
                    {
                        linhvuc_ett temp = new linhvuc_ett(item);
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

        public Result<bool> insert_linhvuc(linhvuc_ett linhvuc)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
               
                db.Proc_Insert_LinhVuc(linhvuc.tenlinhvuc);
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

        public Result<bool> delete_linhvuc(int malinhvuc)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                // int dt = db.Database.ExecuteSqlCommand("Delete from tbl_linhvuc where malinhvuc = " + malinhvuc);

                db.Proc_Delete_LinhVuc(malinhvuc);
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

        public Result<bool> edit_linhvuc(linhvuc_ett linhvuc)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //// find the only row to edit
                //var dt = db.tbl_linhvuc.SqlQuery("Select * from tbl_linhvuc where malinhvuc = " + linhvuc.malinhvuc).SingleOrDefault();
                //// if fields are null or "" then maintaining the old data;
                //if (linhvuc.tenlinhvuc != null && linhvuc.tenlinhvuc != "")
                //{
                //    dt.tenlinhvuc = linhvuc.tenlinhvuc;
                //}
                //db.SaveChanges();

                db.Proc_Update_LinhVuc(linhvuc.malinhvuc,linhvuc.tenlinhvuc);
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

        public Result<List<linhvuc_ett>> select_linhvuc_fields(string input, string howtosearch)
        {
            Result<List<linhvuc_ett>> rs = new Result<List<linhvuc_ett>>();
            try
            {
                DbSqlQuery<tbl_linhvuc> dt = null;
                List<linhvuc_ett> lst = new List<linhvuc_ett>();
                switch (howtosearch)
                {
                    case "tenlv":
                        dt = db.tbl_linhvuc.SqlQuery(String.Format("Select * from tbl_linhvuc where tenlinhvuc like '%{0}%'", input));
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (tbl_linhvuc item in dt)
                    {
                        linhvuc_ett temp = new linhvuc_ett(item);
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
