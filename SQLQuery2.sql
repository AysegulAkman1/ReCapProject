﻿Create table Cars(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear nvarchar(50),
	DailyPrice int,
	Description string(200),
	FOREIGN KEY (BranchId) References Brands(Id),
	FOREIGN KEY (ColorId) References Colors(Id),
)

Create table Colors(
	Id int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(50),
)

Create table Brands(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(50),
)

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions) VALUES

    (1,1,'2018',180,'Honda/Civic - Beyaz - Otomatik Hybrid'),

    (2,3,'2015',170,'Mercedes - Kırmızı - Otomatik Dizel'),

    (3,2,'2017',300,'BMW - Siyah - Otomatik Hybrid'),

    (4,4,'2013',115,'Renault/Kangoo - Mavi - Manuel Benzin');



INSERT INTO Colors(ColorName) VALUES('Beyaz'),('Siyah'),('Kırmızı'),('Mavi');

INSERT INTO Brands(BrandName) VALUES ('Honda'),('Mercedes'),('BMW'),('Renault');

