select count(*) as PersonCount,PersonType
from Person.Person
group by PersonType

select color,count(Color) as ProductColor
from Production.Product
where color in ('Red','black')
group by Color

select TerritoryID,count(*) as SalesCount
from Sales.SalesOrderHeader SOH
where OrderDate between 'July 1 2005' and 'December 30 2006'
group by TerritoryID

select ST.Name as TerritoryID,count(*) as SalesCount
from Sales.SalesOrderHeader SOH
left join Sales.SalesTerritory ST
on SOH.TerritoryID=ST.TerritoryID
WHERE OrderDate BETWEEN '7/1/2005' AND '12/31/2006'	GROUP BY ST.Name	  