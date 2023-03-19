
# Birthday Manager
Project created to improve my knowledge acquired at the University.


 # Technologies and programming languages:</br>
 </br>
 Front-end:
 </br>
 </br>
<a href="https://getbootstrap.com" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/bootstrap/bootstrap-plain-wordmark.svg" alt="bootstrap" width="40" height="40"/> </a>  <a href="https://www.w3schools.com/css/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original-wordmark.svg" alt="css3" width="40" height="40"/> </a> <a href="https://www.w3.org/html/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original-wordmark.svg" alt="html5" width="40" height="40"/> </a> <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-original.svg" alt="javascript" width="40" height="40"/> </a> 
 </br>
 </br>
Back-end:</br>
 </br>
<a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a>
<a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/> </a> 
<a href="https://www.microsoft.com/en-us/sql-server" target="_blank" rel="noreferrer"> <img src="https://www.svgrepo.com/show/303229/microsoft-sql-server-logo.svg" alt="mssql" width="40" height="40"/> </a> </p>

# Project Architecture:</br>
 </br>
The Birthday Manager was developed using a three-tier structure: Web(MVC), Domain with the business logic and types, and Services with the data,
separating the responsibilities and limiting the layers to know only what is necessary from each other.

# The App

This project is a birthday manager. All data, including messages sent via the "Contact Us" form, are
saved in a SQL SERVER LOCAL DB. For implementing the LocalDB I use Entity Framework and Migrations.

When the user selects a friend at the table and changes the View, the selected item remains, I used Sections for that.

In the form I use tag helpers  for the execution of the post and for handling errors. If the fields are null, the user has the message: "Your message was not sent, please fill in all fields" but if all fields are correct, the message is: "Message sent successfully".

For the Frontend, I used Bootstrap and the Vegas Library in conjunction with JQuery to display multiple images in the Index View.

The layout was adapted for mobile, tablets and desktop. 

This video is a demo if you want to see the app in action.

[![Alt text](https://img.youtube.com/vi/9f-ZS7BD-Cg/0.jpg )](https://youtube.com/shorts/9f-ZS7BD-Cg?feature=share)

# Thank You!
Thanks for reading my Readme and if you have any suggestions, I'm open to hearing from you. :+1: :raised_hands:
