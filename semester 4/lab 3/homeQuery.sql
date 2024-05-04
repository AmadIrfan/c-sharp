
/*
*/
Select COUNT(Customers.Country)
from Customers;
/*
*/
SELECT Customers.Country
From Customers;
/*
*/
SELECT DISTINCT [Order Details].OrderID
FROM [Order Details]
WHERE [Order Details].Discount=0;
/*
*/
SELECT Customers.ContactName
From Customers
Where Customers.Region IS null;
