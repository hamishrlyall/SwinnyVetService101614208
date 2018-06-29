CREATE TABLE [dbo].[Owner]
(
	[OwnerID] INT NOT NULL,
	[Surname] NVARCHAR(100) NOT NULL,
	[Givenname] NVARCHAR(100) NOT NULL,
	[Phone] NVARCHAR(10) NOT NULL,
	Constraint PK_OwnerID PRIMARY KEY (OwnerID)
)
