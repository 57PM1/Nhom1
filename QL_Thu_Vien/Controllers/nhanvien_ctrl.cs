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
    public class nhanvien_ctrl
    {
        QL_Thu_VienEntities db = new QL_Thu_VienEntities();

        // [ToanNV] Get all nhan vien
        public Result<List<nhanvien_ett>> select_all_nhanvien()
        {
            QL_Thu_VienEntities db_select = new QL_Thu_VienEntities();

            Result<List<nhanvien_ett>> rs = new Result<List<nhanvien_ett>>();
            try
            {
                List<nhanvien_ett> lst = new List<nhanvien_ett>();
                var dt = db_select.tbl_nhanvien.SqlQuery("Select * from tbl_nhanvien");
                if (dt.Count() > 0)
                {
                    foreach (tbl_nhanvien item in dt)
                    {
                        nhanvien_ett temp = new nhanvien_ett(item);
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

        // [ToanNV] Insert nhân viên
        public Result<bool> insert_nhanvien(nhanvien_ett nhanvien)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
                // create new tbl_nhanvien to insert to database_context
                //string sql = String.Format("Insert into tbl_nhanvien(tennv, diachi, dienthoai, email, chucvu, tuoi, taikhoan, matkhau) values(N'{0}', N'{1}', '{2}', N'{3}', N'{4}', {5},  N'{6}', N'{7}')", nhanvien.tennhanvien, nhanvien.diachi, nhanvien.sdt, nhanvien.email, nhanvien.chucvu, nhanvien.tuoi, nhanvien.taikhoan, PasswordUtil.HashPassword(nhanvien.matkhau));

                //db.Database.ExecuteSqlCommand(sql);
                //db.SaveChanges();

                db.Proc_Insert_NhanVien(nhanvien.tennhanvien, nhanvien.diachi, nhanvien.sdt, nhanvien.email, nhanvien.chucvu, nhanvien.tuoi, nhanvien.taikhoan, PasswordUtil.HashPassword(nhanvien.matkhau));

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

        //[ToanNV] Delete nhân viên
        public Result<bool> delete_nhanvien(int manhanvien)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //int dt = db.Database.ExecuteSqlCommand("Delete from tbl_nhanvien where manv = " + manhanvien);

                db.Proc_Delete_NhanVien(manhanvien);

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

        //[ToanNV] edit nhân viên
        public Result<bool> edit_nhanvien(nhanvien_ett nhanvien)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //find the only row to edit
                //var dt = db.tbl_nhanvien.SqlQuery("Select * from tbl_nhanvien where manv = " + nhanvien.manhanvien).SingleOrDefault();
                //// if fields are null or "" then maintaining the old data;
                //if (nhanvien.tennhanvien != null && nhanvien.tennhanvien != "")
                //{
                //    dt.tennv = nhanvien.tennhanvien;
                //}
                //if (nhanvien.diachi != null && nhanvien.diachi != "")
                //{
                //    dt.diachi = nhanvien.diachi;
                //}
                //if (nhanvien.sdt != null && nhanvien.sdt != "")
                //{
                //    dt.dienthoai = nhanvien.sdt;
                //}
                //if (nhanvien.email != null && nhanvien.email != "")
                //{
                //    dt.email = nhanvien.email;
                //}
                //if (nhanvien.chucvu != null && nhanvien.chucvu != "")
                //{
                //    dt.chucvu = nhanvien.chucvu;
                //}
                //if (nhanvien.tuoi != null)
                //{
                //    dt.tuoi = nhanvien.tuoi;
                //}
                //if (nhanvien.taikhoan != null && nhanvien.taikhoan != "")
                //{
                //    dt.taikhoan = nhanvien.taikhoan;
                //}
                //if (nhanvien.matkhau != null && nhanvien.matkhau != "")
                //{
                //    dt.matkhau = PasswordUtil.HashPassword(nhanvien.matkhau);
                //}

                db.Proc_Update_NhanVien(nhanvien.manhanvien, nhanvien.tennhanvien, nhanvien.diachi, nhanvien.sdt, nhanvien.email, nhanvien.chucvu, nhanvien.tuoi, nhanvien.taikhoan, PasswordUtil.HashPassword(nhanvien.matkhau));

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

        // [ToanNV] Search by fields
        public Result<List<nhanvien_ett>> select_nhanvien_fields(string input, string howtosearch)
        {
            QL_Thu_VienEntities db_select = new QL_Thu_VienEntities();

            Result<List<nhanvien_ett>> rs = new Result<List<nhanvien_ett>>();
            try
            {
                DbSqlQuery<tbl_nhanvien> dt = null;
                List<nhanvien_ett> lst = new List<nhanvien_ett>();
                switch (howtosearch)
                {
                    case "hoten":
                        dt = db_select.tbl_nhanvien.SqlQuery(String.Format("Select * from tbl_nhanvien where tennv like N'%{0}%'", input));
                        break;
                    case "chucvu":
                        dt = db_select.tbl_nhanvien.SqlQuery(String.Format("Select * from tbl_nhanvien where chucvu like N'%{0}%'", input));
                        break;
                    case "taikhoan":
                        dt = db_select.tbl_nhanvien.SqlQuery(String.Format("Select * from tbl_nhanvien where taikhoan like N'%{0}%'", input));
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (tbl_nhanvien item in dt)
                    {
                        nhanvien_ett temp = new nhanvien_ett(item);
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
