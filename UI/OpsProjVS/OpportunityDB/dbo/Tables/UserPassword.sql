CREATE TABLE [dbo].[UserPassword] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [UserID]    INT            NULL,
    [Password]  NVARCHAR (100) NULL,
    [CreatedOn] DATETIME       NULL,
    [IsActive]  BIT            NULL,
    CONSTRAINT [PK_Pwd] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_USERID_USER_ID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[USERS] ([ID])
);

