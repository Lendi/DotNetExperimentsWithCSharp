--Get DeptName of EmpId
create procedure sp_GetDeptNameById(@Eid int ,@Dname varchar(40) output)
as
begin
if(exists(Select * from Employee where eid=@Eid))
select @Dname=Dname from Dept where did=(Select did from employee where
eid=@Eid)
else
print 'Invalid Id'
end

declare @Dname varchar(40)
exec sp_GetDeptNameById 100,@Dname output
print @Dname
