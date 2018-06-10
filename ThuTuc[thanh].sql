use QuanLyNhanSu

GO
---- Thanh----Luong
create PROC SP_ThemLuong (@BacLuong VARCHAR(10), @LuongCoBan INT , @HeSoLuong INT , @HeSoPhuCap INT )
AS
BEGIN
	INSERT dbo.Luong( BacLuong ,LuongCoBan ,HeSoLuong ,HeSoPhuCap)
	VALUES  (@BacLuong, @LuongCoBan, @HeSoLuong, @HeSoPhuCap)
END 

GO
create PROC SP_SuaLuong (@BacLuong VARCHAR(10), @LuongCoBan INT , @HeSoLuong INT , @HeSoPhuCap INT )
AS
BEGIN
	UPDATE dbo.Luong SET LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong, HeSoPhuCap = @HeSoPhuCap
	WHERE BacLuong = @BacLuong
END

GO
create PROC SP_XoaLuong(@BacLuong VARCHAR(10))
AS
BEGIN
	DELETE dbo.Luong WHERE BacLuong = @BacLuong
END 

GO
create PROC SP_Luong_SelectAll 
AS
BEGIN
		SELECT * FROM dbo.Luong
END

GO
create PROC SP_Luong_SelectByID (@BacLuong VARCHAR(10) )
AS
BEGIN
		SELECT * FROM dbo.Luong WHERE BacLuong = @BacLuong
END
go


---------Trinh do hoc van

GO

CREATE PROC SP_TDHV_SelectAll
AS
BEGIN
SELECT * FROM dbo.TrinhDoHocVan
END
GO
CREATE PROC SP_TDHV_SelectByID (@MaTDHV INT )
AS
BEGIN
		SELECT * FROM dbo.TrinhDoHocVan WHERE MaTDHV = @MaTDHV
END
GO

CREATE PROC SP_Them_TDHV (@MaTDHV VARCHAR(10),@TenTDHV NVARCHAR(50),@ChuyenNganh NVARCHAR(50))
AS
BEGIN
	INSERT dbo.TrinhDoHocVan
	VALUES  ( @MaTDHV, @TenTDHV,@ChuyenNganh)
END

GO
CREATE PROC SP_Sua_TDHV (@MaTDHV VARCHAR(10),@TenTDHV NVARCHAR(50),@ChuyenNganh NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.TrinhDoHocVan
	SET TenTrinhDo =@TenTDHV,ChuyenNganh=@ChuyenNganh
	WHERE MaTDHV=@MaTDHV
END

GO 
CREATE PROC SP_Xoa_TDHV (@MaTDHV varchar(10))
AS
BEGIN
		DELETE dbo.TrinhDoHocVan WHERE MaTDHV = @MaTDHV
END

GO