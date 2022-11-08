CREATE TABLE [dbo].[BuildingMaterials] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Count]          INT            NOT NULL,
    [Action]         NVARCHAR (MAX) NULL,
    [TeamOfWorkerId] INT            NOT NULL,
    CONSTRAINT [PK_BuildingMaterials] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BuildingMaterials_TeamOfWorkers_TeamOfWorkerId] FOREIGN KEY ([TeamOfWorkerId]) REFERENCES [dbo].[TeamOfWorkers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_BuildingMaterials_TeamOfWorkerId]
    ON [dbo].[BuildingMaterials]([TeamOfWorkerId] ASC);