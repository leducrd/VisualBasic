CREATE TABLE [dbo].[Mayor] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [MayorName]    VARCHAR (50) NULL,
    [MayorTown]    VARCHAR (50) NULL,
    [CatalogueNum] INT          NULL,
    [FishNum]      INT          NULL,
    [InsectNum]    INT          NULL,
    [SeafoodNum]   INT          NULL,
    [MayorInfo]    VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
