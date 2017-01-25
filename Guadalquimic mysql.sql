Create table Profesores(
Id int AUTO_INCREMENT,    
Nombre varchar(25) not null,
Apellidos varchar(30) not null,
Correo varchar(40) unique not null,   
Contraseña varchar(255) not null,
constraint PK_Profesores Primary key (Id));

Create table Centros(
Id int AUTO_INCREMENT,
Nombre varchar(50) not null,
Localizacion varchar(100),
constraint PK_Centros Primary key (Id)
);

Create table Profesores_Centros(
Id_Profesor int not null,
Id_Centro int not null,
Fecha_Alta date not null,
Fecha_Baja date null   
);

Create table  Viajes(
Id int AUTO_INCREMENT,
Fecha_Inicio datetime not null,
Fecha_Fin datetime not null,
Tipo varchar(200) null,
Denominacion varchar(200) null,
Notas varchar(400) null,
    constraint PK_Viajes Primary key (Id)
);

Create table Profesores_Viajes(
Id_Profesor int not null,
Id_Viaje int not null
);

Create table Grupos(
Id int AUTO_INCREMENT,
Id_Viaje int not null,
Id_Centro int not null,
Nombre varchar(20) unique not null,
constraint PK_Grupos Primary key (Id)
);

Create table Profesores_Grupos(
Id_Profesor int not null,  
Id_Grupo int not null
);

Create table Alumnos(
Id int AUTO_INCREMENT,
Nombre varchar(25) not null,
Apellidos varchar(30) not null,
Correo varchar(40) unique not null,
Contraseña varchar(255) not null,
    constraint PK_Alumnos Primary key (Id)
);

Create table Alumnos_Grupos(
Id_Alumno int not null,  
Id_Grupo int not null
);

Create table Medidas(
Id int AUTO_INCREMENT,
Id_Alumno int not null,
Id_Grupo int not null,
Id_Estacion int not null,
Id_Magnitud int not null,
Fecha datetime not null,
Fecha_Modificabilidad datetime not null,
Valor real not null,
Confirmada tinyint(1) not null,
constraint PK_Medidas Primary key (Id)
);

Create table Magnitudes(
Id int AUTO_INCREMENT,  
Nombre varchar(30) not null,
Unidad varchar(30) null,
Val_Max real null,
Val_Min real null,
constraint PK_Magnitudes Primary key (Id)
);

Create table Estaciones(
Id int AUTO_INCREMENT,
Nombre varchar(40) not null,
Latitud varchar(40) null,
Longitud varchar(40) null,
constraint PK_Estaciones Primary key (Id)
);


Alter table Profesores_Centros add constraint PK_Profesores_Centros Primary key (Id_Profesor,Id_Centro);
Alter table Profesores_Viajes add constraint PK_Profesores_Viajes Primary key (Id_Profesor,Id_Viaje);
Alter table Profesores_Grupos add constraint PK_Profesores_Grupos Primary key (Id_Profesor,Id_Grupo);
Alter table Alumnos_Grupos add constraint PK_Alumnos_Grupos Primary key (Id_Alumno,Id_Grupo);

Alter table Grupos add constraint FK_Grupos_Viajes Foreign key (Id_Viaje) References Viajes(Id);
Alter table Grupos add constraint FK_Grupos_Centros Foreign key (Id_Centro) References Centros(Id);
Alter table Medidas add constraint FK_Medidas_Estaciones Foreign key (Id_Estacion) References Estaciones(Id);
Alter table Medidas add constraint FK_Medidas_Grupos Foreign key (Id_Grupo) References Grupos(Id);
Alter table Medidas add constraint FK_Medidas_Alumnos Foreign key (Id_Alumno) References Alumnos(Id);
Alter table Medidas add constraint FK_Medidas_Magnitudes Foreign key (Id_Magnitud) References Magnitudes(Id);

Alter table Profesores_Centros add constraint FK_PC_Profesores Foreign key (Id_Profesor) References Profesores(Id);
Alter table Profesores_Centros add constraint FK_PC_Centros Foreign key (Id_Centro) References Centros(Id);
Alter table Profesores_Viajes add constraint FK_PV_Profesores Foreign key (Id_Profesor) References Profesores(Id);
Alter table Profesores_Viajes add constraint FK_PV_Viajes Foreign key (Id_Viaje) References Viajes(Id);
Alter table Profesores_Grupos add constraint FK_PG_Profesores Foreign key (Id_Profesor) References Profesores(Id);
Alter table Profesores_Grupos add constraint FK_PG_Grupos Foreign key (Id_Grupo) References Grupos(Id);
Alter table Alumnos_Grupos add constraint FK_AG_Alumnos Foreign key (Id_Alumno) References Alumnos(Id);
Alter table Alumnos_Grupos add constraint FK_AG_Grupos Foreign key (Id_Grupo) References Grupos(Id);
