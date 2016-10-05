begin tran
select * from emp2
delete from emp2 where eid=110
go
rollback tran
go