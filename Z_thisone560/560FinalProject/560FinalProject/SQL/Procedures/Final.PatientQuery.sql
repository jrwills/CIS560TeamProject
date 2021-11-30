--Query to display all patients
SELECT P.PatientID, PD.FirstName, PD.LastName, P.BloodType, PD.Gender FROM Final.Patient P INNER JOIN Final.PersonalDetails PD ON P.UniqueID = PD.UniqueID ORDER BY PD.FirstName ASC
