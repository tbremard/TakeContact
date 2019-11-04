TakeContact by Thierry Brémard
Xoru.eu
August 2015

The goal of the program is to allow visitor to give you their name, and Mail.
You should run this program and put in in full screen

There are three screens :
+ Form screen composed of input fields and a submit button ( this is the startup screen)
+ Confirmation screen composed of a simple message and a continue button
+ Display list screen : display the full list

Command Line:
-clear
	The program uses a local database ( Database.sdf ) so you do not need any server running, and do not need internet connection
	To reset the database, start the program with -clear in commandline :
	>TakeContact.exe -clear
	At the next startup, the program will display "0 person in database"

-nolist
    The program propose to display the content of the database by default. use this Option to hide the button to display the database.
	Typically you can find interesting to let the customers enter their contact, and prevent them from looking at the other contacts.


At the end of the day you can make an export to Excel file and then use the standard excel file to do what
you want ( print, insert in your own database ...).
To export just go in the Display list screen and click 'Export' button.

You can cusotmise 2 fields in file: "TakeContact.exe.config":
"MainTitle" is the text displayed at the top of the Form Screen
"ConfirmationContent" is the text displayed once you submitted the Form Screen
The other fields or content of buttons are not customizable in this version.

Full customizable application and source code is available on request at t.bremard@gmail.com

Technical overview:
This application is written in language C# with Microsoft .NET 4.0
Ui is done with WPF
The local database is SqlCe

