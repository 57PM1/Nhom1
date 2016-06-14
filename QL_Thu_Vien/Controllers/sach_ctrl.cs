using DoAnCNPM.Models;
using DoAnCNPM.Shareds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Controllers
{
    public  class sach_ctrl
    {
        public sach_ctrl() { }

        // QL_Thu_VienDataContext db = new QL_Thu_VienDataContext();
        QL_Thu_VienEntities db = new QL_Thu_VienEntities();

        public Result<List<tacgia_ett>> select_tacgia(string masach)
        {
            QL_Thu_VienEntities db1 = new QL_Thu_VienEntities();
            Result<List<tacgia_ett>> rs = new Result<List<tacgia_ett>>();
            try
            {
                List<tacgia_ett> lst = new List<tacgia_ett>();
                var dt = db1.tbl_sach.SqlQuery("select * from tbl_sach where masach=" + int.Parse(masach)).FirstOrDefault();
                var item = dt.tbl_tacgia;

                if (item.Count()>0)
                {
                    foreach (var i in item)
                    {
                        tacgia_ett temp = new tacgia_ett();
                        temp.matacgia = i.matg;
                        temp.tentacgia = i.tentg;
                        lst.Add(temp);
                    }
                }
                else
                {
                    rs.data = null;
                    rs.errInfor = Constants.empty_data;
                }
                rs.data = lst;
                rs.errcode = ErrorCode.sucess;
            }
            catch (Exception e)
            {
                rs.data = null;
                rs.errInfor = e.ToString();
                rs.errcode = ErrorCode.fail;
                return rs;
            }


            return rs;
        }

        public Result<List<sachview_ett>> select_all_sachview()
        {
            QL_Thu_VienEntities db1 = new QL_Thu_VienEntities();
            Result<List<sachview_ett>> rs = new Result<List<sachview_ett>>();
            try
            {
                List<sachview_ett> lst = new List<sachview_ett>();
                //var dt = from o in db.tbl_saches
                //         join p in db.tbl_tacgias on o.matg equals p.matg
                //         join k in db.tbl_nxbs on o.manxb equals k.manxb
                //         join l in db.tbl_linhvucs on o.malv equals l.malinhvuc
                //         select new sachview_ett() { masach = o.masach, tensach = o.tensach, linhvuc = l.tenlinhvuc, tacgia = p.tentg, nxb = k.tennxb, soluong = o.soluong.ToString(), sotrang = o.sotrang.ToString(), ngaynhap = o.ngaynhap };
                var dt = db1.tbl_sach.SqlQuery("select * from tbl_sach");
                if (dt.Count() > 0)
                {
                    foreach (var item in dt)
                    {
                        sachview_ett temp = new sachview_ett();
                        temp.masach = item.masach;
                        temp.tensach = item.tensach;
                        temp.nxb = item.tbl_nxb.tennxb;
                        temp.linhvuc = item.tbl_linhvuc.tenlinhvuc;
                        temp.sotrang = (int) item.sotrang;
                        temp.soluonghientai = (int) item.soluonghientai;
                        temp.soluongbandau = (int)item.soluongbandau;
                        temp.ngaynhap = item.ngaynhap;
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

        public Result<List<sachview_ett>> select_sach_almost_null()
        {
            Result<List<sachview_ett>> rs = new Result<List<sachview_ett>>();
            try
            {
                //List<sachview_ett> lst = new List<sachview_ett>();
                //var dt = from o in db.tbl_saches
                //         join p in db.tbl_tacgias on o.matg equals p.matg
                //         join k in db.tbl_nxbs on o.manxb equals k.manxb
                //         join l in db.tbl_linhvucs on o.malv equals l.malinhvuc
                //         where o.soluong < 5
                //         select new sachview_ett() { masach = o.masach, tensach = o.tensach, linhvuc = l.tenlinhvuc, tacgia = p.tentg, nxb = k.tennxb, soluong = o.soluong.ToString(), sotrang = o.sotrang.ToString(), ngaynhap = o.ngaynhap };
                //if (dt.Count() > 0)
                //{
                //    foreach (sachview_ett item in dt)
                //    {
                //        lst.Add(item);
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

        public Result<List<sachview_ett>> select_sach_no_one_borrow()
        {
            Result<List<sachview_ett>> rs = new Result<List<sachview_ett>>();
            try
            {
                //List<sachview_ett> lst = new List<sachview_ett>();
                //var dt = from o in db.tbl_saches
                //         where !(from b2 in db.tbl_phieumuon_tras
                //                 join b3 in db.tbl_chitietphieus on b2.sophieumuon equals b3.sophieumuon
                //                 select b3.masach).Contains(o.masach)
                //         join p in db.tbl_tacgias on o.matg equals p.matg
                //         join k in db.tbl_nxbs on o.manxb equals k.manxb
                //         join l in db.tbl_linhvucs on o.malv equals l.malinhvuc
                //         select new sachview_ett() { masach = o.masach, tensach = o.tensach, linhvuc = l.tenlinhvuc, tacgia = p.tentg, nxb = k.tennxb, soluong = o.soluong.ToString(), sotrang = o.sotrang.ToString(), ngaynhap = o.ngaynhap };

                //if (dt.Count() > 0)
                //{
                //    foreach (sachview_ett item in dt)
                //    {
                //        lst.Add(item);
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

        public Result<bool> insert_sach(sach_ett sach, List<tacgia_ett> tacgias)
        {
            Result<bool> rs = new Result<bool>();

            try
            {
                //// create new tbl_sach to insert to database_context
                db.Proc_Insert_Sach(sach.tensach, sach.manxb, sach.malv, sach.sotrang, sach.soluonghientai, sach.soluongbandau, sach.ngaynhap);
                foreach (var item in tacgias)
                {
                    db.Proc_Insert_Sach_Tacgia(item.matacgia);
                }
                //tbl_sach temp = new tbl_sach();
                //temp.tensach = sach.tensach;
                //temp.matg = sach.matg;
                //temp.manxb = sach.manxb;
                //temp.malv = sach.malv;
                //temp.sotrang = sach.sotrang;
                //temp.soluong = sach.soluong;
                //temp.ngaynhap = sach.ngaynhap;

                //db.tbl_saches.InsertOnSubmit(temp);
                //db.SubmitChanges();

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

        public Result<bool> delete_sach(int masach)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //var dt = db.tbl_saches.Where(o => o.masach == masach);
                //if (dt.Count() > 0)
                //{
                //    foreach (tbl_sach item in dt)
                //    {
                //        db.tbl_saches.DeleteOnSubmit(item);
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
                db.Proc_Delete_Sach_Tacgia(masach);
                db.Proc_Delete_Sach(masach);
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

        public Result<bool> edit_sach(sach_ett sach, List<tacgia_ett> tacgias)
        {
            Result<bool> rs = new Result<bool>();
            try
            {
                //// find the only row to edit
                //var dt = db.tbl_saches.Where(o => o.masach == sach.masach).SingleOrDefault();
                //// if fields are null or "" then maintaining the old data;
                //if (sach.tensach != null && sach.tensach != "")
                //{
                //    dt.tensach = sach.tensach;
                //}
                //if (sach.matg != null)
                //{
                //    dt.matg = sach.matg;
                //}
                //if (sach.manxb != null)
                //{
                //    dt.manxb = sach.manxb;
                //}
                //if (sach.malv != null)
                //{
                //    dt.malv = sach.malv;
                //}
                //if (sach.soluong != null)
                //{
                //    dt.soluong = sach.soluong;
                //}
                //if (sach.sotrang != null)
                //{
                //    dt.sotrang = sach.sotrang;
                //}
                //if (sach.ngaynhap != null || sach.ngaynhap != "")
                //{
                //    dt.ngaynhap = sach.ngaynhap;
                //}

                //db.SubmitChanges();
                QL_Thu_VienEntities db2 = new QL_Thu_VienEntities();
                db2.Proc_Update_Sach(sach.masach, sach.tensach, sach.manxb, sach.malv, sach.sotrang, sach.soluonghientai, sach.soluongbandau, sach.ngaynhap);
                db2.Proc_Delete_Sach_Tacgia(sach.masach);
                foreach (var item in tacgias)
                {
                    db2.Proc_Update_Sach_Tacgia(sach.masach, item.matacgia);
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

        public Result<List<sachview_ett>> select_sach_fields(string input, string howtosearch)
        {
            Result<List<sachview_ett>> rs = new Result<List<sachview_ett>>();
            try
            {
                var dt = db.tbl_sach.SqlQuery("select * from tbl_sach");
                // IQueryable<tbl_sach> dt = null;
                List<sachview_ett> lst = new List<sachview_ett>();
                switch (howtosearch)
                {
                    case "tensach":
                        dt = db.tbl_sach.SqlQuery("select * from tbl_sach where tensach like '%" + input + "%'");
                        break;
                    case "tacgia":
                        //dt = db.tbl_sach.SqlQuery("select * from tbl_sach where masach= (select masach from tbl_sach_tacgia where matg=(select top 1 matg from tbl_tacgia where tentg like '%"+input+"%'))"); 
                        var d = db.tbl_sach.SqlQuery("Select * from tbl_sach");
                        var k = d.Where(i => i.tbl_tacgia.Where(o => o.tentg.Contains(input)).Count() > 0);
                        if (k.Count() > 0)
                        {
                            foreach (var item in k)
                            {
                                sachview_ett temp = new sachview_ett();
                                temp.masach = item.masach;
                                temp.tensach = item.tensach;
                                temp.nxb = item.tbl_nxb.tennxb;
                                temp.linhvuc = item.tbl_linhvuc.tenlinhvuc;
                                temp.sotrang = (int)item.sotrang;
                                temp.soluonghientai = (int)item.soluonghientai;
                                temp.soluongbandau = (int)item.soluongbandau;
                                temp.ngaynhap = item.ngaynhap;
                                lst.Add(temp);
                            }
                            rs.data = lst;
                            rs.errcode = ErrorCode.sucess;
                            return rs;
                        }
                        break;
                    case "linhvuc":
                        dt = db.tbl_sach.SqlQuery("select * from tbl_sach where malv=(select top 1 malv from tbl_linhvuc where tenlinhvuc like '%" + input + "%')");
                        break;
                    case "nxb":
                        dt = db.tbl_sach.SqlQuery("select * from tbl_sach where manxb=(select top 1 manxb from tbl_nxb where tennxb like '%" + input + "%')");
                        break;
                    default:
                        break;
                }

                if (dt.Count() > 0)
                {
                    foreach (var item in dt)
                    {
                        sachview_ett temp = new sachview_ett();
                        temp.masach = item.masach;
                        temp.tensach = item.tensach;
                        temp.nxb = item.tbl_nxb.tennxb;
                        temp.linhvuc = item.tbl_linhvuc.tenlinhvuc;
                        temp.sotrang = (int)item.sotrang;
                        temp.soluonghientai = (int)item.soluonghientai;
                        temp.soluongbandau = (int)item.soluongbandau;
                        temp.ngaynhap = item.ngaynhap;
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

    }
}
