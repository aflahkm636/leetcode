select contest_id ,cast((count(user_id )*100.0 /(SELECT COUNT(*) FROM Users))as decimal(5,2)) as percentage 
from Register
group by contest_id
order by percentage desc,contest_id
