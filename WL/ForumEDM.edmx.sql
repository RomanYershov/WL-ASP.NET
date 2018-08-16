
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/17/2018 01:02:59
-- Generated from EDMX file: C:\Users\Tom\Documents\Visual Studio 2017\Projects\WL\WL\ForumEDM.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ForumDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CommentsDiscussions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommentsSet] DROP CONSTRAINT [FK_CommentsDiscussions];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentsUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommentsSet] DROP CONSTRAINT [FK_CommentsUsers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[C__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[C__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[DiscussionsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DiscussionsSet];
GO
IF OBJECT_ID(N'[dbo].[CommentsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommentsSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL,
    [Age] int  NOT NULL
);
GO

-- Creating table 'DiscussionsSet'
CREATE TABLE [dbo].[DiscussionsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DateTime] datetime  NOT NULL,
    [State] nvarchar(max)  NOT NULL,
    [Categories_Id] int  NOT NULL
);
GO

-- Creating table 'CommentsSet'
CREATE TABLE [dbo].[CommentsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [CreateDateTime] datetime  NOT NULL,
    [Discussions_Id] int  NOT NULL,
    [Users_Id] int  NOT NULL
);
GO

-- Creating table 'CategoriesSet'
CREATE TABLE [dbo].[CategoriesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiscussionsSet'
ALTER TABLE [dbo].[DiscussionsSet]
ADD CONSTRAINT [PK_DiscussionsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CommentsSet'
ALTER TABLE [dbo].[CommentsSet]
ADD CONSTRAINT [PK_CommentsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriesSet'
ALTER TABLE [dbo].[CategoriesSet]
ADD CONSTRAINT [PK_CategoriesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Discussions_Id] in table 'CommentsSet'
ALTER TABLE [dbo].[CommentsSet]
ADD CONSTRAINT [FK_CommentsDiscussions]
    FOREIGN KEY ([Discussions_Id])
    REFERENCES [dbo].[DiscussionsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentsDiscussions'
CREATE INDEX [IX_FK_CommentsDiscussions]
ON [dbo].[CommentsSet]
    ([Discussions_Id]);
GO

-- Creating foreign key on [Users_Id] in table 'CommentsSet'
ALTER TABLE [dbo].[CommentsSet]
ADD CONSTRAINT [FK_CommentsUsers]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentsUsers'
CREATE INDEX [IX_FK_CommentsUsers]
ON [dbo].[CommentsSet]
    ([Users_Id]);
GO

-- Creating foreign key on [Categories_Id] in table 'DiscussionsSet'
ALTER TABLE [dbo].[DiscussionsSet]
ADD CONSTRAINT [FK_CategoriesDiscussions]
    FOREIGN KEY ([Categories_Id])
    REFERENCES [dbo].[CategoriesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriesDiscussions'
CREATE INDEX [IX_FK_CategoriesDiscussions]
ON [dbo].[DiscussionsSet]
    ([Categories_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------