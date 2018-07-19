--SELECT * FROM dbo.Cars

INSERT INTO Cars(
id,Brand,Model,Body,EngieValue,[New Or Old],[Fuel Type])
Values(2,'Mersedes', 'Brabus','Sedan', 3.59,'New','Octan')


UPDATE dbo.Cars
SET Brand = 'Mersedes', Model= 'Brabus', EngieValue = 3.59, [Fuel Type]='Octan'
WHERE id = 2

DELETE dbo.Cars