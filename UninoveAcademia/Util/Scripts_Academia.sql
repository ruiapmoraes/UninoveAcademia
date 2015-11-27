-- Criando tabela de Login
Create Table Login (
	Codigo int Primary Key,
	Usuario Varchar(8) Not Null,
	Senha Varchar(8) Not Null,
	Tipo_Usuario Varchar Not Null,
	Data_Criacao DateTime Not Null
)

-- Área de Testes
INSERT INTO Login (Codigo, Usuario, Senha, Tipo_Usuario, Data_Criacao)
	Values (1, 'ruimorae', '123456', 'P', '2015-11-27')

	ALTER TABLE Login add Data_Criacao DateTime

	delete from Login

	select usuario, senha from Login Where usuario = 'ruimora' and senha = '123456'

	select usuario, senha from Login