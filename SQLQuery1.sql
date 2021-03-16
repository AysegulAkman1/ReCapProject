CREATE TABLE Colors(
 Id int PRIMARY KEY IDENTITY(1,1),
 ColorName nvarchar(50),
)

Create table Brands(
  Id int PRIMARY KEY IDENTITY(1,1),
  BrandName nvarchar(50),
)

Create table Cars(
  Id int PRIMARY KEY IDENTITY(1,1),
  BrandId int,
  ColorId int,
  ModelYear string(25),
  DailyPrice int,
  Description nvarchar(200),
  FOREIGN KEY (ColorId) REFERENCES Colors(Id),
  FOREIGN KEY (BrandId) REFERENCES Brands(Id),

)

Insert INTO Cars(BrandId, ColorId, ModelYear, DailyPrice, Description) Values
  (1,1,'2018',452,'Mercedes - Siyah - Otomatik Dizel'),
  (2,3,'2020',563,'Audi6 - Beyaz - Otomatik Benzin'),
  (3,2,'1998',658,'BMW - Mavi - Manuel Benzin');


Insert INTO Brands(BrandName) Values 
   ('Siyah'),
   ('Beyaz'),
   ('Mavi');

Insert INTO Colors(ColorName) Values
   ('Mercedes'),
   ('Audi6'),
   ('BMW');