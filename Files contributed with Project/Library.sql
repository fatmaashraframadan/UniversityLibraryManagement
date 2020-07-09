create database Library_Management_System

/*==============================================================*/
/* Table: ADMIN */
/*==============================================================*/
create table ADMIN (
AD_ID numeric(6) primary key not null,
NAME varchar(20) null,
E_MAIL varchar(20) null,
PHONE numeric(20) null,
SEX varchar(10) null,
DOB datetime null,
SALARY numeric(5) null,
HOURS numeric(2) null,
ADDRESS varchar(30) null
)
/*==============================================================*/
/* Table: ADVANCE_BORROW */
/*==============================================================*/
create table ADVANCE_BORROW (
ID2 numeric(6) not null,
ISBN numeric(6) not null
)
go

alter table ADVANCE_BORROW
add constraint PK_ADVANCE_BORROW primary key nonclustered (ID2, ISBN)
go

/*==============================================================*/
/* Index: ADVANCE_BORROW2_FK */
/*==============================================================*/
create index ADVANCE_BORROW2_FK on ADVANCE_BORROW (
ISBN ASC
)
go

/*==============================================================*/
/* Index: ADVANCE_BORROW_FK */
/*==============================================================*/
create index ADVANCE_BORROW_FK on ADVANCE_BORROW (
ID2 ASC
)
go

alter table ADVANCE_BORROW
add constraint FK_ADVANCE__ADVANCE_B_PROFFESS foreign key (ID2)
references PROFFESSOR (ID2)
go

alter table ADVANCE_BORROW
add constraint FK_ADVANCE__ADVANCE_B_BOOK foreign key (ISBN)
references BOOK (ISBN)
go

/*==============================================================*/
/* Table: BOOK */
/*==============================================================*/
create table BOOK (
ISBN numeric(6) not null,
PUB_ID numeric(6) not null,
CAT_ID numeric(6) not null,
TITLE varchar(30) null,
LANGUAGE varchar(10) null,
NUM_OF_PAGES numeric(6) null,
YEAR numeric(6) null,
PRICE numeric(6) null,
AVAILABLE numeric(3) null,
AUTHOR varchar(20) null
)
go

alter table BOOK
add constraint PK_BOOK primary key nonclustered (ISBN)
go

/*==============================================================*/
/* Index: PUBLISHED_BY_FK */
/*==============================================================*/
create index PUBLISHED_BY_FK on BOOK (
PUB_ID ASC
)
go

/*==============================================================*/
/* Index: BOOK_BY_CATEGORY_FK */
/*==============================================================*/
create index BOOK_BY_CATEGORY_FK on BOOK (
CAT_ID ASC
)
go

alter table BOOK
add constraint FK_BOOK_BOOK_BY_C_CATEGORY foreign key (CAT_ID)
references CATEGORY (CAT_ID)
go

alter table BOOK
add constraint FK_BOOK_PUBLISHED_PUBLISHE foreign key (PUB_ID)
references PUBLISHER (PUB_ID)
go

/*==============================================================*/
/* Table: BORROWED_BY */
/*==============================================================*/
create table BORROWED_BY (
STU_ID numeric(6) not null,
ISBN numeric(6) not null,
START_DATE datetime null,
END_DATE datetime null
)
go

alter table BORROWED_BY
add constraint PK_BORROWED_BY primary key nonclustered (STU_ID, ISBN)
go

/*==============================================================*/
/* Index: BORROWED_BY2_FK */
/*==============================================================*/
create index BORROWED_BY2_FK on BORROWED_BY (
ISBN ASC
)
go

/*==============================================================*/
/* Index: BORROWED_BY_FK */
/*==============================================================*/
create index BORROWED_BY_FK on BORROWED_BY (
STU_ID ASC
)
go

alter table BORROWED_BY
add constraint FK_BORROWED_BORROWED__STUDENT foreign key (STU_ID)
references STUDENT (STU_ID)
go

alter table BORROWED_BY
add constraint FK_BORROWED_BORROWED__BOOK foreign key (ISBN)
references BOOK (ISBN)
go

/*==============================================================*/
/* Table: CATEGORY */
/*==============================================================*/
create table CATEGORY (
NAME varchar(20) null,
CAT_ID numeric(6) not null
)
go

alter table CATEGORY
add constraint PK_CATEGORY primary key nonclustered (CAT_ID)
go

/*==============================================================*/
/* Table: MANAGED_BY */
/*==============================================================*/
create table MANAGED_BY (
ISBN numeric(6) not null,
AD_ID numeric(6) not null,
UPDATE_TYPE varchar(20) null,
UPDATE_TIME datetime null
)
go

alter table MANAGED_BY
add constraint PK_MANAGED_BY primary key nonclustered (ISBN, AD_ID)
go

/*==============================================================*/
/* Index: MANAGED_BY2_FK */
/*==============================================================*/
create index MANAGED_BY2_FK on MANAGED_BY (
AD_ID ASC
)
go

/*==============================================================*/
/* Index: MANAGED_BY_FK */
/*==============================================================*/
create index MANAGED_BY_FK on MANAGED_BY (
ISBN ASC
)
go

alter table MANAGED_BY
add constraint FK_MANAGED__MANAGED_B_BOOK foreign key (ISBN)
references BOOK (ISBN)
go

alter table MANAGED_BY
add constraint FK_MANAGED__MANAGED_B_ADMIN foreign key (AD_ID)
references ADMIN (AD_ID)
go

/*==============================================================*/
/* Table: PROFFESSOR */
/*==============================================================*/
create table PROFFESSOR (
ID2 numeric(6) not null,
NAME varchar(20) null,
E_MAIL varchar(20) null,
PHONE numeric(20) null,
SEX varchar(10) null,
DOB datetime null,
ADDRESS varchar(30) null
)
go

alter table PROFFESSOR
add constraint PK_PROFFESSOR primary key nonclustered (ID2)
go

/*==============================================================*/
/* Table: PUBLISHER */
/*==============================================================*/
create table PUBLISHER (
PUB_ID numeric(6) not null,
NAME varchar(20) null,
ADDRESS varchar(30) null
)
go

alter table PUBLISHER
add constraint PK_PUBLISHER primary key nonclustered (PUB_ID)
go

/*==============================================================*/
/* Table: STUDENT */
/*==============================================================*/
create table STUDENT (
STU_ID numeric(6) not null,
NAME varchar(20) null,
E_MAIL varchar(20) null,
PHONE numeric(20) null,
SEX varchar(10) null,
DOB datetime null,
ADDRESS varchar(30) null
)
go

alter table STUDENT
add constraint PK_STUDENT primary key nonclustered (STU_ID)
go