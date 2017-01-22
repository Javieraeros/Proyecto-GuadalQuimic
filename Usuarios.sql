--Primero crear la BBDD!!!!

--Creación de Usuarios
use Guadalquimic
CREATE LOGIN Alumno   
    WITH PASSWORD = 'fjmajada#)1617.',Default_database=Guadalquimic;  
GO  
Create Login Profesor
	With Password = 'rbrln!?2201,',Default_database=Guadalquimic;  ;


CREATE USER Alumno FOR LOGIN Alumno;  
GO  


CREATE USER Profesor FOR LOGIN Profesor;  
GO  


--Permisos