USE CNPM_QuanLyNhanSu
GO 

CREATE PROC DangNhap(@TaiKhoan NVARCHAR(50),@MatKhau NVARCHAR(50), @PhanQuyen NVARCHAR(50))
 AS
 BEGIN
 SELECT * FROM dbo.NguoiDung 
 WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau AND PhanQuyen=@PhanQuyen
 END
 GO


 CREATE PROC SP_ThemNguoiDung(@TaiKhoan NVARCHAR(50),@MatKhau NVARCHAR(50), @PhanQuyen NVARCHAR(50),@MaNV VARCHAR(10))
 AS
 BEGIN
 INSERT dbo.NguoiDung
 VALUES  (@TaiKhoan,@MatKhau,@PhanQuyen,@MaNV)
 END
 GO
  CREATE  PROC SP_SuaTK(@TaiKhoan NVARCHAR(50),@MatKhau NVARCHAR(50))
 AS
 BEGIN
	UPDATE dbo.NguoiDung
	SET MatKhau = @MatKhau
	WHERE TaiKhoan = @TaiKhoan
 END
 GO
 CREATE PROC Select_TK 
 AS
 BEGIN
	SELECT TaiKhoan,MatKhau,HoTen,PhanQuyen FROM  dbo.NguoiDung,dbo.NhanVien
	WHERE NguoiDung.MaNV = NhanVien.MaNV
 END
 GO 
  CREATE PROC Xoa_TK (@TaiKhoan VARCHAR(10))
 AS
 BEGIN
	DELETE dbo.NguoiDung WHERE TaiKhoan = @TaiKhoan
 END
 GO 

 ALTER PROC SeLect_TKNV
 AS
 BEGIN
	SELECT MaNV,HoTen FROM NhanVien
	WHERE MaNV IN (SELECT MaTP FROM PhongBan)
 END 



