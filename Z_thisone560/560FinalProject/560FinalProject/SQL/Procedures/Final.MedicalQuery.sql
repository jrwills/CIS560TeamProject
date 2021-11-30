--Query to display all medical personnel
SELECT MP.MedicalPersonnelID, PD.FirstName, PD.LastName, PD.Gender FROM Final.MedicalPersonnel MP INNER JOIN Final.PersonalDetails PD ON MP.UniqueID = PD.UniqueID ORDER BY PD.FirstName ASC
