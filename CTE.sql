WITH Hires
 AS ( 
	 SELECT YEAR(HireDate) AS HireYear, BusinessEntityID
	 FROM HumanResources.Employee
	  ),
HireByYear
AS (
	SELECT HireYear,COUNT(*) AS HireCount
	FROM Hires
	GROUP BY HireYear 
	)
select H1.HireYear,
		H1.HireCount as CurrentYearHireCount,
		H2.HireCount as PriorYearHireCount
from HireByYear H1
left outer join HireByYear H2
on H1.HireYear=H2.HireYear+1

with product
as(
	select year(SellStartDate) as ProductSaleStartyear,ProductID
	from Production.Product
	)
select ProductSaleStartyear,count(*)as ProductCount
from product
group by ProductSaleStartyear


WITH SalesMonth
 AS (
   SELECT MONTH(OrderDate) AS OrderMonth,
		  TotalDue 
   FROM Sales.SalesOrderHeader 
 WHERE YEAR(OrderDate) = 2006 
	) 
 
SELECT OrderMonth,
     SUM(TotalDue) AS MonthlySales
FROM SalesMonth 
GROUP BY OrderMonth
ORDER BY 1 
 