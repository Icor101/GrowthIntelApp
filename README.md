# GrowthIntelApp

The app provides useful information pertaining to the growth/development of a child patient and lists abnormalities (if any) on the basis of inputs provided by a paediatrician. The app’s front end was built using C# Winforms and the database side was handled using SQL and PL/SQL.
<BR>

The app starts with a Login/Sign Up window:


<img src = "https://user-images.githubusercontent.com/34352365/153768584-b46cd502-12b9-4891-9d50-07e06fb10465.JPG" align="left" height="300" widht="300">
<BR clear = "LEFT">

After successful login the user can view the main app window which consists of two tabs:

- Report 
- Vaccine Tracker

The **'Report'** tab prompts the user to enter a bunch of details about the patient.
<img src="https://user-images.githubusercontent.com/34352365/153768864-3cc776be-4a15-46ad-9615-9d0a1af2b547.JPG" align="left" height="350" width="450">
<BR clear = "LEFT">
If the inputs are valid, the app generates a report showing a comparison of the growth metrics against the ideal standards using a histogram. The report also shows a list of abnnormalities (like "Short stature", "Overweight", "Underweight" etc) discovered on the basis of the inputs provided.
<BR>
<BR>
<img src="https://user-images.githubusercontent.com/34352365/153768928-50e9d9cc-9dc8-44c9-8b0d-d00bd2f0c976.JPG" align="left" height="350" width="450">
<BR clear = "LEFT">

The '**Vaccine Tracker**' tab allows the paediatrician to update the database and keep track of a child's vaccination course against multiple diseases like BCG, Hepatitis B, DTP etc.
<BR>
<img src="https://user-images.githubusercontent.com/34352365/153769013-c5e1c439-64b2-4031-a080-e5335cf6c45d.JPG" align="left" height="350" width="450">
<BR clear = "LEFT">
  
# How to use
- Download and install Oracle Database 11g 32-bit
- Replace \<PASSWORD\> with your database password everywhere in the code and in the init.bat script which is present inside the 'SQL Scripts' folder
- Run init.bat to create and populate tables, stored procedures and triggers required by the app
- Run GrowthIntelApp.sln
