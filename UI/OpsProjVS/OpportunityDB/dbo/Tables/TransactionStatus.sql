CREATE TABLE [dbo].[TransactionStatus] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [StatusName] NVARCHAR (300) NOT NULL,
    CONSTRAINT [PK_TransactionStatus] PRIMARY KEY CLUSTERED ([ID] ASC)
);

