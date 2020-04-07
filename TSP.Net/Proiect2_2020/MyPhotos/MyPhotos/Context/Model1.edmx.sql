
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/13/2020 10:36:02
-- Generated from EDMX file: D:\Facultate\Anul III S2\TSP\Proiect1_2020\MyPhotos\MyPhotos\Context\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PhotoDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [PhotoId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [LocationId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [PersonId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tags'
CREATE TABLE [dbo].[Tags] (
    [TagId] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Localization'
CREATE TABLE [dbo].[Localization] (
    [Photos_PhotoId] int  NOT NULL,
    [Locations_LocationId] int  NOT NULL
);
GO

-- Creating table 'PersonOccurences'
CREATE TABLE [dbo].[PersonOccurences] (
    [Photos_PhotoId] int  NOT NULL,
    [People_PersonId] int  NOT NULL
);
GO

-- Creating table 'PhotoTags'
CREATE TABLE [dbo].[PhotoTags] (
    [Photos_PhotoId] int  NOT NULL,
    [Tags_TagId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PhotoId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([PhotoId] ASC);
GO

-- Creating primary key on [LocationId] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([LocationId] ASC);
GO

-- Creating primary key on [PersonId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([PersonId] ASC);
GO

-- Creating primary key on [TagId] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [PK_Tags]
    PRIMARY KEY CLUSTERED ([TagId] ASC);
GO

-- Creating primary key on [Photos_PhotoId], [Locations_LocationId] in table 'Localization'
ALTER TABLE [dbo].[Localization]
ADD CONSTRAINT [PK_Localization]
    PRIMARY KEY CLUSTERED ([Photos_PhotoId], [Locations_LocationId] ASC);
GO

-- Creating primary key on [Photos_PhotoId], [People_PersonId] in table 'PersonOccurences'
ALTER TABLE [dbo].[PersonOccurences]
ADD CONSTRAINT [PK_PersonOccurences]
    PRIMARY KEY CLUSTERED ([Photos_PhotoId], [People_PersonId] ASC);
GO

-- Creating primary key on [Photos_PhotoId], [Tags_TagId] in table 'PhotoTags'
ALTER TABLE [dbo].[PhotoTags]
ADD CONSTRAINT [PK_PhotoTags]
    PRIMARY KEY CLUSTERED ([Photos_PhotoId], [Tags_TagId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Photos_PhotoId] in table 'Localization'
ALTER TABLE [dbo].[Localization]
ADD CONSTRAINT [FK_Localization_Photo]
    FOREIGN KEY ([Photos_PhotoId])
    REFERENCES [dbo].[Photos]
        ([PhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Locations_LocationId] in table 'Localization'
ALTER TABLE [dbo].[Localization]
ADD CONSTRAINT [FK_Localization_Location]
    FOREIGN KEY ([Locations_LocationId])
    REFERENCES [dbo].[Locations]
        ([LocationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Localization_Location'
CREATE INDEX [IX_FK_Localization_Location]
ON [dbo].[Localization]
    ([Locations_LocationId]);
GO

-- Creating foreign key on [Photos_PhotoId] in table 'PersonOccurences'
ALTER TABLE [dbo].[PersonOccurences]
ADD CONSTRAINT [FK_PersonOccurences_Photo]
    FOREIGN KEY ([Photos_PhotoId])
    REFERENCES [dbo].[Photos]
        ([PhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [People_PersonId] in table 'PersonOccurences'
ALTER TABLE [dbo].[PersonOccurences]
ADD CONSTRAINT [FK_PersonOccurences_Person]
    FOREIGN KEY ([People_PersonId])
    REFERENCES [dbo].[People]
        ([PersonId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonOccurences_Person'
CREATE INDEX [IX_FK_PersonOccurences_Person]
ON [dbo].[PersonOccurences]
    ([People_PersonId]);
GO

-- Creating foreign key on [Photos_PhotoId] in table 'PhotoTags'
ALTER TABLE [dbo].[PhotoTags]
ADD CONSTRAINT [FK_PhotoTags_Photo]
    FOREIGN KEY ([Photos_PhotoId])
    REFERENCES [dbo].[Photos]
        ([PhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tags_TagId] in table 'PhotoTags'
ALTER TABLE [dbo].[PhotoTags]
ADD CONSTRAINT [FK_PhotoTags_Tags]
    FOREIGN KEY ([Tags_TagId])
    REFERENCES [dbo].[Tags]
        ([TagId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoTags_Tags'
CREATE INDEX [IX_FK_PhotoTags_Tags]
ON [dbo].[PhotoTags]
    ([Tags_TagId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------