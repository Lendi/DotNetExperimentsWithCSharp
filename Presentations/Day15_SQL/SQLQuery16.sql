alter view vw_emp_it
with schemabinding
as
select eid,ename from dbo.emp2 where did='BFS'
select * from vw_emp_it
update emp2 set did='IT' where did='BFS'