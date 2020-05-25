select TerritoryID,sum(TotalDue) as TotalSales
from Sales.SalesOrderHeader
group by TerritoryID 
having sum(TotalDue)>10000000

select ST.Name as TerritoryName, sum(TotalDue) as TotalSales
from Sales.SalesOrderHeader SOH
left outer join Sales.SalesTerritory ST
on SOH.TerritoryID=ST.TerritoryID
group by ST.Name
having SUM(TotalDue)>10000000	

select count(*) as ProductCount,Color
from Production.Product
where Color is not null
group by Color
having COUNT(*)>=20

select P.Name as ProductName,count(SOD.OrderQty) as OrderedProduct
from Sales.SalesOrderHeader SOH
inner join Sales.SalesOrderDetail SOD
on Soh.SalesOrderID=SOD.SalesOrderID
inner join Production.Product P
on P.ProductID=SOD.ProductID
where Soh.OrderDate between 'january 1 2006' and 'december 1 2006'
group by P.Name
having count(SOD.orderQty)>200


select P.FirstName,count(*) as OrderPlaced,P.LastName
from
Sales.SalesOrderHeader SOH
inner join Sales.Customer C
on C.CustomerID=SOH.CustomerID
inner join Person.Person P
on P.BusinessEntityID=C.PersonID
where SOH.OrderDate between 'july 1 2005' and 'december 31 2006'
group by P.FirstName,P.LastName
having Count(*)>6
order by OrderPlaced desc


