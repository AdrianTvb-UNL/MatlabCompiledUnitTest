CREATE TABLE [dbo].[Connector](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataConfigId] [int] NULL,
	[ModelKnownAs] [varchar](50) NOT NULL,
	[ModelAssemblyFilename] [varchar](200) NOT NULL,
	[ConnectorKnownAs] [varchar](50) NOT NULL,
	[ConnectorAssemblyFilename] [varchar](200) NOT NULL,
	[ServerName] [varchar](20) NULL,
	[Datasource] [varchar](300) NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_Connector_Created]  DEFAULT (getdate()),
 CONSTRAINT [PK_ConnectorConfig] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Connector]  WITH CHECK ADD  CONSTRAINT [FK_DataConfig_Connector] FOREIGN KEY([DataConfigId])
REFERENCES [dbo].[DataConfig] ([Id])
GO

ALTER TABLE [dbo].[Connector] CHECK CONSTRAINT [FK_DataConfig_Connector]