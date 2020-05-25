select FirstName, CAST(FirstName as VARCHAR) AS name
from Person.Person

select 11/4,CAST(11 as float)/cast(4 as float),11.0/4.0

select FirstName, CAST(FirstName as VARCHAR(3)) AS name
from Person.Person


select size,CAST(size as int)
from Production.Product


select CAST(Size AS INT) 
FROM Production.Product 
WHERE ISNUMERIC(Size) = 1