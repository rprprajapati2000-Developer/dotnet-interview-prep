SELECT 
    e.EmployeeName,
    m.EmployeeName AS ManagerName
FROM Employee e
JOIN Employee m
ON e.ManagerId = m.EmployeeId;
