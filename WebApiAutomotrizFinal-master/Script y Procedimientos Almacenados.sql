--Procedimientos Almacenados
create procedure SP_Consultar_FormaEntrega
as
select *
from formas_entregas

create procedure SP_Consultar_Marcas
as
select *
from marcas

create procedure SP_Consultar_Modelos
as
select *
from modelos

create procedure SP_Consultar_Colores
as
select *
from colores

alter procedure SP_Inser_Vehiculos
@descripcion varchar(100),
@precio money,
@stock int,
@marca int,
@modelo int,
@color int
as
begin
insert into vehiculos (descripcion,pre_unitario,stock,id_marca,id_modelo,id_color) values (@descripcion,@precio,@stock,@marca,@modelo,@color)
end

select * from autopartes


create procedure SP_Inser_Autopartes
@descripcion varchar(100),
@precio money,
@stock int,
@stock_minimo int,
@marca int,
@modelo int
as
begin 
insert into autopartes (descripcion,pre_unitario, stock, stock_minimo,id_marca,id_modelo) values (@descripcion,@precio,@stock,@stock_minimo,@marca,@modelo)
end

create procedure SP_Consultar_Vehiculos
as
select v.id_vehiculo, v.descripcion, ma.marca, m.modelo, c.color, v.pre_unitario
from vehiculos v join colores c on c.id_color=v.id_color join modelos m on m.id_modelo=v.id_modelo join marcas ma on ma.id_marca=v.id_marca

select * from vehiculos

create procedure SP_Consultar_TipoCliente
as
select *
from tipos_clientes

create table formas_pagos
(id_forma_pago int identity(1,1),
forma_pago varchar(50)
constraint pk_formaspago primary key (id_forma_pago)
)

create table barrios
(id_barrio int identity(1,1),
barrio varchar (50),
id_ciudad int
constraint pk_barrio primary key (id_barrio)
)


create table tipos_clientes
(id_tipo_cliente int identity(1,1),
nombre varchar (50)
constraint pk_tipo_cliente primary key (id_tipo_cliente)
)

create table marcas
(id_marca int identity(1,1),
marca varchar (50)
constraint pk_marca primary key (id_marca)
)

create table modelos 
(id_modelo int identity(1,1),
modelo varchar(50)
constraint pk_modelos primary key (id_modelo)
)

create table colores
(id_color int identity(1,1),
color varchar (50)
constraint pk_colores primary key (id_color)
)


create table vehiculos
(id_vehiculo int identity(1,1),
descripcion varchar(100),
pre_unitario money,
stock int,
id_marca int,
id_modelo int,
id_color int
constraint pk_vehiculos primary key (id_vehiculo)
constraint fk_vehiculos_marcas foreign key (id_marca)
references marcas (id_marca),
constraint fk_vehiculos_modelos foreign key (id_modelo)
references modelos (id_modelo),
constraint fk_vehiculos_colores foreign key (id_color)
references colores (id_color)
)

create table autopartes
(id_autoparte int identity(1,1),
descripcion varchar(100),
pre_unitario money,
stock int,
stock_minimo int,
id_marca int,
id_modelo int
constraint pk_autopartes primary key (id_autoparte)
constraint fk_autopartes_marcas foreign key (id_marca)
references marcas (id_marca),
constraint fk_autopartes_modelos foreign key (id_modelo)
references modelos (id_modelo),
)

create table formas_entregas
(id_forma_entrega int identity(1,1),
forma_entrega varchar(50)
constraint pk_forma_entrega primary key (id_forma_entrega)
)

--//TABLAS MAESTRAS//
create table facturas
(nro_factura int identity (1,1),
id_forma_pago int,
id_cliente int,
id_vendedor int,
id_forma_entrega int,
fecha datetime
constraint pk_factura primary key (nro_factura),
constraint fk_factura_formapago foreign key (id_forma_pago)
references formas_pagos (id_forma_pago),
constraint pk_factura_vendedor foreign key(id_vendedor) references vendedores(id_vendedor),
constraint fk_factura_cliente foreign key (id_cliente)
references clientes (id_cliente),
constraint fk_facturas_entrega foreign key (id_forma_entrega)
references formas_entregas (id_forma_entrega)
)

create table detalle_facturas
(
detalle_nro int not null,
nro_factura int not null,
pre_unitario money,
cantidad int,
id_vehiculo int,
id_autoparte int
constraint pk_detalle_nro primary key(detalle_nro,nro_factura)
constraint fk_factura foreign key (nro_factura)
references facturas (nro_factura),
constraint fk_det_factura_vehiculo foreign key (id_vehiculo)
references vehiculos (id_vehiculo),
constraint fk_det_factura_autoparte foreign key (id_autoparte)
references autopartes (id_autoparte)
)



create table clientes
(id_cliente int identity(1,1),
nombre varchar (100),
apellido varchar (100),
calle varchar (100),
altura int,
email varchar (100),
nro_tel bigint,
id_tipo_cliente int,
barrio varchar(100),
nro_doc bigint
constraint pk_clientes primary key (id_cliente),
constraint fk_cliente_tipo foreign key (id_tipo_cliente)
references tipos_clientes (id_tipo_cliente),
)
create table vendedores
(id_vendedor int identity(1,1),
nombre varchar (100),
apellido varchar (100),
calle varchar (100),
altura int,
email varchar (100),
nro_tel bigint,
barrio varchar(100),
nro_doc bigint
constraint pk_vendedores primary key (id_vendedor),


)


insert into marcas(marca)
values('BMW')
insert into marcas(marca)
values('Ford')
insert into marcas(marca)
values('Chevrolet')
insert into marcas(marca)
values('Toyota')
insert into marcas(marca)
values('Mazda')
insert into marcas(marca)
values('Mitsubishi')

select * from marcas

insert into colores(color)
values('Negro')
insert into colores(color)
values('Azul')
insert into colores(color)
values('Rojo')
insert into colores(color)
values('Amarillo')
insert into colores(color)
values('Blanco')
insert into colores(color)
values('Verde')

insert into formas_entregas(forma_entrega)
values('Correo postal')
insert into formas_entregas(forma_entrega)
values('Flota de transporte propia')
insert into formas_entregas(forma_entrega)
values('Recoger en tienda')


INSERT INTO tipos_clientes (nombre) VALUES ('Empresa')
INSERT INTO tipos_clientes (nombre) VALUES ('Consumidor final')
INSERT INTO tipos_clientes (nombre) VALUES ('Proveedor')

INSERT INTO formas_pagos (forma_pago) VALUES ('Transferencia Bancaria')
INSERT INTO formas_pagos (forma_pago) VALUES ('Efectivo')
INSERT INTO formas_pagos (forma_pago) VALUES ('Tarjeta de Credito')
INSERT INTO formas_pagos (forma_pago) VALUES ('Tarjeta de Debito')

INSERT INTO modelos(modelo) VALUES('Deportivo')
INSERT INTO modelos(modelo) VALUES('Camioneta')
INSERT INTO modelos(modelo) VALUES('Otros')