create database SkyProject
go

use SkyProject 

create table Clerk --店员表
(
Uid varchar(20) not null, --用户名
Password varchar(20) not null, --密码
ClerkName nvarchar(10) not null, --姓名
Sex nvarchar(1) not null, --性别
Telephone varchar(11) not null, --电话号码
IDNumber varchar(18) not null, --身份证号码
Address nvarchar(50) --地址
)
go

alter table Clerk
add constraint PK_ClerkUid
 primary key(Uid)
 go

create table Client--客户表
(
ClientNo varchar(20) not null, --客户编号
ClientName nvarchar(10) not null, --姓名
Sex nvarchar(1) not null, --性别
Telephone varchar(11) not null --电话号码
)
go

alter table Client
add constraint PK_ClientNo
 primary key(ClientNo)
 go

create table Supplier --供应商表
(
SupplierNo varchar(20) not null, --供应商编号
SupplierName nvarchar(10) not null, --姓名
Telephone varchar(11) not null --电话号码
)
go

alter table Supplier
add constraint PK_SupplierNo
 primary key(SupplierNo)
 go

create table Keeper --仓管员表
(
Uid varchar(20) not null, --用户名
Password varchar(20) not null, --密码
KeeperName nvarchar(10) not null, --姓名
Sex nvarchar(1) not null, --性别
Telephone varchar(11) not null, --电话号码
IDNumber varchar(18) not null, --身份证号码
Address nvarchar(50) --地址
)
go

alter table Keeper
add constraint PK_KeeperUid
 primary key(Uid)
 go

create table Command --商品表
(
CommandNo varchar(20) not null, --商品编号
CommandName nvarchar(10) not null, --商品名
CommandNum int not null, --商品数量
CommandUnit varchar(10) not null --商品规格（单位）
)
go

alter table Command
add constraint PK_CommandNo
 primary key(CommandNo)
 go

 create table Purchase --进货单
 (
 PurchaseID varchar(20) not null, --进货单编号
 SupplierNo varchar(20) not null, --供应商编号
 CommandNo varchar(20) not null, --商品编号
 CommandNum int not null, --商品数量
 CommandUnit varchar(10) not null, --商品规格（单位）
 PurchaseDate datetime not null, --进货日期
 Uid varchar(20) not null, --仓管员编号
 )
 go 

--主键约束
 alter table Purchase
add constraint PK_PurchaseID
 primary key(PurchaseID)
 go 
 --外键约束
 alter table Purchase 
 add constraint FK_SupplierNo
 foreign Key(SupplierNo)
 references Supplier(SupplierNo)
 go	
 alter table Purchase 
 add constraint FK_PurchaseCommandNo
 foreign Key(CommandNo)
 references Command(CommandNo)
 go
 alter table Purchase 
 add constraint FK_KeeperUid01
 foreign Key(Uid)
 references Keeper(Uid)
 go

 create table Sales --销售单
 (
 SalesID varchar(20) not null, --销售单编号
 ClientNo varchar(20) not null, --客户编号
 CommandNo varchar(20) not null, --商品编号
 CommandNum int not null, --商品数量
 CommandUnit varchar(10) not null, --商品规格（单位）
 SalesDate datetime not null, --销售日期
 Uid varchar(20) not null, --店员编号
 States nvarchar(10) not null --状态
 )
 go 

--主键约束
 alter table Sales
add constraint PK_SalesID
 primary key(SalesID)
 go 
 --外键约束
 alter table Sales 
 add constraint FK_ClientNo
 foreign Key(ClientNo)
 references Client(ClientNo)
 go
 alter table Sales 
 add constraint FK_SalesCommandNo
 foreign Key(CommandNo)
 references Command(CommandNo)
 go
 alter table Sales 
 add constraint FK_ClerkUid01
 foreign Key(Uid)
 references Clerk(Uid)
 go
 --默认约束
 alter table Sales 
 add constraint DF_SalesStates
 default('处理中') for States
 go


 create table Picking --提货单
 (
 PickingID varchar(20) not null, --提货单编号
 CommandNo varchar(20) not null, --商品编号
 CommandNum int not null, --商品数量
 CommandUnit varchar(10) not null, --商品规格（单位）
 PickingDate datetime not null, --提货日期
 Uid varchar(20) not null, --店员编号
 States nvarchar(10) not null --状态
 )
 go 

--主键约束
 alter table Picking
add constraint PK_PickingID
 primary key(PickingID)
 go 
 --外键约束

 alter table Picking 
 add constraint FK_PickingCommandNo
 foreign Key(CommandNo)
 references Command(CommandNo)
 go
 alter table Picking
 add constraint FK_ClerkUid02
 foreign Key(Uid)
 references Clerk(Uid)
 go
 --默认约束
 alter table Picking 
 add constraint DF_PickingStates
 default('处理中') for States
 go

 create table Output --出库单
 (
 OutputID varchar(20) not null, --出库单编号
 CommandNo varchar(20) not null, --商品编号
 CommandNum int not null, --商品数量
 CommandUnit varchar(10) not null, --商品规格（单位）
 OutputDate datetime not null, --出库日期
 Uid varchar(20) not null, --仓管员编号
 States nvarchar(10) not null --状态
 )
 go 

--主键约束
 alter table Output
add constraint PK_OutputID
 primary key(OutputID)
 go 
 --外键约束

 alter table Output 
 add constraint FK_OutputCommandNo
 foreign Key(CommandNo)
 references Command(CommandNo)
 go
 alter table Output
 add constraint FK_KeeperUid02
 foreign Key(Uid)
 references Keeper(Uid)
 go
 --默认约束
 alter table Output 
 add constraint DF_OutputStates
 default('处理中') for States
 go


 declare @SupplierNo char(10),@SupplierName char(10),@Telephone char(10)
 set @SupplierNo='22'
 set @SupplierName ='22'
 set @Telephone = '22'
 insert into Supplier select @SupplierNo,@SupplierName,@Telephone



