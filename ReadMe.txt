Municipality Application
Overview
The Municipality Application is designed to manage and display various municipal events and announcements. This project aims to streamline community engagement through an intuitive interface, allowing users to view upcoming events, search for specific events, and report issues.

Getting Started
Prerequisites
Before running the application, ensure you have the following installed on your machine:

Visual Studio (2019 or later)
.NET Framework (version compatible with your project settings, usually .NET 4.5 or later)

Running the Application
Open the solution file (Municipality_App.sln) in Visual Studio.
Restore any NuGet packages if prompted.
Set the project as the startup project by right-clicking on it in the Solution Explorer and selecting Set as StartUp Project.
Build the project by clicking on Build > Build Solution or pressing Ctrl + Shift + B.
Start the application by clicking on the Start button (or pressing F5).
Project Structure
The main classes and their responsibilities in the application are as follows:

Form1: The main entry point of the application with buttons to navigate to the IssueReport and AnnouncementAndEvents forms.
AnnouncementAndEvents: Manages and displays municipal events and announcements, allowing users to filter and search events.
IssueReport: (Pending changes) Will handle reporting issues by the user.
Changes Made to the IssueReport Page
The IssueReport page has been enhanced to include a structured layout for users to report issues effectively.
Users can input details about the issue, categorize it, and submit it to the municipality.
Additional validation checks have been implemented to ensure users provide necessary information before submitting a report.