create table tipo_utilizador(
	id_tipo_utilizador	integer identity(1,1) primary key,
	descricao			varchar(20) not null
	);

create table Utilizador(
	id_utilizador		integer identity(1,1) primary key,
	username			varchar(30) not null,
	pass				varchar(30) not null check(len(pass)>5),
	nome				varchar(50) not null,
	nif					varchar(9) not null check(len(nif)>0 and len(nif)<10),
	idade				integer not null check(idade>16),
	localidade			varchar(50) not null,
	id_tipo_utilizador	integer not null,
	saldo				money not null default 0,
	movimentos			nvarchar(150), 
	foreign key (id_tipo_utilizador) references tipo_utilizador(id_tipo_utilizador)
	);

create table teatro(
	id_teatro			integer identity(1,1) primary key,
	nome_teatro			varchar(30) not null,
	morada_teatro		varchar(50) not null,
	localizacao			varchar(30)  not null,
	telemovel			integer not null,
	telefone			integer not null,
	email				varchar(50) not null
);


create table sessao(
	id_sessao			integer identity(1,1) primary key,
	data_sessao			date not null,
	hora_inicio			time not null,
	hora_fim			time not null,
	lugar_totais		integer not null,
	lugares_disponiveis	integer not null
	
);


create table espetaculo(
	id_espetaculo		integer identity(1,1) primary key,
	nome				varchar(50) not null,
	sinopse				varchar(100) not null, 
	data_inicio			date not null,
	data_fim			date not null,
	preco				money not null check(preco > 0)
);


create table regista_espetaculo(
	id_registo			integer identity(1,1) primary key,
	id_sessao			integer not null,
	id_espetaculo		integer not null,
	id_teatro			integer not null,
	foreign key (id_sessao) references sessao(id_sessao),
	foreign key (id_espetaculo) references espetaculo(id_espetaculo),
	foreign key (id_teatro) references teatro(id_teatro)
);

create table reserva(
	id_reserva			integer identity(1,1) primary key,
	data_reserva		date not null check(data_reserva >= getdate()),
	quantidade			integer not null check(quantidade > 0),
	id_registo			integer not null,
	foreign key (id_registo) references regista_espetaculo(id_registo)

);

create table comprar_bilhete(
	id_compra			integer identity(1,1) primary key,
	id_utilizador		integer not null,
	id_reserva			integer not null,
	total_pagar			money not null check(total_pagar > 0),
	referencia_pagamento integer not null,
	foreign key (id_utilizador) references Utilizador(id_utilizador),
	foreign key (id_reserva) references reserva(id_reserva)

);

