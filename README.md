# HyperSloop

Welcome to HyperSloop. 
This is a project I built in Blazor Server that communicates to Arduinos on a network via UDP. This code can be found in the HyperSloop and UDP services files. Once a series of Events are finished, an upload of the current users stats for that slide run are inserted into the database and a view is created shown in the SqlQueries file. Then, the the views are updated to display the data. There is a section for data specifically for the current user, and a Global leaderboards view that shows the data for every single user, along with some charts that were built with the Radzen Blazor Library. 

Uses the following:
- Blazor Server
- Entity Framework Core
- Radzen Library 
- Blazorise
- MySql
- C#
