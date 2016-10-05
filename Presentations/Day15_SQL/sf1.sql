--scalare functions
create function fn_ADD(@a int,@b int)
returns int
as
begin
declare @c int
set @c=@a+@b
return @c
end
select dbo.fn_Add(3,4)
select dbo.fn_Add(5,6)
select dbo.fn_Add(4,5)