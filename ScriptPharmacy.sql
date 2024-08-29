create database Pharmacy
use pharmacy
create table Users(
Id int identity (1,1) primary key,
UserRole varchar(50) not null,
Name varchar(100) not null,
DateBirth datetime not null,
Mobile varchar(50) not null,
Email varchar(100) not null,
UserName varchar(100) not null unique,
Pass varchar(100) not null
)
delete from Users where UserName='Jorone'
insert into Users values('Pharmacist','John' ,'02/02/2001','0623897654','John@gmail;com','Jorone','0123')
insert into Users values('Administrator','Alex' ,'02/02/2001','0623897654','Alex@gmail;com','Alex','0123')

create table Medicines(
Id int identity(1,1) primary key,
Code varchar(100) not null,
Name varchar(100) not null,
Number varchar(100) not null,
Manufacturing Datetime not null,
Expired datetime not null,
Quantity int Not null,
PriceUnit float not null)

select * from Users

--UserRole,Name,DateBirth,Mobile,UserName,Pass