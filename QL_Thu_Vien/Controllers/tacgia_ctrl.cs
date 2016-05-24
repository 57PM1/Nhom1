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
                db.Proc_Insert_TacGia(tacgia.tentacgia, tacgia.gioitinh, tacgia.diachi);

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

                db.Proc_Delete_TacGia(matacgia);

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
                db.Proc_Update_TacGia(tacgia.matacgia, tacgia.tentacgia, tacgia.gioitinh, tacgia.diachi);
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
