create or replace trigger display_check
after insert or update or delete on user_table
for each row 

declare

fdose int;
dtp int;
sec int;
third int;
totaldose int;
age int;
vcname varchar(10);

t2to3 int := 0;
t1to2 int := 0;
dptmsg int := 0;

begin
	
	
	if updating then
	
		
		
		
		
		
		if :new.v4 > (:old.v4)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 4;
			
			
			if age < fdose + sec then
				t1to2:=1;
			elsif age < fdose + sec +third then
				t2to3 := 1;
			else
				t1to2:=0; t2to3:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);	
			
				
			
		end if;
		
		if :new.v2 > (:old.v2)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 2;
			
			
			if age < fdose + sec then
				t1to2:=1;
			elsif age < fdose + sec +third then
				t2to3:=1;
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
			else 
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);	
				
			
		end if;
		
		
		if :new.v1 > (:old.v1)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 1;
			
			
			if age < fdose + sec then
				t1to2:=1;
			elsif age < fdose + sec +third then
				t2to3:=1;
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
			else 
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);	
			
			
		end if;
		
		
		if :new.v3 > (:old.v3)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 3;
			
			
			if age < fdose + sec then
				t1to2:=1;
			elsif age < fdose + sec +third then
				t2to3:=1;
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
			else
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);	
				
			
		end if;
		
		if :new.v5 > (:old.v5)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 5;
			
			
			if age < fdose + sec then
				t1to2:=1;
			elsif age < fdose + sec +third then
				t2to3:=1;
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
			else
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);		
			
		end if;
		
		if :new.v6 > (:old.v6 )	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 6;
			
			
			if age < fdose + sec then
				t1to2:=1;
			elsif age < fdose + sec +third then
				t2to3:=1;
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
			else 
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);		
			
		end if;
		
		if :new.v7 > (:old.v7)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 7;
			
			
			if age < fdose + sec then
				t1to2:=1;
			elsif age < fdose + sec +third then
				t2to3:=1;
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
			else
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);		
			
		end if;
	end if;
	
end;
/
