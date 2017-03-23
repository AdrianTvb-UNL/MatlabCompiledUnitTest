CREATE TABLE [dbo].[ModuleAndSupervisor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModuleId] [int] NOT NULL,
	[SupervisorId] [int] NOT NULL,
	[Created] [datetime] NOT NULL CONSTRAINT [DF_ModuleAndSupervisor_Created]  DEFAULT (getdate()),
 CONSTRAINT [PK_ModuleAndSupervisor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]