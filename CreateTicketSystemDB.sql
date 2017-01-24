-- Create Ticket System Database

USE Master
GO

-- Will Check to see if Database already exists, if so will drop current form of database than create a new Database
DROP DATABASE IF EXISTS TicketSystemDB
    
GO

CREATE DATABASE TicketSystemDB
GO

USE TicketSystemDB
GO

-- Create Tables
CREATE TABLE Events
(
EventID				int				Identity PRIMARY KEY
,EventName			varchar(50)		NOT NULL
,EventDates			Datetime		NOT NULL
,EventPriceRange	varchar(50)		NULL
,EventPromoter		varchar(50)		NULL
,EventInfo			varchar(MAX)	NULL
,VenueID			int				NOT NULL
,GenreID			int				NOT NULL
,PerformerID		int				NOT NULL
)

CREATE TABLE Venues
(
VenueID			int				Identity PRIMARY KEY
,VenueName		varchar(50)		NOT NULL
,VenueType		varchar(50)		NULL
,VenueURL		varchar(50)		NULL
,VenueAddress	varchar(50)		NOT NULL
,VenueCity		varchar(50)		NOT NULL
,VenueState		char(2)			NOT NULL
,VenueInfo		varchar(MAX)	NULL
)

CREATE TABLE Genre
(
GenreID		int				Identity PRIMARY KEY
,GenreName	varchar(50)		NOT NULL
,GenreInfo	varchar(MAX)	NULL
)

CREATE TABLE Performer
(
PerformerID		int				Identity PRIMARY KEY
,PerformerName	varchar(50)		NOT NULL
,PerformerURL	varchar(50)		NULL
,PerformerInfo	varchar(MAX)	NULL
)