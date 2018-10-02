use master;
go
 drop database banco;
go
 create database banco;
go
 use banco;

go
 create table tbProduto (
	idProduto int primary key identity(0,1) not null,
	produtoNome varchar(64) not null unique,
	produtoDesc varchar(512),
	produtoQtd int check(produtoQtd >-1) not null,
	produtoValor decimal check(produtoValor >0) not null,
	produtoDataLote date not null default GETDATE(),
	produtoDataValidade date not null check(produtoDataValidade >GETDATE())
)