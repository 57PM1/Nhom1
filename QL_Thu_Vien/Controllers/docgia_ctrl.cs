using DoAnCNPM.Models;
using DoAnCNPM.Shareds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Controllers
{
    public class docgia_ctrl
    {
        public docgia_ctrl() { }

        // QL_Thu_VienDataContext db = new QL_Thu_VienDataContext();
        QL_Thu_VienEntities db = new QL_Thu_VienEntities();

        public Result<List<docgia_ett>> select_all_docgia()
        {
            Result<List<docgia_ett>> rs = new Result<List<docgia_ett>>();
            try
            {
                QL_Thu_VienEntities db1 = new QL_Thu_VienEntities();
                List<docgia_ett> lst = new List<docgia_ett>();
                var dt = db1.tbl_docgia.SqlQuery("select * from tbl_docgia");
                if (dt.Count() > 0)
                {
                    foreach (tbl_docgia item in dt)
                    {
                        docgia_ett temp = new docgia_ett(item);
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

        public Result<bool> insert_docgia(docgia_ett docgia)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
                // create new tbl_docgia to insert to database_context
                db.Proc_Insert_DocGia(docgia.tendocgia, docgia.ngaysinh, docgia.gioitinh, docgia.lop, docgia.diachi, docgia.email);

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

        public Result<List<view_quahan_ett>> select_expired_docgia()
        {
            Result<List<view_quahan_ett>> rs = new Result<List<view_quahan_ett>>();
            try
            {
                List<view_quahan_ett> lst = new List<view_quahan_ett>();
                var dt = db.tbl_quahan_view.SqlQuery("select * from tbl_quahan_view");
                if (dt.Count() > 0)
                {
                    foreach (tbl_quahan_view item in dt)
                    {
                        view_quahan_ett temp = new view_quahan_ett(item);
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

        public Result<bool> delete_docgia(int madocgia)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //var dt = db.tbl_docgias.Where(o => o.madg == madocgia);
                //if (dt.Count() > 0)
                //{
                //    foreach (tbl_docgia item in dt)
                //    {
                //        db.tbl_docgias.DeleteOnSubmit(item);
                //    }
                //    db.SubmitChanges();

                //}
                //else
                //{
                //    rs.data = false;
                //    rs.errcode = ErrorCode.NaN;
                //    rs.errInfor = Constants.empty_data;
                //}
                db.Proc_Delete_DocGia(madocgia);
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

        public Result<bool> edit_docgia(docgia_ett docgia)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                // find the only row to edit
                //var dt = db.tbl_docgias.Where(o => o.madg == docgia.madocgia).SingleOrDefault();
                //// if fields are null or "" then maintaining the old data;
                //if (docgia.tendocgia != null && docgia.tendocgia != "")
                //{
                //    dt.tendg = docgia.tendocgia;
                //}
                //if (docgia.ngaysinh != null && docgia.ngaysinh != "")
                //{
                //    dt.ngaysinh = docgia.ngaysinh;
                //}
                //if (docgia.gioitinh != null && docgia.gioitinh != "")
                //{
                //    dt.gioitinh = docgia.gioitinh;
                //}
                //if (docgia.lop != null && docgia.lop != "")
                //{
                //    dt.lop = docgia.lop;
                //}
                //if (docgia.diachi != null && docgia.diachi != "")
                //{
                //    dt.diachi = docgia.diachi;
                //}
                //if (docgia.email != null && docgia.email != "")
                //{
                //    dt.email = docgia.email;
                //}

                //db.SubmitChanges();
                db.Proc_Edit_DocGia(docgia.tendocgia, docgia.ngaysinh, docgia.gioitinh, docgia.lop, docgia.diachi, docgia.email, docgia.madocgia);
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

        public Result<List<docgia_ett>> select_docgia_fields(string input, string howtosearch)
        {
            Result<List<docgia_ett>> rs = new Result<List<docgia_ett>>();
            try
            {
                List<docgia_ett> lst = new List<docgia_ett>();
                var dt = db.tbl_docgia.SqlQuery("select * from tbl_docgia");
                switch (howtosearch)
                {
                    case "hoten":
                        dt = db.tbl_docgia.SqlQuery("select * from tbl_docgia where tendg like '%" + input + "%'");
                        break;
                    case "lop":
                        dt = db.tbl_docgia.SqlQuery("select * from tbl_docgia where lop like '%" + input + "%'");
                        break;
                    case "email":
                        dt = db.tbl_docgia.SqlQuery("select * from tbl_docgia where email like '%" + input + "%'");
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (tbl_docgia item in dt)
                    {
                        docgia_ett temp = new docgia_ett(item);
                        lst.Add(temp);
                    }
                    rs.data = lst;
                    rs.errcode = ErrorCode.sucess;
                    return rs;
                }
                else
                {
                    rs.data = null;
                    rs.errInfor = Constants.empty_data; return rs;
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
        public Result<List<view_quahan_ett>> select_hethan_fields(string input, string howtosearch)
        {
            Result<List<view_quahan_ett>> rs = new Result<List<view_quahan_ett>>();
            try
            {
                List<view_quahan_ett> lst = new List<view_quahan_ett>();
                var dt = db.tbl_quahan_view.SqlQuery("select * from tbl_quahan_view");
                switch (howtosearch)
                {
                    case "hoten":
                        dt = db.tbl_quahan_view.SqlQuery("select * from tbl_quahan_view where tendg like '%" + input + "%'");
                        break;
                    case "lop":
                        dt = db.tbl_quahan_view.SqlQuery("select * from tbl_quahan_view where lop like '%" + input + "%'");
                        break;
                    case "email":
                        dt = db.tbl_quahan_view.SqlQuery("select * from tbl_quahan_view where email like '%" + input + "%'");
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (tbl_quahan_view item in dt)
                    {
                        view_quahan_ett temp = new view_quahan_ett(item);
                        lst.Add(temp);
                    }
                    rs.data = lst;
                    rs.errcode = ErrorCode.sucess;
                }
                else
                {
                    rs.data = null;
                    rs.errInfor = Constants.empty_data; return rs;
                }
              //  return rs;
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
