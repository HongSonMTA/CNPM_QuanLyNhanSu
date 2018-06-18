create database CNPM_QuanLyNhanSu
go
use CNPM_QuanLyNhanSu

go
create table ChucVu(
MaChucVu VARCHAR(10) primary key,
TenChucVu nvarchar(50))
GO

create table Luong(
BacLuong VARCHAR(10) primary key,
LuongCoBan INT ,
HeSoLuong int,
HeSoPhuCap int)
GO
create table PhongBan(
MaPB VARCHAR(10) primary key,
TenPB nvarchar(50),
MaTP VARCHAR(10),
DiaChi nvarchar(50),
SDT char(15))

go
create table TrinhDoHocVan(
MaTDHV VARCHAR(10) primary key,
TenTrinhDo nvarchar(50),
ChuyenNganh nvarchar(50))

go
create table NhanVien(
MaNV varchar(10) primary key,
HoTen nvarchar(50),
DanToc nvarchar(50),
GioiTinh NVARCHAR(5) CHECK(GioiTinh IN (N'Nam',N'Nữ')),
SDT CHAR(15),
QueQuan nvarchar(50),
NgaySinh date,
MaTDHV VARCHAR(10) REFERENCES TrinhDoHocVan(MaTDHV),
MaPB VARCHAR(10) references PhongBan(MaPB),
BacLuong VARCHAR(10) references Luong(BacLuong)
)

GO
CREATE TABLE ThoiGianCongTac(
MaNV VARCHAR(10) REFERENCES NhanVien(MaNV),
MaCV VARCHAR(10) REFERENCES ChucVu(MaChucVu),
NgayNhanChuc DATE,
PRIMARY KEY (MaNV,MaCV))

GO
CREATE TABLE NguoiDung
(
	TaiKhoan NVARCHAR(30) PRIMARY KEY,
	MatKhau NVARCHAR(30),
	PhanQuyen NVARCHAR(50),
	MaNV VARCHAR(10) REFERENCES dbo.NhanVien (MaNV)
)

GO
CREATE TABLE ThanNhan(
MaTN VARCHAR(10)PRIMARY KEY,
TenTN NVARCHAR(50) ,
MaNV VARCHAR(10) REFERENCES dbo.NhanVien(MaNV),
GioiTinh NVARCHAR(5) CHECK(GioiTinh IN (N'Nam',N'Nữ')),
MoiQuanHe NVARCHAR(30),
Tuoi INT
)
