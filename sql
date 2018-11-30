/////////////////
//单表每类取头3条
select * from(
select * ,row_number() over(partition by prodcategoryid order by id desc)
as rowindex from products)a
where rowindex<=2

select * from products a where
(select count(*) from products b where b.prodcategoryid=a.prodcategoryid and b.id<a.id) <4

/////////////////
//关联表每类取头3条
select * from 
(select * ,row_number() 
over(partition by prodcategoryid order by id desc) as rowindex 
from products 
where prodcategoryid in (select prodcategoryid from UFolwProdCategorys where userBaseId=2)) a
where rowindex<=2

select * from products a where
(select count(*) from products b where b.prodcategoryid=a.prodcategoryid and b.id<a.id) <4 
and prodcategoryid in (select prodcategoryid from UFolwProdCategorys where userBaseId=2)
