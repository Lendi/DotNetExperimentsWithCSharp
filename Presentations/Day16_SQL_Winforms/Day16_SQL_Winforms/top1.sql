--using top with select
select top 3 * from employee
select top 2 ename,sal from employee
select * from employee where sal>30000
select top 2 * from employee where sal>30000
select top 20 percent * from employee

--using top with update
select * from employee where sal<40000
update top(2) employee set sal=sal+sal*10/100 from employee where sal<40000
select * from employee where sal<40000

--using top with delete
select * from employee where sal>40000
delete top(1) employee where sal>40000
select * from employee where sal>40000

--using top with order by
select * from emp2 order by sal
select top 2 * from emp2 order by sal