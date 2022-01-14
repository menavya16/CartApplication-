DROP PROCEDURE IF EXISTS spGetImageData;
GO

Create proc spGetImageData
as
Begin 
	Select Name, [Order], description from tblimages
End

