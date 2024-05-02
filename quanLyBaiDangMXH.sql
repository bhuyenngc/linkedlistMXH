create database quanLyBaiDangMXH
use quanLyBaiDangMXH

CREATE TABLE baiDang (
    PostID NVARCHAR(20) PRIMARY KEY ,
    noiDungBaiDang NVARCHAR(MAX),
    tacGia NVARCHAR(100),
    ngayDang NVARCHAR(100),
);
ALTER TABLE baiDang ADD N'Hình ảnh' Image