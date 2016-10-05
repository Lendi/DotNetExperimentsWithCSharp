create procedure sp_Add(@a int,@b int=5)
as
begin
declare @c int
set @c=@a+@b
print @c
end
exec sp_Add 5
exec sp_Add 5,6
exec sp_Add @b=12,@a=45