CREATE TABLE [Final].[PersonalDetails] (
    [UniqueId]      INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]     NVARCHAR (32)  NOT NULL,
    [LastName]      NVARCHAR (32)  NOT NULL,
    [Email]         NVARCHAR (128) NOT NULL,
    [PhoneNumber]   VARCHAR (15)   NOT NULL,
    [StreetAddress] NVARCHAR (128) NOT NULL,
    [Gender]        NVARCHAR (32)  NOT NULL,
    [DateOfBirth]   NVARCHAR (32)  NOT NULL,
    PRIMARY KEY CLUSTERED ([UniqueId] ASC)
);

