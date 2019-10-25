/*
--------------------------------------------------------------------
Adaptado de http://www.sqlservertutorial.net/load-sample-database/
--------------------------------------------------------------------
*/

-- drop tables
DROP TABLE IF EXISTS detalles_venta;
DROP TABLE IF EXISTS ventas;
DROP TABLE IF EXISTS bicicletas;
DROP TABLE IF EXISTS categorias;
DROP TABLE IF EXISTS marcas;
DROP TABLE IF EXISTS clientes;
DROP TABLE IF EXISTS empleados;

-- drop the schemas

DROP SCHEMA IF EXISTS bicicleteria;

CREATE SCHEMA bicicleteria;

