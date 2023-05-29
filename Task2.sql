--Поскольку структура базы данных не была указана, то она будет иметь следующий вид: 
create table Product(
ID int not null identity,
ProdName varchar(100) not null unique,
primary key clustered (ID asc)
)

create table Category(
ID int not null identity,
CategoryName varchar(50) not null unique,
primary key clustered (ID asc)
)

create table Product_Category(
ID int not null identity,
ProductID int not null references Product(ID),
CategoryID int not null references Category(ID),
primary key clustered (ID asc)
)

--Запрос, возвращающий пары в виде «Имя продукта – Имя категории». Если категория не указана, то будет выведено только имя продукта
select Product.ProdName + COALESCE( ' - ' + Category.CategoryName, '')
from Product
	left join Product_Category on Product.ID = Product_Category.ProductID
	left join Category on Category.ID = Product_Category.CategoryID

--Если выводить нужно было сами столбцы:
select Product.ProdName, Category.CategoryName
from Product
	left join Product_Category on Product.ID = Product_Category.ProductID
	left join Category on Category.ID = Product_Category.CategoryID
