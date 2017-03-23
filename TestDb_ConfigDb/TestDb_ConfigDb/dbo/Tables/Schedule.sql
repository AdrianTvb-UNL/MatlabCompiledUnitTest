CREATE TABLE [dbo].[Schedule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModuleId] [int] NOT NULL,
	[DataConfigId] [int] NULL,
	[AlgorithmConfigId] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Interval] [bigint] NULL,
	[Offset] [bigint] NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_Schedule_Created]  DEFAULT (getdate()),
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Module] FOREIGN KEY([ModuleId])
REFERENCES [dbo].[Module] ([Id])
GO

ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Module]