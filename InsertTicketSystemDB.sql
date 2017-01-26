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
           (
		   'Tacoma Dome'
           ,NULL
           ,'www.tacomadome.org'
           ,'2727 East D St'
           ,'Tacoma'
           ,'WA'
           ,'TODO: FILL IN LATER'
		   ),
		   (
		   'Key Arena'
           ,NULL
           ,'key.arenaseattle.com/'
           ,'1st Avenue N and 305 Harrison Street'
           ,'Seattle'
           ,'WA'
           ,'TODO: FILL IN LATER'
		   ),
		   (
		   'Paramount Theatre'
           ,NULL
           ,'paramount.theater-seattle.com'
           ,'911 Pine St'
           ,'Seattle'
           ,'WA'
           ,'TODO: FILL IN LATER'
		   )
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
           (<PerformerName, varchar(50),>
           ,<PerformerURL, varchar(50),>
           ,<PerformerInfo, varchar(max),>)
GO



USE [TicketSystemDB]
GO

INSERT INTO [dbo].[Events]
           ([EventName]
           ,[EventDates]
           ,[EventPriceRange]
           ,[EventPromoter]
           ,[EventInfo]
           ,[VenueID]
           ,[GenreID]
           ,[PerformerID])
     VALUES
           (<EventName, varchar(50),>
           ,<EventDates, datetime,>
           ,<EventPriceRange, varchar(50),>
           ,<EventPromoter, varchar(50),>
           ,<EventInfo, varchar(max),>
           ,<VenueID, int,>
           ,<GenreID, int,>
           ,<PerformerID, int,>)
GO

