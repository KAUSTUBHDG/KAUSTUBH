select FirstName,LastName,JobTitle
from HumanResources.vEmployeeDepartment
order by FirstName

select FirstName,LastName,JobTitle
from HumanResources.vEmployeeDepartment
order by FirstName,LastName desc

select FirstName,LastName,CountryRegionName
from Sales.vIndividualCustomer
order by 3

select FirstName,LastName,CountryRegionName
from Sales.vIndividualCustomer
where CountryRegionName in ('United States','France')
order by 3

select Name,AnnualSales,YearOpened,SquareFeet as [Store Size],NumberEmployees as [Total Employees]
from Sales.vStoreWithDemographics
where AnnualSales>1000000 and NumberEmployees>=45
order by [Store Size]  desc,

select Name,AnnualSales,YearOpened,SquareFeet as [Store Size],NumberEmployees as [Total Employees]
from Sales.vStoreWithDemographics
where AnnualSales>1000000 and NumberEmployees>=45
order by [Total Employees] desc