create or replace procedure checkUserAndPswd(a in varchar,b in varchar,flag in out varchar) as
t1 varchar(20);
t2 varchar(20);
begin
	select username,password into t1,t2
	from doctor
	where username like a and password like b;
	
exception
	when no_data_found then
		flag:='false';
end;
/
