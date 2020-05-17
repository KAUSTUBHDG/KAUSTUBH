select count(*)
from Person.Person

select Count(MiddleName)
from Person.Person

select avg(StandardCost)
from Production.Product
where StandardCost>0.00

select avg(Freight)
from Sales.SalesOrderHeader
where TerritoryID=4

select max(ListPrice)
from Production.Product

select sum(P.ListPrice*PPI.Quantity)
from Production.Product P
inner join Production.ProductInventory PPI
on P.ProductID=PPI.ProductID
where P.ListPrice>0

