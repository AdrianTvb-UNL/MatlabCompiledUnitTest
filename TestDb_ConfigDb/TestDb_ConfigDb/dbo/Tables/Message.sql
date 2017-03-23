CREATE TABLE [dbo].[Message](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ModuleId] [int] NOT NULL,
	[ModuleRunId] [uniqueidentifier] NOT NULL,
	[TypeId] [varchar](64) NOT NULL,
	[Data] [varchar](256) NULL,
	[Date] [datetime] NOT NULL CONSTRAINT [DF_Message_Date]  DEFAULT (getdate()),
 CONSTRAINT [PK_MessageService] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_MessageType] FOREIGN KEY([TypeId])
REFERENCES [dbo].[MessageType] ([Id])
GO

ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_MessageType]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Module] FOREIGN KEY([ModuleId])
REFERENCES [dbo].[Module] ([Id])
GO

ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Module]