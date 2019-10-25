/*
--------------------------------------------------------------------
Adaptado de http://www.sqlservertutorial.net/load-sample-database/
--------------------------------------------------------------------
*/

use bicicleteria;

-- create tables
CREATE TABLE categorias (
	category_id INT IDENTITY (1, 1) PRIMARY KEY,
	category_name VARCHAR (255) NOT NULL
);

CREATE TABLE marcas (
	brand_id INT IDENTITY (1, 1) PRIMARY KEY,
	brand_name VARCHAR (255) NOT NULL
);

CREATE TABLE bicicletas (
	product_id INT IDENTITY (1, 1) PRIMARY KEY,
	product_name VARCHAR (255) NOT NULL,
	brand_id INT NOT NULL,
	category_id INT NOT NULL,
	model_year SMALLINT NOT NULL,
	list_price DECIMAL (10, 2) NOT NULL,
	FOREIGN KEY (category_id) REFERENCES categorias (category_id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (brand_id) REFERENCES marcas (brand_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE clientes (
	customer_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (255) NOT NULL,
	last_name VARCHAR (255) NOT NULL,
	phone VARCHAR (25),
	email VARCHAR (255) NOT NULL,
	street VARCHAR (255),
	city VARCHAR (50),
	state VARCHAR (25),
	zip_code VARCHAR (5)
);

CREATE TABLE empleados (
	staff_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (50) NOT NULL,
	last_name VARCHAR (50) NOT NULL,
	email VARCHAR (255) NOT NULL UNIQUE,
	phone VARCHAR (25),
	active tinyint NOT NULL,
	manager_id INT,
	FOREIGN KEY (manager_id) REFERENCES empleados (staff_id) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE ventas (
	order_id INT IDENTITY (1, 1) PRIMARY KEY,
	customer_id INT,
	order_status tinyint NOT NULL,
	-- Order status: 1 = Pending; 2 = Processing; 3 = Rejected; 4 = Completed
	order_date DATE NOT NULL,
	required_date DATE NOT NULL,
	shipped_date DATE,
	staff_id INT NOT NULL,
	FOREIGN KEY (customer_id) REFERENCES clientes (customer_id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (staff_id) REFERENCES empleados (staff_id) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE detalles_venta (
	order_id INT,
	item_id INT,
	product_id INT NOT NULL,
	quantity INT NOT NULL,
	list_price DECIMAL (10, 2) NOT NULL,
	discount DECIMAL (4, 2) NOT NULL DEFAULT 0,
	PRIMARY KEY (order_id, item_id),
	FOREIGN KEY (order_id) REFERENCES ventas (order_id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (product_id) REFERENCES bicicletas (product_id) ON DELETE CASCADE ON UPDATE CASCADE
);
