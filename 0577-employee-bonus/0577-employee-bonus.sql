select a.name ,b.bonus from Employee a left join 
Bonus b on a.empId=b.empid
where b.bonus<1000 or b.bonus IS NULL