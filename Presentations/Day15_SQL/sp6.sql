alter procedure sp_Delete_Product(@pid int)
as
begin 
if(exists(select * from product where pid=@pid))
delete from product where pid=@pid
else
print 'invalid id'
end

alter procedure sp_Update_Product(
@pid int,@pname varchar(10),@price money,
@stock int)
as
begin
if((select count(*) from product where pid=@pid)<>0)
update product set price=@price,stock=@stock where pid=@pid
else
print 'invalid id'
end

exec sp_Delete_Product @pid=123
exec sp_Update_Product @price=300,@pid=101,@pname='keyboard',@stock=40
select * from product