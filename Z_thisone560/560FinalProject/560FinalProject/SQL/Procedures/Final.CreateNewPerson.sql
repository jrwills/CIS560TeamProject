--use [TestDatabase2];

--CreateNewPerson (Allows the user to add/update a row to be filled with provided information)
CREATE OR ALTER PROCEDURE Final.CreateNewPerson
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@Email NVARCHAR(32),
	@Gender NVARCHAR(32),
	@StreetAddress NVARCHAR(32)
AS

INSERT Final.PersonalDetails(FirstName,LastName,Email,Gender,StreetAddress)
VALUES(@FirstName, @LastName, @Email, @Gender, @StreetAddress)