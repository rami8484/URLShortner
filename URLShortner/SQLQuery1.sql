create database words
on primary
(NAME = Storage, FILENAME = 'd:\words.mdf')
log on
(NAME = StorageLog, FILENAME = 'd:\words.ldf')
use words
create table words
(ID int identity(1,1),
Word varchar(1000) not null)