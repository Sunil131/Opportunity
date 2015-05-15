GO

/****** Object: Table [dbo].[NetworkCircle] Script Date: 4/24/2015 2:26:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NetworkCircle] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (50) NOT NULL,
    [State] NCHAR (10)    NOT NULL
);


GO

/****** Object: Table [dbo].[NetworkPlan] Script Date: 4/24/2015 2:26:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NetworkPlan] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [NetworkID]         INT            NOT NULL,
    [NumberTypeID]      INT            NOT NULL,
    [PlanName]          NVARCHAR (100) NOT NULL,
    [Amount]            MONEY          NOT NULL,
    [Validity]          INT            NOT NULL,
    [MiscDescription1]  NVARCHAR (100) NULL,
    [MiscDescription2]  NVARCHAR (100) NULL,
    [MiscDescription3]  NVARCHAR (100) NULL,
    [MiscDescription4]  NVARCHAR (100) NULL,
    [MiscDescription5]  NVARCHAR (100) NULL,
    [MiscDescription6]  NVARCHAR (100) NULL,
    [MiscDescription7]  NVARCHAR (100) NULL,
    [MiscDescription8]  NVARCHAR (100) NULL,
    [MiscDescription9]  NVARCHAR (100) NULL,
    [MiscDescription10] NVARCHAR (100) NULL
);



GO

/****** Object: Table [dbo].[Networks] Script Date: 4/24/2015 2:26:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Networks] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (MAX) NULL,
    [NetworkCircleID] INT            NOT NULL
);



GO

/****** Object: Table [dbo].[NumberType] Script Date: 4/24/2015 2:26:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NumberType] (
    [Id]          INT        IDENTITY (1, 1) NOT NULL,
    [NumberType]  NCHAR (10) NOT NULL,
    [Description] NCHAR (10) NULL,
    [CreatedOn]   NCHAR (10) NULL
);



GO

/****** Object: Table [dbo].[TransactionStatus] Script Date: 4/24/2015 2:27:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TransactionStatus] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Status] NVARCHAR (50) NOT NULL
);



GO

/****** Object: Table [dbo].[User] Script Date: 4/24/2015 2:27:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Email]        NVARCHAR (200) NOT NULL,
    [Name]         NVARCHAR (100) NOT NULL,
    [IsRegistered] BIT            NOT NULL,
    [IsDeleted]    NCHAR (10)     NOT NULL,
    [CreatedOn]    DATETIME       NULL
);



GO

/****** Object: Table [dbo].[UserNumber] Script Date: 4/24/2015 2:27:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserNumber] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [UserId]       INT           NOT NULL,
    [NumberTypeId] INT           NOT NULL,
    [Number]       NVARCHAR (50) NOT NULL,
    [CreatedOn]    DATETIME      NULL
);



GO

/****** Object: Table [dbo].[UserPassword] Script Date: 4/24/2015 2:27:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserPassword] (
    [Id]        INT            NOT NULL,
    [Password]  NVARCHAR (100) NOT NULL,
    [UserId]    INT            NOT NULL,
    [CreatedOn] DATETIME       NOT NULL
);



GO

/****** Object: Table [dbo].[UserTransaction] Script Date: 4/24/2015 2:27:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserTransaction] (
    [Id]                  INT      IDENTITY (1000, 1) NOT NULL,
    [UserID]              INT      NOT NULL,
    [NetworkPlanID]       INT      NOT NULL,
    [Amount]              MONEY    NOT NULL,
    [TransactionStatusId] INT      NOT NULL,
    [CreatedOn]           DATETIME NOT NULL
);






