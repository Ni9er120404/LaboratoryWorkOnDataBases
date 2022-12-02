CREATE PROCEDURE [dbo].[Procedure5] @N INT
AS
SELECT * FROM BuildingMaterials WHERE BuildingMaterials.Count < @N;