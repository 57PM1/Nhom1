
-- Nha xuat ban
Create Proc Proc_Insert_NXB 
	@tennxb nvarchar(100),
	@diachi nvarchar(200) = '',
	@sdt varchar(12) = ''
As
	Begin
		Insert into tbl_nxb(tennxb, diachi, sdt) values(@tennxb, @diachi, @sdt);
	End
Go

Create Proc Proc_Update_NXB 
	@manxb int,
	@tennxb nvarchar(100),
	@diachi nvarchar(200) = '',
	@sdt varchar(12) = ''
As
	Begin
		Update tbl_nxb set tennxb = @tennxb, diachi = @diachi, sdt = @sdt where manxb = @manxb
	End
Go


Create Proc Proc_Delete_NXB 
	@manxb int
As
	Begin
		Delete from tbl_nxb where manxb = @manxb
	End
Go

--Exec Proc_Delete_NXB 10

-- Nhan vien

Create Proc Proc_Insert_NhanVien
	@tennv nvarchar(50),
	@diachi nvarchar(50) = '',
	@dienthoai varchar(12) = '',
	@email varchar(50) = '',
	@chucvu nvarchar(100) = '',
	@tuoi int = 0,
	@taikhoan varchar(50),
	@matkhau nvarchar(50)
As
	Begin
		Insert into tbl_nhanvien(tennv, diachi, dienthoai, email, chucvu, tuoi, taikhoan, matkhau) values(@tennv, @diachi, @dienthoai, @email, @chucvu, @tuoi, @taikhoan, @matkhau);
	End
Go

Create Proc Proc_Update_NhanVien 
	@manv int,
	@tennv nvarchar(50),
	@diachi nvarchar(50) = '',
	@dienthoai varchar(12) = '',
	@email varchar(50) = '',
	@chucvu nvarchar(100) = '',
	@tuoi int = 0,
	@taikhoan varchar(50),
	@matkhau nvarchar(50)
As
	Begin
		Update tbl_nhanvien set tennv = @tennv, diachi = @diachi, dienthoai = @dienthoai, email = @email, chucvu = @chucvu, tuoi = @tuoi, taikhoan = @taikhoan, matkhau = @matkhau where manv = @manv
	End
Go


Create Proc Proc_Delete_NhanVien
	@manv int
As
	Begin
		Delete from tbl_nhanvien where manv = @manv
	End
Go

-- Phieu muon tra


Create Proc Proc_Insert_PhieuMuonTra
	@madg int,
	@manv int,
	@ngaymuon varchar(50) = '',
	@ngaytra varchar(50) = '',
	@ghichu nvarchar(300) = ''
As
	Begin
		Insert into tbl_phieumuon_tra(madg, manv, ngaymuon, ngaytra, ghichu) values(@madg, @manv, @ngaymuon, @ngaytra, @ghichu)
	End
Go

Create Proc Proc_Update_PhieuMuonTra
	@sophieumuon int,
	@madg int,
	@manv int,
	@ngaymuon varchar(50) = '',
	@ngaytra varchar(50) = '',
	@ghichu nvarchar(300) = ''
As
	Begin
		Update tbl_phieumuon_tra set madg = @madg, manv = @manv, ngaymuon = @ngaymuon, ngaytra = @ngaytra, ghichu = @ghichu where sophieumuon = @sophieumuon
	End
Go


Create Proc Proc_Delete_PhieuMuonTra
	@sophieumuon int
As
	Begin
		Delete from tbl_phieumuon_tra where sophieumuon = @sophieumuon
	End
Go

-- Chi tiet phieu

Create Proc Proc_Insert_ChiTietPhieu
	@sophieumuon int, 
	@masach int,
	@trangthaisach nvarchar(50) = ''
As
	Begin
		Insert into tbl_chitietphieu(sophieumuon, masach, trangthaisach) values(@sophieumuon, @masach, @trangthaisach);
	End
Go


Create Proc Proc_Delete_ChiTietPhieu
	@sophieumuon int,
	@masach int
As
	Begin
		Delete from tbl_chitietphieu where sophieumuon = @sophieumuon and masach = @masach
	End
Go


--độc giả--
Create Proc Proc_Insert_DocGia
	@tendg nvarchar(50),
	@ngaysinh varchar(50)='',
	@gioitinh nvarchar(3)='',
	@lop varchar(10)='',
	@diachi nvarchar(100)='',
	@email varchar(50)=''

As
	Begin 
		Insert into tbl_docgia (tendg, ngaysinh, gioitinh, lop, diachi, email) values (@tendg, @ngaysinh, @gioitinh, @lop, @diachi, @email)
	End
Go


Create proc Proc_Delete_DocGia
	@madg int

As
	Begin
		Delete from tbl_docgia where madg=@madg
	End
Go

Create proc Proc_Edit_DocGia
	@tendg nvarchar(50),
	@ngaysinh varchar(50),
	@gioitinh nvarchar(3),
	@lop varchar(10),
	@diachi nvarchar(100),
	@email varchar(50),
	@madg int

As
	Begin
		Update tbl_docgia set tendg=@tendg, ngaysinh=@ngaysinh, gioitinh=@gioitinh, lop=@lop, diachi=@diachi, email=@email where madg=@madg
	End
Go


------------------------------------------------------------------------------------------
--Trigger

Create Trigger Auto_Subtract_SoLuong_Sach On tbl_chitietphieu
	After Insert
As
	Begin
		Update tbl_sach set soluonghientai = soluonghientai - 1 where tbl_sach.masach = (Select masach from inserted)
	End
Go

-----------------------------------------------------------------------------------------------
-- Index

CREATE INDEX Index_TenSach
ON tbl_sach (tensach)
