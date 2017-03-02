# TicketSystem

## About The Ticket System.

    This is a ticket sytem similar to say a ticketmaster with the exception to visiting a website.
    This is a desktop application where you can search events and see their details, create events, create new performers, create genres,
    create venues with the future ambition to edit everything that is saved to the database.
    
    We built the database first and added it to the application using entity and representitive of the EF DESIGNER FROM DATABASE. 

	**The project is on github with link(https://github.com/dbasargin/TicketSystem).**
 
## Before Getting started.-Download project from github
	
   1) It would be a good Idea to open the Solution in Visual Studio.

   2) In the solution explorer under Solution Items, open file named "CreateTicketSystemDB.sql";

   3) Run this database script straight from visual studio(this will create your database).
   
   4) In the solution under Solution Items, open file named "InsertTicketSystemDB.sql";

   5) Run this script(This will populate your database with some seed data).
   
### What we got done.
    * Parent Form -  this contains all child forms, and menustrip which controls all navigation for the program.	
    * Homepage Form - displays list of all events and search capabilities.
    * create Event Form - allows you to create a new event.
    * create Category Form - allows you to create new genres of events to search by.
    * create Performer Form - allows you to create new performers.
    * create Venue Form - allows user to create new venues.
    
## Unfinished work we expect the program to do.
    - We want to create Forms to edit Event, Category, Performer and Venue.
    - publish application.
    
## Coding Conventions.

    **Entity frameWork**
			-Accessing the database using entity framework.
			-Example: TicketSystemDBEntities db = new TicketSystemDBEntities();
    
    **Navigation**
          Navigation is all handled in ParentFrm by calling function "ChangeChildForm(Form F)"
          * example ((FrmParent)this.MdiParent).ChangeChildForm(YOur new created form)
          This function closes current form and displays new form.
    **Classes**
          Classes are coded in PascalCase ex. ThisIsPascalCase.....
          Functions in classes are all documented pretty well.
