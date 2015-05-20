CREATE TABLE [dbo].[NetworkCircle] (
    [ID]                       INT           IDENTITY (1, 1) NOT NULL,
    [OpertorCircleCode]        NVARCHAR (5)  NOT NULL,
    [OpertorCircleDescription] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_NetworkCircle_ID] PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([OpertorCircleCode] ASC)
);



