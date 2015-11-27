-- Criando tabela de Login
Create Table Login (
	Codigo int Primary Key,
	Usuario Varchar(8) Not Null,
	Senha Varchar(8) Not Null,
	Tipo_Usuario Varchar Not Null,
	Data_Criacao DateTime Not Null
)