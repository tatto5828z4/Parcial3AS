drop database prototipo3p;
create database prototipo3p;
use prototipo3p;

create table producto(
idProducto int primary key,
nombre varchar(50),
precio float
)engine = InnoDB;

create table bodega(
idBodega int primary key,
nombre varchar(50),
direccion varchar(50),
estatus varchar(1),
idProducto int,
FOREIGN KEY (idProducto) REFERENCES  producto(idProducto)
)engine = InnoDB;

create table cliente(
idCliente int primary key,
nombre varchar(50),
telefono varchar(10),
direccion varchar(50),
estatus varchar(1)
)engine = InnoDB;

create table tipoPago(
idTipo int primary key,
descripcion varchar(50),
estatus varchar(1)
)engine = InnoDB;