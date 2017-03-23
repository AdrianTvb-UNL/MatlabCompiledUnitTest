CREATE TABLE [dbo].[Supervisor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_Supervisor_Created]  DEFAULT (getdate()),
 CONSTRAINT [PK_Supervisor_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Supervisor]  WITH CHECK ADD  CONSTRAINT [FK_Company_Supervisor] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([Id])
GO

ALTER TABLE [dbo].[Supervisor] CHECK CONSTRAINT [FK_Company_Supervisor]