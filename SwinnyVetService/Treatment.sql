CREATE TABLE [dbo].[Treatment]
(
	[TreatmentID] INT NOT NULL,
	[Name] NVARCHAR(100) NOT NULL,
	[OwnerID] INT NOT NULL,
	[ProcedureID] INT NOT NULL,
	[Date] DATE NOT NULL,
	[Notes] NVARCHAR(256) NOT NULL,
	[Price] MONEY NOT NULL,
	Constraint PK_TreatmentID PRIMARY KEY (TreatmentID),
	--Constraint FK_Treatment_Name FOREIGN KEY ([Name]) REFERENCES Pet ([Name]),
	Constraint FK_Treatment_OwnerID FOREIGN KEY (OwnerID) REFERENCES [Owner] (OwnerID),
	Constraint FK_Treatment_ProcedureID FOREIGN KEY (ProcedureID) REFERENCES [Procedure] (ProcedureID)
)
