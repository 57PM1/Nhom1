using DoAnCNPM.Models;
using DoAnCNPM.Shareds;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Controllers
{
    public class nhaxuatban_ctrl
    {

        QL_Thu_VienEntities db = new QL_Thu_VienEntities();


        //[ToanNV] Get all nha xuat ban
        public Result<List<nhaxuatban_ett>> select_all_nhaxuatban()
        {
            QL_Thu_VienEntities db_select = new QL_Thu_VienEntities();

            Result<List<nhaxuatban_ett>> rs = new Result<List<nhaxuatban_ett>>();
            try
            {
                List<nhaxuatban_ett> lst = new List<nhaxuatban_ett>();
                var dt = db_select.tbl_nxb.SqlQuery("Select * from tbl_nxb");
                if (dt.Count() > 0)
                {
                    foreach (tbl_nxb item in dt)
                    {
                        nhaxuatban_ett temp = new nhaxuatban_ett(item);
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

        //[ToanNV] Insert nhaxuatban to database
        public Result<bool> insert_nhaxuatban(nhaxuatban_ett nhaxuatban)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
                //string sql = String.Format("Insert into tbl_nxb(tennxb, diachi, sdt) values(N'{0}', N'{1}', '{2}')", nhaxuatban.tennxb, nhaxuatban.diachi, nhaxuatban.sdt);
                //db.Database.ExecuteSqlCommand(sql);
                //db.SaveChanges();


                db.Proc_Insert_NXB(nhaxuatban.tennxb, nhaxuatban.diachi, nhaxuatban.sdt);

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

        public Result<bool> delete_nhaxuatban(int manhaxuatban)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //int dt = db.Database.ExecuteSqlCommand("Delete from tbl_nxb where manxb = " + manhaxuatban);

                db.Proc_Delete_NXB(manhaxuatban);

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

        public Result<bool> edit_nhaxuatban(nhaxuatban_ett nhaxuatban)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //// find the only row to edit
                //var dt = db.tbl_nxb.SqlQuery("Select * from tbl_nxb where manxb = " + nhaxuatban.manxb).SingleOrDefault();
                //// if fields are null or "" then maintaining the old data;
                //if (nhaxuatban.tennxb != null && nhaxuatban.tennxb != "")
                //{
                //    dt.tennxb = nhaxuatban.tennxb;
                //}
                //if (nhaxuatban.sdt != null && nhaxuatban.sdt != "")
                //{
                //    dt.sdt = nhaxuatban.sdt;
                //}
                //if (nhaxuatban.diachi != null && nhaxuatban.diachi != "")
                //{
                //    dt.diachi = nhaxuatban.diachi;
                //}        
                //db.SaveChanges();

                db.Proc_Update_NXB(nhaxuatban.manxb, nhaxuatban.tennxb, nhaxuatban.diachi, nhaxuatban.sdt);
              

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

        public Result<List<nhaxuatban_ett>> select_nhaxuatban_fields(string input, string howtosearch)
        {
            QL_Thu_VienEntities db_select = new QL_Thu_VienEntities();

            Result<List<nhaxuatban_ett>> rs = new Result<List<nhaxuatban_ett>>();
            try
            {
                DbSqlQuery<tbl_nxb> dt = null;
                List<nhaxuatban_ett> lst = new List<nhaxuatban_ett>();
                switch (howtosearch)
                {
                    case "tennxb":
                        dt = db_select.tbl_nxb.SqlQuery(String.Format("Select * from tbl_nxb where tennxb like N'%{0}%'", input));
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (tbl_nxb item in dt)
                    {
                        nhaxuatban_ett temp = new nhaxuatban_ett(item);
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
