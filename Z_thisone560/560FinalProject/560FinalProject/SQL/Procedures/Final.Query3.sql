--Counts the donation from all male donors [platelets]
SELECT PD.FirstName, PD.LastName, D.BloodType, BD.DonationType, COUNT(*) AS DonationCount FROM Final.Donor D INNER JOIN Final.PersonalDetails PD ON D.UniqueID = PD.UniqueID INNER JOIN Final.BloodDonation BD ON BD.DonorID = D.DonorID AND BD.DonationType = 'Platelets' WHERE PD.Gender = 'Male' GROUP BY PD.FirstName, PD.LastName, D.BloodType, BD.DonationType ORDER BY PD.FirstName ASC
