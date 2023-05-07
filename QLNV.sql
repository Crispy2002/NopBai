create database QLNV

use QLNV
go
create table QLNV
(
	MaNV int identity(1,1) primary key,
	HoTen nvarchar(30),
	DiaChi nvarchar(100),
	SDT int 
);
insert into QLNV values(N'trieu',N'dhfashdi',324)
select * from QLNV
drop table QLNV