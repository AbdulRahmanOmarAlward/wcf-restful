USE [WCFRestFull]
GO

CREATE TABLE [dbo].[Article](
	[ID] [int] NULL,
	[Title] [varchar](50) NULL,
	[Contents] [varchar](max) NULL,
	[Author] [varchar](50) NULL,
	[URL] [varchar](50) NULL,
	[BlogID] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Blog]    Script Date: 5/4/2017 10:04:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Blog](
	[ID] [int] NULL,
	[Name] [varchar](50) NULL,
	[URL] [varchar](50) NULL,
	[Owner] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
