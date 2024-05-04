/*
1. Write a query to report orders which were delayed shipped.
*/

SELECT * 
FROM Orders
WHERE ShippedDate > RequiredDate;

/*
2. Our employees belong to how many countries. List the names.
*/

SELECT COUNT(DISTINCT Country) AS TOTALCOUNTRIES
FROM Employees;

SELECT DISTINCT Country
FROM Employees;


/*
3. Is there any employee who is not accountable? 
*/

SELECT * 
FROM Employees
WHERE ReportsTo is NULL;
/*
4. List the names of products which have been discontinued.
*/

SELECT ProductName
FROM Products
WHERE Discontinued=0;

/*
5. List the IDs the orders on which discount was not provided.
*/

SELECT DISTINCT OrderID
FROM [Order Details]
WHERE Discount=0;

/*
Enlist the names of customers who have not specified their region.
*/

SELECT ContactName
From Customers
Where Region IS null;


/*
7.Enlist the names of customers along with contact number who either belongs to UK or USA.
*/

SELECT ContactName,Phone
FROM Customers
WHERE Country = 'UK' OR Country = 'USA';

/*
8. Report the names of companies who have provided their web page.
*/
SELECT CompanyName
FROM Suppliers
WHERE Suppliers.HomePage is not null;

/*
9. In which countries, products were sold in year 1997.
*/

SELECT DISTINCT ShipCountry
FROM Orders
WHERE year(ShippedDate) LIKE '1997';

/*
List the ids of customers whose orders were never shipped.
*/

SELECT CustomerID 
FROM Orders
WHERE ShippedDate is null;

/*
11. Write a query to report suppliers with their id, company name and city. 
*/
SELECT SupplierID,CompanyName,City
FROM Suppliers;


/*
12. Our employees belong to how many countries. List them who are used to live in London. 
*/
SELECT COUNT(DISTINCT Country) AS TotalCountries
FROM Employees;

SELECT *
FROM Employees
WHERE City ='london';

/*
13. List the names of products which have not been discontinued. 
*/
SELECT ProductName 
FROM Products
WHERE Discontinued=1;
/*
14. List the IDs the orders on which discount was 0.1 or less. 
 */
 SELECT OrderID
 From [Order Details]
 WHERE Discount <=0.1;

/*
 15. Enlist the IDS, names of employees and their contact number with extensions who have not specified their 
region.
*/

SELECT EmployeeID AS ID, CONCAT(FirstName,LastName) AS Name  , HomePhone AS ContactNumber
FROM Employees
WHERE region is null;