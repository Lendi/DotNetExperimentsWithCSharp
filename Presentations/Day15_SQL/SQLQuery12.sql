create view vw_emp
as
select * from employee
select * from vw_emp
insert into vw_emp values(101,'abc','TeamLeader',12000,getdate(),'IT',null)
select * from employee
update vw_emp set sal=23000 where eid=110
delete from vw_emp where eid=110
sp_helptext vw_emp
sp_helptext Empdept
sp_depends vw_emp
sp_depends EMpdept