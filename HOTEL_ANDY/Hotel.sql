create database BD_HOTE
;
use BD_HOTE
;

create table HABITACION
(id_habitacion  int identity(1,1) primary key not null,
numero_habitacion char(8),
tipo varchar(20)
);


create table EMPLEADO
(id_empleado  int identity(1,1) primary key not null,
nombre varchar(30) ,
apellido varchar(30) ,
edad char(3),
Sexo varchar (30),
Telefono char(20)  check (Telefono LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]'),
direcion varchar(30),
dni_empleado char (20) , check(dni_empleado LIKE('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
turno varchar(30),
tipo varchar(20),
cargo varchar(20),
salario char(8) 
);

create table MODO_PAGO
(id_modo_pago  int identity(1,1) primary key not null,
modo_pago varchar(30)
);

create table CLIENTE
(id_cliente  int identity(1,1)primary key not null,
nombre varchar(30),
apellido varchar(30),
Telefono char(20) check (Telefono LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]'),
dni_cliente char (20) , check(dni_cliente LIKE('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
direcion varchar(30)
);

create table PROMOCION
(id_promocion  int identity(1,1) primary key not null,
 descuento varchar(10),
 costo int 
);

create table ESTANCIA
(id_estancia  int identity(1,1) primary key not null,
fecha_entrada date,
fecha_salida date,
id_empleado int not null,
id_modo_pago int not null,
id_cliente int not null,
id_habitacion int not null,
ciudad varchar(25),
pago int,
id_promocion int not null,
foreign key (id_promocion) references PROMOCION (id_promocion), 
foreign key(id_empleado) references  EMPLEADO (id_empleado),
foreign key(id_modo_pago) references MODO_PAGO (id_modo_pago),
foreign key (id_habitacion) references HABITACION (id_habitacion),
foreign key (id_cliente) references CLIENTE (id_cliente)
);