select * into emp4 from employee
create view vw_emp7
with schemabinding

as
select eid,ename from dbo.emp4 where did='IT' 
with check option
select * from vw_emp6
update vw_emp6 set did='CF' where did='IT'

--drop view
drop view vw_emp5
select * from vw_emp7
sp_rename 'vw_emp5.ename','empname'
select * from vw_emp5
