create procedure sp_GetAge(@dob datetime)
as
begin
declare @y int
set @y=datediff(yy,@dob,getdate())
return @y
end

declare @a int
exec @a=sp_GetAge '12.2.1967'
print @a