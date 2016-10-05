--Finding Age
create function fn_GetAge(@dob datetime)
returns int
as
begin
declare @year int
set @year=datediff(yy,@dob,getdate())
return @year
end
--calling function
select dbo.fn_GetAge('12.2.1989') as 'Age'
select dbo.fn_GetAge('10.2.1947') as 'Age'