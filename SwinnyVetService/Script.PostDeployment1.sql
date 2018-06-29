/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF '$(LoadTestData)' = 'true'

BEGIN

DELETE FROM [Owner]
DELETE FROM Pet
DELETE FROM [Procedure]
DELETE FROM Treatment

INSERT INTO [Owner] (OwnerID, Surname, Givenname, Phone) VALUES
(1, 'Sinatra', 'Frank', '400111222'),
(2,	'Ellington', 'Duke', '400222333'),
(3, 'Fitzgerald', 'Ella', '400333444');

INSERT INTO Pet ([Name], [Type], OwnerID) VALUES
('Buster', 'Dog', 1),
('Fluffy', 'Cat', 1),
('Stew', 'Rabbit', 2),
('Buster', 'Dog', 3),
('Pooper', 'Dog', 3);

INSERT INTO [Procedure] (ProcedureID, [Description], Price) VALUES
(1, 'Rabies Vaccination', $24.00),
(10, 'Examine and Treat Wound', $30.00),
(05, 'Heart Worm Test', 25.00),
(08, 'Tetnus Vaccination', 17.00);

INSERT INTO Treatment (TreatmentID, [Name], OwnerID, ProcedureID, [Date], Notes, Price) VALUES
(1, 'Buster', 1, 1, '2017-06-17', 'Routine Vaccination', $22.00),
(2, 'Buster', 1, 1, '2018-05-15', 'Booster Shot', $24.00),
(3, 'Fluffy', 1, 10, '2018-05-10', 'Wounds sustained in apparent cat fight.', $24.00),
(4, 'Stew', 2, 10, '2018-05-10', 'Wounds sustained during attmot to cook the stew.', $30.00),
(5, 'Pooper', 3, 5, '2018-05-18', 'Routine Test', $25.00);



END;