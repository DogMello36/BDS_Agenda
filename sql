create table Pessoa (
	id int primary key identity(1,1),
	nome nvarchar(40),
	Endereço nvarchar(40),
	cidade varchar(40),
	email nvarchar(40),
	data_nascimento date
);

select * from Pessoa;
select * from Pessoa where cidade = 'São Paulo';
select * from Pessoa where nome like 'B%';
