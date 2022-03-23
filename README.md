# CSCD-488-490-Senior-Project

# How to Open this Program
Inside the folder, if you click in the .sln file, it will open up Visual Studio with the project.
Afterwards, it is able to run.

# Migrating To Your Database
Provided int the Data folder is a script.sql file as well as CSVs for the data in the specimens and templates tables.
Once you set up your SQl database, run the script.sql to build the needed scheme, then import the CSVs if you would like our testing data.
Now, update the appsettings.json file and update the connection string to that supplied by your database server.

# Application
Without needing Visual Studio to run, you can use the exe generated on build found here.
...\CSCD-488-490-Senior-Project\Team 6 Senior Project\bin\Debug\net6.0-windows\

# Deployment
To be able to deploy the program with an installer, the steps in this guide work:
https://docs.devexpress.com/eXpressAppFramework/113235/deployment/deployment-tutorial/setup-project-deployment-of-a-windows-forms-application