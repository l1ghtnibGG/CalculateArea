# Разработал  C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам

## Task№1 
### https://github.com/l1ghtnibGG/CalculateArea

## Task№2 
### https://github.com/l1ghtnibGG/CalculateArea/blob/master/Task2-SQL.txt

### Code from Task№2

``create table Products
(
    Id int identity not null primary key,
    Name varchar(255)
);

create table Categories
(
    Id int identity not null primary key,
    Name varchar(255)
);

create table ProductsCategories
(
    ProductId  int,
    CategoryId int,

    constraint PK_ProductsInCategories primary key (ProductId, CategoryId),
    constraint FK_ProductId foreign key (ProductId) references Products (Id),
    constraint FK_CategoryId foreign key (CategoryId) references Categories (Id)
);

insert into Products 
values ('Banana'), ('Apple'), ('Grapes'), ('Pear'), ('Kiwi');

insert into Categories
values ('Fruits'), ('Berries');

insert into ProductsCategories
values (1, 1), (2, 1), (3, 1), (3, 2), (4, 1), (5, 1), (5, 2);

select p.Name, c.Name
from Products p
	left join ProductsCategories pc 
		on p.Id = pc.ProductId
	left join Categories c 
		on c.Id = pc.CategoryId;``