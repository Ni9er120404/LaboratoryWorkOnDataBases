CREATE TABLE [dbo].[ConstructionRepairs] (
    [Id]                    INT            IDENTITY (1, 1) NOT NULL,
    [Address]               NVARCHAR (MAX) NULL,
    [Square]                FLOAT (53)     NOT NULL,
    [Kind]                  NVARCHAR (MAX) NULL,
    [ConstructionCompanyId] INT            NOT NULL,
    CONSTRAINT [PK_ConstructionRepairs] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ConstructionRepairs_ConstructionCompanies_ConstructionCompanyId] FOREIGN KEY ([ConstructionCompanyId]) REFERENCES [dbo].[ConstructionCompanies] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ConstructionRepairs_ConstructionCompanyId]
    ON [dbo].[ConstructionRepairs]([ConstructionCompanyId] ASC);
