USE [Paraglider]
GO
/****** Object:  Table [dbo].[Certificate]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificate](
    [Id] [int] NOT NULL,
    [Label] [varchar](50) NOT NULL,
    [Id_Level] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fly]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fly](
    [Id] [int] NOT NULL,
    [DateFly] [date] NULL,
    [Duration] [time](7) NULL,
    [Id_LandingSite] [int] NOT NULL,
    [Id_LaunchingSite] [int] NOT NULL,
    [Id_PILOT] [smallint] NOT NULL,
    [Id_Paraglider] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FONCTION]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FONCTION](
    [Id] [int] NOT NULL,
    [Label] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Internship]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Internship](
    [Id] [int] NOT NULL,
    [StartDate] [date] NULL,
    [EndDate] [date] NULL,
    [Price] [decimal](15, 2) NULL,
    [Id_Certificate] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LandingSite]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LandingSite](
    [Id] [int] NOT NULL,
    [Name] [varchar](100) NULL,
    [Orientation] [text] NULL,
    [Description] [varchar](100) NULL,
    [Id_Level] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LaunchingSite]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LaunchingSite](
    [Id] [int] NOT NULL,
    [Name] [varchar](100) NULL,
    [Orientation] [text] NULL,
    [Description] [varchar](250) NULL,
    [Id_Level] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Level]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Level](
    [Id] [int] NOT NULL,
    [Label] [varchar](50) NULL,
    [Description] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberShipFee]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberShipFee](
    [AmountYear] [date] NOT NULL,
    [Amount] [decimal](15, 2) NULL,
PRIMARY KEY CLUSTERED 
(
    [AmountYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obtain]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obtain](
    [Id] [smallint] NOT NULL,
    [Id_Certificate] [int] NOT NULL,
    [ObtainingDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC,
    [Id_Certificate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paraglider]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paraglider](
    [Id] [int] NOT NULL,
    [ServiceDate] [date] NULL,
    [LastUseService] [date] NULL,
    [Id_Level] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParagliderModel]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParagliderModel](
    [Id] [int] NOT NULL,
    [NumberOfHomologation] [varchar](50) NOT NULL,
    [HomologationDate] [varchar](50) NULL,
    [Size] [decimal](15, 2) NULL,
    [MinWeight] [decimal](15, 2) NULL,
    [MaxWeight] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
    [NumberOfHomologation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pay]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pay](
    [Id] [smallint] NOT NULL,
    [AmountYear] [date] NOT NULL,
    [DateCotisation] [date] NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC,
    [AmountYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PILOT]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PILOT](
    [Id] [smallint] NOT NULL,
    [LastName] [varchar](100) NULL,
    [FirstName] [varchar](100) NULL,
    [Weight] [decimal](15, 2) NULL,
    [Adress] [varchar](300) NULL,
    [Tel] [varchar](100) NULL,
    [Id_FONCTION] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supervise]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supervise](
    [Id] [smallint] NOT NULL,
    [Id_Internship] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC,
    [Id_Internship] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Take]    Script Date: 18-02-20 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Take](
    [Id] [smallint] NOT NULL,
    [Id_Internship] [int] NOT NULL,
    [examen] [bit] NOT NULL,
    [Payement] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC,
    [Id_Internship] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Certificate]  WITH CHECK ADD FOREIGN KEY([Id_Level])
REFERENCES [dbo].[Level] ([Id])
GO
ALTER TABLE [dbo].[Fly]  WITH CHECK ADD FOREIGN KEY([Id_LandingSite])
REFERENCES [dbo].[LandingSite] ([Id])
GO
ALTER TABLE [dbo].[Fly]  WITH CHECK ADD FOREIGN KEY([Id_LaunchingSite])
REFERENCES [dbo].[LaunchingSite] ([Id])
GO
ALTER TABLE [dbo].[Fly]  WITH CHECK ADD FOREIGN KEY([Id_Paraglider])
REFERENCES [dbo].[Paraglider] ([Id])
GO
ALTER TABLE [dbo].[Fly]  WITH CHECK ADD FOREIGN KEY([Id_PILOT])
REFERENCES [dbo].[PILOT] ([Id])
GO
ALTER TABLE [dbo].[Internship]  WITH CHECK ADD FOREIGN KEY([Id_Certificate])
REFERENCES [dbo].[Certificate] ([Id])
GO
ALTER TABLE [dbo].[LandingSite]  WITH CHECK ADD FOREIGN KEY([Id_Level])
REFERENCES [dbo].[Level] ([Id])
GO
ALTER TABLE [dbo].[LaunchingSite]  WITH CHECK ADD FOREIGN KEY([Id_Level])
REFERENCES [dbo].[Level] ([Id])
GO
ALTER TABLE [dbo].[Obtain]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[PILOT] ([Id])
GO
ALTER TABLE [dbo].[Obtain]  WITH CHECK ADD FOREIGN KEY([Id_Certificate])
REFERENCES [dbo].[Certificate] ([Id])
GO
ALTER TABLE [dbo].[Paraglider]  WITH CHECK ADD FOREIGN KEY([Id_Level])
REFERENCES [dbo].[ParagliderModel] ([Id])
GO
ALTER TABLE [dbo].[Pay]  WITH CHECK ADD FOREIGN KEY([AmountYear])
REFERENCES [dbo].[MemberShipFee] ([AmountYear])
GO
ALTER TABLE [dbo].[Pay]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[PILOT] ([Id])
GO
ALTER TABLE [dbo].[PILOT]  WITH CHECK ADD FOREIGN KEY([Id_FONCTION])
REFERENCES [dbo].[FONCTION] ([Id])
GO
ALTER TABLE [dbo].[supervise]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[PILOT] ([Id])
GO
ALTER TABLE [dbo].[supervise]  WITH CHECK ADD FOREIGN KEY([Id_Internship])
REFERENCES [dbo].[Internship] ([Id])
GO
ALTER TABLE [dbo].[Take]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[PILOT] ([Id])
GO
ALTER TABLE [dbo].[Take]  WITH CHECK ADD FOREIGN KEY([Id_Internship])
REFERENCES [dbo].[Internship] ([Id])
GO
