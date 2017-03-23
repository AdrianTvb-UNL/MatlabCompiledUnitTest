CREATE TABLE [dbo].[AlgorithmRunParameterGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModuleRunId] [uniqueidentifier] NOT NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_AlgorithmRunParameterGroup_Created]  DEFAULT (getdate())
) ON [PRIMARY]