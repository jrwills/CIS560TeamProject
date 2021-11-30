--SEARCH Donor Query with additional c# concatination
SELECT PD.FirstName, PD.LastName, D.BloodType, PD.Gender FROM Final.Donor D INNER JOIN Final.PersonalDetails PD ON D.UniqueID = PD.UniqueID WHERE D.DonorID = " + s + " ORDER BY PD.FirstName ASC
--SEARCH Patient Query with additional c# concatination
SELECT PD.FirstName, PD.LastName, P.BloodType, PD.Gender FROM Final.Patient P INNER JOIN Final.PersonalDetails PD ON P.UniqueID = PD.UniqueID WHERE P.PatientID = " + s + " ORDER BY PD.FirstName ASC
--SEARCH Medical Personnel Query with additional c# concatination
SELECT PD.FirstName, PD.LastName, PD.Gender FROM Final.MedicalPersonnel MP INNER JOIN Final.PersonalDetails PD ON MP.UniqueID = PD.UniqueID WHERE MP.MedicalPersonnelID = " + s + " ORDER BY PD.FirstName ASC