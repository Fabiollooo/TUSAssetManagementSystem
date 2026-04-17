# Introduction 
This application offers both students and staff at the TUS Midwest campus the ability to book any available room at any available time, while also allowing administrators to manage users, rooms and bookings present in the application.
The objective of this project is to maximize time and space efficiency with regards to room bookings on the TUS Midwest campus. This is done by an automated booking cancelling system that ensures resources on campus are used to their fullest extent.

# Getting Started
Installation process:
1. The database should be deployed on a Microsoft Azure server.
2. The application's DataLayer.cs file within the DataAccessLayer should be edited to include the database deployed on your Microsoft Azure server. This is done by editing the ConnectionString property within the openConnection method found within the DataLayer.cs file.
3. Once the database connection is made, it should be safe to build and test the application!

# Test Data
Administrator Login
Username: Fabian
Password: a

Staff Login
Username: Arman
Password: st

Student Login
Username = Tomasz
Password = s

# Contribute
The DataAccessLayer should contain all methods that interact with the Azure database. Any time a new method is to be created inside DataLayer.cs, it should also be reflected inside the IDataLayer interface.  
The BusinessLayer should contain all the business rules of the application. Any time a business entity wants to interact with the DataAccessLayer, it must go through the BusinessLayer to ensure data is valid. Any time a new method is to be created inside Model.cs, it should also be reflected inside the IModel interface.