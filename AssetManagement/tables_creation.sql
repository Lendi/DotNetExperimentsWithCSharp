create database AssetManagement

use AssetManagement

create table users(
emp_id int not null primary key,
short_id varchar(25) not null unique,
fname varchar(25) not null,
lname varchar(25) not null,
email_id varchar(25) not null,
user_password varchar(25)not null,
manager_id int not null,
designation varchar(25),
mobile int not null,
date_of_join datetime,
active varchar(1)
)


create table RequestInfo(
request_id int not null primary key,
emp_id int foreign key references users(emp_id),
short_id varchar(25) not null unique,
asset_name varchar(25),
manager_id int not null,
request_status int,
request_date datetime, 
manager_approved_date datetime, 
remarks varchar(100)
)

create table AssetInfo(
asset_id int not null primary key,
assetname varchar(25) not null,
emp_id int,
request_id int,
issueddate datetime, 
)

create table TransferHistory(
transfer_id int, 
from_emp_id int,
manager_id int,
asset_id int,
assetname varchar(25),
to_emp_id int,
transferdate timestamp,
transferstatus int,
remarks varchar(100)
)



