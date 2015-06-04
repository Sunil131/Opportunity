CREATE TABLE [dbo].[Network] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (200) NULL,
    [NetworkCode]  NVARCHAR (5)   NOT NULL,
    [NetworkImage] NVARCHAR (50)  NULL,
    CONSTRAINT [PK_NETWORK_ID] PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([NetworkCode] ASC)
);





