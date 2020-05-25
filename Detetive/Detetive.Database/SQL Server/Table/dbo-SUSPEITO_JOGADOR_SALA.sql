CREATE TABLE dbo.SUSPEITO_JOGADOR_SALA(
  ID_SUSPEITO_JOGADOR_SALA INT IDENTITY(1,1) PRIMARY KEY,
  ID_JOGADOR_SALA		   INT FOREIGN KEY REFERENCES JOGADOR(ID_JOGADOR) NOT NULL,
  ID_SUSPEITO              INT FOREIGN KEY REFERENCES SUSPEITO(ID_SUSPEITO) NOT NULL,
  IE_ATIVO				   BIT DEFAULT 1
)