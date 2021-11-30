CREATE TABLE Final.BloodDonation --Done
(
	DonationID INT NOT NULL PRIMARY KEY,
	Date NVARCHAR(32) NOT NULL,
	DonorID INT NOT NULL,
	DonationType NVARCHAR(32) NOT NULL,
	MedicalPersonnelID INT NOT NULL
);