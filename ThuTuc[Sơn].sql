use CNPM_QuanLyNhanSu
GO

-- Hiện ra danh sách Nhân Viên
GO
create PROC NV_SelectAll 
AS
BEGIN
	SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu 
	FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc
	WHERE  PhongBan.MaPB = NhanVien.MaPB   
	AND  Luong.BacLuong = NhanVien.BacLuong  
	AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV
	AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV
	AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc
 END

--
GO


-- Thêm Nhân Viên

GO
create PROC ThemNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @MaDanToc VARCHAR(10), @GioiTinh NVARCHAR(5), @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB NVARCHAR(50), @BacLuong VARCHAR(10))
AS
BEGIN
INSERT INTO dbo.NhanVien( MaNV , HoTen ,MaDanToc ,GioiTinh ,SDT ,QueQuan ,NgaySinh ,MaTDHV ,MaPB ,BacLuong)
VALUES  ( @MaNV,@HoTen,@MaDanToc,@GioiTinh,@SDT,@QueQuan,@NgaySinh,@MaTDHV,@MaPB,@BacLuong)
END


-- Sửa Nhân Viên
GO
create PROC SuaNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @MaDanToc NVARCHAR(50), @GioiTinh NVARCHAR(5), @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB VARCHAR(10), @BacLuong VARCHAR(10))
AS
BEGIN
UPDATE dbo.NhanVien
SET HoTen=@HoTen,MaDanToc=@MaDanToc,GioiTinh=@GioiTinh,SDT=@SDT,QueQuan=@QueQuan,NgaySinh=@NgaySinh,MaTDHV=@MaTDHV,MaPB=@MaPB,BacLuong=@BacLuong
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

create PROC Select_TGCT
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
create PROC Sua_TGCT (@manv VARCHAR(10),@macv VARCHAR(10),@ngaynhanchuc DATE)
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
GO
-------Dân Tộc ------------
CREATE PROC SelectAll_DT
AS
BEGIN
SELECT * FROM DanToc 
END

GO
CREATE PROC Them_DT (@MaDanToc VARCHAR(10),@TenDanToc NVARCHAR(50),@GhiChu NVARCHAR(MAX))
AS
BEGIN
	INSERT INTO DanToc(MaDanToc,TenDanToc,GhiChu)
	VALUES(@MaDanToc,@TenDanToc,@GhiChu)
END

GO
CREATE PROC Sua_DT (@MaDanToc VARCHAR(10),@TenDanToc NVARCHAR(50),@GhiChu NVARCHAR(MAX))
AS
BEGIN
	UPDATE DanToc
	SET TenDanToc = @TenDanToc ,GhiChu = @GhiChu
	WHERE MaDanToc = @MaDanToc
END
GO

CREATE PROC Xoa_DT (@MaDanToc VARCHAR(10))
AS
BEGIN
DELETE DanToc WHERE MaDanToc = @MaDanToc 
END