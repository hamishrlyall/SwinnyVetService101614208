CREATE TABLE [dbo].[Pet]
(
	[OwnerID] INT NOT NULL,
	[Name] NVARCHAR(100) NOT NULL,
	[Type] NVARCHAR(50) NOT NULL,
	Constraint PK_PetID PRIMARY KEY ([Name], OwnerID),
	Constraint PK_Pet_OwnerID FOREIGN KEY (OwnerID) REFERENCES [Owner] (OwnerID)
)
