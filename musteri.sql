USE [müsteri]
GO
/****** Object:  Table [dbo].[tablo]    Script Date: 2.06.2021 00:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablo](
	[kullanici_adi] [nchar](16) NULL,
	[sifre] [nchar](16) NULL,
	[mail] [nchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tablo] ([kullanici_adi], [sifre], [mail]) VALUES (N'aa              ', N'aa              ', N'aa@gmail.com                                      ')
INSERT [dbo].[tablo] ([kullanici_adi], [sifre], [mail]) VALUES (N'tugce           ', N'123             ', N'tugce@gmail.com                                   ')
INSERT [dbo].[tablo] ([kullanici_adi], [sifre], [mail]) VALUES (N'selma           ', N'123             ', N'selma@gmail.com                                   ')
GO
