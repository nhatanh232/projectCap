create table users(
userID int identity (1,1) primary key,
username varchar(45) not null,
password nvarchar(45) not null,
email nvarchar(45) not null,
phoneNumber varchar(11) not null,
roleId int foreign key references roles(roleID),
createdDate datetime,
updateDate datetime
)
select * from users
create table userRole(
userID int foreign key references users(userID),
roleID int foreign key references roles(roleID)
)

create table roles(
roleID int primary key,
roleName nvarchar(45) not null
)

create table userFood(
foodID int foreign key references food(foodID),
distributorID int foreign key references users(userID),
createdDate datetime
)

create table food(
foodID int primary key,
categoryID int foreign key references categories(categoryID),
providerID int foreign key references users(userID)
)

create table foodDetail(
foodDetailID int primary key,
foodID int foreign key references food(foodID),
createdDate datetime
)

create table categories(
categoryID int primary key,
categoryName nvarchar(45)
)