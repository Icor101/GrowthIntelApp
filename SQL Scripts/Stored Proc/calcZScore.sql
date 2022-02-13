create or replace procedure calcZscore(pgender in number:=NULL,page in number:= NULL,pheight in number:= NULL,pweight in number:=NULL,pleng in number:= NULL,phc in number:=NULL,pstat in number:=NULL,wtageinfOP out number,lenageOP out number,hcageinfOP out number,wtstatOP out number,statageOP out number,bmiagerevOP out number,wtleninfOP out number,exc out number) as

    l number;
    m number;
    s number;
    z number;
    z_int int;
	gender number(16,12):=pgender;
	leng number(16,12):=pleng;
	age number(16,12):=page;
	height number(16,12):=pheight;
    second_precision_digit int;
    gender_null EXCEPTION;
	height_null EXCEPTION;
	pbmi number(16,12):=pweight/power(pheight/100,2);

begin
if gender is null then
    raise gender_null;
else
        if age is not null then
			if (age>=0) and (age<=36) then
					select l,m,s into l,m,s
					from wtageinf i
					where (i.age=page) and (i.sex=gender); 
			else
				select l,m,s into l,m,s
				from wtage i
				where i.agemos=age and i.sex=gender; 
			end if;
            
            if l=0 then
                z:=LN(pweight/m)/s;
            else
                z:=(power(pweight/m,l)-1)/(l*s);
            end if;

            z_int:=z*100;
			second_precision_digit:=abs(mod(z_int,10));
            z_int:=z_int/10;
            z:=z_int/10.00;
			
			dbms_output.put_line(z_int||' '||second_precision_digit||' '||z);

            if second_precision_digit=0 then
                select zero into wtageinfOP
                from StdDistTable temp
                where temp.zscore=z;
            elsif second_precision_digit=1 then
                select one into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=2 then
                select two into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=3 then
                select three into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=4 then
                select four into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=5 then
                select five into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=6 then
                select six into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=7 then
                select seven into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=8 then
                select eight into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=9 then
                select nine into wtageinfOP
                from StdDistTable temp
				where temp.zscore=z;
            end if;

			if(age>=0) and (age<36) then
				select l,m,s into l,m,s
				from lenageinf i
				where i.age=page and i.sex=gender;
				
				if l=0 then
					z:=LN(pleng/m)/s;
				else
					z:=(power(pleng/m,l)-1)/(l*s);
				end if;

            z_int:=z*100;
			second_precision_digit:=abs(mod(z_int,10));
            z_int:=z_int/10;
            z:=z_int/10.00;
			
			dbms_output.put_line(z_int||' '||second_precision_digit||' '||z);

            if second_precision_digit=0 then
                select zero into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=1 then
                select one into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=2 then
                select two into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=3 then
                select three into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=4 then
                select four into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=5 then
                select five into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=6 then
                select six into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=7 then
                select seven into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=8 then
                select eight into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=9 then
                select nine into lenageOP
                from StdDistTable temp
				where temp.zscore=z;
            end if;
			else
				lenageOP:=100;
			end if;		
		end if;
		
			if (age>=0) and (age<36) then
				select l,m,s into l,m,s
				from hcageinf i
				where i.agemos=age and i.sex=gender;

				if l=0 then
					z:=LN(phc/m)/s;
				else
					z:=(power(phc/m,l)-1)/(l*s);
				end if;

				z_int:=z*100;
			  second_precision_digit:=abs(mod(z_int,10));
				z_int:=z_int/10;
				z:=z_int/10.00;

				dbms_output.put_line(z_int||' '||second_precision_digit||' '||z);
				
				if second_precision_digit=0 then
					select zero into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=1 then
					select one into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=2 then
					select two into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=3 then
					select three into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=4 then
					select four into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=5 then
					select five into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=6 then
					select six into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=7 then
					select seven into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=8 then
					select eight into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=9 then
					select nine into hcageinfOP
					from StdDistTable temp
					where temp.zscore=z;
				end if;
			else
				hcageinfOP:=100;
			end if;
			
			if(page>=24) and (page<240)then
				select l,m,s into l,m,s
				from statage i
				where i.agemos=age and i.sex=gender;
				
				if l=0 then
                z:=LN(pstat/m)/s;
				else
					z:=(power(pstat/m,l)-1)/(l*s);
				end if;

				z_int:=z*100;
				second_precision_digit:=abs(mod(z_int,10));
				z_int:=z_int/10;
				z:=z_int/10.00;
			
			dbms_output.put_line(z_int||' '||second_precision_digit||' '||z);

            if second_precision_digit=0 then
                select zero into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=1 then
                select one into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=2 then
                select two into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=3 then
                select three into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=4 then
                select four into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=5 then
                select five into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=6 then
                select six into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=7 then
                select seven into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=8 then
                select eight into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=9 then
                select nine into statageOP
                from StdDistTable temp
				where temp.zscore=z;
            end if;
		else
			statageOP:=100;
		end if;

			if(page>=24) and (page<240) then
				select l,m,s into l,m,s
				from bmiagerev i
				where i.agemos=page and i.sex=gender;
				
				if l=0 then
                z:=LN(pbmi/m)/s;
				else
					z:=(power(pbmi/m,l)-1)/(l*s);
				end if;
				z_int:=z*100;
				second_precision_digit:=abs(mod(z_int,10));
				z_int:=z_int/10;
				z:=z_int/10.00;
			
			dbms_output.put_line(z_int||' '||second_precision_digit||' '||z);

            if second_precision_digit=0 then
                select zero into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=1 then
                select one into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=2 then
                select two into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=3 then
                select three into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=4 then
                select four into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=5 then
                select five into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=6 then
                select six into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=7 then
                select seven into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=8 then
                select eight into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            elsif second_precision_digit=9 then
                select nine into bmiagerevOP
                from StdDistTable temp
				where temp.zscore=z;
            end if;
		else
			bmiagerevop:=100;
		end if;
	end if;
    if height is not null then
		if(page>=24) and (page<=60)and (pheight>=77) and (pheight<120.5) then
			select l,m,s into l,m,s
			from wtstat i
			where i.height=pheight and i.sex=gender;
			
			if l=0 then
            z:=LN(pweight/m)/s;
        else
            z:=(power(pweight/m,l)-1)/(l*s);
        end if;
        z_int:=z*100;
      second_precision_digit:=abs(mod(z_int,10));
        z_int:=z_int/10;
        z:=z_int/10.00;
		
		dbms_output.put_line(z_int||' '||second_precision_digit||' '||z);

        if second_precision_digit=0 then
            select zero into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=1 then
            select one into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=2 then
            select two into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=3 then
            select three into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=4 then
            select four into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=5 then
            select five into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=6 then
            select six into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=7 then
            select seven into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=8 then
            select eight into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        elsif second_precision_digit=9 then
            select nine into wtstatOP
            from StdDistTable temp
			where temp.zscore=z;
        end if;
	else
		wtstatOP:=100;
	end if;
	else
		raise height_null;
end if;


    if leng is not null then
		if(page>0) and (page<=36) then
			if(pleng>=45) and (pleng<103) then
				select l,m,s into l,m,s
				from wtleninf i
				where i.len=leng and i.sex=gender;
				if l=0 then
				z:=LN(pweight/m)/s;
				else
					z:=(power(pweight/m,l)-1)/(l*s);
				end if;
				z_int:=z*100;
				second_precision_digit:=abs(mod(z_int,10));
				z_int:=z_int/10;
				z:=z_int/10.00;
		
				dbms_output.put_line(z_int||' '||second_precision_digit||' '||z);

				if second_precision_digit=0 then
					select zero into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=1 then
					select one into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=2 then
					select two into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=3 then
					select three into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=4 then
					select four into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=5 then
					select five into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=6 then
					select six into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=7 then
					select seven into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=8 then
					select eight into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				elsif second_precision_digit=9 then
					select nine into wtleninfOP
					from StdDistTable temp
					where temp.zscore=z;
				end if;
			end if;
			else
				wtleninfOP:=100;
		end if;		
    end if;

exception
	when no_data_found then
		exc:=-1;
    when gender_null then
        dbms_output.put_line('Please enter gender');
	when height_null then
		dbms_output.put_line('Please enter height');
end;
/