CREATE TABLE Sedes (idSede int PRIMARY KEY, NombreDeLaSede VARCHAR(30));
CREATE TABLE Productos (Codigo VARCHAR(20) PRIMARY KEY, Nombre VARCHAR(30), Valor FLOAT);
CREATE TABLE Ventas (idSede int PRIMARY KEY, codigoProducto VARCHAR(30), valor FLOAT);

insert into Sedes (idSede,NombreDeLaSede) values(001,'Sede Norte');
insert into Sedes (idSede,NombreDeLaSede) values(002,'Sede Sur');
insert into Sedes (idSede,NombreDeLaSede) values(003,'Sede Centro');

insert into Productos (Codigo,Nombre,Valor) values('P001','juego de sala',1000000);
insert into Productos (Codigo,Nombre,Valor) values('P002','Juego de Comedor',1200000);
insert into Productos (Codigo,Nombre,Valor) values('P003','Nevera',800000);
insert into Productos (Codigo,Nombre,Valor) values('P004','Estufa',500000);
