use master
drop database PhoneBook

create database PhoneBook;
go;
use PhoneBook;
go;
create Table People
(
Id int primary key identity(1,1) not null,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
Mail nvarchar(100) not null,
Phone nvarchar(30) not null,
);

insert into People VALUES('Jhon','Doe','jhon.doe@code.edu.az','+9945077788899');