--Displays a query for all plasma donations since 2021
SELECT DISTINCT BD.Date, Gender, PD.FirstName, PD.LastName, D.BloodType, BD.DonationType FROM Final.Donor D INNER JOIN Final.PersonalDetails PD ON D.UniqueID = PD.UniqueID INNER JOIN Final.BloodDonation BD ON BD.DonorID = D.DonorID AND BD.Date > '2021-01-01' WHERE BD.DonationType = 'Plasma' ORDER BY Date ASC, PD.LastName ASC
