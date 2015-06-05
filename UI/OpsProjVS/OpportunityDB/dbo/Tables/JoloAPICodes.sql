CREATE TABLE [dbo].[JoloAPICodes] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [Code]        NVARCHAR (100) NOT NULL,
    [CodeType]    NVARCHAR (100) NOT NULL,
    [ServiceType] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_IDJolo] PRIMARY KEY CLUSTERED ([ID] ASC)
);

