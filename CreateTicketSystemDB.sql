-- Create Ticket System Database

USE Master
GO

-- Will Check to see if Database already exists, if so will drop current form of database than create a new Database
IF DB_ID('TicketSystemDB') IS NOT NULL
	DROP DATABASE [TicketSystemDB]
GO
GO

CREATE DATABASE TicketSystemDB
GO

USE TicketSystemDB
GO

-- Create Tables

CREATE TABLE Venues
(
VenueID			int				Identity(1,1)
,VenueName		varchar(50)		NOT NULL
,VenueType		varchar(50)		NULL
,VenueURL		varchar(50)		NULL
,VenueAddress	varchar(50)		NOT NULL
,VenueCity		varchar(50)		NOT NULL
,VenueState		char(2)			NOT NULL
,VenueInfo		varchar(MAX)	NULL
,CONSTRAINT PK_VenueID PRIMARY KEY CLUSTERED (VenueID)
)

CREATE TABLE Genre
(
GenreID		int				Identity(1,1)
,GenreName	varchar(50)		NOT NULL
,GenreInfo	varchar(MAX)	NULL
,CONSTRAINT PK_GenreID PRIMARY KEY CLUSTERED (GenreID)
)

CREATE TABLE Performer
(
PerformerID		int				Identity(1,1)
,PerformerName	varchar(50)		NOT NULL
,PerformerURL	varchar(50)		NULL
,PerformerInfo	varchar(MAX)	NULL
,CONSTRAINT PK_PerformerID PRIMARY KEY CLUSTERED (PerformerID)
)

CREATE TABLE Events
(
EventID				int				Identity(1,1)
,EventName			varchar(50)		NOT NULL
,EventStartDate		Date			NOT NULL
,EventEndDate			Date			NOT NULL 
,EventPriceRange	varchar(50)		NULL
,EventPromoter		varchar(50)		NULL
,EventInfo			varchar(MAX)	NULL
,VenueID			int				FOREIGN KEY REFERENCES Venues(VenueID)
,GenreID			int				FOREIGN KEY REFERENCES Genre(GenreID)
,PerformerID		int				FOREIGN KEY REFERENCES Performer(PerformerID)
,CONSTRAINT PK_EventID PRIMARY KEY CLUSTERED (EventID)
)