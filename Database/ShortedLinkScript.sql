USE [ShortedLink]
GO
/****** Object:  Table [dbo].[LINK]    Script Date: 16.12.2016 21:40:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LINK](
	[ID] [uniqueidentifier] NOT NULL,
	[ShortLink] [char](6) NOT NULL,
	[LongLink] [nvarchar](max) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[CreatedDate] [smalldatetime] NOT NULL,
	[Password] [nvarchar](20) NULL,
	[Notification] [bit] NOT NULL,
	[ExpireDate] [smalldatetime] NULL,
	[OneShot] [bit] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_Link] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNQ_Link] UNIQUE NONCLUSTERED 
(
	[ShortLink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LINK_LOG]    Script Date: 16.12.2016 21:40:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LINK_LOG](
	[ID] [uniqueidentifier] NOT NULL,
	[LinkID] [uniqueidentifier] NOT NULL,
	[Date_] [datetime] NOT NULL,
	[Referer] [nvarchar](max) NOT NULL,
	[Agent] [varchar](200) NULL,
 CONSTRAINT [PK_LinkLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USER]    Script Date: 16.12.2016 21:40:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[ID] [uniqueidentifier] NOT NULL,
	[EMail] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CreatedDate] [smalldatetime] NOT NULL,
	[UpdateDate] [smalldatetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[LINK]  WITH CHECK ADD  CONSTRAINT [FK_Link_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[USER] ([ID])
GO
ALTER TABLE [dbo].[LINK] CHECK CONSTRAINT [FK_Link_User]
GO
ALTER TABLE [dbo].[LINK_LOG]  WITH CHECK ADD  CONSTRAINT [FK_LinkLog_Link] FOREIGN KEY([LinkID])
REFERENCES [dbo].[LINK] ([ID])
GO
ALTER TABLE [dbo].[LINK_LOG] CHECK CONSTRAINT [FK_LinkLog_Link]
GO
