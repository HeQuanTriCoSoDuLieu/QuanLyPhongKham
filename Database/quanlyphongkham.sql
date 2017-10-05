USE [quanlyphongkhamV1.0]
GO

CREATE PROCEDURE USP_LOGIN	
@username CHAR(50),
@password CHAR(50)
AS
BEGIN
	SELECT COUNT(*) FROM dbo.TAIKHOAN WHERE TENDANGNHAP = @username AND MATKHAU = @password
END

GO

EXEC dbo.USP_LOGIN  @username = 'admin',  @password = '1' 
GO


UPDATE dbo.TAIKHOAN SET TENHIENTHI= N'Đặng Huỳnh Đạt Ý 1' WHERE MATK = '1'
GO


SELECT * FROM dbo.TAIKHOAN
GO
