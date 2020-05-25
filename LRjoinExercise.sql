select SP.BusinessEntityID,SP.SalesYTD,ST.Name as[Territoy Name]
from Sales.SalesPerson SP
Left join Sales.SalesTerritory ST
on ST.TerritoryID=SP.TerritoryID

select SP.BusinessEntityID,SP.SalesYTD,ST.Name as[Territoy Name],
		P.FirstName,P.LastName
from Sales.SalesPerson SP
Left  join Sales.SalesTerritory ST
on ST.TerritoryID=SP.TerritoryID
Left  join Person.Person P
on P.BusinessEntityID=SP.BusinessEntityID
where ST.Name in ('northeast','central')

select P.Name as [Product Name],P.ListPrice,
		PS.Name as[ProductSubcategor Name],
		PC.Name as [ProductCategory Name]
from Production.Product P
Left join Production.ProductSubcategory PS
on PS.ProductSubcategoryID=P.ProductSubcategoryID
Left Join Production.ProductCategory PC
on PC.ProductCategoryID =PS.ProductCategoryID
order by PC.Name desc ,PS.Name asc




