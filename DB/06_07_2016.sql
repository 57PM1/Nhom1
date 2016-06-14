--Trigger

Create Trigger Auto_Increase_SoLuong_Sach On tbl_chitietphieu
	After Delete
As
	Begin
		Update tbl_sach set soluonghientai = soluonghientai + 1 where tbl_sach.masach = (Select masach from deleted)
	End
Go


Alter table tbl_nhanvien
Add Constraint uc_TaiKhoan Unique(taikhoan)