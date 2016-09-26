use CSCDB

create table Product_Details(
prodid int not null,
prodname varchar(25) not null,
supplierid int not null primary key,
)

create table supplier_info(
supplierid int not null foreign key references product_details(supplierid),
suppliername varchar(25) not null,
supplier_address varchar(50),
city varchar(25),
contact_no int,
email varchar(25)
)

select * from Product_Details

ALTER TABLE Product_Details
ADD UNIQUE (prodid)