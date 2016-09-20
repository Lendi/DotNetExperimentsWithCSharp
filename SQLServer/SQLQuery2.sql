create table Dept(
Did char(3) primary key, 
Dname varchar(30) unique not null
)

create table Employee(
Eid char(5) primary key,
Ename varchar(30), 
Did char(3) foreign key references Dept(Did),
Salary money check (Salary > 0)
)

alter table Dept alter column Did char(5)
alter table Course alter column Cname varchar(50)



use CSCDB
create table Student(
Sid char(5), 
Sname varchar(30), 
dob date,
age int,
)

create table Course(
Cid char(5),
Cname varchar(30),
)

create table Enroll(
Eid char(10)
)


alter table Student add Sid char not null


