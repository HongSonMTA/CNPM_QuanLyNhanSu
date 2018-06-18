use QuanLyNhanSu
GO

--Minh--Phòng Ban

--Thêm Phòng Ban
create PROC Them_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	INSERT INTO dbo.PhongBan( MaPB, TenPB,MaTP, DiaChi, SDT )
	VALUES  (@MaPb,@TenPB,@MaTP,@DiaChi,@Sdt )
END

GO
--Sửa Phòng ban
create PROC Sua_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	UPDATE dbo.PhongBan
	SET TenPB = @TenPB,MaTP = @MaTP,DiaChi = @DiaChi,SDT=@Sdt
	WHERE MaPB = @MaPb
END

GO 
--xóa Phòng Ban
create PROC Xoa_PB (@Ma varchar(10))
AS
BEGIN
		DELETE dbo.PhongBan WHERE MaPB = @Ma
END

GO
--Hiển Thị dữ liệu
ALTER PROC PB_SelectAll 
AS
BEGIN
		SELECT * FROM dbo.PhongBan
END

GO
CREATE PROC PB_SellectNV @MaPB VARCHAR(10)
AS 
BEGIN
	SELECT nv.MaNV, nv.HoTen,nv.DanToc,nv.GioiTinh,nv.SDT,nv.QueQuan,nv.NgaySinh,nv.MaTDHV,nv.BacLuong
	FROM dbo.NhanVien nv
	WHERE nv.MaPB = @MaPB

END