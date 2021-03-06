USE [TestDb]
GO
/****** Object:  Table [dbo].[TestTable]    Script Date: 03/14/2017 16:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OpenId] [nvarchar](50) NOT NULL,
	[WeChatUnionId] [nvarchar](50) NOT NULL,
	[SupplierId] [int] NOT NULL,
	[SupplierMemberId] [int] NOT NULL,
	[SupplierAccount] [nvarchar](50) NOT NULL,
	[WorkStatus] [tinyint] NOT NULL,
	[WorkLogTime] [date] NOT NULL,
 CONSTRAINT [PK_WeChatUserWorkLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTable', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'微信用户的OpenID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTable', @level2type=N'COLUMN',@level2name=N'OpenId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'微信服务号Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTable', @level2type=N'COLUMN',@level2name=N'WeChatUnionId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTable', @level2type=N'COLUMN',@level2name=N'SupplierId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTable', @level2type=N'COLUMN',@level2name=N'SupplierMemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商登录账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTable', @level2type=N'COLUMN',@level2name=N'SupplierAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工作状态 0:下班 1:上班' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTable', @level2type=N'COLUMN',@level2name=N'WorkStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日志记录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestTable', @level2type=N'COLUMN',@level2name=N'WorkLogTime'
GO
/****** Object:  Table [dbo].[Person]    Script Date: 03/14/2017 16:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PId] [int] IDENTITY(1,1) NOT NULL,
	[PName] [nvarchar](50) NOT NULL,
	[PPhone] [nvarchar](50) NOT NULL,
	[PMemberId] [nvarchar](50) NOT NULL,
	[pSex] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 03/14/2017 16:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OId] [int] IDENTITY(1,1) NOT NULL,
	[OTitle] [nvarchar](50) NOT NULL,
	[OSerialNumber] [nvarchar](50) NOT NULL,
	[OPMemberId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_Person_pSex]    Script Date: 03/14/2017 16:08:55 ******/
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_pSex]  DEFAULT ((0)) FOR [pSex]
GO
/****** Object:  Default [DF_WeChatUserWorkLog_OpenId]    Script Date: 03/14/2017 16:08:55 ******/
ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_WeChatUserWorkLog_OpenId]  DEFAULT ('') FOR [OpenId]
GO
/****** Object:  Default [DF_WeChatUserWorkLog_WeChatUnionId]    Script Date: 03/14/2017 16:08:55 ******/
ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_WeChatUserWorkLog_WeChatUnionId]  DEFAULT ('') FOR [WeChatUnionId]
GO
/****** Object:  Default [DF_WeChatUserWorkLog_SupplierId]    Script Date: 03/14/2017 16:08:55 ******/
ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_WeChatUserWorkLog_SupplierId]  DEFAULT ((0)) FOR [SupplierId]
GO
/****** Object:  Default [DF_WeChatUserWorkLog_SupplierMemberId]    Script Date: 03/14/2017 16:08:55 ******/
ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_WeChatUserWorkLog_SupplierMemberId]  DEFAULT ((0)) FOR [SupplierMemberId]
GO
/****** Object:  Default [DF_WeChatUserWorkLog_SupplierAccount]    Script Date: 03/14/2017 16:08:55 ******/
ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_WeChatUserWorkLog_SupplierAccount]  DEFAULT (N'‘’') FOR [SupplierAccount]
GO
/****** Object:  Default [DF_WeChatUserWorkLog_WorkStatus]    Script Date: 03/14/2017 16:08:55 ******/
ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_WeChatUserWorkLog_WorkStatus]  DEFAULT ((0)) FOR [WorkStatus]
GO
/****** Object:  Default [DF_WeChatUserWorkLog_WorkLogTime]    Script Date: 03/14/2017 16:08:55 ******/
ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_WeChatUserWorkLog_WorkLogTime]  DEFAULT (getdate()) FOR [WorkLogTime]
GO
