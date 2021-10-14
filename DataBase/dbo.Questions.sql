CREATE TABLE [dbo].[Questions] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [Name_Quest] NVARCHAR (MAX) NOT NULL,
    [Var_Answ1]  NVARCHAR (MAX) NOT NULL,
    [Var_Answ2]  NVARCHAR (MAX) NOT NULL,
    [Var_Answ3]  NVARCHAR (MAX) NOT NULL,
    [Answ]       NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED ([ID] ASC)
);

