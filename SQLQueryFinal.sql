create database PROJECT18
Go

use PROJECT18;

CREATE TABLE Administrator (
	id INT NOT NULL ,
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
	id int NOT NULL ,
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
	id INT NOT NULL ,
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
	id INT NOT NULL ,
	type int NOT NULL,
	observation VARCHAR(255) NOT NULL,
	comment VARCHAR(255),
	date DATE NOT NULL default (getdate()),
	reported_by INT NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Notes_FYAs (
	id INT NOT NULL ,
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
	name VARCHAR(30) NOT NULL,
	functionality VARCHAR(60) NOT NULL,
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
	name VARCHAR(30) NOT NULL,
	functionality VARCHAR(60) NOT NULL,
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
	id INT NOT NULL ,
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


insert into Administrator values(1,1,'ahmed azzam','ahmed_azzam','ahmed','ahmed@yahoo.com');
insert into Administrator values(2,1,'mohammed azzam','mohammed_azzam','mohammed','mohammed@yahoo.com');
insert into Administrator values(3,1,'mahmoud azzam','mahmoud_azzam','mahmoud','mahmoud@yahoo.com');
insert into Administrator values(4,1,'ayman azzam','ayman_azzam','ayman','ayman@yahoo.com');
insert into Administrator values(5,1,'shawky azzam','shawky_azzam','shawky','shawky@yahoo.com');
insert into Administrator values(6,1,'shehata azzam','shehata_azzam','shehata','shehata@yahoo.com');
insert into Administrator values(7,1,'azzam','azzam','azzam','azzam@yahoo.com');
insert into Administrator values(8,1,'salma ahmed','salma_ahmed','salma','salma@yahoo.com');
insert into Administrator values(9,1,'nagat ahmed','nagat_ahmed','nagat','nagat@yahoo.com');
insert into Administrator values(10,1,'younes mohammed','younes_mohammed','younes','younes@yahoo.com');


insert into Sub_Department values(1,'Production',1,1,1,1);
insert into Sub_Department values(2,'Maintenance',0,2,1,2);


insert into Operator values(1,'sara hosny','sara','ayman','ayman@yahoo.com',0,1,1);
insert into Operator values(2,'mostafa Elshaer','mostafa','mostafa','mostafa@yahoo.com',0,2,0);
insert into Operator values(3,'mhmd abd-allah','mhmd','mhmd','mhmd@yahoo.com',0,1,0);
insert into Operator values(4,'hamdy','hamdy','hamdy','hamdy@yahoo.com',0,2,0);
insert into Operator values(5,'radwa khatab','radwa','radwa','radwa@yahoo.com',0,1,1);
insert into Operator values(6,'ayman akwah','akwah','akwah','akwah@yahoo.com',2,2,0);
insert into Operator values(7,'amr abo-shama','amr','amr','amr@yahoo.com',2,1,0);
insert into Operator values(8,'mazen','mazen','mazen','mazen@yahoo.com',2,2,0);
insert into Operator values(9,'sebak','sebak','sebak','sebak@yahoo.com',2,1,0);
insert into Operator values(10,'reham ali','reham','reham','reham@yahoo.com',2,2,0);


insert into Maintenance_Companies values(1,'ASM','ASM@yahoo.com','Cairo/Egypt','Hamada','Hamada@yahoo.com',01136482056);
insert into Maintenance_Companies values(2,'BMC','BMC@yahoo.com','ALEX/Egypt','Fatma','Fatma@yahoo.com',01111437056);

insert into Production_Machines values(1,'production_machine1','Using in production step 1',8,'2018-12-22','www.ASM.com/productionmachine1',1,1,'Working',90);
insert into Production_Machines values(2,'production_machine2','Using in production step 2',4,'2018-12-23','www.ASM.com/productionmachine2',1,1,'Working',85);
insert into Production_Machines values(3,'production_machine3','Using in production step 3',6,'2018-12-21','www.ASM.com/productionmachine3',1,1,'in Maintenance',70);
insert into Production_Machines values(4,'production_machine4','Using in production step 4',4,'2018-12-23','www.ASM.com/productionmachine4',1,1,'Working',69);
insert into Production_Machines values(5,'production_machine5','Using in production step 5',3,'2018-12-20','www.ASM.com/productionmachine5',1,1,'Working',105);
insert into Production_Machines values(6,'production_machine6','Using in production step 6',4,'2018-12-23','www.ASM.com/productionmachine6',1,1,'in Maintenance',120);
insert into Production_Machines values(7,'production_machine7','Using in production step 7',5,'2018-12-21','www.ASM.com/productionmachine7',1,1,'Working',60);
insert into Production_Machines values(8,'production_machine8','Using in production step 8',4,'2018-12-22','www.ASM.com/productionmachine8',1,1,'Working',99);
insert into Production_Machines values(9,'production_machine9','Using in production step 9',9,'2018-12-15','www.ASM.com/productionmachine9',1,1,'in Maintenance',70);
insert into Production_Machines values(10,'production_machine_Final','Using in production final step',12,'2018-11-23','www.ASM.com/productionmachinefinal',1,1,'Working',80);


insert into Utilities_Machines values(1,'Utility_machine1','Using in Maintenance production_machine1,2,3 step 1',6,'2018-08-22','www.BMC.com/Maintenanceonmachine1',2,2);
insert into Utilities_Machines values(2,'Utility_machine2','Using in Maintenance production_machine1,2,3 step 2',8,'2018-10-02','www.BMC.com/Maintenanceonmachine2',2,2);
insert into Utilities_Machines values(3,'Utility_machine3','Using in Maintenance production_machine1,2,3 step 3',10,'2018-12-23','www.BMC.com/Maintenanceonmachine3',2,2);
insert into Utilities_Machines values(4,'Utility_machine4','Using in Maintenance production_machine4,5,6,7,8 step 1',7,'2018-12-09','www.BMC.com/Maintenanceonmachine4',2,2);
insert into Utilities_Machines values(5,'Utility_machine5','Using in Maintenance production_machine4,5,6,7,8 step 2',9,'2018-12-06','www.BMC.com/Maintenanceonmachine5',2,2);
insert into Utilities_Machines values(6,'Utility_machine6','Using in Maintenance production_machine4,5,6,7,8 step 3',11,'2018-11-22','www.BMC.com/Maintenanceonmachine6',2,2);
insert into Utilities_Machines values(7,'Utility_machine7','Using in Maintenance production_machine9 step 1',5,'2018-12-16','www.BMC.com/Maintenanceonmachine7',2,2);
insert into Utilities_Machines values(8,'Utility_machine8','Using in Maintenance production_machine9 step 2',4,'2018-12-13','www.BMC.com/Maintenanceonmachine8',2,2);
insert into Utilities_Machines values(9,'Utility_machine9','Using in Maintenance production_machine9 step 3',3,'2018-12-12','www.BMC.com/Maintenanceonmachine9',2,2);
insert into Utilities_Machines values(10,'Utility_machine10','Using in Maintenance production_machine_final',12,'2018-12-10','www.BMC.com/Maintenanceonmachine10',2,2);
