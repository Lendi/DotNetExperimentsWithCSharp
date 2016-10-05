--display experience of the employees
create function fn_GetExp(@hiredate datetime)
returns int
as
begin
declare @exp int
set @exp=datediff(yy,@hiredate,getdate())
return @exp
end
select Ename,dbo.fn_GetExp(hiredate) as 'Experience' from employee