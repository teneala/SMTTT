create table customer 
(
	ID int,
    firstname varchar(40),
    lastname varchar(40),
    emailAddress varchar(40),
    phonenumber int,
    customerpassword varchar(40),
    city varchar(40),
    state varchar(40),
    street varchar(40),
    cardnumber int,
    securitynumber int,
    zipcode int,
    cardtype varchar(40),
    
    Primary Key (ID)
    
    
);

create table employee 
(
	ID int,
    firstname varchar(40),
    lastname varchar(40),
    emailAddress varchar(40),
    phonenumber int,
    employeepassword varchar(40)
    
);

create table product
(
	
	productname varchar(40),
    serialnumber int,
    brand varchar(40),
    color varchar(40),
    price double,
    producttype varchar(40),
    availability bool,
    quantity int
    
    );
    

create table orders
(
	orderid int,
    ordertype bool,
	Foreign Key (orderid) References customer(ID)

    
)
