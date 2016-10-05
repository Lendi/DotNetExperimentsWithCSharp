--Get All Employees whos Names starts with given char
alter function fn_GetEmpByChar(@c char(1))
returns table
as
--return select * from employee where left(ename,1)=@c
return select * from employee where ename like @c+'%'
select * from fn_GetEmpByChar('s')
select * from fn_GetEmpByChar('d')