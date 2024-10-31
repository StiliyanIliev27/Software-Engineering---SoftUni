SELECT
	e.FirstName
    ,e.LastName
	,e.HireDate
	,d.[Name]
FROM Employees e
	JOIN Departments d ON d.DepartmentID = e.DepartmentID
WHERE e.HireDate > '01-01-1999' AND d.[Name] IN ('Sales', 'Finance')
ORDER BY e.HireDate