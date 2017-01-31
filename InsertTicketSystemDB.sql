-- Insert some data into the TicketsytemDB

USE [TicketSystemDB]
GO

INSERT INTO [dbo].[Venues]
           ([VenueName]
           ,[VenueType]
           ,[VenueURL]
           ,[VenueAddress]
           ,[VenueCity]
           ,[VenueState]
           ,[VenueInfo])
     VALUES
           ('Tacoma Dome',NULL ,'www.tacomadome.org' ,'2727 East D St' ,'Tacoma' ,'WA' ,'TODO: FILL IN LATER'  ),
		   ('Key Arena',NULL ,'key.arenaseattle.com/' ,'1st Avenue N and 305 Harrison Street' ,'Seattle' ,'WA' ,'TODO: FILL IN LATER' ),
		   ('Paramount Theatre' ,NULL ,'paramount.theater-seattle.com' ,'911 Pine St' ,'Seattle' ,'WA' ,'TODO: FILL IN LATER' )
GO
USE [TicketSystemDB]
GO

INSERT INTO [dbo].[Genre]
           ([GenreName]
           ,[GenreInfo])
     VALUES
           ('Music','TODO: LATER'),('Sports','TODO: LATER'),('Arts & Theatre','TODO: LATER')
GO

USE [TicketSystemDB]
GO

INSERT INTO [dbo].[Performer]
           ([PerformerName]
           ,[PerformerURL]
           ,[PerformerInfo])
     VALUES
           ('Burno Mars','www.brunomars.com/','TODO'),
		   ('WWE', 'www.wwe.com', 'TODO'),
		   ('Sarah Silverman', 'sarahsilvermanonline.com', 'TODO')

GO



USE [TicketSystemDB]
GO

ALTER TABLE Events 	ADD EventEndDate	Datetime	NOT NULL;
EXEC sp_rename 'Events.EventDates', 'EventStartDate';


USE [TicketSystemDB]
GO

INSERT INTO [dbo].[Events]
           ([EventName]
           ,[EventStartDate]
           ,[EventPriceRange]
           ,[EventPromoter]
           ,[EventInfo]
           ,[VenueID]
           ,[GenreID]
           ,[PerformerID]
           ,[EventEndDate])
     VALUES
           ('Bruno Mars: 24K Magic World Tour','Jul-24-2017' ,'$24.00 - $200.00' ,null ,'TODO'
           ,1 ,1 ,1 , 'Jul-24-2017')
		   
		   ,('WWE SmackDown','Feb-7-2017' ,'$50.00 - $250.00' ,'WWE' ,'TODO'
           ,2 ,2 ,2 ,'Feb-7-2017')

		   ,('Sarah Silverman Standup' ,'Feb-7-2017' ,'$25.00- $75.00' ,NULL ,'TODO'
           ,3 ,3 ,3 ,'Feb-7-2017')
GO

SELECT *
FROM Venues