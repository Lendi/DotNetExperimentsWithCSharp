declare @desig varchar(20)
declare update_cursor cursor dynamic
for select Desig from Employee 
open update_cursor 
fetch next from update_cursor into @desig
while(@@fetch_status=0)
begin
print @desig
if(@desig='Programmer')
update employee set sal=sal+sal*30/100 where desig=@desig
if(@desig='TeamLeader')
update employee set sal=sal+sal*20/100 where desig=@desig
if(@desig='ProjectManager')
update employee set sal=sal+sal*10/100 where desig=@desig
fetch next from update_cursor into @desig
end
close update_cursor
deallocate update_cursor

select * from Employee