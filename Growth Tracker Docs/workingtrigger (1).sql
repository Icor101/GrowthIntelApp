create or replace trigger display_check1
after insert or update or delete on user_table
for each row 

declare

fdose int;
dtp int;
sec int;
third int;
totaldose int;
age int;
vcname varchar(25);

t2to3 int := 0;
t1to2 int := 0;
dptmsg int := 0;

begin
	
	
	if updating then
		if :new.v4 = (:old.v4 + 1)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 4;
			
			
			if age < fdose + sec then
				t1to2:=1;
				dbms_output.put_line('next dosage in '||sec||'weeks for'||vcname);
			elsif age < fdose + sec +third then
				t2to3 := 1;
				dbms_output.put_line('next dosage in '||third||'weeks for'||vcname);
			else
				t1to2:=0; t2to3:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);		
		end if;
		
		if :new.v2 = (:old.v2 + 1)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 2;
			
			
			if age < fdose + sec then
				t1to2:=1;
				dbms_output.put_line('next dosage in '||sec||'weeks for'||vcname);
			elsif age < fdose + sec +third then
				t2to3:=1;
				dbms_output.put_line('next dosage in '||third||'weeks for'||vcname);
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
				dbms_output.put_line('DPT Vaccine not taken');
			else 
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);	
				
			
		end if;
		
		
		if :new.v1 = (:old.v1 + 1)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 1;
			
			
			if age < fdose + sec then
				t1to2:=1;
				dbms_output.put_line('next dosage in '||sec||'weeks for'||vcname);
			elsif age < fdose + sec +third then
				t2to3:=1;
				dbms_output.put_line('next dosage in '||third||'weeks for'||vcname);
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
				dbms_output.put_line('DPT Vaccine not taken');
			else 
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);	
			
			
		end if;
		
		
		if :new.v3 = (:old.v3 + 1)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 3;
			
			
			if age < fdose + sec then
				t1to2:=1;
				dbms_output.put_line('next dosage in '||sec||'weeks for'||vcname);
			elsif age < fdose + sec +third then
				t2to3:=1;
				dbms_output.put_line('next dosage in '||third||'weeks for'||vcname);
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
				dbms_output.put_line('DPT Vaccine not taken');
			else
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);	
				
			
		end if;
		
		if :new.v5 = (:old.v5 + 1)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 5;
			
			
			if age < fdose + sec then
				t1to2:=1;
				dbms_output.put_line('next dosage in '||sec||'weeks for'||vcname);
			elsif age < fdose + sec +third then
				t2to3:=1;
				dbms_output.put_line('next dosage in '||third||'weeks for'||vcname);
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
				dbms_output.put_line('DPT Vaccine not taken');
			else
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);		
			
		end if;
		
		if :new.v6 = (:old.v6 + 1)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 6;
			
			
			if age < fdose + sec then
				t1to2:=1;
				dbms_output.put_line('next dosage in '||sec||'weeks for'||vcname);
			elsif age < fdose + sec +third then
				t2to3:=1;
				dbms_output.put_line('next dosage in '||third||'weeks for'||vcname);
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
				dbms_output.put_line('DPT Vaccine not taken');
			else 
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);		
			
		end if;
		
		if :new.v7 = (:old.v7 + 1)	then
			select vname, wDTP, dose1, v1to2, v2to3, no_of_doses into vcname, dtp, fdose, sec, third, totaldose from vaccine
			where pkey = 7;
			
			
			if age < fdose + sec then
				t1to2:=1;
				dbms_output.put_line('next dosage in '||sec||'weeks for'||vcname);
			elsif age < fdose + sec +third then
				t2to3:=1;
				dbms_output.put_line('next dosage in '||third||'weeks for'||vcname);
			else
				t1to2:=0; t2to3:=0;
			end if;
				
			if :new.v4 = :old.v4 and dtp=1 then
			    dptmsg:=1;
				dbms_output.put_line('DPT Vaccine not taken');
			else
				dptmsg:=0;
			end if;
			insert into dbmsoutput values(t1to2,t2to3, dptmsg);		
			
		end if;
		
		
		
		
		
		
		
	end if;
	
end;
/