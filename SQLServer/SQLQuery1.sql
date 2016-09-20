-- Create Database
use CSCDB
Create table student(
Sid int primary key,
Sname varchar(20) not null,
DOB date,
Age int check(Age > 0 and Age < 100)
)

create table Course(
Cid int, 
Cname varchar(30) not null unique,
primary key ([Cid]))

create table Enroll(
Eid int primary key, 
Sid int foreign key references Student(Sid),
Edate date default getdate() check(Edate < getdate())
)

