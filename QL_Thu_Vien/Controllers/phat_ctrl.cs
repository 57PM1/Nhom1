using DoAnCNPM.Models;
using DoAnCNPM.Shareds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Controllers
{
    class phat_ctrl
    {
        QL_Thu_VienEntities db = new QL_Thu_VienEntities();

        public Result<List<phat_ett>> select_all()
        {
            QL_Thu_VienEntities db1 = new QL_Thu_VienEntities();
            Result<List<phat_ett>> rs = new Result<List<phat_ett>>();
            try
            {
                List<phat_ett> lst = new List<phat_ett>();
                var dt = db1.tbl_xuphat.SqlQuery("select * from tbl_xuphat");
                if (dt.Count()>0)
                {
                    foreach (var item in dt)
                    {
                        phat_ett temp = new phat_ett();
                        temp.maphat = item.maphat;
                        temp.loaiphat = item.loaiphat;
                        temp.giatien =(long) item.giatien;
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
            catch (Exception ex)
            {
                rs.errcode = ErrorCode.fail;
                rs.errInfor = ex.ToString();
                return rs;
            }
        }

        public Result<bool> insert_mucphat(phat_ett phat)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                db.Database.ExecuteSqlCommand("insert into tbl_xuphat(loaiphat, giatien) values (N'" + phat.loaiphat + "', '" + phat.giatien +"')");
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

        public Result<bool> delete_phat(int maphat)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                db.Database.ExecuteSqlCommand("delete from tbl_xuphat where maphat={0}", maphat);
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

        public Result<bool> edit_phat(phat_ett phat)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                db.Database.ExecuteSqlCommand("update tbl_xuphat set loaiphat=N'" + phat.loaiphat + "', giatien=" + phat.giatien+" where maphat="+phat.maphat);
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

        public Result<List<phat_ett>> search_phat(string loaiphat)
        {
            Result<List<phat_ett>> rs = new Result<List<phat_ett>>();
            try
            {
                List<phat_ett> lst = new List<phat_ett>();
                var dt = db.tbl_xuphat.SqlQuery("select * from tbl_xuphat where loaiphat like '%"+loaiphat+"%'");
                if (dt.Count() > 0)
                {
                    foreach (var item in dt)
                    {
                        phat_ett temp = new phat_ett();
                        temp.maphat = item.maphat;
                        temp.loaiphat = item.loaiphat;
                        temp.giatien = (long)item.giatien;
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
            catch (Exception ex)
            {
                rs.errcode = ErrorCode.fail;
                rs.errInfor = ex.ToString();
                return rs;
            }
        }
    }
}
