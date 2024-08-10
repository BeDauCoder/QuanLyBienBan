create database qlbb
go

--drop database qlbb
--drop table taiKhoan
--drop table BienBan
create table TaiKhoan(idTaiKhoan int IDENTITY(1,1) primary key,tenTaiKhoan varchar(50),matKhau varchar(50))
go

create table BienBan(idBienBan int IDENTITY(1,1) primary key,tieuDe nvarchar(100),thoiGian DATE,noiDung ntext,khoa nvarchar(50),
thanhPhanThamGia nvarchar(4000),thongTinNguoiDu ntext,thuKi nvarchar(100),chuTri nvarchar(100),ketLuan ntext,yKien ntext,thoiGianBatDau DATETIME,diaDiem nvarchar(500),thoiGianKetThuc DATETIME)
go

SELECT * FROM BienBan