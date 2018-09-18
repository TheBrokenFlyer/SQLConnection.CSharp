use master;
go
 drop database banco;
go
 create database banco;
go
 use banco;

go
 create table tbEstadocivil (
	estadocivil varchar(11) unique
)
insert into tbEstadocivil(estadocivil) values
	('solteiro(a)'),
	('casado(a)'),
	('outro');

go
 create table tbPessoa (
	id_pessoa int identity(1,1) NOT NULL,
	pessoa_nome varchar(64) NOT NULL,
	pessoa_endereco varchar(128) NOT NULL,
	pessoa_estadocivil varchar(11) NOT NULL default 'solteiro(a)',
	pessoa_nasc date NOT NULL,
	
	primary key (id_pessoa),
	foreign key (pessoa_estadocivil) references tbEstadocivil(estadocivil)
)

go
 create table tbFuncionario (
	id_funcionario int identity(1,1) NOT NULL,
	id_pessoa int unique NOT NULL,
	funcionario_salario decimal NOT NULL,
	funcionario_ramal int,
	
	primary key (id_funcionario),
	foreign key (id_pessoa) references tbPessoa(id_pessoa)
)

go
 create table tbCliente (
	id_cliente int identity(1,1) NOT NULL,
	id_pessoa int unique NOT NULL,
	cliente_inclusao datetime NOT NULL default GETDATE()
	
	primary key (id_cliente),
	foreign key (id_pessoa) references tbPessoa(id_pessoa)
)
