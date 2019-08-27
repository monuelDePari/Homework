CREATE TABLE Sell.Clients(
	id tinyint NOT NULL IDENTITY(1, 1),
	client_name varchar NOT NULL,
	client_surname varchar NOT NULL,
	date_of_birth Date NOT NULL,
	phone varchar NOT NULL,
	e_mail varchar NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT clients_buys FOREIGN KEY (id) 
	REFERENCES Sell.Buys (id) ON DELETE NO ACTION 
										ON UPDATE NO ACTION,
);
CREATE TABLE Sell.Marks(
	id tinyint NOT NULL IDENTITY(1, 1),
	_name varchar NOT NULL,
	contry varchar NOT NULL,
	date_of_foundation Date NOT NULL,
	number int NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT marks_cars FOREIGN KEY (id) 
	REFERENCES Sell.Cars (id) ON DELETE NO ACTION 
										ON UPDATE NO ACTION,
);
CREATE TABLE Sell.Cars(
	id tinyint NOT NULL IDENTITY(1, 1),
	car_id tinyint NOT NULL,
	class varchar NOT NULL,
	model varchar NOT NULL,
	color varchar NOT NULL,
	engine_value int NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT cars_buys FOREIGN KEY (id) 
	REFERENCES Sell.Buys (id) ON DELETE NO ACTION 
										ON UPDATE NO ACTION,
);
CREATE TABLE Sell.Personal(
	id tinyint NOT NULL IDENTITY(1, 1),
	name varchar NOT NULL,
	surname varchar NOT NULL,
	date_of_birth Date NOT NULL,
	phone varchar NOT NULL,
	e_mail varchar NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT personal_buys FOREIGN KEY (id) 
	REFERENCES Sell.Personal (id) ON DELETE NO ACTION 
										ON UPDATE NO ACTION,
);
CREATE TABLE Sell.Buys(
	id tinyint NOT NULL IDENTITY(1, 1),
	client_id tinyint NOT NULL,
	seller_id tinyint NOT NULL,
	car_id tinyint NOT NULL,
	date_of Date NOT NULL,
	PRIMARY KEY(id),
);