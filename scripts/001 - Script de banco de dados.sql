IF OBJECT_ID(N'[AplicaoSCIMVC]') IS NULL
BEGIN
    CREATE TABLE [AplicaoSCIMVC] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK_AplicaoSCIMVC] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Categ] (
    [Id] int NOT NULL IDENTITY,
    [Status] BIT NOT NULL DEFAULT (1),
    [Marca] BIT NOT NULL DEFAULT (1),
    [Data_Inc] datetime2 NOT NULL DEFAULT (GETDATE()),
    [Data_Alt] datetime2 NULL,
    [Data_Hab] datetime2 NULL,
    [Nome] VARCHAR(25) NOT NULL,
    [Grupo] VARCHAR(25) NOT NULL,
    CONSTRAINT [PK_Categ] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Livros] (
    [Id] int NOT NULL IDENTITY,
    [Status] BIT NOT NULL DEFAULT (1),
    [Marca] BIT NOT NULL DEFAULT (1),
    [Data_Inc] datetime2 NOT NULL DEFAULT (GETDATE()),
    [Data_Alt] datetime2 NULL,
    [Data_Hab] datetime2 NULL,
    [ISBN] VARCHAR(13) NOT NULL,
    [Titulo] VARCHAR(50) NOT NULL,
    [CategoriaId] int NOT NULL,
    [P_Venda] DECIMAL(16,2) NULL,
    [P_Custo] DECIMAL(16,2) NULL,
    [Base_Calc] DECIMAL(16,2) NULL,
    [Formatado] VARCHAR(15) NULL,
    [NPaginas] SMALLINT NULL,
    [Edicao] SMALLINT NULL,
    [Ano] SMALLINT NULL,
    [Peso] DECIMAL(16,2) NULL,
    [Loc] VARCHAR(10) NULL,
    [Resenha] VARCHAR(1000) NULL,
    [Capa] VARCHAR(100) NULL,
    [Promo] BIT NOT NULL DEFAULT (0),
    [Est_Min] INT NULL,
    [Est_Disp] INT NULL,
    [QtDoac] INT NULL,
    [QtCons] INT NULL,
    [QtVend] INT NULL,
    CONSTRAINT [PK_Livros] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Livros_Categ_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categ] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Livros_CategoriaId] ON [Livros] ([CategoriaId]);

GO

CREATE INDEX [titulo_Livros] ON [Livros] ([Titulo]);

GO

INSERT INTO [AplicaoSCIMVC] ([MigrationId], [ProductVersion])
VALUES (N'20210306055105_Inicio', N'3.1.12');

GO

