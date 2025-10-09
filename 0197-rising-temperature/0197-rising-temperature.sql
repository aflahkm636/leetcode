/* Write your T-SQL query statement below */
select a.id from weather a inner join weather b on DATEADD(DAY, -1, a.recordDate) =b.recordDate where a.temperature> b.temperature;