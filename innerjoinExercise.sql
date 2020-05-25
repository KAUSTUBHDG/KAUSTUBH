select P.FirstName,P.LastName,PP.PasswordHash
from Person.Person P
Inner join Person.[Password] PP
on PP.BusinessEntityID=P.BusinessEntityID

select E.BusinessEntityID,E.NationalIDNumber,E.JobTitle,EH.DepartmentID,EH.StartDate,EH.EndDate
from HumanResources.Employee E
inner join HumanResources.EmployeeDepartmentHistory EH
on E.BusinessEntityID=EH.BusinessEntityID

select P.FirstName,P.LastName,PP.PasswordHash,PE.EmailAddress
from Person.Person P
Inner join Person.[Password] PP
on PP.BusinessEntityID=P.BusinessEntityID
inner join Person.EmailAddress PE
on PE.BusinessEntityID=P.BusinessEntityID

