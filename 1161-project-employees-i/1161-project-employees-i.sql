select a.project_id,CAST(AVG(b.experience_years * 1.0) AS DECIMAL(5,2)) AS average_years  from 
Project a left join Employee b on a.employee_id=b.employee_id
group by a.project_id
