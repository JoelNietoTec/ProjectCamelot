CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(60) NOT NULL, 
    [BillName] NVARCHAR(150) NULL, 
    [ChargeAddress] NVARCHAR(150) NULL, 
    [SendAddress] NVARCHAR(150) NULL, 
    [CountryId] INT NOT NULL, 
    [PhoneNumber] NVARCHAR(30) NULL, 
    [FaxNumber] NVARCHAR(30) NULL, 
    [Email] NVARCHAR(200) NULL, 
    [LawyerId] INT NULL, 
    [IndustryId] NVARCHAR(2) NULL, 
    [CreationDate] DATE NULL, 
    [ModificationDate] DATETIME NULL, 
    CONSTRAINT [FK_Clients_ToLawyers] FOREIGN KEY ([LawyerId]) REFERENCES [Lawyers]([Id]), 
    CONSTRAINT [FK_Clients_ToCountries] FOREIGN KEY ([CountryId]) REFERENCES [Countries]([Id]), 
    CONSTRAINT [FK_Clients_ToIndustries] FOREIGN KEY ([IndustryId]) REFERENCES [Industries]([Id])
)
