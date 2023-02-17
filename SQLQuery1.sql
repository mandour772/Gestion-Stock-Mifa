create database Gestion_stock_mifa
use Gestion_stock_mifa

create table client(
idc int primary key not null identity(1,1),
nomc varchar(20)not null,
prenom varchar(20)not null,
telephone int not null,
email varchar(80)not null)

create table produit(
idproduit int primary key not null identity(1,1),
nomp varchar(20)not null,
prix float not null,
ncategorie int references categorie (ncategorie) not null,
quantite int not null,
)


