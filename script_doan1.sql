create database HeThongGiatUi
use HeThongGiatUi

create table TAIKHOAN
(
	TENTK varchar(5) not null primary key,
	MK varchar(10) not null,
	VAITRO varchar(30),
	FOREIGN KEY(TENTK) REFERENCES dbo.NHANVIEN(MANV)
)

create table NHANVIEN
(
	MANV varchar(5) not null primary key,
	TENNV nvarchar(50),
	NGSINH date,
	DIACHI nvarchar(20),
	SDT char(10),
	LUONG numeric(18,0),
	MA_NQL varchar(5),
	PHAI bit,
	foreign key (MA_NQL) references dbo.NHANVIEN(MANV)
)

create table KHACHHANG
(
	MAKH varchar(4) not null primary key,
	MA_LOAIKH varchar(4),
	TENKH nvarchar(50),
	DIACHI nvarchar(20),
	SDT char(10),
	foreign key(MA_LOAIKH) references dbo.PHANLOAIKH(MA_LOAIKH)
)

create table PHANLOAIKH
(
	MA_LOAIKH varchar(4) not null primary key,
	LOAIKH nvarchar(10)
)

create table DONHANG
(
	MADH varchar(5) not null,
	MANV varchar(5) not null,
	NGAYBAN date,
	MAKH varchar(4),
	TONGTIEN numeric(18,0),
	primary key(MADH, MANV, MAKH),
	foreign key(MANV) references dbo.NHANVIEN(MANV),
	foreign key(MAKH) references dbo.KHACHHANG(MAKH)
)

insert into NHANVIEN values('NV001',N'Nguyễn Văn Tý', '1998/12/01', N'Cần Thơ', '0120120123', 25000, 'NV002', 1),
							('NV002', N'Trần Văn Sửu', '1997/01/05', N'Vĩnh Long', '0906040503', 30000, 'NV002', 1),
							('NV003',N'Đinh Thị Dần', '1999/04/24', N'TP. HCM', '0120000123', 25000, 'NV001', 0),
							('NV004', N'Hồ Minh Mẹo', '1997/01/27', N'Trà Vinh', '0906041111', 30000, 'NV001', 1)
							
insert into TAIKHOAN values('NV001', '001', 'Admin'),
							('NV002', '002', 'Admin'),
							('NV003', '003', 'Nhan vien'),
							('NV004', '004', 'Nhan vien')

insert into KHACHHANG values('K001', 'V01', N'Bùi Hải Hoàng Chuột', N'Cà Mau', '0102201133'),
							('K002', 'L01',N'Sửu Đầu Trâu', N'Hà Giang', '0909000999'),
							('K003', 'N01',N'Dậu Đầu Gà', N'Quảng Ninh', '0899000987')

insert into PHANLOAIKH values('V01', N'Cao cấp'),
							('L01', N'Thân thiết'),
							('N01', N'Mới')

insert into DONHANG values('DH001', 'NV003', '2021/10/22', 'K001', 10000),
							('DH002', 'NV003', '2021/10/22', 'K001', 20000),
							('DH003', 'NV004', '2021/10/21', 'K002', 15000)


