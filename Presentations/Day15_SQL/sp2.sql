create procedure div(@a int,@b int)
as
begin
declare @c int
set @c=@a/@b
if(@@ERROR<>0)
print 'b value should not be zero'
else
return @c
end

declare @res int
exec @res=div 2,0
print @res