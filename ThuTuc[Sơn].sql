use CNPM_QuanLyNhanSu
GO

-- Hiện ra danh sách Nhân Viên
GO
ALTER PROC NV_SelectAll 
AS
BEGIN
	SELECT dbo.NhanVien.MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu 
	FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac
	WHERE  PhongBan.MaPB = NhanVien.MaPB   
	AND  Luong.BacLuong = NhanVien.BacLuong  
	AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV
	AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV
 END

--
GO


-- Thêm Nhân Viên

GO
create PROC ThemNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @DanToc NVARCHAR(50), @GioiTinh NVARCHAR(5), @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB NVARCHAR(50), @BacLuong VARCHAR(10))
AS
BEGIN
INSERT INTO dbo.NhanVien( MaNV , HoTen ,DanToc ,GioiTinh ,SDT ,QueQuan ,NgaySinh ,MaTDHV ,MaPB ,BacLuong)
VALUES  ( @MaNV,@HoTen,@DanToc,@GioiTinh,@SDT,@QueQuan,@NgaySinh,@MaTDHV,@MaPB,@BacLuong)
END


-- Sửa Nhân Viên
GO
create PROC SuaNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @DanToc NVARCHAR(50), @GioiTinh NVARCHAR(5), @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB VARCHAR(10), @BacLuong VARCHAR(10))
AS
BEGIN
UPDATE dbo.NhanVien
SET HoTen=@HoTen,DanToc=@DanToc,GioiTinh=@GioiTinh,SDT=@SDT,QueQuan=@QueQuan,NgaySinh=@NgaySinh,MaTDHV=@MaTDHV,MaPB=@MaPB,BacLuong=@BacLuong
WHERE MaNV=@MaNV
END

-- Xóa Nhân Viên
GO
create PROC XoaNV(@MaNV VARCHAR(10))
AS
BEGIN
DELETE dbo.NhanVien
WHERE MaNV=@MaNV
END


--Thủ tục thời gian công tác--
GO

ALTER PROC Select_TGCT
AS
BEGIN
SELECT ThoiGianCongTac.MaNV,HoTen,TenChucVu,NgayNhanChuc FROM dbo.ThoiGianCongTac,dbo.ChucVu,NhanVien
WHERE ThoiGianCongTac.MaNV = NhanVien.MaNV AND ThoiGianCongTac.MaCV = ChucVu.MaChucVu
END
-----------
GO
-------------
CREATE PROC Them_TGCT (@manv VARCHAR(10),@macv VARCHAR(10),@ngaynhanchuc DATE)
AS
BEGIN
	INSERT dbo.ThoiGianCongTac
	        ( MaNV, MaCV, NgayNhanChuc )
	VALUES  ( @manv,@macv,@ngaynhanchuc)
	
END
------------------
GO
ALTER PROC Sua_TGCT (@manv VARCHAR(10),@macv VARCHAR(10),@ngaynhanchuc DATE)
AS
BEGIN
	UPDATE dbo.ThoiGianCongTac
	SET NgayNhanChuc=@ngaynhanchuc
	WHERE MaNV=@manv AND  MaCV = @manv 
END
-----------------
GO 
CREATE PROC Xoa_TGCT (@MaNV varchar(10),@MaCV VARCHAR(10))
AS
BEGIN
		DELETE dbo.ThoiGianCongTac WHERE MaNV=@MaNV AND MaCV = @MaCV
END

GO

CREATE PROC SelectAll_NV
AS
BEGIN
SELECT * FROM dbo.NhanVien
END
GO
--Thủ tục chức vụ--

CREATE PROC SelectAll_CV
AS
BEGIN
SELECT * FROM dbo.ChucVu
END
GO

CREATE PROC Them_CV (@machucvu VARCHAR(10),@tenchucvu NVARCHAR(50))
AS
BEGIN
	INSERT dbo.ChucVu
	        ( MaChucVu, TenChucVu )
	VALUES  ( @machucvu,@tenchucvu)
	
END

GO
CREATE PROC Sua_CV (@machucvu VARCHAR(10),@tenchucvu NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.ChucVu
	SET TenChucVu=@tenchucvu
	WHERE MaChucVu=@machucvu
END

GO 
CREATE PROC XoaCV (@machucvu varchar(10))
AS
BEGIN
		DELETE dbo.ChucVu WHERE MaChucVu=@machucvu
END