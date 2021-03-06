﻿USE [Parapente]
GO
/****** Object:  Table [dbo].[BREVET]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BREVET](
	[Id_Brevet] [int] NOT NULL,
	[Label] [varchar](50) NOT NULL,
	[Id_Niveau] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Brevet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COTISATION]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COTISATION](
	[Id_Cotisation] [int] NOT NULL,
	[Montant] [decimal](15, 2) NULL,
	[AnnéeCotisation] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cotisation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Encadre]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Encadre](
	[Id_Pilote] [int] NOT NULL,
	[Id_Stage] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pilote] ASC,
	[Id_Stage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FONCTION]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FONCTION](
	[Id_Fonction] [int] NOT NULL,
	[Label] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Fonction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MODELE_PARAPENTE]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODELE_PARAPENTE](
	[Id_Modele] [int] NOT NULL,
	[NumeroHomologation] [varchar](50) NOT NULL,
	[dateHomologation] [varchar](50) NULL,
	[Taille] [decimal](15, 2) NULL,
	[PoidsMin] [decimal](15, 2) NULL,
	[PoidMax] [decimal](15, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Modele] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NumeroHomologation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NIVEAU]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NIVEAU](
	[Id_Niveau] [int] NOT NULL,
	[Intitulé] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Niveau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obtient]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obtient](
	[Id_Pilote] [int] NOT NULL,
	[Id_Brevet] [int] NOT NULL,
	[DateObtention] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pilote] ASC,
	[Id_Brevet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PARAPENTE]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARAPENTE](
	[Id_Parapente] [int] NOT NULL,
	[DateMiseEnService] [date] NULL,
	[DateDerniereRevision] [date] NULL,
	[Id_Modele] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Parapente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passe]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passe](
	[Id_Pilote] [int] NOT NULL,
	[Id_Stage] [int] NOT NULL,
	[examen] [bit] NOT NULL,
	[Payement] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pilote] ASC,
	[Id_Stage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paye]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paye](
	[Id_Pilote] [int] NOT NULL,
	[Id_Cotisation] [int] NOT NULL,
	[DateCotisation] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pilote] ASC,
	[Id_Cotisation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PILOTE]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PILOTE](
	[Id_Pilote] [int] NOT NULL,
	[Nom] [varchar](100) NULL,
	[Prenom] [varchar](100) NULL,
	[Poids] [decimal](15, 2) NULL,
	[Adresse] [varchar](300) NULL,
	[Tel] [varchar](100) NULL,
	[Id_Fonction] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pilote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SITE_ATTERISSAGE]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SITE_ATTERISSAGE](
	[Id_Atterissage] [int] NOT NULL,
	[Nom] [varchar](100) NULL,
	[Orientation] [varchar](50) NULL,
	[Description] [varchar](100) NULL,
	[NiveauRequis] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Atterissage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SITE_DECOLLAGE]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SITE_DECOLLAGE](
	[Id_Decollage] [int] NOT NULL,
	[Nom] [varchar](100) NULL,
	[Orientation] [varchar](50) NULL,
	[Description] [varchar](250) NULL,
	[NiveauRequis] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Decollage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STAGE]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAGE](
	[Id_Stage] [int] NOT NULL,
	[DateDebut] [date] NULL,
	[DateFin] [date] NULL,
	[Prix] [decimal](15, 2) NULL,
	[NiveauRequis] [int] NULL,
	[Id_Brevet] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Stage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vol]    Script Date: 05-02-20 16:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vol](
	[Id_Pilote] [int] NOT NULL,
	[Id_Parapente] [int] NOT NULL,
	[Id_Atterissage] [int] NOT NULL,
	[Id_Decollage] [int] NOT NULL,
	[DateVol] [date] NULL,
	[DureeVol] [decimal](15, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pilote] ASC,
	[Id_Parapente] ASC,
	[Id_Atterissage] ASC,
	[Id_Decollage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BREVET]  WITH CHECK ADD FOREIGN KEY([Id_Niveau])
REFERENCES [dbo].[NIVEAU] ([Id_Niveau])
GO
ALTER TABLE [dbo].[Encadre]  WITH CHECK ADD FOREIGN KEY([Id_Pilote])
REFERENCES [dbo].[PILOTE] ([Id_Pilote])
GO
ALTER TABLE [dbo].[Encadre]  WITH CHECK ADD FOREIGN KEY([Id_Stage])
REFERENCES [dbo].[STAGE] ([Id_Stage])
GO
ALTER TABLE [dbo].[Obtient]  WITH CHECK ADD FOREIGN KEY([Id_Brevet])
REFERENCES [dbo].[BREVET] ([Id_Brevet])
GO
ALTER TABLE [dbo].[Obtient]  WITH CHECK ADD FOREIGN KEY([Id_Pilote])
REFERENCES [dbo].[PILOTE] ([Id_Pilote])
GO
ALTER TABLE [dbo].[PARAPENTE]  WITH CHECK ADD FOREIGN KEY([Id_Modele])
REFERENCES [dbo].[MODELE_PARAPENTE] ([Id_Modele])
GO
ALTER TABLE [dbo].[Passe]  WITH CHECK ADD FOREIGN KEY([Id_Pilote])
REFERENCES [dbo].[PILOTE] ([Id_Pilote])
GO
ALTER TABLE [dbo].[Passe]  WITH CHECK ADD FOREIGN KEY([Id_Stage])
REFERENCES [dbo].[STAGE] ([Id_Stage])
GO
ALTER TABLE [dbo].[Paye]  WITH CHECK ADD FOREIGN KEY([Id_Cotisation])
REFERENCES [dbo].[COTISATION] ([Id_Cotisation])
GO
ALTER TABLE [dbo].[Paye]  WITH CHECK ADD FOREIGN KEY([Id_Pilote])
REFERENCES [dbo].[PILOTE] ([Id_Pilote])
GO
ALTER TABLE [dbo].[PILOTE]  WITH CHECK ADD FOREIGN KEY([Id_Fonction])
REFERENCES [dbo].[FONCTION] ([Id_Fonction])
GO
ALTER TABLE [dbo].[STAGE]  WITH CHECK ADD FOREIGN KEY([Id_Brevet])
REFERENCES [dbo].[BREVET] ([Id_Brevet])
GO
ALTER TABLE [dbo].[Vol]  WITH CHECK ADD FOREIGN KEY([Id_Atterissage])
REFERENCES [dbo].[SITE_ATTERISSAGE] ([Id_Atterissage])
GO
ALTER TABLE [dbo].[Vol]  WITH CHECK ADD FOREIGN KEY([Id_Decollage])
REFERENCES [dbo].[SITE_DECOLLAGE] ([Id_Decollage])
GO
ALTER TABLE [dbo].[Vol]  WITH CHECK ADD FOREIGN KEY([Id_Parapente])
REFERENCES [dbo].[PARAPENTE] ([Id_Parapente])
GO
ALTER TABLE [dbo].[Vol]  WITH CHECK ADD FOREIGN KEY([Id_Pilote])
REFERENCES [dbo].[PILOTE] ([Id_Pilote])
GO
