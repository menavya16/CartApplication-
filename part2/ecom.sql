CREATE TABLE [ProductDetails]
(
	[ProductID] INT NOT NULL IDENTITY PRIMARY KEY,
	ProductName varchar(50),
	Price int,
	ProductImage varchar(50)
)

insert into ProductDetails values( 'Acer Aspire',500, 'images/AcerAspire.png');
insert into ProductDetails values('Dell Inspiron',500, 'images/DellInspiron.png');
insert into ProductDetails values('HP Pavilion',500, 'images/HPPavilion.png');
insert into ProductDetails values('Lenovo Yoga',500, 'images/lenovoYoga.png');

