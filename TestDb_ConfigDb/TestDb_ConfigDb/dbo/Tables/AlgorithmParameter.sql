CREATE TABLE [dbo].[AlgorithmParameter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlgorithmConfigId] [int] NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Value] [varchar](256) NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_AlgorithmParameter_Date]  DEFAULT (getdate()),
 CONSTRAINT [PK_AlgorithmParameters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AlgorithmParameter]  WITH CHECK ADD  CONSTRAINT [FK_AlgorithmConfig_AlgorithmParameters] FOREIGN KEY([AlgorithmConfigId])
REFERENCES [dbo].[AlgorithmConfig] ([Id])
GO

ALTER TABLE [dbo].[AlgorithmParameter] CHECK CONSTRAINT [FK_AlgorithmConfig_AlgorithmParameters]