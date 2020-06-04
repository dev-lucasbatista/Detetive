CREATE TABLE dbo.LOCAL_PORTA(
	ID_LOCAL_PORTA	INT IDENTITY(1,1) PRIMARY KEY,
	ID_LOCAL		INT	FOREIGN KEY REFERENCES LOCAL(ID_LOCAL) NOT NULL,
	NR_LINHA_1		INT NOT NULL,
	NR_COLUNA_1		INT NOT NULL,
	NR_LINHA_2		INT NOT NULL,
	NR_COLUNA_2		INT NOT NULL,
	IE_ATIVO		BIT DEFAULT 1
)