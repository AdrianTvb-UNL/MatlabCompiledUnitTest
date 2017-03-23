CREATE TABLE [dbo].[TableConfig](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ConnectorConfigId] [int] NOT NULL,
	[EntityRepositoryName] [varchar](40) NOT NULL,
	[TableName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TableConfig] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TableConfig]  WITH CHECK ADD  CONSTRAINT [FK_Connector_TableConfig] FOREIGN KEY([ConnectorConfigId])
REFERENCES [dbo].[Connector] ([Id])
GO

ALTER TABLE [dbo].[TableConfig] CHECK CONSTRAINT [FK_Connector_TableConfig]