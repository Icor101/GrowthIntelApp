create table vaccine(pkey int, vname varchar(20), dose1 int, no_of_doses int, v1to2 int, v2to3 int, v3to4 int, wDTP int);

insert into vaccine values(1, 'BCG',0,1,0,0,0,0);
insert into vaccine values(2, 'Hepatitis B',0,3,6,4,0,1);
insert into vaccine values(3, 'Polio bOPV+IPV',6,3,4,4,0,1);
insert into vaccine values(4, 'DTP Vaccine',6,3,4,4,0,0);
insert into vaccine values(5, 'H.Influenzae typeb', 6,3,4,4,0,1);
insert into vaccine values(6, 'P.Conjugate',6,3,4,4,0,0);
insert into vaccine values (7, 'Rotavirus',6,3,4,4,0,0);

commit;