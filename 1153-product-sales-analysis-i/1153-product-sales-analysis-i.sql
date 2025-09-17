select A.product_name,b.year ,b.price from Sales b left join Product A on b.product_id=A.product_id;
