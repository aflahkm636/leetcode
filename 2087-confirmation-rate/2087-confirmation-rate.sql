SELECT 
  a.user_id,
  ROUND(
    COALESCE(
    CAST(SUM(CASE WHEN b.action = 'confirmed' THEN 1 ELSE 0 END) AS FLOAT)
    / NULLIF(COUNT(b.action), 0),0),
    2
  ) AS confirmation_rate
FROM Signups a
LEFT JOIN Confirmations b 
  ON a.user_id = b.user_id
GROUP BY a.user_id;
