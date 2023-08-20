## Sobre

Desenvolvimento de um sistema CRUD para o registro de clientes, implementado em C# e Windows Forms.

## Banco de Dados

<code>
  
CREATE TABLE Genero(
id_genero INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
nomeGenero VARCHAR(20)
)

CREATE TABLE Cliente(
id_Cliente INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
nome_Cliente VARCHAR(100) NOT NULL,
sobrenome VARCHAR(100),
dataNascimento DATE NOT NULL,
numTelefone VARCHAR(20),
Rua VARCHAR(50),
numero VARCHAR(10),
cep VARCHAR(10),
Bairro VARCHAR(50),
Cidade VARCHAR(50),
UF VARCHAR (2),

id_genero INT,
FOREIGN KEY(id_genero) REFERENCES genero(id_genero)

ativo INT
)

INSERT INTO genero(nomeGenero) VALUE('FEMININO')
INSERT INTO genero(nomeGenero) VALUE('MASCULINO')
INSERT INTO genero(nomeGenero) VALUE('OUTROS')

</code>

Link do arquivo .bak para download: 
[Link do](https://drive.google.com/file/d/1vnvShEP7mK-pHl91RImy7nCG9UndNr14/view?usp=sharing)https://drive.google.com/file/d/1vnvShEP7mK-pHl91RImy7nCG9UndNr14/view?usp=sharing
