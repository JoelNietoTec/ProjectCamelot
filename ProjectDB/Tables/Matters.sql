CREATE TABLE [dbo].[Matters]
(
	[CompanyId] INT NOT NULL,
	[MatterId] INT NOT NULL , 
    [ClientId] INT NULL, 
    [LawyerId] INT NULL, 
    [Name] NVARCHAR(150) NULL, 
    [MatterTypeId] INT NULL, 
    [ChargedFees] MONEY NULL, 
    [ChargedExpenses] MONEY NULL, 
    [DepositBalance] MONEY NULL, 
    [FeesBalance] MONEY NULL, 
    [PaidExpenses] MONEY NULL, 
    [ExpensesBalance] MONEY NULL, 
    [Notes] NTEXT NULL, 
    [CreatedDate] DATE NULL, 
    [Status] NVARCHAR NULL, 
    CONSTRAINT [FK_Matters_ToClients] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([Id]), 
    CONSTRAINT [FK_Matters_ToLawyers] FOREIGN KEY ([LawyerId]) REFERENCES [Lawyers]([Id]), 
    CONSTRAINT [FK_Matters_ToMatterTypes] FOREIGN KEY ([MatterTypeId]) REFERENCES [MatterTypes]([Id]), 
    CONSTRAINT [FK_Matters_ToCompanies] FOREIGN KEY ([CompanyId]) REFERENCES [Companies]([Id]) 
	
    
)

GO

CREATE UNIQUE CLUSTERED INDEX [Matters_Index] ON [dbo].[Matters] ([CompanyId], [MatterId])

GO
