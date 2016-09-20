create table Product (
Pid int not null, 
Pname varchar(30) not null
)

alter table Product add constraint pk_id primary key(Pid)
alter table Product add constraint uk_name unique(Pname)
