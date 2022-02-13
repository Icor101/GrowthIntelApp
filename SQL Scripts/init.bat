cd ".\Populate Tables"
for %%f in (*.sql) do ( start "%%f" /separate sqlplus -s -l SYSTEM/<PASSWORD>@XE @"%%f")
cd "..\Stored Proc"
for %%f in (*.sql) do ( start "%%f" /separate sqlplus -s -l SYSTEM/<PASSWORD>@XE @"%%f")
cd "..\Triggers"
for %%f in (*.sql) do ( start "%%f" /separate sqlplus -s -l SYSTEM/<PASSWORD>@XE @"%%f")
echo SQLCommand execution completed...  
exit