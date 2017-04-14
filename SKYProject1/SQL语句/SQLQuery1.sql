create database SkyProject
go

use SkyProject 

create table Clerk --��Ա��
(
Uid varchar(20) not null, --�û���
Password varchar(20) not null, --����
ClerkName nvarchar(10) not null, --����
Sex nvarchar(1) not null, --�Ա�
Telephone varchar(11) not null, --�绰����
IDNumber varchar(18) not null, --���֤����
Address nvarchar(50) --��ַ
)
go

alter table Clerk
add constraint PK_ClerkUid
 primary key(Uid)
 go

create table Client--�ͻ���
(
ClientNo varchar(20) not null, --�ͻ����
ClientName nvarchar(10) not null, --����
Sex nvarchar(1) not null, --�Ա�
Telephone varchar(11) not null --�绰����
)
go

alter table Client
add constraint PK_ClientNo
 primary key(ClientNo)
 go

create table Supplier --��Ӧ�̱�
(
SupplierNo varchar(20) not null, --��Ӧ�̱��
SupplierName nvarchar(10) not null, --����
Telephone varchar(11) not null --�绰����
)
go

alter table Supplier
add constraint PK_SupplierNo
 primary key(SupplierNo)
 go

create table Keeper --�ֹ�Ա��
(
Uid varchar(20) not null, --�û���
Password varchar(20) not null, --����
KeeperName nvarchar(10) not null, --����
Sex nvarchar(1) not null, --�Ա�
Telephone varchar(11) not null, --�绰����
IDNumber varchar(18) not null, --���֤����
Address nvarchar(50) --��ַ
)
go

alter table Keeper
add constraint PK_KeeperUid
 primary key(Uid)
 go

create table Command --��Ʒ��
(
CommandNo varchar(20) not null, --��Ʒ���
CommandName nvarchar(10) not null, --��Ʒ��
CommandNum int not null, --��Ʒ����
CommandUnit varchar(10) not null --��Ʒ��񣨵�λ��
)
go

alter table Command
add constraint PK_CommandNo
 primary key(CommandNo)
 go

 create table Purchase --������
 (
 PurchaseID varchar(20) not null, --���������
 SupplierNo varchar(20) not null, --��Ӧ�̱��
 CommandNo varchar(20) not null, --��Ʒ���
 CommandNum int not null, --��Ʒ����
 CommandUnit varchar(10) not null, --��Ʒ��񣨵�λ��
 PurchaseDate datetime not null, --��������
 Uid varchar(20) not null, --�ֹ�Ա���
 )
 go 

--����Լ��
 alter table Purchase
add constraint PK_PurchaseID
 primary key(PurchaseID)
 go 
 --���Լ��
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

 create table Sales --���۵�
 (
 SalesID varchar(20) not null, --���۵����
 ClientNo varchar(20) not null, --�ͻ����
 CommandNo varchar(20) not null, --��Ʒ���
 CommandNum int not null, --��Ʒ����
 CommandUnit varchar(10) not null, --��Ʒ��񣨵�λ��
 SalesDate datetime not null, --��������
 Uid varchar(20) not null, --��Ա���
 States nvarchar(10) not null --״̬
 )
 go 

--����Լ��
 alter table Sales
add constraint PK_SalesID
 primary key(SalesID)
 go 
 --���Լ��
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
 --Ĭ��Լ��
 alter table Sales 
 add constraint DF_SalesStates
 default('������') for States
 go


 create table Picking --�����
 (
 PickingID varchar(20) not null, --��������
 CommandNo varchar(20) not null, --��Ʒ���
 CommandNum int not null, --��Ʒ����
 CommandUnit varchar(10) not null, --��Ʒ��񣨵�λ��
 PickingDate datetime not null, --�������
 Uid varchar(20) not null, --��Ա���
 States nvarchar(10) not null --״̬
 )
 go 

--����Լ��
 alter table Picking
add constraint PK_PickingID
 primary key(PickingID)
 go 
 --���Լ��

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
 --Ĭ��Լ��
 alter table Picking 
 add constraint DF_PickingStates
 default('������') for States
 go

 create table Output --���ⵥ
 (
 OutputID varchar(20) not null, --���ⵥ���
 CommandNo varchar(20) not null, --��Ʒ���
 CommandNum int not null, --��Ʒ����
 CommandUnit varchar(10) not null, --��Ʒ��񣨵�λ��
 OutputDate datetime not null, --��������
 Uid varchar(20) not null, --�ֹ�Ա���
 States nvarchar(10) not null --״̬
 )
 go 

--����Լ��
 alter table Output
add constraint PK_OutputID
 primary key(OutputID)
 go 
 --���Լ��

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
 --Ĭ��Լ��
 alter table Output 
 add constraint DF_OutputStates
 default('������') for States
 go


 declare @SupplierNo char(10),@SupplierName char(10),@Telephone char(10)
 set @SupplierNo='22'
 set @SupplierName ='22'
 set @Telephone = '22'
 insert into Supplier select @SupplierNo,@SupplierName,@Telephone



