create database PROJECT11
Go

use PROJECT11;

CREATE TABLE Administrator (
	id INT NOT NULL IDENTITY,
	prev int NOT NULL DEFAULT 1,
	name VARCHAR(30) NOT NULL,
	username VARCHAR(20) NOT NULL ,
	password VARCHAR(10) NOT NULL default '0000',
	e_mail VARCHAR(30) ,
	PRIMARY KEY (id),
	UNIQUE (username),
	UNIQUE (e_mail),
);

CREATE TABLE Operator (
	id int NOT NULL IDENTITY,
	name VARCHAR(30) NOT NULL,
	username VARCHAR(20) NOT NULL ,
	password VARCHAR(10) NOT NULL default '0000',
	e_mail VARCHAR(30) ,
	PRIMARY KEY (id),
	UNIQUE (username),
	UNIQUE (e_mail),
	prev int NOT NULL DEFAULT 0,
	works_in INT NOT NULL,
	is_chief int NOT NULL
);

CREATE TABLE Sub_Department (
	id INT NOT NULL IDENTITY,
	name VARCHAR(20) NOT NULL,
	category int NOT NULL,
	building_no INT NOT NULL,
	partition_no INT NOT NULL,
	manager_id INT NOT NULL,
	PRIMARY KEY (id),
	UNIQUE (name),
	UNIQUE (manager_id),
	UNIQUE (building_no , partition_no)
);

CREATE TABLE Stop_Go_Cards (
	id INT NOT NULL IDENTITY,
	type int NOT NULL,
	observation VARCHAR(255) NOT NULL,
	comment VARCHAR(255),
	date DATE NOT NULL default (getdate()),
	reported_by INT NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Notes_FYAs (
	id INT NOT NULL IDENTITY,
	content VARCHAR(255) NOT NULL,
	Timestamp DATETIME NOT NULL,
	is_received int NOT NULL,
	from_administrator INT default 0,
	from_operator INT default 0,
	PRIMARY KEY (id)
);

CREATE TABLE Final_Products (
	date DATE NOT NULL,
	product_QTY INT NOT NULL,
	feedback VARCHAR(255),
	PRIMARY KEY (date)
);

CREATE TABLE Production_Machines (
	id int NOT NULL,
	name VARCHAR(20) NOT NULL,
	functionality VARCHAR(50) NOT NULL,
	periodic_maintenance int NOT NULL ,
	last_maintenance DATE NOT NULL default (getdate()),
	catalog_link VARCHAR(255) NOT NULL,
	included_in INT NOT NULL,
	maintenance_company INT NOT NULL,
	PRIMARY KEY (id),
	current_state VARCHAR(15) NOT NULL,
	productivity INT NOT NULL
);

CREATE TABLE Utilities_Machines (
	id int NOT NULL,
	name VARCHAR(20) NOT NULL,
	functionality VARCHAR(50) NOT NULL,
	periodic_maintenance int NOT NULL ,
	last_maintenance DATE NOT NULL default (getdate()),
	catalog_link VARCHAR(255) NOT NULL,
	included_in INT NOT NULL,
	maintenance_company INT NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Safety_Gauges (
	department_id INT NOT NULL,
	no INT NOT NULL,
	normal INT NOT NULL,
	current_reading INT NOT NULL default 0,
	type VARCHAR(20) NOT NULL,
	PRIMARY KEY (department_id,no)
);

CREATE TABLE Documented_Problems (
	utility_machine_id int DEFAULT 0,
	production_machine_id int DEFAULT 0,
	no INT NOT NULL,
	category VARCHAR(255) NOT NULL,
	description VARCHAR(255) NOT NULL,
	cause VARCHAR(255) NOT NULL,
	solution VARCHAR(255) NOT NULL,
	supervised_by INT NOT NULL,
	PRIMARY KEY (production_machine_id,utility_machine_id,no)
);

CREATE TABLE Maintenance_Companies (
	id INT NOT NULL IDENTITY,
	name VARCHAR(20) NOT NULL,
	e_mail VARCHAR(30) NOT NULL,
	address VARCHAR(50) NOT NULL,
	representative_name VARCHAR(30) NOT NULL,
	representative_email VARCHAR(30) NOT NULL,
	repre_contact_number INT NOT NULL,
	PRIMARY KEY (id),
	UNIQUE (repre_contact_number),
	UNIQUE (representative_email),
 	UNIQUE (e_mail),
	UNIQUE (name)
);

CREATE TABLE Notes_To_Employee (
	note_id INT NOT NULL IDENTITY,
	administrator_id INT DEFAULT 0,
	operator_id INT DEFAULT 0,
	PRIMARY KEY (note_id,administrator_id,operator_id)
);

CREATE TABLE operates (
	operator_id INT NOT NULL,
	utility_machine_id int DEFAULT 0,
	production_machine_id int DEFAULT 0,
	PRIMARY KEY (operator_id,utility_machine_id,production_machine_id)
);

CREATE TABLE Cards_To_Admin (
	card_id INT NOT NULL,
	admin_id INT NOT NULL,
	PRIMARY KEY (card_id,admin_id)
);

CREATE TABLE Problem_Occur_On_Date (
	utility_machine_id INT DEFAULT 0,
	production_machine_id INT DEFAULT 0,
	problem_number INt NOT NULL,
	problem_date DATE NOT NULL,
	PRIMARY KEY (production_machine_id,utility_machine_id,problem_number,problem_date),
	FOREIGN KEY (production_machine_id,utility_machine_id,problem_number) REFERENCES Documented_Problems(production_machine_id,utility_machine_id,no)
);





ALTER TABLE Operator ADD CONSTRAINT Operator_fk1 FOREIGN KEY (works_in) REFERENCES Sub_Department(id);

ALTER TABLE Sub_Department ADD CONSTRAINT Sub_Department_fk0 FOREIGN KEY (manager_id) REFERENCES Administrator(id);

ALTER TABLE Stop_Go_Cards ADD CONSTRAINT Stop_Go_Cards_fk0 FOREIGN KEY (reported_by) REFERENCES Operator(id);

ALTER TABLE Notes_FYAs ADD CONSTRAINT Notes_FYAs_fk0 FOREIGN KEY (from_administrator) REFERENCES Administrator(id);

ALTER TABLE Notes_FYAs ADD CONSTRAINT Notes_FYAs_fk1 FOREIGN KEY (from_operator) REFERENCES Operator(id);

ALTER TABLE Utilities_Machines ADD CONSTRAINT Utilities_Machines_fk0 FOREIGN KEY (included_in) REFERENCES Sub_Department(id);
ALTER TABLE Production_Machines ADD CONSTRAINT production_Machines_fk0 FOREIGN KEY (included_in) REFERENCES Sub_Department(id);

ALTER TABLE Utilities_Machines ADD CONSTRAINT Machines_fk1 FOREIGN KEY (maintenance_company) REFERENCES Maintenance_Companies(id);
ALTER TABLE Production_Machines ADD CONSTRAINT Machines_fk2 FOREIGN KEY (maintenance_company) REFERENCES Maintenance_Companies(id);

ALTER TABLE Safety_Gauges ADD CONSTRAINT Safety_Gauges_fk0 FOREIGN KEY (department_id) REFERENCES Sub_Department(id);

ALTER TABLE Documented_Problems ADD CONSTRAINT Documented_Problems_fk0 FOREIGN KEY (utility_machine_id) REFERENCES Utilities_Machines(id);
ALTER TABLE Documented_Problems ADD CONSTRAINT Documented_Problems_fk1 FOREIGN KEY (production_machine_id) REFERENCES Production_Machines(id);

ALTER TABLE Documented_Problems ADD CONSTRAINT Documented_Problems_fk2 FOREIGN KEY (supervised_by) REFERENCES Administrator(id);

ALTER TABLE Notes_To_Employee ADD CONSTRAINT Notes_To_Employee_fk0 FOREIGN KEY (note_id) REFERENCES Notes_FYAs(id);

ALTER TABLE Notes_To_Employee ADD CONSTRAINT Notes_To_Employee_fk1 FOREIGN KEY (administrator_id) REFERENCES Administrator(id);
ALTER TABLE Notes_To_Employee ADD CONSTRAINT Notes_To_Employee_fk2 FOREIGN KEY (operator_id) REFERENCES Operator(id);

ALTER TABLE operates ADD CONSTRAINT operates_fk0 FOREIGN KEY (operator_id) REFERENCES Operator(id);

ALTER TABLE operates ADD CONSTRAINT operates_fk1 FOREIGN KEY (utility_machine_id) REFERENCES Utilities_Machines(id);
ALTER TABLE operates ADD CONSTRAINT operates_fk2 FOREIGN KEY (production_machine_id) REFERENCES Production_Machines(id);

ALTER TABLE Cards_To_Admin ADD CONSTRAINT Cards_To_Admin_fk0 FOREIGN KEY (card_id) REFERENCES Stop_Go_Cards(id);

ALTER TABLE Cards_To_Admin ADD CONSTRAINT Cards_To_Admin_fk1 FOREIGN KEY (admin_id) REFERENCES Administrator(id);

ALTER TABLE Problem_Occur_On_Date ADD CONSTRAINT Problem_Occur_On_Date_fk2 FOREIGN KEY (problem_date) REFERENCES Final_Products(date);

ALTER TABLE Stop_Go_Cards ADD CONSTRAINT Stop_Go_Cards_fk1 FOREIGN KEY (date) REFERENCES Final_Products (date) ;

	