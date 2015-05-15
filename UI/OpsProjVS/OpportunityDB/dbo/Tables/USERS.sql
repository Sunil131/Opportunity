CREATE TABLE [dbo].[USERS] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Email]        NVARCHAR (100) NULL,
    [NAME]         NVARCHAR (200) NULL,
    [IsRegistered] BIT            NULL,
    [IsDeleted]    BIT            NULL,
    [CreateOn]     DATETIME       NULL,
    CONSTRAINT [PK_UserID] PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

