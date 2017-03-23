CREATE TABLE [dbo].[AlgorithmConfig](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModuleId] [int] NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_AlgorithmConfig_Created]  DEFAULT (getdate()),
 CONSTRAINT [PK_AlgorithmConfig] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AlgorithmConfig]  WITH CHECK ADD  CONSTRAINT [FK_Module_AlgorithmConfig] FOREIGN KEY([ModuleId])
REFERENCES [dbo].[Module] ([Id])
GO

ALTER TABLE [dbo].[AlgorithmConfig] CHECK CONSTRAINT [FK_Module_AlgorithmConfig]