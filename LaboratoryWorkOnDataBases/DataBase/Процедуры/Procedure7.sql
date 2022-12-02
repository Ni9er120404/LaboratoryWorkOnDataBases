CREATE PROCEDURE [dbo].[Procedure7] @A NVARCHAR
AS
UPDATE ConstructionCompanies
SET Address=@A;