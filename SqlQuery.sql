SELECT Products.Name as ProductName, Categories.Name as CategoryName
FROM Products
LEFT JOIN Categories
ON Products.CategoryId=Categories.Id