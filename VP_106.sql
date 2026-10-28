CREATE DATABASE DuLieu;
GO
USE DuLieu
GO
CREATE TABLE SanPham(
	MaSanPham nvarchar(10) PRIMARY KEY,
	TenSanPham nText NOT NULL,
	GiaBan nvarchar(12) NOT NULL);
INSERT INTO SanPham VALUES
('SP01', N'Cơm', 20),
('SP02', N'Cơm gà', 25);
SELECT * FROM SanPham;