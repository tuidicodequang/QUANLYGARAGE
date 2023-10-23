create database QuanLyOTo
Go
use QuanLyOTo
GO
create table SanPham(
	MaSP VARCHAR(50) PRIMARY KEY,
    TenSP VARCHAR(50),
    Hang VARCHAR(50),
    Mau VARCHAR(50),
	Gia BIGINT

)

INSERT INTO SanPham (MaSP, TenSP, Hang, Mau,Gia)
VALUES 
('001', 'Lamborghini Aventador', 'Lamborghini', 'Red',7300000000),
('002', 'Lamborghini Aventador', 'Lamborghini', 'Blue',7300000000),
('003', 'Lamborghini Aventador', 'Lamborghini', 'Orange',7300000000),
('004', 'Xe A', 'Loại A', 'Red',0),
('005', 'Xe A', 'Loại A', 'Red',0),
('006', 'Xe A', 'Loại A', 'Red',0),
('007', 'Xe A', 'Loại A', 'Red',0),
('008', 'Xe A', 'Loại A', 'Red',0),
('009', 'Xe A', 'Loại A', 'Red',0),
('010', 'Xe A', 'Loại A', 'Red',0),
('011', 'Xe A', 'Loại A', 'Red',0),
('012', 'Xe A', 'Loại A', 'Red',0)


create table KhachHang(
	Username varchar(50) ,
	MaKH varchar(50) ,
	HoTen nvarchar(50),
	GioiTinh nvarchar(50),
	NgaySinh date,
	MatKhau nvarchar(50),
	primary key(Username,MaKH)
)
INSERT INTO KhachHang (Username,MaKH, HoTen, GioiTinh, NgaySinh, MatKhau)
VALUES 
('johndoe','001', N'John Doe', N'Nam', '1990-01-01', 'password123'),
('janedoe','002', N'Jane Doe', N'Nữ', '1992-03-15', 'secret456'),
('smith','003', N'Smith', N'Nam', '1985-07-20', 'abc123'),
('doejohn','004', N'Doe John', N'Nam', '1995-09-10', 'qwerty'),
('maryjane','005', N'Mary Jane', N'Nữ', '1998-02-28', 'welcome1'),
('alex','006', N'Alex', N'Nam', '1993-12-05', 'pass123'),
('sarah', '007',N'Sarah', N'Nữ', '1991-06-18', 'password789'),
('mike','008', N'Mike', N'Nam', '1987-11-25', '123456'),
('emily','009', N'Emily', N'Nữ', '1994-04-12', 'letmein'),
('david','010', N'David', N'Nam', '1996-08-08', 'hello123'),
('Hung Anh','011', N'Phan Hùng Anh', N'Nam', '2004-04-07', '123'),
('Tien Anh','012', N'Trần Phan Tiến Anh', N'Nam', '2004-01-01', '456')

Create table NhanVien(
	Username varchar(50) ,
	MaNV varchar(50),
	HoTen nvarchar(50),
	GioiTinh nvarchar(50),
	NgaySinh date,
	MatKhau nvarchar(50),
	DiaChi nvarchar(50),
	Sdt varchar(10),
	primary key(Username,MaNV)
)
GO
INSERT INTO NhanVien(Username,MaNV, HoTen, GioiTinh, NgaySinh,DiaChi ,Sdt ,MatKhau)
VALUES 
('Hung Anh','NV01', N'Phan Hùng Anh', N'Nam', '2004-04-07',N'Khanh Hoa','0123456789', '123'),
('Tien Anh', 'NV02',N'Trần Phan Tiến Anh', N'Nam', '2004-01-01',N'Ca Mau','0123456789', '456')
