USE [MvcCRUDDB]
GO

/****** Object:  Table [dbo].[Prd_Master]    Script Date: 10/4/2020 1:33:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prd_Master](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Product_Name] [varchar](100) NULL,
	[Category_Name] [varchar](100) NULL,
	[Product_Description] [varchar](200) NULL,
	[Additional_Info] [varchar](200) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


