create procedure sp_Add_Product(
@pid int,@pname varchar(10),@price money,
@stock int)
as
begin
insert into Product values(@pid,@pname,@price,@stock)
end
exec sp_Add_Product 100,'Mouse',300,40
exec sp_Add_Product 101,'Keyboard',500,10
exec sp_Add_Product 102,'Joystick',1000,50
select * from product