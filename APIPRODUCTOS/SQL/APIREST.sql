
create database APIREST
USE APIREST

CREATE TABLE PRODUCTOS(
IdProducto int identity primary key,
Nombre varchar(50),
Marca varchar(50),
Stock int
)

------------------SP_PRODUCTOS--------------------------
create procedure sp_Listar_Productos
as
begin
	select * from PRODUCTOS
end

insert into PRODUCTOS values ('Producto1','Marca1',5000)
insert into PRODUCTOS values ('Producto2','Marca2',5000)
insert into PRODUCTOS values ('Producto3','Marca3',5000)
insert into PRODUCTOS values ('Producto4','Marca4',5000)
insert into PRODUCTOS values ('Producto5','Marca5',5000)
insert into PRODUCTOS values ('Producto6','Marca6',5000)
insert into PRODUCTOS values ('Producto7','Marca7',5000)
insert into PRODUCTOS values ('Producto8','Marca8',5000)
insert into PRODUCTOS values ('Producto9','Marca9',5000)

insert into PRODUCTOS values ('Producto10','Marca10',5000)
insert into PRODUCTOS values ('Producto11','Marca11',5000)
insert into PRODUCTOS values ('Producto12','Marca12',5000)
insert into PRODUCTOS values ('Producto13','Marca13',5000)
insert into PRODUCTOS values ('Producto14','Marca14',5000)
insert into PRODUCTOS values ('Producto15','Marca15',5000)
insert into PRODUCTOS values ('Producto16','Marca16',5000)
insert into PRODUCTOS values ('Producto17','Marca17',5000)
insert into PRODUCTOS values ('Producto18','Marca18',5000)
insert into PRODUCTOS values ('Producto19','Marca19',5000)
insert into PRODUCTOS values ('Producto20','Marca20',5000)