CREATE TABLE dbo.LOCAL(
  ID_LOCAL      INT IDENTITY(1,1) PRIMARY KEY,
  DS_LOCAL      VARCHAR(100) NOT NULL,
  NR_LINHA_1	INT NOT NULL,
  NR_COLUNA_1	INT NOT NULL,
  NR_LINHA_2	INT NOT NULL,
  NR_COLUNA_2	INT NOT NULL,
  IE_ATIVO      BIT DEFAULT 1
)