



CREATE VIEW [dbo].[tbl_quahan_view]
AS
SELECT        dbo.tbl_docgia.madg, dbo.tbl_docgia.tendg, dbo.tbl_docgia.ngaysinh, dbo.tbl_docgia.gioitinh, dbo.tbl_docgia.lop, dbo.tbl_docgia.diachi, dbo.tbl_docgia.email, dbo.tbl_phieumuon_tra.ngaymuon, 
                         dbo.tbl_phieumuon_tra.ngaytra
FROM            dbo.tbl_docgia INNER JOIN
                         dbo.tbl_phieumuon_tra ON dbo.tbl_docgia.madg = dbo.tbl_phieumuon_tra.madg
WHERE        (dbo.tbl_phieumuon_tra.xacnhantra = 0 OR
                         dbo.tbl_phieumuon_tra.xacnhantra IS NULL) AND (dbo.tbl_phieumuon_tra.ngaytra < { fn NOW() })

GO

CREATE VIEW [dbo].[tbl_sachsaphet_view]
AS
SELECT        dbo.tbl_sach.masach, dbo.tbl_sach.tensach, dbo.tbl_linhvuc.tenlinhvuc, dbo.tbl_nxb.tennxb, dbo.tbl_sach.soluonghientai, dbo.tbl_sach.ngaynhap
FROM            dbo.tbl_linhvuc INNER JOIN
                         dbo.tbl_sach ON dbo.tbl_linhvuc.malinhvuc = dbo.tbl_sach.malv INNER JOIN
                         dbo.tbl_nxb ON dbo.tbl_sach.manxb = dbo.tbl_nxb.manxb
WHERE        (dbo.tbl_sach.soluonghientai <= 5)

GO