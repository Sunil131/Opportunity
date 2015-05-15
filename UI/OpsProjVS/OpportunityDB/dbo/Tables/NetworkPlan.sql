CREATE TABLE [dbo].[NetworkPlan] (
    [ID]               INT             IDENTITY (1, 1) NOT NULL,
    [NetworkID]        INT             NULL,
    [UserNumerID]      INT             NULL,
    [Amount]           MONEY           NOT NULL,
    [Validity]         INT             DEFAULT ((0)) NOT NULL,
    [MisDescription1]  NVARCHAR (1000) NULL,
    [MisDescription2]  NVARCHAR (1000) NULL,
    [MisDescription3]  NVARCHAR (1000) NULL,
    [MisDescription4]  NVARCHAR (1000) NULL,
    [MisDescription5]  NVARCHAR (1000) NULL,
    [MisDescription6]  NVARCHAR (1000) NULL,
    [MisDescription7]  NVARCHAR (1000) NULL,
    [MisDescription8]  NVARCHAR (1000) NULL,
    [MisDescription9]  NVARCHAR (1000) NULL,
    [MisDescription10] NVARCHAR (1000) NULL,
    CONSTRAINT [PK_NETWORKPLAN_ID] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_NetworkID_NetworkPlan] FOREIGN KEY ([NetworkID]) REFERENCES [dbo].[Network] ([ID]),
    CONSTRAINT [FK_NetworkPlan_UserNumberID] FOREIGN KEY ([UserNumerID]) REFERENCES [dbo].[UserNumber] ([ID])
);

