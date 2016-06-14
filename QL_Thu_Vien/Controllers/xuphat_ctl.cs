using DoAnCNPM.Controllers;
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
    class xuphat_ctl
    {
        QL_Thu_VienEntities db = new QL_Thu_VienEntities();
        public Result<List<xuphat_ett>> select_all_xuphat()
        {
            Result<List<xuphat_ett>> rs = new Result<List<xuphat_ett>>();
            try
            {
                QL_Thu_VienEntities db1 = new QL_Thu_VienEntities();
                List<xuphat_ett> lst = new List<xuphat_ett>();
                var dt = db1.tbl_xuphat.SqlQuery("select * from tbl_xuphat");
                if (dt.Count() > 0)
                {
                    foreach (tbl_xuphat item in dt)
                    {
                        xuphat_ett temp = new xuphat_ett(item);
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

        public Result<bool> insert_xuphat(xuphat_ett xuphat)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
                db.Proc_Insert_XuPhat(xuphat.loaiphat, long.Parse(xuphat.giatien.ToString()));

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

        public Result<bool> delete_xuphat(int maxuphat)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                db.Proc_Delete_XuPhat(maxuphat);
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

        public Result<bool> update_xuphat(xuphat_ett xuphat)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                db.Proc_Update_XuPhat(xuphat.maphat, xuphat.loaiphat, long.Parse(xuphat.giatien.ToString()));

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

        public Result<List<xuphat_ett>> select_xuphat_fields(string input, string howtosearch)
        {
            Result<List<xuphat_ett>> rs = new Result<List<xuphat_ett>>();
            try
            {
                DbSqlQuery<tbl_xuphat> dt = null;
                List<xuphat_ett> lst = new List<xuphat_ett>();
                switch (howtosearch)
                {
                    case "loaiphat":
                        dt = db.tbl_xuphat.SqlQuery(String.Format("Select * from tbl_xuphat where loaiphat like N'%{0}%'", input));
                        break;
                    case "giatien":
                        dt = db.tbl_xuphat.SqlQuery(String.Format("Select * from tbl_xuphat where giatien=", input));
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (tbl_xuphat item in dt)
                    {
                        xuphat_ett temp = new xuphat_ett(item);
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
