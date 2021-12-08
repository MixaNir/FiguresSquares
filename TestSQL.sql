SELECT product_name, c.category_name
FROM Products as p
FULL JOIN Products_Categories as pc
    ON pc.productID = p.ID
Full JOIN Categories as c
    ON pc.categoryID = c.ID;