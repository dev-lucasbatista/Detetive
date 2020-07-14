CREATE TABLE dbo.JOGADOR_SALA 
(
  ID_JOGADOR_SALA     INT IDENTITY(1,1) PRIMARY KEY,
  ID_JOGADOR          INT FOREIGN KEY REFERENCES JOGADOR(ID_JOGADOR) NOT NULL,
  ID_SALA             INT FOREIGN KEY REFERENCES SALA(ID_SALA) NOT NULL,
  ID_SUSPEITO         INT FOREIGN KEY REFERENCES SUSPEITO(ID_SUSPEITO) NULL,
  ID_LOCAL			  INT FOREIGN KEY REFERENCES LOCAL(ID_LOCAL) NULL,
  NR_ORDER            INT NOT NULL,
  NR_PASSAGEM_SECRETA INT DEFAULT 3,
  IE_VEZ              BIT DEFAULT 0,
  NR_COLUNA           INT NOT NULL,
  NR_LINHA            INT NOT NULL,
  QT_MOVIMENTO        INT DEFAULT 0,
  IE_ROLARDADOS       BIT DEFAULT 0,
  IE_REALIZARPALPITE  BIT DEFAULT 0,
  IE_JOGANDO          BIT DEFAULT 1,
  IE_ATIVO            BIT DEFAULT 1
)