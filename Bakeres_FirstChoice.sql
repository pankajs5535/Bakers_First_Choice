USE [Bakeres_FirstChoice]
GO
/****** Object:  Table [dbo].[tbl_bill_print]    Script Date: 23-06-2024 10:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_bill_print](
	[bill_id] [int] IDENTITY(1,1) NOT NULL,
	[invoice_number] [int] NULL,
	[cust_name] [varchar](50) NULL,
	[cust_phone] [varchar](50) NULL,
	[cust_email] [varchar](50) NULL,
	[cust_dtp] [varchar](50) NULL,
	[product_name] [varchar](50) NULL,
	[product_quantity] [varchar](50) NULL,
	[product_price] [varchar](50) NULL,
	[grant_total] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_bill_print] PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_customer]    Script Date: 23-06-2024 10:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[bdate] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_item]    Script Date: 23-06-2024 10:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_item](
	[item_id] [int] IDENTITY(1,1) NOT NULL,
	[item_name] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_item] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_product]    Script Date: 23-06-2024 10:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [varchar](50) NULL,
	[item_id] [int] NOT NULL,
	[product_price] [float] NULL,
 CONSTRAINT [PK_tbl_product] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_signup]    Script Date: 23-06-2024 10:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_signup](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[surname] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[city] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_signup] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 23-06-2024 10:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NULL,
	[user_surname] [varchar](50) NULL,
	[user_gender] [varchar](50) NULL,
	[user_email] [varchar](50) NULL,
	[user_password] [varchar](50) NULL,
	[user_city] [varchar](50) NULL,
	[user_phone] [varchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_product]  WITH CHECK ADD  CONSTRAINT [FK_tbl_product_tbl_item] FOREIGN KEY([item_id])
REFERENCES [dbo].[tbl_item] ([item_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_product] CHECK CONSTRAINT [FK_tbl_product_tbl_item]
GO
