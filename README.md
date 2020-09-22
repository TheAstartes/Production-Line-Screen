# Production-Line-Screen

<!-- ABOUT THE PROJECT -->
## About The Project

This small [ASP.NET MVC] program helps visualising and monitoring production lines.The convention here is that program receives data from [Microsoft SQL Server] and converts it to a graph.The graph displays 5 modes within chosen span of hours:
*Production [cycle completed without obstructions]
*Breakdown [cycle has delay or has not completed]
*Planned stop
*Changeover [maitanance of production line]
*No data [system has no registry]

User has an option to pick a time and frequency at which program will create a text file under chosen directory,the file contains data [Name of productionline / Registry time entry / Status].

![alt text](https://user-images.githubusercontent.com/46090816/93887344-e00f5400-fce6-11ea-832c-62881d342b34.jpg)


### Built With
*ASP.NET Core 2.1

