create function fn_CountEmpByDeptId(@did char(5))
returns int
as
begin
declare @count int
select @count=count(*) from Employee where did=@did
return @count
end
select dbo.fn_CountEmpByDeptId('IT') as 'no of Employees'
select distinct(did),dbo.fn_CountEmpByDeptId(did) as 'no of Employees' 
from Employee
where did is not null order by did desc