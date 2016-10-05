select * from vw_emp

sp_helptext vw_emp
alter view vw_emp
with schemabinding
as
select eid,ename from dbo.employee

create unique clustered index id_cluster on vw_emp(eid)
select * from vw_emp
insert into vw_emp values(102,'xyz')