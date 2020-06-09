CREATE TABLE dbo.SUSPEITO 
(
  ID_SUSPEITO   INT IDENTITY(1,1) PRIMARY KEY,
  DS_SUSPEITO   VARCHAR(100) NOT NULL,
  ID_LOCAL      INT FOREIGN KEY REFERENCES LOCAL(ID_LOCAL) NULL,
  IE_ATIVO      BIT DEFAULT 1
)