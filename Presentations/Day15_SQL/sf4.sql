--Get DeptName of EMployee
alter function fn_GetDeptNameByEmpId(@Eid int)
returns varchar(30)
as
begin
declare @dname varchar(30)
select @dname=dname from dept where did=
(select did from employee where eid=@eid)
return @dname
end
select dbo.fn_GetDeptNameByEmpId(100)
select Eid,Ename,dbo.fn_GetDeptNameByEmpId(Eid) as 'DeptName' from Employee