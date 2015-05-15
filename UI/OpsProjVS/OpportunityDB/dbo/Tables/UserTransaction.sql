CREATE TABLE [dbo].[UserTransaction] (
    [ID]                  INT      IDENTITY (1, 1) NOT NULL,
    [UserID]              INT      NULL,
    [NetworkPlanID]       INT      NULL,
    [TransactionStatusID] INT      NOT NULL,
    [Amount]              MONEY    NULL,
    [CreateOn]            DATETIME NULL,
    CONSTRAINT [PK_UserTransaction] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TransactionStatusID] FOREIGN KEY ([TransactionStatusID]) REFERENCES [dbo].[TransactionStatus] ([ID])
);

