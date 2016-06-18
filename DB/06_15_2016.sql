
create proc [dbo].[Proc_Insert_Sach_Tacgia]
	@matg int
As
	Begin 
		Insert into tbl_sach_tacgia (masach, matg) values (IDENT_CURRENT('tbl_sach'), @matg)
	End

create Proc [dbo].[Proc_Update_Sach_Tacgia]
	@masach int,
	@matg int
As
	Begin
		insert into tbl_sach_tacgia (masach, matg) values (@masach, @matg);
	End


Create Proc [dbo].[Proc_Delete_Sach_Tacgia]
	@masach int
As
	Begin
		Delete from tbl_sach_tacgia where masach=@masach
	End