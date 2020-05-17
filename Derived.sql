select *
from(
	select Year(HireDate) as HireYear,Year(BirthDate) as BirthYear
	from HumanResources.Employee
	)as HD
where HireYear>2006 and BirthYear<1986 

select OrderYear,sum(TotalDue) as Sales
from(
	select*, Year(OrderDate)as OrderYear
	from Sales.SalesOrderHeader  
	)as SO
where OrderYear between '2005' and '2006'
group by OrderYear