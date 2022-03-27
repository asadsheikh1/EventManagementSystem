CREATE DATABASE Event_Management_System;
DROP DATABASE Event_Management_System;

CREATE TABLE ADMIN_LOGIN(
	username VARCHAR(20),
	pass VARCHAR(20)
);

CREATE TABLE PACKAGE(
	package_id INT,
	package_name VARCHAR(20),
	PRIMARY KEY(package_id)
);

CREATE TABLE EVENT_MODULE(
	event_id INT,
	event_name VARCHAR(20),
	event_type VARCHAR(20),
	event_date_time DATETIME,
	event_price INT,
	event_description VARCHAR(100),
	PRIMARY KEY(event_id)
);

CREATE TABLE EVENT_MODULE_EVENT_THEME(
	event_id INT FOREIGN KEY REFERENCES EVENT_MODULE(event_id),
	event_theme VARCHAR(100),
	PRIMARY KEY(event_id, event_theme)
);

CREATE TABLE TBL_PACKAGE_EVENT_MODULE_EVENT_DATE(
	package_id INT FOREIGN KEY REFERENCES PACKAGE(package_id),
	event_id INT FOREIGN KEY REFERENCES EVENT_MODULE(event_id)
	PRIMARY KEY(package_id, event_id)
);

CREATE TABLE TRANSPORT(
	transport_id INT,
	transport_price INT,
	transport_seater INT,
	transport_type VARCHAR(20),
	transport_quantity INT,
	PRIMARY KEY(transport_id)
);

CREATE TABLE TRANSPORT_EXPENSE(
	transport_id INT FOREIGN KEY REFERENCES TRANSPORT(transport_id),
	maintenance_expense INT,
	fuel_expense INT
);

CREATE TABLE TBL_PACKAGE_TRANSPORT(
	package_id INT FOREIGN KEY REFERENCES PACKAGE(package_id),
	transport_id INT FOREIGN KEY REFERENCES TRANSPORT(transport_id),
	PRIMARY KEY(package_id, transport_id)
);

CREATE TABLE DRIVER(
	driver_id INT,
	PRIMARY KEY(driver_id)
);

CREATE TABLE DRIVER_NAME(
	driver_id INT FOREIGN KEY REFERENCES DRIVER(driver_id),
	driver_f_name VARCHAR(20),
	driver_l_name VARCHAR(20)
);

CREATE TABLE DRIVER_DRIVER_PHONE(
	driver_id INT FOREIGN KEY REFERENCES DRIVER(driver_id),
	driver_phone DECIMAL(10, 0),
	PRIMARY KEY(driver_id, driver_phone)
);

CREATE TABLE TBL_TRANSPORT_DRIVER(
	transport_id INT FOREIGN KEY REFERENCES TRANSPORT(transport_id),
	driver_id INT FOREIGN KEY REFERENCES DRIVER(driver_id),
	PRIMARY KEY(transport_id, driver_id)
);

CREATE TABLE FOOD(
	food_id INT,
	food_weight INT,
	food_name VARCHAR(20),
	food_quantity INT,
	food_type VARCHAR(20),
	food_price INT,
	PRIMARY KEY(food_id)
);

CREATE TABLE TBL_PACKAGE_FOOD(
	package_id INT FOREIGN KEY REFERENCES PACKAGE(package_id),
	food_id INT FOREIGN KEY REFERENCES FOOD(food_id),
	PRIMARY KEY(package_id, food_id)
);

CREATE TABLE DEAL(
	deal_id INT,
	deal_name VARCHAR(20),
	deal_price INT,
	PRIMARY KEY(deal_id)
);

CREATE TABLE TBL_FOOD_DEAL(
	food_id INT FOREIGN KEY REFERENCES FOOD(food_id),
	deal_id INT FOREIGN KEY REFERENCES DEAL(deal_id),
	quantity INT,
	PRIMARY KEY(food_id, deal_id)
);

CREATE TABLE SERVICE(
	service_id INT,
	service_type VARCHAR(50),
	service_price INT,
	PRIMARY KEY(service_id)
);

CREATE TABLE TBL_PACKAGE_SERVICE(
	package_id INT FOREIGN KEY REFERENCES PACKAGE(package_id),
	service_id INT FOREIGN KEY REFERENCES SERVICE(service_id),
	PRIMARY KEY(package_id, service_id)
);

CREATE TABLE CUSTOMER(
	customer_id INT,
	dob DATE,
	PRIMARY KEY(customer_id)
);

CREATE TABLE CUSTOMER_CUSTOMER_NAME(
	customer_id INT FOREIGN KEY REFERENCES CUSTOMER(customer_id),
	customer_f_name VARCHAR(20),
	customer_l_name VARCHAR(20)
);

CREATE TABLE CUSTOMER_CUSTOMER_PHONE(
	customer_id INT FOREIGN KEY REFERENCES CUSTOMER(customer_id),
	customer_phone DECIMAL(10, 0),
	PRIMARY KEY(customer_id, customer_phone)
);

CREATE TABLE CUSTOMER_CUSTOMER_ADDRESS(
	customer_id INT FOREIGN KEY REFERENCES CUSTOMER(customer_id),
	block VARCHAR(20),
	street VARCHAR(100),
	area VARCHAR(20),
	city VARCHAR(20)
);

CREATE TABLE TBL_CUSTOMER_PACKAGE(
	customer_id INT FOREIGN KEY REFERENCES CUSTOMER(customer_id),
	package_id INT FOREIGN KEY REFERENCES PACKAGE(package_id),
	PRIMARY KEY(customer_id, package_id)
);

CREATE TABLE INVOICE(
	invoice_id INT,
	customer_id INT FOREIGN KEY REFERENCES CUSTOMER(customer_id),
	PRIMARY KEY(invoice_id)
);

CREATE TABLE INVOICE_INVOICE_DATE(
	invoice_id INT FOREIGN KEY REFERENCES INVOICE(invoice_id),
	invoice_day INT,
	invoice_month INT,
	invoice_year INT,
	CHECK (invoice_day <= 31),
	CHECK (invoice_month <= 12)
);

INSERT INTO ADMIN_LOGIN VALUES
('admin', '123');

INSERT INTO PACKAGE VALUES
(1, 'Package # 1'),
(2, 'Package # 2'),
(3, 'Package # 3'),
(4, 'Package # 4'),
(5, 'Package # 5');

INSERT INTO EVENT_MODULE VALUES
(1, 'Mehndi', 'Family', '01-22-2021 12:30:00', 40000, 'Desirable & Eye Catching Decoration With Mehendi Themes & Color'),
(2, 'Mayoun', 'Family', '03-05-2021 12:30:00', 50000, 'Desirable & Eye Catching Decoration With Mehendi Themes & Color'),
(3, 'Shadi', 'Family & Friends', '05-01-2021 12:30:00', 60000, 'Desirable & Eye Catching Decoration With Mehendi Themes & Color'),
(4, 'Valime', 'Family & Friends', '06-11-2021 12:30:00', 40000, 'Desirable & Eye Catching Decoration With Mehendi Themes & Color'),
(5, 'Picnic', 'Family & Friends', '12-31-2021 12:30:00', 45000, 'All Desirable Facilities In Reasonable Prices');

INSERT INTO EVENT_MODULE_EVENT_THEME VALUES
(1,'Green & Yellow, Nautical Spree.'),
(2,'Red & Yellow, Yellow & Pink, Yellow & Orange'),
(3,'Blue & Golden, Gardenia, Shimmer & Bling, Rose'),
(4,'Vinatge, Tall Taper Candle, Rose Gold'),
(5,'Flamingo Lauau, Masks & Mimosas');

/*
INSERT INTO TBL_PACKAGE_EVENT_MODULE_EVENT_DATE VALUES
(1, 1, 21, 1, 2021),
(2, 2, 12, 3, 2021),
(3, 3, 18, 12, 2021),
(4, 4, 16, 2, 2021),
(5, 5, 22, 6, 2021);
*/

INSERT INTO TRANSPORT VALUES
(1, 5000, 20, 'Hiace', 10),
(2, 7000, 30, 'Mini Van', 10),
(3, 8000, 40, 'Coach', 10),
(4, 10000, 30, 'Coaster', 10),
(5, 15000, 20, 'Limousine', 10);

INSERT INTO TRANSPORT_EXPENSE VALUES
(1, 2000, 3000),
(2, 3000, 4000),
(3, 4000, 5000),
(4, 5000, 6000),
(5, 8000, 7000);

/* 
INSERT INTO TBL_PACKAGE_TRANSPORT VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);
*/

INSERT INTO DRIVER VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7);

INSERT INTO DRIVER_NAME VALUES
(1, 'Ahmed', 'Mehmood'),
(2, 'Faisal', 'Kashif'),
(3, 'Ishtiaq', 'Ahmed'),
(4, 'Dilbar', 'Hussain'),
(5, 'Shafqat', 'Ali'),
(6, 'Niaz', 'Khan'),
(7, 'Faisal', 'Hassan');

INSERT INTO DRIVER_DRIVER_PHONE VALUES
(1, 03123456789),
(2, 03234567890),
(3, 03896437474),
(4, 03246810123),
(5, 03135791113),
(6, 03987654321),
(7, 03987654321);

INSERT INTO TBL_TRANSPORT_DRIVER VALUES
(1, 2),
(2, 3),
(3, 1),
(4, 6),
(5, 4);

INSERT INTO FOOD VALUES
(1, 20, 'Biryani', 10, 'Desi', 50000),
(2, 20, 'Mutton Karahi', 10, 'Desi', 40000),
(3, 20, 'Qorma', 10, 'Desi', 40000),
(4, 15, 'Tandoori Tikka', 10, 'BBQ', 60000),
(5, 15, 'Tandoori Chicken', 10, 'Desi', 56000),
(6, 10, 'Zarda', 6, 'Sweet', 30000),
(7, 10, 'Lab e Shireen', 7, 'Sweet', 20000),
(8, 10, 'Gajar Ka Halwa', 7, 'Sweet', 20000),
(9, 10, 'Roti & Taftaan', 6, 'Roti', 12000),
(10, 10, 'Parahta', 6, 'Roti', 10000),
(11, 10, 'Soft Drinks', 6, 'Beverages', 8000);

/* 
INSERT INTO TBL_PACKAGE_FOOD VALUES
(1, 1),
(2, 2),
(2, 7),
(3, 3),
(3, 8),
(4, 1),
(4, 4),
(5, 2),
(5, 10),
(5, 11);
*/

INSERT INTO DEAL VALUES
(1, 'Deal # 1', 4000),
(2, 'Deal # 2', 5000),
(3, 'Deal # 3', 8000);

INSERT INTO TBL_FOOD_DEAL VALUES
(1, 1, 10),
(11, 1, 10),
(2, 2, 10),
(10, 2, 10),
(1, 3, 10),
(11, 3, 10);

INSERT INTO SERVICE VALUES
(1, 'Buffet', 15000),
(2, 'Reception', 16000),
(3, 'Decoration', 20000),
(4, 'Lightning', 5000),
(5, 'Catering', 12000),
(6, 'Table Decoration', 8000),
(7, 'Ballons Decoration', 4000),
(8, 'Seasonal Juice And Soups', 10000);

/*
INSERT INTO TBL_PACKAGE_SERVICE VALUES
(1, 6),
(2, 5),
(2, 2),
(3, 1),
(3, 3),
(4, 4),
(4, 7),
(5, 4),
(5, 7),
(5, 8);
*/

INSERT INTO CUSTOMER VALUES 
(1, '12-11-2001'),
(2, '08-08-1985'),
(3, '06-12-1982'),
(4, '12-22-1965'),
(5, '07-03-2000'),
(6, '11-21-2002'),
(7, '05-10-2002'),
(8, '1-21-1999');

INSERT INTO CUSTOMER_CUSTOMER_NAME VALUES
(1, 'Asad', 'Sheikh'),
(2, 'Hadi', 'Khan'),
(3, 'Sameer', 'Ul Haq'),
(4, 'Afnan', 'Ansari'),
(5, 'Saad', 'Asif'),
(6, 'Nomir', 'Nasir'),
(7, 'Ali', 'Muhammad'),
(8, 'Muzammil', 'Ahmed');

INSERT INTO CUSTOMER_CUSTOMER_PHONE VALUES
(1, 03987954898),
(1, 03987954899),
(2, 03865778998),
(3, 03219843986),
(4, 03589532327),
(5, 03798793299),
(6, 03428003200),
(6, 03428003201),
(7, 03787788438),
(8, 03662588433);

INSERT INTO CUSTOMER_CUSTOMER_ADDRESS VALUES
(1, 'D-90', 'Badar Commercial Area', 'Clifton', 'Karachi'),
(2, 'UC-1', 'Lawrence Road', 'Saddar', 'Karachi'),
(3, '2', 'Haji Dilbar', 'Korangi', 'Karachi'),
(4, '6C', 'Streat Lane', 'Landhi', 'Karachi'),
(5, '13-E', 'Afridi House Road', 'Gulshan e Iqbal', 'Karachi'),
(6, 'B-23', 'Tariq Road', 'PECHS', 'Karachi'),
(7, 'D-8', 'Numaish', 'PECHS', 'Karachi'),
(8, 'Sector V', 'Metropolitan Street', 'Gulshan e Maymar', 'Karachi');

/*
INSERT INTO TBL_CUSTOMER_PACKAGE VALUES
(1, 3),
(2, 5),
(3, 3),
(4, 4),
(5, 4),
(6, 1),
(7, 2),
(8, 1);

INSERT INTO INVOICE VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8);

INSERT INTO INVOICE_INVOICE_DATE VALUES
(1, 12, 9, 2021),
(2, 3, 5, 2021),
(3, 17, 2, 2021),
(4, 23, 12, 2021),
(5, 9, 4, 2021),
(6, 29, 8, 2021),
(7, 31, 5, 2021),
(8, 30, 7, 2021);
*/

DROP TABLE PACKAGE;
DROP TABLE EVENT_MODULE;
DROP TABLE EVENT_MODULE_EVENT_THEME;
DROP TABLE TBL_PACKAGE_EVENT_MODULE_EVENT_DATE;
DROP TABLE TRANSPORT;
DROP TABLE TRANSPORT_EXPENSE;
DROP TABLE TBL_PACKAGE_TRANSPORT;
DROP TABLE DRIVER;
DROP TABLE DRIVER_NAME;
DROP TABLE DRIVER_DRIVER_PHONE;
DROP TABLE TBL_TRANSPORT_DRIVER;
DROP TABLE FOOD;
DROP TABLE TBL_PACKAGE_FOOD;
DROP TABLE DEAL;
DROP TABLE TBL_FOOD_DEAL;
DROP TABLE SERVICE;
DROP TABLE TBL_PACKAGE_SERVICE;
DROP TABLE CUSTOMER;
DROP TABLE CUSTOMER_CUSTOMER_NAME;
DROP TABLE CUSTOMER_CUSTOMER_PHONE;
DROP TABLE CUSTOMER_CUSTOMER_ADDRESS;
DROP TABLE TBL_CUSTOMER_PACKAGE;
DROP TABLE INVOICE;
DROP TABLE INVOICE_INVOICE_DATE;
