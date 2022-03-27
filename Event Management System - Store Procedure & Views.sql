CREATE VIEW VIEW_CUSTOMER AS
(SELECT c.customer_id, ccn.customer_f_name, ccn.customer_l_name, c.dob, datediff(YY, dob, getdate()) AS age, ccp.customer_phone, cca.block, cca.street, cca.area, cca.city FROM CUSTOMER c
INNER JOIN CUSTOMER_CUSTOMER_NAME ccn ON c.customer_id = ccn.customer_id
INNER JOIN CUSTOMER_CUSTOMER_PHONE ccp ON c.customer_id = ccp.customer_id
INNER JOIN CUSTOMER_CUSTOMER_ADDRESS cca ON c.customer_id = cca.customer_id);

CREATE VIEW VIEW_ALL_PACKAGE AS
(SELECT INVOICE.invoice_id, CUSTOMER.customer_id, PACKAGE.package_id, EVENT_MODULE.event_id, TRANSPORT.transport_id, DRIVER.driver_id, FOOD.food_id, DEAL.deal_id, SERVICE.service_id, 
customer_f_name, customer_l_name, block, street, area, city, package_name, event_name, event_type, event_date_time, event_price, event_description, event_theme, 
transport_price, transport_seater, transport_type, driver_f_name, driver_l_name, driver_phone, food_name, food_price, deal_name, deal_price, service_type, service_price, 
(event_price + transport_price + food_price + deal_price + service_price) AS amount FROM PACKAGE
INNER JOIN TBL_PACKAGE_EVENT_MODULE_EVENT_DATE ON PACKAGE.package_id = TBL_PACKAGE_EVENT_MODULE_EVENT_DATE.package_id
INNER JOIN EVENT_MODULE ON TBL_PACKAGE_EVENT_MODULE_EVENT_DATE.event_id = EVENT_MODULE.event_id
INNER JOIN EVENT_MODULE_EVENT_THEME ON TBL_PACKAGE_EVENT_MODULE_EVENT_DATE.event_id = EVENT_MODULE_EVENT_THEME.event_id
INNER JOIN TBL_PACKAGE_TRANSPORT ON PACKAGE.package_id = TBL_PACKAGE_TRANSPORT.package_id
INNER JOIN TRANSPORT ON TBL_PACKAGE_TRANSPORT.transport_id = TRANSPORT.transport_id
INNER JOIN TRANSPORT_EXPENSE ON TRANSPORT_EXPENSE.transport_id = TRANSPORT.transport_id
INNER JOIN TBL_TRANSPORT_DRIVER ON TBL_TRANSPORT_DRIVER.transport_id = TRANSPORT.transport_id
INNER JOIN DRIVER ON TBL_TRANSPORT_DRIVER.driver_id = DRIVER.driver_id
INNER JOIN DRIVER_NAME ON DRIVER_NAME.driver_id = DRIVER.driver_id
INNER JOIN DRIVER_DRIVER_PHONE ON DRIVER_DRIVER_PHONE.driver_id = DRIVER.driver_id
INNER JOIN TBL_PACKAGE_FOOD ON PACKAGE.package_id = TBL_PACKAGE_FOOD.package_id
INNER JOIN FOOD ON TBL_PACKAGE_FOOD.food_id = FOOD.food_id
INNER JOIN TBL_FOOD_DEAL ON TBL_FOOD_DEAL.food_id = FOOD.food_id
INNER JOIN DEAL ON TBL_FOOD_DEAL.deal_id = DEAL.deal_id
INNER JOIN TBL_PACKAGE_SERVICE ON PACKAGE.package_id = TBL_PACKAGE_SERVICE.package_id
INNER JOIN SERVICE ON TBL_PACKAGE_SERVICE.service_id = SERVICE.service_id
INNER JOIN TBL_CUSTOMER_PACKAGE ON TBL_CUSTOMER_PACKAGE.package_id = PACKAGE.package_id
INNER JOIN CUSTOMER ON TBL_CUSTOMER_PACKAGE.customer_id = CUSTOMER.customer_id
INNER JOIN CUSTOMER_CUSTOMER_NAME ON CUSTOMER_CUSTOMER_NAME.customer_id = CUSTOMER.customer_id
INNER JOIN CUSTOMER_CUSTOMER_PHONE ON CUSTOMER_CUSTOMER_PHONE.customer_id = CUSTOMER.customer_id
INNER JOIN CUSTOMER_CUSTOMER_ADDRESS ON CUSTOMER_CUSTOMER_ADDRESS.customer_id = CUSTOMER.customer_id
INNER JOIN INVOICE ON CUSTOMER.customer_id = INVOICE.customer_id
INNER JOIN INVOICE_INVOICE_DATE ON INVOICE_INVOICE_DATE.invoice_id = INVOICE.invoice_id);

SELECT * FROM VIEW_CUSTOMER;
SELECT * FROM VIEW_ALL_PACKAGE;

CREATE PROC SP_INSERT_CUSTOMER
	@customer_id INT,
	@dob DATE,
	@customer_f_name VARCHAR(20),
	@customer_l_name VARCHAR(20),
	@customer_phone DECIMAL(10, 0),
	@block VARCHAR(20),
	@street VARCHAR(100),
	@area VARCHAR(20),
	@city VARCHAR(20)
AS
BEGIN
	INSERT INTO CUSTOMER VALUES
	(@customer_id, @dob);
	INSERT INTO CUSTOMER_CUSTOMER_NAME VALUES
	(@customer_id, @customer_f_name, @customer_l_name);
	INSERT INTO CUSTOMER_CUSTOMER_PHONE VALUES
	(@customer_id, @customer_phone);
	INSERT INTO CUSTOMER_CUSTOMER_ADDRESS VALUES
	(@customer_id, @block, @street, @area, @city);
END

CREATE PROC SP_UPDATE_CUSTOMER
	@customer_id INT,
	@dob DATE,
	@customer_f_name VARCHAR(20),
	@customer_l_name VARCHAR(20),
	@customer_phone DECIMAL(10, 0),
	@block VARCHAR(20),
	@street VARCHAR(100),
	@area VARCHAR(20),
	@city VARCHAR(20)
AS
BEGIN
	UPDATE CUSTOMER SET dob = @dob WHERE customer_id = @customer_id;
	UPDATE CUSTOMER_CUSTOMER_NAME SET customer_f_name = @customer_f_name, customer_l_name = @customer_l_name WHERE customer_id = @customer_id;
	UPDATE CUSTOMER_CUSTOMER_PHONE SET customer_phone = @customer_phone WHERE customer_id = @customer_id;
	UPDATE CUSTOMER_CUSTOMER_ADDRESS SET block = @block, street = @street, area = @area, city = @city WHERE customer_id = @customer_id;
END

CREATE PROC SP_DELETE_CUSTOMER
	@customer_id INT
AS
BEGIN
	DELETE FROM CUSTOMER_CUSTOMER_ADDRESS WHERE customer_id = @customer_id;
	DELETE FROM CUSTOMER_CUSTOMER_PHONE WHERE customer_id = @customer_id;
	DELETE FROM CUSTOMER_CUSTOMER_NAME WHERE customer_id = @customer_id;
	DELETE FROM CUSTOMER WHERE customer_id = @customer_id;
END

CREATE PROC SP_VIEW_CUSTOMER
AS
BEGIN
	SELECT CUSTOMER.customer_id, customer_f_name, customer_l_name, dob, datediff(YY, dob, getdate()) AS age, customer_phone, block, street, area, city FROM CUSTOMER
	INNER JOIN CUSTOMER_CUSTOMER_NAME ON CUSTOMER.customer_id = CUSTOMER_CUSTOMER_NAME.customer_id
	INNER JOIN CUSTOMER_CUSTOMER_PHONE ON CUSTOMER.customer_id = CUSTOMER_CUSTOMER_PHONE.customer_id
	INNER JOIN CUSTOMER_CUSTOMER_ADDRESS ON CUSTOMER.customer_id = CUSTOMER_CUSTOMER_ADDRESS.customer_id
END

CREATE PROC SP_INSERT_EVENT
	@event_id INT,
	@event_name VARCHAR(20), 
	@event_type VARCHAR(20), 
	@event_date_time DATETIME, 
	@event_price INT, 
	@event_description VARCHAR(100), 
	@event_theme VARCHAR(100)
AS
BEGIN
	INSERT INTO EVENT_MODULE VALUES
	(@event_id, @event_name, @event_type, @event_date_time, @event_price, @event_description);
	INSERT INTO EVENT_MODULE_EVENT_THEME VALUES
	(@event_id, @event_theme);
END

CREATE PROC SP_DELETE_EVENT
	@event_id INT
AS
BEGIN
	DELETE FROM EVENT_MODULE_EVENT_THEME WHERE event_id = @event_id;
	DELETE FROM EVENT_MODULE WHERE event_id = @event_id;
END

CREATE PROC SP_INSERT_TRANSPORT
	@transport_id INT,
	@transport_price INT, 
	@transport_seater INT, 
	@transport_type VARCHAR(20), 
	@transport_quantity INT, 
	@maintenance_expense INT, 
	@fuel_expense INT
AS
BEGIN
	INSERT INTO TRANSPORT VALUES
	(@transport_id, @transport_price, @transport_seater, @transport_type, @transport_quantity);
	INSERT INTO TRANSPORT_EXPENSE VALUES
	(@transport_id, @maintenance_expense, @fuel_expense);
END

CREATE PROC SP_DELETE_TRANSPORT
	@transport_id INT
AS
BEGIN
	DELETE FROM TRANSPORT_EXPENSE WHERE transport_id = @transport_id;
	DELETE FROM TRANSPORT WHERE transport_id = @transport_id;
END

CREATE PROC SP_VIEW_TRANSPORT
AS
BEGIN
	SELECT TRANSPORT.transport_id, transport_price, transport_seater, transport_type, transport_quantity, maintenance_expense, fuel_expense, (maintenance_expense + fuel_expense) AS expense FROM TRANSPORT INNER JOIN TRANSPORT_EXPENSE ON TRANSPORT.transport_id = TRANSPORT_EXPENSE.transport_id;
END

CREATE PROC SP_INSERT_SERVICE
	@service_id INT,
	@service_type VARCHAR(50),
	@service_price INT
AS
BEGIN
	INSERT INTO SERVICE VALUES
	(@service_id, @service_type, @service_price);
END

CREATE PROC SP_DELETE_SERVICE
	@service_id INT
AS
BEGIN
	DELETE FROM SERVICE WHERE service_id = @service_id;
END

CREATE PROC SP_VIEW_SERVICE
AS
BEGIN
	SELECT service_id, service_type, service_price FROM SERVICE;
END

CREATE PROC SP_INSERT_FOOD
	@food_id INT,
	@food_weight INT,
	@food_name VARCHAR(20),
	@food_quantity INT,
	@food_type VARCHAR(20),
	@food_price INT
AS
BEGIN
	INSERT INTO FOOD VALUES(@food_id, @food_weight, @food_name, @food_quantity, @food_type, @food_price);
END

CREATE PROC SP_VIEW_FOOD
AS
BEGIN
	SELECT FOOD.food_id, food_weight, food_name, food_quantity, food_type, food_price FROM FOOD;
END

CREATE PROC SP_DELETE_FOOD
	@food_id INT
AS
BEGIN
	DELETE FROM FOOD WHERE food_id = @food_id;
END

CREATE PROC SP_INSERT_DEAL
	@deal_id INT,
	@deal_name VARCHAR(20),
	@deal_price INT
AS
BEGIN
	INSERT INTO DEAL VALUES(@deal_id, @deal_name, @deal_price);
END

CREATE PROC SP_DELETE_DEAL
	@deal_id INT
AS
BEGIN
	DELETE FROM DEAL WHERE deal_id = @deal_id;
END

CREATE PROC SP_VIEW_DEAL
AS
BEGIN
	SELECT * FROM DEAL;
END

CREATE PROC SP_INSERT_FOOD_DEAL
	@food_id INT,
	@deal_id INT,
	@quantity INT
AS
BEGIN
	INSERT INTO TBL_FOOD_DEAL VALUES(@food_id, @deal_id, @quantity);
END

CREATE PROC SP_DELETE_FOOD_DEAL
	@food_id INT,
	@deal_id INT
AS
BEGIN
	DELETE FROM TBL_FOOD_DEAL WHERE food_id = @food_id AND deal_id = @deal_id;
END

CREATE PROC SP_VIEW_FOOD_DEAL
AS
BEGIN
	SELECT * FROM TBL_FOOD_DEAL;
END

CREATE PROC SP_INSERT_PACKAGE
	@event_id INT,
	@transport_id INT,
	@food_id INT,
	@service_id INT,
	@package_id INT,
	@customer_id INT
AS
BEGIN
	INSERT INTO TBL_PACKAGE_EVENT_MODULE_EVENT_DATE(package_id, event_id) VALUES(@package_id, @event_id);
	INSERT INTO TBL_PACKAGE_TRANSPORT VALUES(@package_id, @transport_id);
	INSERT INTO TBL_PACKAGE_FOOD VALUES(@package_id, @food_id);
	INSERT INTO TBL_PACKAGE_SERVICE VALUES(@package_id, @service_id);
	INSERT INTO TBL_CUSTOMER_PACKAGE VALUES(@customer_id, @package_id);
END

CREATE PROC SP_VIEW_PACKAGE
AS
BEGIN
	SELECT PACKAGE.package_id, CUSTOMER.customer_id, EVENT_MODULE.event_id, TRANSPORT.transport_id, FOOD.food_id, SERVICE.service_id, 
	event_price, transport_price, food_price, service_price, (event_price + transport_price + food_price + service_price) AS total FROM PACKAGE
	INNER JOIN TBL_PACKAGE_EVENT_MODULE_EVENT_DATE ON PACKAGE.package_id = TBL_PACKAGE_EVENT_MODULE_EVENT_DATE.package_id
	INNER JOIN EVENT_MODULE ON TBL_PACKAGE_EVENT_MODULE_EVENT_DATE.event_id = EVENT_MODULE.event_id
	INNER JOIN TBL_PACKAGE_TRANSPORT ON PACKAGE.package_id = TBL_PACKAGE_TRANSPORT.package_id
	INNER JOIN TRANSPORT ON TBL_PACKAGE_TRANSPORT.transport_id = TRANSPORT.transport_id
	INNER JOIN TRANSPORT_EXPENSE ON TRANSPORT_EXPENSE.transport_id = TRANSPORT.transport_id
	INNER JOIN TBL_PACKAGE_FOOD ON PACKAGE.package_id = TBL_PACKAGE_FOOD.package_id
	INNER JOIN FOOD ON TBL_PACKAGE_FOOD.food_id = FOOD.food_id
	INNER JOIN TBL_PACKAGE_SERVICE ON PACKAGE.package_id = TBL_PACKAGE_SERVICE.package_id
	INNER JOIN SERVICE ON TBL_PACKAGE_SERVICE.service_id = SERVICE.service_id
	INNER JOIN TBL_CUSTOMER_PACKAGE ON TBL_CUSTOMER_PACKAGE.package_id = PACKAGE.package_id
	INNER JOIN CUSTOMER ON TBL_CUSTOMER_PACKAGE.customer_id = CUSTOMER.customer_id
	INNER JOIN CUSTOMER_CUSTOMER_NAME ON CUSTOMER_CUSTOMER_NAME.customer_id = CUSTOMER.customer_id;
END
