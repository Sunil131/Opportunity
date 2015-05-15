CREATE TABLE [dbo].[UserNumber] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [NumerTypeID] INT           NULL,
    [Number]      NVARCHAR (30) NULL,
    [CreateOn]    DATETIME      NULL,
    CONSTRAINT [PK_USER_NUMBER_ID] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_NUMBERTYPE] FOREIGN KEY ([NumerTypeID]) REFERENCES [dbo].[NumberType] ([ID])
);

