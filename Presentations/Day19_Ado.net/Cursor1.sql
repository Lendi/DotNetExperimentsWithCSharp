declare @pname varchar(20)
declare @price int
declare c cursor
for select pname,price from product
open c
fetch next from c into @pname,@price
while(@@fetch_status=0)
begin
print @pname+convert(char(10),@price)
fetch next from c into @pname,@price
end
close c
deallocate c