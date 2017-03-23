CREATE TABLE [dbo].[AlgorithmRunParameter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlgorithmRunParameterGroupId] [int] NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Value] [varchar](256) NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_AlgorithmRunParameter_Created]  DEFAULT (getdate())
) ON [PRIMARY]