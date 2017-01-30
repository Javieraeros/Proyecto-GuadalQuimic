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
Id int identity(1,1),    
Nombre nvarchar(25) not null,
Apellidos nvarchar(30) not null,
Correo nvarchar(40) unique not null,  
Contraseña nvarchar(255) not null
)

Create table Centros(
Id int identity(1,1),
Nombre nvarchar(50) unique not null,
Localizacion nvarchar(100) null
)

Create table Profesores_Centros(
Id_Profesor int not null,
Id_Centro int not null,
Fecha_Alta date null,
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
Id_Profesor int not null,
Id_Viaje int not null
)

Create table Grupos(
Id int identity(1,1),
Id_Viaje int not null,
Id_Centro int not null,
Nombre nvarchar(20) unique not null
)

Create table Profesores_Grupos(
Id_Profesor int not null,  
Id_Grupo int not null
)

Create table Alumnos(
Id int identity(1,1),
Nombre nvarchar(25) not null,
Apellidos nvarchar(30) not null,
Alias nvarchar(30) unique not null,
Contraseña nvarchar(255) not null,
Correo nvarchar(40) unique not null,
Curso nvarchar(20) null
)

Create table Alumnos_Grupos(
Id_Alumno int not null,  
Id_Grupo int not null
)

Create table Medidas(
Id int identity(1,1),
Id_Alumno int not null,
Id_Grupo int not null,
Id_Estacion int not null,
Id_Magnitud int not null,
Fecha datetime not null,
Fecha_Modificabilidad datetime not null,
Valor real not null,
Confirmada bit not null
)

Create table Magnitudes(
Id int identity(1,1),  
Nombre nvarchar(30) not null,
Unidad nvarchar(30) null,
Val_Max real null,
Val_Min real null
)

Create table Estaciones(
Id int identity(1,1),
Nombre nvarchar(40) not null,
Latitud nvarchar(40) null,
Longitud nvarchar(40) null
)

go
--Claves

Alter table Profesores add constraint PK_Profesores Primary key (Id)
Alter table Centros add constraint PK_Centros Primary key (Id)
Alter table Viajes add constraint PK_Viajes Primary key (Id)
Alter table Grupos add constraint PK_Grupos Primary key (Id)
Alter table Alumnos add constraint PK_Alumnos Primary key (Id)
Alter table Medidas add constraint PK_Medidas Primary key (Id)
Alter table Magnitudes add constraint PK_Magnitudes Primary key (Id)
Alter table Estaciones add constraint PK_Estaciones Primary key (Id)

Alter table Profesores_Centros add constraint PK_Profesores_Centros Primary key (Id_Profesor,Id_Centro)
Alter table Profesores_Viajes add constraint PK_Profesores_Viajes Primary key (Id_Profesor,Id_Viaje)
Alter table Profesores_Grupos add constraint PK_Profesores_Grupos Primary key (Id_Profesor,Id_Grupo)
Alter table Alumnos_Grupos add constraint PK_Alumnos_Grupos Primary key (Id_Alumno,Id_Grupo)
go

Alter table Grupos add constraint FK_Grupos_Viajes Foreign key (Id_Viaje) References Viajes(Id)
Alter table Grupos add constraint FK_Grupos_Centros Foreign key (Id_Centro) References Centros(Id)
Alter table Medidas add constraint FK_Medidas_Estaciones Foreign key (Id_Estacion) References Estaciones(Id)
Alter table Medidas add constraint FK_Medidas_Grupos Foreign key (Id_Grupo) References Grupos(Id)
Alter table Medidas add constraint FK_Medidas_Alumnos Foreign key (Id_Alumno) References Alumnos(Id)
Alter table Medidas add constraint FK_Medidas_Magnitudes Foreign key (Id_Magnitud) References Magnitudes(Id)

Alter table Profesores_Centros add constraint FK_PC_Profesores Foreign key (Id_Profesor) References Profesores(Id)
Alter table Profesores_Centros add constraint FK_PC_Centros Foreign key (Id_Centro) References Centros(Id)
Alter table Profesores_Viajes add constraint FK_PV_Profesores Foreign key (Id_Profesor) References Profesores(Id)
Alter table Profesores_Viajes add constraint FK_PV_Viajes Foreign key (Id_Viaje) References Viajes(Id)
Alter table Profesores_Grupos add constraint FK_PG_Profesores Foreign key (Id_Profesor) References Profesores(Id)
Alter table Profesores_Grupos add constraint FK_PG_Grupos Foreign key (Id_Grupo) References Grupos(Id)
Alter table Alumnos_Grupos add constraint FK_AG_Alumnos Foreign key (Id_Alumno) References Alumnos(Id)
Alter table Alumnos_Grupos add constraint FK_AG_Grupos Foreign key (Id_Grupo) References Grupos(Id)

go

--Restricciones

Alter table Profesores add constraint CK_CorreoProfesor check (Correo like '%@%.%')
Alter table Alumnos add constraint CK_CorreoAlumno check (Correo like '%@%.%')
go
--Programación

Create Trigger FechaValidaProfesores on Profesores_Centros after update,insert as 
declare @FechaAlta datetime, @FechaBaja datetime
Select @FechaAlta=Fecha_Alta from inserted
Select @FechaBaja=Fecha_Baja from inserted
If @FechaAlta>@FechaBaja
rollback
go

Create Trigger FechaValidaViajes on Viajes after update,insert as 
declare @FechaInicio datetime, @FechaFin datetime
Select @FechaInicio=Fecha_Inicio from inserted
Select @FechaFin=Fecha_Fin from inserted
If @FechaInicio>@FechaFin
rollback
go

Create Trigger FechaValidaMedidas on Medidas after update,insert as 
declare @Fecha datetime, @FechaModificabilidad datetime
Select @Fecha=Fecha from inserted
Select @FechaModificabilidad=Fecha_Modificabilidad from inserted
If @Fecha>@FechaModificabilidad
rollback
go

Create Trigger MagnitudesVálidas on Magnitudes after update,insert as 
declare @Min real, @Max real
Select @Min=Val_Min from inserted
Select @Max=Val_Max from inserted
If @Min>@Max
rollback
go


--Datos