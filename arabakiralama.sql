USE [Arac_Kiralama]
GO
/****** Object:  Table [dbo].[arackayıt]    Script Date: 2.06.2021 00:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arackayıt](
	[arac_id] [nchar](10) NOT NULL,
	[plaka] [nchar](10) NULL,
	[marka] [nchar](50) NULL,
	[seri] [nchar](50) NULL,
	[yil] [nchar](50) NULL,
	[renk] [nchar](50) NOT NULL,
	[km] [nchar](50) NULL,
	[yakit] [nchar](50) NULL,
	[fiyat] [nchar](50) NULL,
	[resim] [nchar](50) NULL,
	[durumu] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[müsteri_ekle]    Script Date: 2.06.2021 00:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[müsteri_ekle](
	[tc_kimlik] [nvarchar](11) NOT NULL,
	[adsoyad] [nchar](50) NULL,
	[telefon] [nchar](11) NULL,
	[adres] [nchar](70) NULL,
	[mail] [nchar](70) NULL,
	[arac_id] [nchar](10) NULL,
 CONSTRAINT [PK_müsteri_ekle] PRIMARY KEY CLUSTERED 
(
	[tc_kimlik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[arackayıt] ([arac_id], [plaka], [marka], [seri], [yil], [renk], [km], [yakit], [fiyat], [resim], [durumu]) VALUES (N'1         ', N'15        ', N'Opel                                              ', N'Corsa                                             ', N'2001                                              ', N'mor                                               ', N'5                                                 ', N'Dizel                                             ', N'5                                                 ', N'C:\Users\LENOVO\OneDrive\Masaüstü\biz.jpeg        ', N'Boş                                               ')
INSERT [dbo].[arackayıt] ([arac_id], [plaka], [marka], [seri], [yil], [renk], [km], [yakit], [fiyat], [resim], [durumu]) VALUES (N'15555     ', N'11        ', N'Renault                                           ', N'Clio                                              ', N'55                                                ', N'mm                                                ', N'21                                                ', N'Dizel                                             ', N'55                                                ', N'C:\Users\LENOVO\OneDrive\Masaüstü\biz.jpeg        ', N'Dolu                                              ')
INSERT [dbo].[arackayıt] ([arac_id], [plaka], [marka], [seri], [yil], [renk], [km], [yakit], [fiyat], [resim], [durumu]) VALUES (N'2         ', N'14        ', N'Opel                                              ', N'Corsa                                             ', N'2001                                              ', N'mor                                               ', N'5                                                 ', N'Dizel                                             ', N'15                                                ', N'C:\Users\LENOVO\OneDrive\Masaüstü\biz.jpeg        ', N'Dolu                                              ')
INSERT [dbo].[arackayıt] ([arac_id], [plaka], [marka], [seri], [yil], [renk], [km], [yakit], [fiyat], [resim], [durumu]) VALUES (N'3         ', N'234       ', N'Renault                                           ', N'Megane                                            ', N'12344                                             ', N'asd                                               ', N'1                                                 ', N'Benzin                                            ', N'213                                               ', N'C:\Users\LENOVO\OneDrive\Masaüstü\biz.jpeg        ', N'Boş                                               ')
INSERT [dbo].[arackayıt] ([arac_id], [plaka], [marka], [seri], [yil], [renk], [km], [yakit], [fiyat], [resim], [durumu]) VALUES (N'77        ', N'11        ', N'Renault                                           ', N'Megane                                            ', N'44                                                ', N'11                                                ', N'1                                                 ', N'Benzin                                            ', N'11                                                ', N'C:\Users\LENOVO\OneDrive\Masaüstü\volkii2.jpeg    ', N'Boş                                               ')
INSERT [dbo].[arackayıt] ([arac_id], [plaka], [marka], [seri], [yil], [renk], [km], [yakit], [fiyat], [resim], [durumu]) VALUES (N'88        ', N'55        ', N'Opel                                              ', N'Astra                                             ', N'202                                               ', N'mm                                                ', N'4                                                 ', N'Benzin                                            ', N'4                                                 ', N'C:\Users\LENOVO\OneDrive\Masaüstü\biz.jpeg        ', N'Dolu                                              ')
INSERT [dbo].[arackayıt] ([arac_id], [plaka], [marka], [seri], [yil], [renk], [km], [yakit], [fiyat], [resim], [durumu]) VALUES (N'888222    ', N'2222      ', N'Renault                                           ', N'Megane                                            ', N'22                                                ', N'55                                                ', N'88                                                ', N'Dizel                                             ', N'15                                                ', N'C:\Users\LENOVO\OneDrive\Masaüstü\biz.jpeg        ', N'Dolu                                              ')
INSERT [dbo].[arackayıt] ([arac_id], [plaka], [marka], [seri], [yil], [renk], [km], [yakit], [fiyat], [resim], [durumu]) VALUES (N'88888     ', N'11        ', N'Fiat                                              ', N'Fiesta                                            ', N'22                                                ', N'mm                                                ', N'55                                                ', N'Benzin                                            ', N'55                                                ', N'C:\Users\LENOVO\OneDrive\Masaüstü\biz.jpeg        ', N'Dolu                                              ')
GO
INSERT [dbo].[müsteri_ekle] ([tc_kimlik], [adsoyad], [telefon], [adres], [mail], [arac_id]) VALUES (N'1', N'tugce                                             ', N'0507173779 ', N'ev                                                                    ', N'g@gmail.com                                                           ', NULL)
INSERT [dbo].[müsteri_ekle] ([tc_kimlik], [adsoyad], [telefon], [adres], [mail], [arac_id]) VALUES (N'444', N'DD                                                ', N'44         ', N'55                                                                    ', N'DFE@gmail.com                                                         ', NULL)
GO
