CREATE TABLE [dbo].[DataConfig](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModuleId] [int] NOT NULL,
	[Description] [varchar](50) NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_DataConfig_Created]  DEFAULT (getdate()),
 CONSTRAINT [PK_DataConfig] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DataConfig]  WITH CHECK ADD  CONSTRAINT [FK_Module_DataConfig] FOREIGN KEY([ModuleId])
REFERENCES [dbo].[Module] ([Id])
GO

ALTER TABLE [dbo].[DataConfig] CHECK CONSTRAINT [FK_Module_DataConfig]