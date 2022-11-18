use master
drop database testdb

create database testdb
use testdb

create table Products (
	id nvarchar(20),
	product_name nvarchar(50),
	PRIMARY KEY (id)
);

create table Category(
	id nvarchar(20),
	category_name nvarchar(50),
	PRIMARY KEY (id)
);

create table ProductCategory(
	product_id nvarchar(20),
	category_id nvarchar(20),
	PRIMARY KEY (product_id, category_id),
	FOREIGN KEY (product_id) REFERENCES Products (id),
	FOREIGN KEY (category_id) REFERENCES Category (id) 
);

INSERT INTO Products 
VALUES
	('pr1', 'Product 1'),
	('pr2', 'Product 2'),
	('pr3', 'Product 3'),
	('pr4', 'Product 4'),
	('pr5', 'Product 5'),
	('pr6', 'Product 6'),
	('pr7', 'Product 7'),
	('pr8', 'Product 8'),
	('pr9', 'Product 9'),
	('pr0', 'Product 0')

INSERT INTO Category
VALUES
	('cat1', 'Category 1'),
	('cat2', 'Category 2'),
	('cat3', 'Category 3')

INSERT ProductCategory
VALUES 
	('pr1', 'cat1'),
	('pr1', 'cat2'),
	('pr2', 'cat3'),
	('pr3', 'cat1'),
	('pr3', 'cat3'),
	('pr4', 'cat3'),
	('pr6', 'cat1'),
	('pr8', 'cat3'),
	('pr0', 'cat2'),
	('pr0', 'cat3'),
	('pr0', 'cat1')


SELECT Products.product_name, Category.category_name 
FROM Products
LEFT JOIN ProductCategory ON Products.id = ProductCategory.product_id
LEFT JOIN Category ON ProductCategory.category_id = Category.id
	
