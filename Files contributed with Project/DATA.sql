select * from BOOK 
select * from BORROWED_BY 
select * from ADMIN
select * from PROFFESSOR
select * from ADVANCE_BORROW
select * from MANAGED_BY
select * from PUBLISHER
select * from CATEGORY
select * from STUDENT

insert into PUBLISHER values (111,'Pearson','UK');
insert into PUBLISHER values (222,'Reed Elsevier','US');
insert into PUBLISHER values (333,'ThomsonReuters','CANADA');
insert into PUBLISHER values (444,'Wolters Kluwer','Germany');
insert into PUBLISHER values (555,'Random House','France');
insert into PUBLISHER values (666,'Hachette Livre','Spain');
insert into PUBLISHER values (777,'Grupo Planeta','US');
insert into PUBLISHER values (888,'Holtzbrinck','Germany');
insert into PUBLISHER values (999,'Scholastic (corp.)','US');
insert into PUBLISHER values (055,'Cengage','US');

insert into CATEGORY values ('Horror',11);
insert into CATEGORY values ('Adventure',22);
insert into CATEGORY values ('Comedy',33);
insert into CATEGORY values ('Fantasy',44);
insert into CATEGORY values ('Drama',55);
insert into CATEGORY values ('Slice of life',66);
insert into CATEGORY values ('Science Fiction',77);
insert into CATEGORY values ('Cooking',88);
insert into CATEGORY values ('Sports',99);
insert into CATEGORY values ('Tragedy',55);

insert into BOOK values (21,111,11,'The Lord of the Rings','ENG',750,1998,60,10,'J. R. R. Tolkien');
insert into BOOK values (22,222,22,'A Tale of Two Cities','ENG',850,1998,70,5,'Charles Dickens');
insert into BOOK values (23,555,99,'The Little Prince','ENG',1055,2005,35,2,'Antoine de Saint');
insert into BOOK values (24,444,88,'Harry Potter','ENG',2500,2006,40,10,'J. K. Rowling');
insert into BOOK values (25,222,44,'The Hobbit','ENG',450,2010,45,5,'J. R. R. Tolkien');
insert into BOOK values (26,555,55,'Alices Adventures','ENG',800,2015,20,10,'Lewis Carroll');
insert into BOOK values (27,777,11,'Dream of the Red Chamber','ENG',900,1997,30,5,'Cao Xueqin');
insert into BOOK values (28,888,77,'And Then There Were None','ENG',750,1990,60,10,'Agatha Christie');
insert into BOOK values (29,222,88,'The Da Vinci Code','ENG',600,1992,60,3,'Dan Brown');
insert into BOOK values (20,111,66,'The Alchemist','ENG',750,1990,55,4,'Paulo Coelho');

insert into STUDENT values (170021,'Ahmed Sayed','ahmed@yahoo.com',01100261796 ,'Male',26-12-1998,'51-khatab');
insert into STUDENT values (170022,'Fatma Ashraf','fatma@yahoo.com',01100261799 ,'Female',26-11-1998,'33-zamalek');
insert into STUDENT values (170023,'Ashraf Samir','ashraf@yahoo.com',01100261798 ,'Male',26-10-1998,'44-helwan');
insert into STUDENT values (170024,'Abdo Okasha','abdo@yahoo.com',01100261797 ,'Male',26-9-1998,'22-khatab');
insert into STUDENT values (170025,'Belal Hamdy','belal@yahoo.com',01100261755 ,'Male',26-8-1998,'10-helwan');
insert into STUDENT values (170026,'Ahmed Dardery','ahmed11@yahoo.com',01100261766 ,'Male',26-7-1998,'20-zamalek');
insert into STUDENT values (170027,'Abo-Taleb','taleb@yahoo.com',01100261744 ,'Male',26-6-1998,'7-zamalek');
insert into STUDENT values (170028,'ebrahim ramadan','hema555@yahoo.com',01100261777 ,'Male',26-5-1998,'8-zaytoun');
insert into STUDENT values (170029,'Mohammed Mostafa','streamer@yahoo.com',011002617922 ,'Male',26-4-1998,'9-zamalek');
insert into STUDENT values (170030,'Esraa Taha','esraa@yahoo.com',01100261711,'Female',26-3-1998,'4-zaytoun');

insert into PROFFESSOR values (101,'Emad Nabil','emad@yahoo.com',01100261796 ,'Male',26-12-1998,'51-khatab');
insert into PROFFESSOR values (102,'El-Ramly','ramly@yahoo.com',01100261796 ,'Male',26-12-1998,'22-Zamalek');
insert into PROFFESSOR values (103,'Esraa Ali','esraa@yahoo.com',01100261796 ,'Female',26-12-1998,'51-Helwan');
insert into PROFFESSOR values (104,'Lubna Hassan','lubna@yahoo.com',01100261796 ,'Female',26-12-1998,'02-roksy');
insert into PROFFESSOR values (105,'Ahmed Mansour','ahmed@yahoo.com',01100261796 ,'Male',26-12-1998,'51-Helwan');
insert into PROFFESSOR values (106,'khaled Esmaat','a.esmaat@yahoo.com',01100261796 ,'Male',26-12-1998,'08-khatab');
insert into PROFFESSOR values (107,'Mina Nabil','mina@yahoo.com',01100261796 ,'Male',26-12-1998,'66-roksy');
insert into PROFFESSOR values (108,'Amany','amany@yahoo.com',01100261796 ,'Female',26-12-1998,'51-Helwan');
insert into PROFFESSOR values (109,'Mazen Ali','mazen@yahoo.com',01100261796 ,'Male',26-12-1998,'80-roksy');
insert into PROFFESSOR values (110,'Yara Ali','yara@yahoo.com',01100261796 ,'Female',26-12-1998,'30-Helwan');

insert into ADMIN values (201,'Emad Nabil','emad22@yahoo.com',01100261796 ,'Male',26-12-1998,3000,8,'51-khatab');
insert into ADMIN values (202,'El-Ramly','ramly1@yahoo.com',01100261796 ,'Male',26-12-1998,3500,8,'22-Zamalek');
insert into ADMIN values (203,'Esraa Ali','esraa1@yahoo.com',01100261796 ,'Female',26-12-1998,3500,8,'51-Helwan');
insert into ADMIN values (204,'Lubna Hassan','lubna1@yahoo.com',01100261796 ,'Female',26-12-1998,3000,8,'02-roksy');
insert into ADMIN values (205,'Ahmed Mansour','ahmed2@yahoo.com',01100261796 ,'Male',26-12-1998,3500,8,'51-Helwan');
insert into ADMIN values (206,'Ali Esmaat','a.esmaat1@yahoo.com',01100261796 ,'Male',26-12-1998,2500,8,'08-khatab');
insert into ADMIN values (207,'Mina Nabil','mina1@yahoo.com',01100261796 ,'Male',26-12-1998,3500,8,'66-roksy');
insert into ADMIN values (208,'Amany','amany1@yahoo.com',01100261796 ,'Female',26-12-1998,3000,8,'51-Helwan');
insert into ADMIN values (209,'Mazen Ali','mazen1@yahoo.com',01100261796 ,'Male',26-12-1998,2500,8,'80-roksy');
insert into ADMIN values (210,'Yara Ali','yara1@yahoo.com',01100261796 ,'Female',26-12-1998,3500,8,'30-Helwan');