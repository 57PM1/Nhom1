﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCNPM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QL_Thu_VienEntities : DbContext
    {
        public QL_Thu_VienEntities()
            : base("name=QL_Thu_VienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_chitietphieu> tbl_chitietphieu { get; set; }
        public virtual DbSet<tbl_docgia> tbl_docgia { get; set; }
        public virtual DbSet<tbl_linhvuc> tbl_linhvuc { get; set; }
        public virtual DbSet<tbl_nhanvien> tbl_nhanvien { get; set; }
        public virtual DbSet<tbl_nxb> tbl_nxb { get; set; }
        public virtual DbSet<tbl_phieumuon_tra> tbl_phieumuon_tra { get; set; }
        public virtual DbSet<tbl_sach> tbl_sach { get; set; }
        public virtual DbSet<tbl_tacgia> tbl_tacgia { get; set; }
        public virtual DbSet<tbl_xuphat> tbl_xuphat { get; set; }
        public virtual DbSet<tbl_quahan_view> tbl_quahan_view { get; set; }
        public virtual DbSet<tbl_sachsaphet_view> tbl_sachsaphet_view { get; set; }
    
        public virtual int Proc_Delete_ChiTietPhieu(Nullable<int> sophieumuon, Nullable<int> masach)
        {
            var sophieumuonParameter = sophieumuon.HasValue ?
                new ObjectParameter("sophieumuon", sophieumuon) :
                new ObjectParameter("sophieumuon", typeof(int));
    
            var masachParameter = masach.HasValue ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_ChiTietPhieu", sophieumuonParameter, masachParameter);
        }
    
        public virtual int Proc_Delete_DocGia(Nullable<int> madg)
        {
            var madgParameter = madg.HasValue ?
                new ObjectParameter("madg", madg) :
                new ObjectParameter("madg", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_DocGia", madgParameter);
        }
    
        public virtual int Proc_Delete_LinhVuc(Nullable<int> malinhvuc)
        {
            var malinhvucParameter = malinhvuc.HasValue ?
                new ObjectParameter("malinhvuc", malinhvuc) :
                new ObjectParameter("malinhvuc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_LinhVuc", malinhvucParameter);
        }
    
        public virtual int Proc_Delete_NhanVien(Nullable<int> manv)
        {
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_NhanVien", manvParameter);
        }
    
        public virtual int Proc_Delete_NXB(Nullable<int> manxb)
        {
            var manxbParameter = manxb.HasValue ?
                new ObjectParameter("manxb", manxb) :
                new ObjectParameter("manxb", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_NXB", manxbParameter);
        }
    
        public virtual int Proc_Delete_PhieuMuonTra(Nullable<int> sophieumuon)
        {
            var sophieumuonParameter = sophieumuon.HasValue ?
                new ObjectParameter("sophieumuon", sophieumuon) :
                new ObjectParameter("sophieumuon", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_PhieuMuonTra", sophieumuonParameter);
        }
    
        public virtual int Proc_Delete_Sach(Nullable<int> masach)
        {
            var masachParameter = masach.HasValue ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_Sach", masachParameter);
        }
    
        public virtual int Proc_Delete_Sach_Tacgia(Nullable<int> masach)
        {
            var masachParameter = masach.HasValue ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_Sach_Tacgia", masachParameter);
        }
    
        public virtual int Proc_Delete_TacGia(Nullable<int> matacgia)
        {
            var matacgiaParameter = matacgia.HasValue ?
                new ObjectParameter("matacgia", matacgia) :
                new ObjectParameter("matacgia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_TacGia", matacgiaParameter);
        }
    
        public virtual int Proc_Delete_XuPhat(Nullable<int> maphat)
        {
            var maphatParameter = maphat.HasValue ?
                new ObjectParameter("maphat", maphat) :
                new ObjectParameter("maphat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Delete_XuPhat", maphatParameter);
        }
    
        public virtual int Proc_Edit_DocGia(string tendg, string ngaysinh, string gioitinh, string lop, string diachi, string email, Nullable<int> madg)
        {
            var tendgParameter = tendg != null ?
                new ObjectParameter("tendg", tendg) :
                new ObjectParameter("tendg", typeof(string));
    
            var ngaysinhParameter = ngaysinh != null ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(string));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var lopParameter = lop != null ?
                new ObjectParameter("lop", lop) :
                new ObjectParameter("lop", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var madgParameter = madg.HasValue ?
                new ObjectParameter("madg", madg) :
                new ObjectParameter("madg", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Edit_DocGia", tendgParameter, ngaysinhParameter, gioitinhParameter, lopParameter, diachiParameter, emailParameter, madgParameter);
        }
    
        public virtual int Proc_Insert_ChiTietPhieu(Nullable<int> sophieumuon, Nullable<int> masach, string trangthaisach)
        {
            var sophieumuonParameter = sophieumuon.HasValue ?
                new ObjectParameter("sophieumuon", sophieumuon) :
                new ObjectParameter("sophieumuon", typeof(int));
    
            var masachParameter = masach.HasValue ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(int));
    
            var trangthaisachParameter = trangthaisach != null ?
                new ObjectParameter("trangthaisach", trangthaisach) :
                new ObjectParameter("trangthaisach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_ChiTietPhieu", sophieumuonParameter, masachParameter, trangthaisachParameter);
        }
    
        public virtual int Proc_Insert_DocGia(string tendg, string ngaysinh, string gioitinh, string lop, string diachi, string email)
        {
            var tendgParameter = tendg != null ?
                new ObjectParameter("tendg", tendg) :
                new ObjectParameter("tendg", typeof(string));
    
            var ngaysinhParameter = ngaysinh != null ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(string));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var lopParameter = lop != null ?
                new ObjectParameter("lop", lop) :
                new ObjectParameter("lop", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_DocGia", tendgParameter, ngaysinhParameter, gioitinhParameter, lopParameter, diachiParameter, emailParameter);
        }
    
        public virtual int Proc_Insert_LinhVuc(string tenlinhvuc)
        {
            var tenlinhvucParameter = tenlinhvuc != null ?
                new ObjectParameter("tenlinhvuc", tenlinhvuc) :
                new ObjectParameter("tenlinhvuc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_LinhVuc", tenlinhvucParameter);
        }
    
        public virtual int Proc_Insert_NhanVien(string tennv, string diachi, string dienthoai, string email, string chucvu, Nullable<int> tuoi, string taikhoan, string matkhau)
        {
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var dienthoaiParameter = dienthoai != null ?
                new ObjectParameter("dienthoai", dienthoai) :
                new ObjectParameter("dienthoai", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var chucvuParameter = chucvu != null ?
                new ObjectParameter("chucvu", chucvu) :
                new ObjectParameter("chucvu", typeof(string));
    
            var tuoiParameter = tuoi.HasValue ?
                new ObjectParameter("tuoi", tuoi) :
                new ObjectParameter("tuoi", typeof(int));
    
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_NhanVien", tennvParameter, diachiParameter, dienthoaiParameter, emailParameter, chucvuParameter, tuoiParameter, taikhoanParameter, matkhauParameter);
        }
    
        public virtual int Proc_Insert_NXB(string tennxb, string diachi, string sdt)
        {
            var tennxbParameter = tennxb != null ?
                new ObjectParameter("tennxb", tennxb) :
                new ObjectParameter("tennxb", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_NXB", tennxbParameter, diachiParameter, sdtParameter);
        }
    
        public virtual int Proc_Insert_PhieuMuonTra(Nullable<int> madg, Nullable<int> manv, string ngaymuon, string ngaytra, string ghichu)
        {
            var madgParameter = madg.HasValue ?
                new ObjectParameter("madg", madg) :
                new ObjectParameter("madg", typeof(int));
    
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            var ngaymuonParameter = ngaymuon != null ?
                new ObjectParameter("ngaymuon", ngaymuon) :
                new ObjectParameter("ngaymuon", typeof(string));
    
            var ngaytraParameter = ngaytra != null ?
                new ObjectParameter("ngaytra", ngaytra) :
                new ObjectParameter("ngaytra", typeof(string));
    
            var ghichuParameter = ghichu != null ?
                new ObjectParameter("ghichu", ghichu) :
                new ObjectParameter("ghichu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_PhieuMuonTra", madgParameter, manvParameter, ngaymuonParameter, ngaytraParameter, ghichuParameter);
        }
    
        public virtual int Proc_Insert_Sach(string tensach, Nullable<int> maxb, Nullable<int> malv, Nullable<int> sotrang, Nullable<int> soluonghientai, Nullable<int> soluongbandau, string ngaynhap)
        {
            var tensachParameter = tensach != null ?
                new ObjectParameter("tensach", tensach) :
                new ObjectParameter("tensach", typeof(string));
    
            var maxbParameter = maxb.HasValue ?
                new ObjectParameter("maxb", maxb) :
                new ObjectParameter("maxb", typeof(int));
    
            var malvParameter = malv.HasValue ?
                new ObjectParameter("malv", malv) :
                new ObjectParameter("malv", typeof(int));
    
            var sotrangParameter = sotrang.HasValue ?
                new ObjectParameter("sotrang", sotrang) :
                new ObjectParameter("sotrang", typeof(int));
    
            var soluonghientaiParameter = soluonghientai.HasValue ?
                new ObjectParameter("soluonghientai", soluonghientai) :
                new ObjectParameter("soluonghientai", typeof(int));
    
            var soluongbandauParameter = soluongbandau.HasValue ?
                new ObjectParameter("soluongbandau", soluongbandau) :
                new ObjectParameter("soluongbandau", typeof(int));
    
            var ngaynhapParameter = ngaynhap != null ?
                new ObjectParameter("ngaynhap", ngaynhap) :
                new ObjectParameter("ngaynhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_Sach", tensachParameter, maxbParameter, malvParameter, sotrangParameter, soluonghientaiParameter, soluongbandauParameter, ngaynhapParameter);
        }
    
        public virtual int Proc_Insert_Sach_Tacgia(Nullable<int> matg)
        {
            var matgParameter = matg.HasValue ?
                new ObjectParameter("matg", matg) :
                new ObjectParameter("matg", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_Sach_Tacgia", matgParameter);
        }
    
        public virtual int Proc_Insert_TacGia(string tentacgia, string gioitinh, string diachi)
        {
            var tentacgiaParameter = tentacgia != null ?
                new ObjectParameter("tentacgia", tentacgia) :
                new ObjectParameter("tentacgia", typeof(string));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_TacGia", tentacgiaParameter, gioitinhParameter, diachiParameter);
        }
    
        public virtual int Proc_Insert_XuPhat(string loaiphat, Nullable<long> giatien)
        {
            var loaiphatParameter = loaiphat != null ?
                new ObjectParameter("loaiphat", loaiphat) :
                new ObjectParameter("loaiphat", typeof(string));
    
            var giatienParameter = giatien.HasValue ?
                new ObjectParameter("giatien", giatien) :
                new ObjectParameter("giatien", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Insert_XuPhat", loaiphatParameter, giatienParameter);
        }
    
        public virtual int Proc_Update_LinhVuc(Nullable<int> malinhvuc, string tenlinhvuc)
        {
            var malinhvucParameter = malinhvuc.HasValue ?
                new ObjectParameter("malinhvuc", malinhvuc) :
                new ObjectParameter("malinhvuc", typeof(int));
    
            var tenlinhvucParameter = tenlinhvuc != null ?
                new ObjectParameter("tenlinhvuc", tenlinhvuc) :
                new ObjectParameter("tenlinhvuc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Update_LinhVuc", malinhvucParameter, tenlinhvucParameter);
        }
    
        public virtual int Proc_Update_NhanVien(Nullable<int> manv, string tennv, string diachi, string dienthoai, string email, string chucvu, Nullable<int> tuoi, string taikhoan, string matkhau)
        {
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var dienthoaiParameter = dienthoai != null ?
                new ObjectParameter("dienthoai", dienthoai) :
                new ObjectParameter("dienthoai", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var chucvuParameter = chucvu != null ?
                new ObjectParameter("chucvu", chucvu) :
                new ObjectParameter("chucvu", typeof(string));
    
            var tuoiParameter = tuoi.HasValue ?
                new ObjectParameter("tuoi", tuoi) :
                new ObjectParameter("tuoi", typeof(int));
    
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Update_NhanVien", manvParameter, tennvParameter, diachiParameter, dienthoaiParameter, emailParameter, chucvuParameter, tuoiParameter, taikhoanParameter, matkhauParameter);
        }
    
        public virtual int Proc_Update_NXB(Nullable<int> manxb, string tennxb, string diachi, string sdt)
        {
            var manxbParameter = manxb.HasValue ?
                new ObjectParameter("manxb", manxb) :
                new ObjectParameter("manxb", typeof(int));
    
            var tennxbParameter = tennxb != null ?
                new ObjectParameter("tennxb", tennxb) :
                new ObjectParameter("tennxb", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Update_NXB", manxbParameter, tennxbParameter, diachiParameter, sdtParameter);
        }
    
        public virtual int Proc_Update_PhieuMuonTra(Nullable<int> sophieumuon, Nullable<int> madg, Nullable<int> manv, string ngaymuon, string ngaytra, string ghichu)
        {
            var sophieumuonParameter = sophieumuon.HasValue ?
                new ObjectParameter("sophieumuon", sophieumuon) :
                new ObjectParameter("sophieumuon", typeof(int));
    
            var madgParameter = madg.HasValue ?
                new ObjectParameter("madg", madg) :
                new ObjectParameter("madg", typeof(int));
    
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            var ngaymuonParameter = ngaymuon != null ?
                new ObjectParameter("ngaymuon", ngaymuon) :
                new ObjectParameter("ngaymuon", typeof(string));
    
            var ngaytraParameter = ngaytra != null ?
                new ObjectParameter("ngaytra", ngaytra) :
                new ObjectParameter("ngaytra", typeof(string));
    
            var ghichuParameter = ghichu != null ?
                new ObjectParameter("ghichu", ghichu) :
                new ObjectParameter("ghichu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Update_PhieuMuonTra", sophieumuonParameter, madgParameter, manvParameter, ngaymuonParameter, ngaytraParameter, ghichuParameter);
        }
    
        public virtual int Proc_Update_Sach(Nullable<int> masach, string tensach, Nullable<int> maxb, Nullable<int> malv, Nullable<int> sotrang, Nullable<int> soluonghientai, Nullable<int> soluongbandau, string ngaynhap)
        {
            var masachParameter = masach.HasValue ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(int));
    
            var tensachParameter = tensach != null ?
                new ObjectParameter("tensach", tensach) :
                new ObjectParameter("tensach", typeof(string));
    
            var maxbParameter = maxb.HasValue ?
                new ObjectParameter("maxb", maxb) :
                new ObjectParameter("maxb", typeof(int));
    
            var malvParameter = malv.HasValue ?
                new ObjectParameter("malv", malv) :
                new ObjectParameter("malv", typeof(int));
    
            var sotrangParameter = sotrang.HasValue ?
                new ObjectParameter("sotrang", sotrang) :
                new ObjectParameter("sotrang", typeof(int));
    
            var soluonghientaiParameter = soluonghientai.HasValue ?
                new ObjectParameter("soluonghientai", soluonghientai) :
                new ObjectParameter("soluonghientai", typeof(int));
    
            var soluongbandauParameter = soluongbandau.HasValue ?
                new ObjectParameter("soluongbandau", soluongbandau) :
                new ObjectParameter("soluongbandau", typeof(int));
    
            var ngaynhapParameter = ngaynhap != null ?
                new ObjectParameter("ngaynhap", ngaynhap) :
                new ObjectParameter("ngaynhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Update_Sach", masachParameter, tensachParameter, maxbParameter, malvParameter, sotrangParameter, soluonghientaiParameter, soluongbandauParameter, ngaynhapParameter);
        }
    
        public virtual int Proc_Update_Sach_Tacgia(Nullable<int> masach, Nullable<int> matg)
        {
            var masachParameter = masach.HasValue ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(int));
    
            var matgParameter = matg.HasValue ?
                new ObjectParameter("matg", matg) :
                new ObjectParameter("matg", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Update_Sach_Tacgia", masachParameter, matgParameter);
        }
    
        public virtual int Proc_Update_TacGia(Nullable<int> matacgia, string tentacgia, string gioitinh, string diachi)
        {
            var matacgiaParameter = matacgia.HasValue ?
                new ObjectParameter("matacgia", matacgia) :
                new ObjectParameter("matacgia", typeof(int));
    
            var tentacgiaParameter = tentacgia != null ?
                new ObjectParameter("tentacgia", tentacgia) :
                new ObjectParameter("tentacgia", typeof(string));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Update_TacGia", matacgiaParameter, tentacgiaParameter, gioitinhParameter, diachiParameter);
        }
    
        public virtual int Proc_Update_XuPhat(Nullable<int> maphat, string loaiphat, Nullable<long> giatien)
        {
            var maphatParameter = maphat.HasValue ?
                new ObjectParameter("maphat", maphat) :
                new ObjectParameter("maphat", typeof(int));
    
            var loaiphatParameter = loaiphat != null ?
                new ObjectParameter("loaiphat", loaiphat) :
                new ObjectParameter("loaiphat", typeof(string));
    
            var giatienParameter = giatien.HasValue ?
                new ObjectParameter("giatien", giatien) :
                new ObjectParameter("giatien", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Update_XuPhat", maphatParameter, loaiphatParameter, giatienParameter);
        }
    
        public virtual ObjectResult<select_admin_Result> select_admin(Nullable<int> id, string username)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_admin_Result>("select_admin", idParameter, usernameParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
