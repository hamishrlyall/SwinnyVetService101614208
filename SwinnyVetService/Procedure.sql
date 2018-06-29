CREATE TABLE [dbo].[Procedure]
(
	[ProcedureID] INT NOT NULL,
	[Description] NVARCHAR(256) NOT NULL,
	[Price] MONEY NOT NULL,
	Constraint PK_ProcedureID PRIMARY KEY (ProcedureID)
)
