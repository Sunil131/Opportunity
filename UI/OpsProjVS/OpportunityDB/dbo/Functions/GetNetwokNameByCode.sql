

Create Function GetNetwokNameByCode(@networkCode nvarchar(10))
returns nvarchar(50)
as
Begin
Declare @name nvarchar(50)
Select @name = name from Network where NetworkCode = @networkCode;
return @name;
End