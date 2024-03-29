USE [Nechami_placement]
GO
/****** Object:  Table [dbo].[class_tbl]    Script Date: 24/10/2021 11:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class_tbl](
	[id_class] [int] IDENTITY(1,1) NOT NULL,
	[class_name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_class_tbl] PRIMARY KEY CLUSTERED 
(
	[id_class] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[propPlace_tbl]    Script Date: 24/10/2021 11:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[propPlace_tbl](
	[id_propPlace] [int] IDENTITY(1,1) NOT NULL,
	[propPlace_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_propPlace_tbl] PRIMARY KEY CLUSTERED 
(
	[id_propPlace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studentConstraints_tbl]    Script Date: 24/10/2021 11:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studentConstraints_tbl](
	[id_studentConstraints] [int] IDENTITY(1,1) NOT NULL,
	[id_student] [int] NOT NULL,
	[id_propPlace] [int] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_studentConstraints_tbl_1] PRIMARY KEY CLUSTERED 
(
	[id_studentConstraints] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students_tbl]    Script Date: 24/10/2021 11:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students_tbl](
	[id_student] [int] IDENTITY(1,1) NOT NULL,
	[family_name] [nvarchar](30) NOT NULL,
	[first_name] [nvarchar](30) NOT NULL,
	[id_class] [int] NOT NULL,
	[chatter_degree] [numeric](5, 1) NOT NULL,
	[recommended_row] [int] NULL,
	[coulmn] [int] NULL,
	[row] [int] NULL,
 CONSTRAINT [PK_students_tbl] PRIMARY KEY CLUSTERED 
(
	[id_student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[studentConstraints_tbl]  WITH CHECK ADD  CONSTRAINT [FK_studentConstraints_tbl_propPlace_tbl] FOREIGN KEY([id_propPlace])
REFERENCES [dbo].[propPlace_tbl] ([id_propPlace])
GO
ALTER TABLE [dbo].[studentConstraints_tbl] CHECK CONSTRAINT [FK_studentConstraints_tbl_propPlace_tbl]
GO
ALTER TABLE [dbo].[studentConstraints_tbl]  WITH CHECK ADD  CONSTRAINT [FK_studentConstraints_tbl_students_tbl] FOREIGN KEY([id_student])
REFERENCES [dbo].[students_tbl] ([id_student])
GO
ALTER TABLE [dbo].[studentConstraints_tbl] CHECK CONSTRAINT [FK_studentConstraints_tbl_students_tbl]
GO
ALTER TABLE [dbo].[students_tbl]  WITH CHECK ADD  CONSTRAINT [FK_students_tbl_class_tbl] FOREIGN KEY([id_class])
REFERENCES [dbo].[class_tbl] ([id_class])
GO
ALTER TABLE [dbo].[students_tbl] CHECK CONSTRAINT [FK_students_tbl_class_tbl]
GO
