select request_at AS Day , ROUND(CONVERT(DECIMAL(7,5), sum( IIF([status] != 'completed'  , 1,0)))/
 Count(*), 2) as 'Cancellation Rate' from Trips T
 where 
   not exists (select  *
    from  Users U 
	where 
    U.users_id= T.driver_id and
    U.banned  ='yes' )
and
 not exists (select  *
    from  Users as U
	where 
   U.users_id= T.client_id and
    U.banned  ='yes' )
 
and
request_at >= '2013-10-01' And request_at <='2013-10-03'
 
   
group by request_at
 