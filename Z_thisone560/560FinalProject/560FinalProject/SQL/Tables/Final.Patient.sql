CREATE TABLE Final.Patient --CURRENT testing purpose
(
	PatientID NVARCHAR(32) NOT NULL PRIMARY KEY,
	BloodType NVARCHAR(32) NOT NULL,
	UniqueID INT NOT NULL IDENTITY(1,1) --need identity here?
);