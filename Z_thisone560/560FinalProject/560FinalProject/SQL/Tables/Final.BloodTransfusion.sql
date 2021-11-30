CREATE TABLE Final.BloodTransfusion
(
	TransfusionID INT NOT NULL PRIMARY KEY,
	Date NVARCHAR(32) NOT NULL,
	DonationType NVARCHAR(32) NOT NULL,
	DonationID INT NOT NULL,
	PatientID INT NOT NULL,
	MedicalPersonnelID INT NOT NULL
);