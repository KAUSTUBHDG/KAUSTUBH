select Left('this string is asic string',8)

select left('this is another string',6)

select CHARINDEX('e',Name) as NAME,Name
from Production.Product
	
select SUBSTRING(Name,3,4) AS substrin,Name
from Sales.SalesTerritory

select left(left('This is slightly longer string',8),4)

select left(FirstName,charindex('e',FirstName,0))as fname
from Person.Person
where left(FirstName,charindex('e',FirstName,0)) <> ' ' 

