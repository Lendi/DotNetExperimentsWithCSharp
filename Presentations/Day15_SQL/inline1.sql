--Get All Employees by Deptid
--inline function
create function fn_GetEmployeesByDeptId(@did char(5))
returns table
as
return select * from Employee where did=@did
--call
select * from fn_GetEmployeesByDeptId('IT')
select ename,sal from fn_GetEmployeesByDeptId('BFS')
select * from dbo.fn_GetEmployeesByDeptId('CF')