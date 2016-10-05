create view vw_emp4
with schemabinding
as
select eid,ename,desig from dbo.emp3

drop table emp3
select * from emp3
alter table emp3 drop column desig