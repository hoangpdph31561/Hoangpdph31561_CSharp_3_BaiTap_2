--TẠO CSDL QUẢN LÝ SÁCH
DROP DATABASE QUANLYSACH_XUONG_LV1
CREATE DATABASE QUANLYSACH_XUONG_LV1
USE QUANLYSACH_XUONG_LV1
--TẠO BẢNG NHÀ XUẤT BẢN
IF OBJECT_ID ('NhaXuatBan') is not null
DROP TABLE NhaXuatBan
GO
CREATE TABLE NhaXuatBan
(
idNhaXuatBan uniqueidentifier not null default NEWSEQUENTIALID(),
tenNhaXuatBan nvarchar(50) null,
constraint pk_NhaXuatBan primary key (idNhaXuatBan)
)
IF OBJECT_ID ('Sach') is not null
DROP TABLE Sach
GO
CREATE TABLE SACH
(
idSach varchar(10) not null,
tenSach nvarchar(50) null,
trangThai bit null,
idNhaXuatBan uniqueidentifier null,
CONSTRAINT pk_Sach primary key (idSach),
constraint fk_Sach_NhaXuatBan foreign key (idNhaXuatBan) references NhaXuatBan(idNhaXuatBan)
)
SELECT * FROM NhaXuatBan
INSERT INTO NhaXuatBan (tenNhaXuatBan) VALUES
(N'Kim Đồng'),
(N'Sự Thật'),
(N'Giáo Dục'),
(N'Đại học Quốc gia')