/* Write your T-SQL query statement below */


select 
class from 
(
 select class,count(distinct student)as num from Courses 
 group by class 
) as trm_f
where num >= 5;
 
