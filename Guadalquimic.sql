--Suscipteble a cambios, probablemete distribución en varios ficheros

--Creación de Base de Datos
use master 
if exists(select * from dbo.sysdatabases where name ='Guadalquimic') 
DROP DATABASE Guadalquimic

Create Database Guadalquimic
go


--Tablas
Use Guadalquimic
Create table Profesores(
Id_Profesor int identity(1,1),    --Usar autoincrement?
Nombre nvarchar(30) not null,
Apellidos nvarchar(30) not null,
Correo nvarchar(40) not null,   --Comprobar correo válido
Contraseña nvarchar(60) not null
)

Create table Centros(
Id_Centro int identity(1,1),
Nombre nvarchar(50) not null,
Localizacion nvarchar(100)
)

Create table Profesores_Centros(
Id_Profesor int,
Id_Centro int,
Fecha_Alta date not null,
Fecha_Baja date null   --Comprobar posterioridad
)

Create table  Viajes(
Id int identity(1,1),
Fecha_Inicio datetime not null,
Fecha_Fin datetime not null,
Tipo nvarchar(200) null,
Denominacion nvarchar(200) null,
Notas nvarchar(max) null 
)

Create table Profesores_Viajes(
Id_Profesor int,
Id_Viaje int
)

Create table Grupos(
Id int identity(1,1),
Nombre nvarchar(20)
)

Create table Profesores_Grupos(
Id_Profesor int,  
Id_Grupo int
)

Create table Alumnos(
Id int identity(1,1),
Nombre
Apellidos
Correo
Contraseña  
)

Create table Alumnos_Grupos(
Id int identity(1,1),  
)

Create table Medidas(
Id int identity(1,1),  
)

Create table Magnitudes(
Id int identity(1,1),  
)

Create table Estaciones(
Id int identity(1,1),  
)


--Claves y restricciones




--Datos


--Programación