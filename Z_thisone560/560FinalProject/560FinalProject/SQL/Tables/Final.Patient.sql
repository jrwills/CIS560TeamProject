CREATE TABLE Final.Patient
(
	PatientID INT NOT NULL PRIMARY KEY, --"UniqueID"
	BloodType NVARCHAR(16) NOT NULL,
	UniqueID NVARCHAR(32) NOT NULL UNIQUE
);