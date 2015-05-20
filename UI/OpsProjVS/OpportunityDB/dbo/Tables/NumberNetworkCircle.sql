CREATE TABLE [dbo].[NumberNetworkCircle] (
    [ID]                INT          IDENTITY (1, 1) NOT NULL,
    [NumberStartup]     INT          NOT NULL,
    [NetworkCode]       NVARCHAR (5) NULL,
    [NetworkCircleCode] NVARCHAR (5) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([NumberStartup] ASC)
);

