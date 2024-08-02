CREATE TABLE [dbo].[USERS] (
    [UserName] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [EmailAddress] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([UserName] ASC)
);

