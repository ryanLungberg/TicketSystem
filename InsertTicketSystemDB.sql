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
           ('Bruno Mars: 24K Magic World Tour','20170218 ' ,'$24.00 - $200.00' ,null ,'TODO'
           ,1 ,1 ,1 , '20170618 ')
		   
		   ,('WWE SmackDown','20171108 ' ,'$50.00 - $250.00' ,'WWE' ,'TODO'
           ,2 ,2 ,2 ,'20171108 ')

		   ,('Sarah Silverman Standup' ,'20170610 ' ,'$25.00- $75.00' ,NULL ,'TODO'
           ,3 ,3 ,3 ,'20170618 ')
GO

