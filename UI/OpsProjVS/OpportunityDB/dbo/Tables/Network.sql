CREATE TABLE [dbo].[Network] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [NetworkCircleID] INT            NULL,
    [Name]            NVARCHAR (200) NULL,
    CONSTRAINT [PK_NETWORK_ID] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_NetworkCircle_ID] FOREIGN KEY ([NetworkCircleID]) REFERENCES [dbo].[NetworkCircle] ([ID])
);

