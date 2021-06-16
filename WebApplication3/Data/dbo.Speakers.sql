CREATE TABLE [dbo].[Speakers] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [SpeakerName]    NVARCHAR (100) NOT NULL,
    [SpeakingDate]   DATETIME2 (7)  NOT NULL,
    [ProfilePicture] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Speakers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

