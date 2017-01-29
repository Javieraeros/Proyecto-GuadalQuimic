use Guadalquimic
--Creación de Login AlumnoGuadalquimic
if not exists(Select * from master.sys.sql_logins where name='AlumnoGuadalquimic')
Begin
CREATE LOGIN AlumnoGuadalquimic  
    WITH PASSWORD = 'fjmajada#)1617.',Default_database=Guadalquimic;  
End
GO  

--Creación de Login ProfesorGuadalquimic
if not exists(Select * from master.sys.sql_logins where name='ProfesorGuadalquimic')
Begin
Create Login ProfesorGuadalquimic
	With Password = 'rbrln!?2201,',Default_database=Guadalquimic;  ;

End
Go

if not exists(Select * from sys.database_principals where name='AlumnoGuadalquimic')
Begin
CREATE USER AlumnoGuadalquimic FOR LOGIN AlumnoGuadalquimic;
End
Grant Select to AlumnoGuadalquimic;
Grant Insert,Update,Delete on Alumnos to AlumnoGuadalquimic;
Grant Insert,Update,Delete on Alumnos_Grupos to AlumnoGuadalquimic;
Grant Insert,Update,Delete on Medidas to AlumnoGuadalquimic;
Grant Insert,Update,Delete on Grupos to AlumnoGuadalquimic;
GO  


if not exists(Select * from sys.database_principals where name='ProfesorGuadalquimic')
Begin
CREATE USER ProfesorGuadalquimic FOR LOGIN ProfesorGuadalquimic;
End 
Grant Insert,Update,Delete to ProfesorGuadalquimic; 
GO  


--Permisos