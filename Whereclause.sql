Select FirstName,LastName
From Person.Person
Where FirstName='Mark'

Select top 100 *
From Production.Product
Where ListPrice <> 0.00

Select *
From HumanResources.vEmployee
Where LastName < 'd'

Select *
From Person.StateProvince
Where CountryRegionCode ='CA'

Select FirstName as [Customer First Name],LastName as [Custome Last Name]
From Sales.vIndividualCustomer
Where LastName='Smith'

select *
from Sales.vIndividualCustomer
where CountryRegionName='australia' or (PhoneNumberType='cell' and EmailPromotion=0)

select *
from HumanResources.vEmployeeDepartment
where Department='Executive' or Department='Tool design' or Department='Engineering'

select *
from HumanResources.vEmployeeDepartment
where Department in('executive','tool design','engineering')

select *
from HumanResources.vEmployeeDepartment
where StartDate > 'July 1 2000' and StartDate< 'June 30 2002'

select *
from HumanResources.vEmployeeDepartment
where StartDate between 'july 1 2000' and 'june 30 2002'

select *
from Sales.vIndividualCustomer
where LastName Like 'r%'

select *
from Sales.vIndividualCustomer
where LastName like '%r'

select *
from Sales.vIndividualCustomer
where LastName in ('Lopez','Martin', 'Wood') and FirstName Like '[c-l]%'

select *
from Sales.SalesOrderHeader
where SalesPersonID is not null

select SalesPersonID,TotalDue
from Sales.SalesOrderHeader
where SalesPersonID is not null and TotalDue>70000