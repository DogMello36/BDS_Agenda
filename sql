
create table Pessoa(
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

insert into Pessoa (nome, Endereço, cidade, email, data_nascimento) values
('João do Grau', 'Rua da Empinada, 157', 'Sorocaba', 'joao.grau@email.com', '1998-04-12'),

('Maria do Café', 'Alameda Expresso Duplo, 42', 'Campinas', 'maria.cafe@email.com', '1995-08-23'),

('Carlos Wi-Fi', 'Rua Sem Sinal, 404', 'São Paulo', 'carlos.wifi@email.com', '1992-11-15'),

('Ana Pixel', 'Travessa HD 4K, 2160', 'Curitiba', 'ana.pixel@email.com', '2001-02-28'),

('Roberto do Churras', 'Rua Picanha Suprema, 999', 'Porto Alegre', 'roberto.churras@email.com', '1988-09-07'),

('Fernanda Fofoca', 'Viela Ouvi Dizer, 13', 'Belo Horizonte', 'fernanda.fofoca@email.com', '1997-06-19'),

('Lucas Bugado', 'Rua Null Pointer, 500', 'Recife', 'lucas.bugado@email.com', '1999-12-01'),

('Patrícia VPN', 'Avenida Conexao Segura, 443', 'Florianópolis', 'patricia.vpn@email.com', '1994-03-10'),

('Thiago Gamer', 'Rua Respawn Infinito, 777', 'Fortaleza', 'thiago.gamer@email.com', '2000-07-21'),

('Juliana do Pix', 'Rua Caiu na Conta, 123', 'Rio de Janeiro', 'juliana.pix@email.com', '1996-05-30'),

('Ricardo SQL', 'Avenida Select Tudo, 1', 'São Paulo', 'ricardo.sql@email.com', '1991-10-14'),

('Camila Meme', 'Travessa Viralizou, 2024', 'Salvador', 'camila.meme@email.com', '1998-01-08'),

('Pedro Estagiario', 'Rua Faz Aí Rapidinho, 88', 'Sorocaba', 'pedro.estagio@email.com', '2003-09-17'),

('Vanessa KPI', 'Avenida Meta Batida, 100', 'Campinas', 'vanessa.kpi@email.com', '1990-04-05'),

('Eduardo Deploy', 'Rua Sexta Feira 18h, 666', 'São José dos Campos', 'eduardo.deploy@email.com', '1993-11-29');
