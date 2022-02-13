set serveroutput on
create or replace procedure vaccupdate(vid in int,  va1 in int , va2 in int , va3 in int, va4 in int, va5 in int, va6 in int, va7 in int) is 
	
begin
	if va1!=0then
		update user_table ut set ut.v1 = va1
	    where ut.chid = vid;
	end if;
		
	if va2!=0	then
		update user_table ut set ut.v2 = va2
	    where ut.chid = vid;
	end if;
	
	if va3!=0	then
		update user_table ut set ut.v3 = va3
	    where ut.chid = vid;
	end if;
		
	if va4!=0	then
		update user_table ut set ut.v4 = va4
	    where ut.chid = vid;
	end if;
		
	if va5!=0	then
		update user_table ut set ut.v5 = va5
	    where ut.chid = vid;
	end if;
		
	if va6!=0	then
		update user_table ut set ut.v6 = va6
	    where ut.chid = vid;
	end if;
		
	if va7!=0 then
		update user_table ut set ut.v7 = va7
	    where ut.chid = vid;
	end if;
		
		
	
end;
/
