# Web Warriors - Project 2 - Monster Trivia
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
# Application Overview
Monster Trivia is an interactive learning and fantasy gaming experience focused on comprehension and teaching of science and mathematics. The target audience for use is middle schoolers having an 8th Grade curriculum knowledge base. Application marketing and sales will be focused on educators seeking to provide alternatives to traditional education techniques. The gaming application aspect is centered around a cosmetic reward and victory system for replayability; core functionality of the program is meant to be used as a teaching tool where students may actively meet and further their educational requirements.

- [Web Warriors - Project 2 - Monster Trivia](#web-warriors---project-2---monster-trivia)
- [Application Overview](#application-overview)
- [Application Features](#application-features)
  * [List of Current Features](#list-of-current-features)
  * [Future Features to be Implemented](#future-features-to-be-implemented)
- [Technologies Used](#technologies-used)
  * [Frontend](#frontend)
  * [Backend](#backend)
  * [Supplementary Technologies](#supplementary-technologies)
- [Getting Started With Monster Trivia](#getting-started-with-monster-trivia)
  * [Running From a Web Browser URL](#running-from-a-web-browser-url)
  * [Running Locally From a Cloned Repository](#running-locally-from-a-cloned-repository)
- [Use of Monster Trivia](#use-of-monster-trivia)
- [Contributors](#contributors)
  * [TEAM WEB WARRIORS](#team-web-warriors)
- [License Information](#license-information)



# Application Features
## List of Current Features
- User Login
- User Avatar Selection
- User Avatar/Player Information Save
- User Interactive Gaming Experience
- User Question Analysis
- User Cosmetic Reward System
## Future Features to be Implemented
- Question Category Expansion
- User Choice of Categories
- Additonal Levels and Question Gauntlets
- Special Levels Activating Hit Point Bonus Increases
- Timer Based Damage Attributes

# Technologies Used
## Frontend
- Angular
- NodeJS
- Typescript
- HTML
- CSS
- JSON
- Bootstrap

## Backend
- C#
- ADO.NET
- Azure SQL Web Server
- ASP.NET Core Web API
- LINQ
- JSON
- SeriLog
- XUnit
- Swagger/Open5e AI

## Supplementary Technologies
- Visual Studio Code
- DBeaver
- Git
- GitHub
- SonarQube
- ThunderClient
- Moq

# Getting Started With Monster Trivia
## Running From a Web Browser URL 
1. Users must direct their browsers to the website URL [https://dungeonwebtwo.azurewebsites.net/](https://dungeonwebtwo.azurewebsites.net/) 
2. Users create an account by signing up and choosing their avatar. From this point the interactive gaming experience is initiated and the user is directed until logical game conclusion.
---
- ![Running Ng Serve](.\FrontEnd\DungeonQuestionnaire\src\assets\images\homescreen.png)
---

## Running Locally From a Cloned Repository
1. Git must be installed first in order to receive the clone repository. [To see how to install git, click here on this line.](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)
2. Create a project directory or change directory to your desired directory for insertion
3. Navigate to the Main Page of the Repository and click Code. You will receive this URL: [https://github.com/220118-Reston-NET/P2-DungeonQuestionnaire.git](https://github.com/220118-Reston-NET/P2-DungeonQuestionnaire.git)  
---
- ![Grabbing the Repo Code](.\FrontEnd\DungeonQuestionnaire\src\assets\images\clone_git.png)
---
4. Open Git Bash or Powershell, and type in "`git clone https://github.com/220118-Reston-NET/P2-DungeonQuestionnaire.git`." Press Enter to clone the repository into your directory. The Project files are now transferred.
5. NodeJS and NPM should be installed on the operating system you are using to properly serve the angular application.
- For **Unix** users, travel to the bash command line and type in `sudo apt update` and then `sudo apt install nodejs npm`. Once done, verify installation by running `node --version`. A version output should generate. Installation of Node Package Manager and NodeJS is now complete. 
- For **Windows** users, NodeJS may be downloaded from their website, [https://nodejs.org/en/download/](https://nodejs.org/en/download/). NodeJS also installs NPM which is a package manager for Node. Type in `node -v`, and if installed correctly a version number will be output.
---
- ![Checking Node Version](.\FrontEnd\DungeonQuestionnaire\src\assets\images\node_example.png)
---
6. Angular must be installed on your system into order to run the application locally.
- For **Unix** users, you will need to travel to your bash command line and type `sudo install -g angular-cli` in order to install angular.  Type in `ng --version` to verify a version output and successful installation.
- For **Windows** users on the command line, you will need to type `npm install -g @angular/cli` in order to install angular. Type in `ng --version` to verify a version output and successful installation. Windows users will more than likely need to change their OS execution security policy. This is done by running powershell in an administration account and typing in `Set-ExecutionPolicy RemoteSigned` and selecting `"Y"` as the choice. This will alow Angular to run, but keep in mind this may leave some systems vulnerable to malicious scripts if their system has been compromised; proceed with caution or use the web application if concerns exist.
---
- ![Checking Angular Version](.\FrontEnd\DungeonQuestionnaire\src\assets\images\angular_version.png)
---
7. Now that we have installed the proper tools, you must make sure you are in the main root directory of the project folder and type in `ng serve` on either **Windows** command line or **Unix** Bash command line. This will start a local development server. You will need to travel to the localhost link indicated by the command line.
---
- ![Running Ng Serve](.\FrontEnd\DungeonQuestionnaire\src\assets\images\ng_serve.png)
---
8. Users create an account by signing up and choosing their avatar. From this point the interactive gaming experience is initiated and the user is directed until logical game conclusion.
---
- ![Running Ng Serve](.\FrontEnd\DungeonQuestionnaire\src\assets\images\homescreen.png)
---



# Use of Monster Trivia
Users of Monster Trivia create a new account and choose an avatar upon signup. The user is then taken to an interactive viewpoint where they will be presented a virtual "Fight" screen where math and science questions are delivered content. The User is then presented a list of answers that will satisfy the question answer upon choosing the correct solution. A correct solution hurts the enemy opponent through a point system. The enemy is depicted along with their own user avatar on the fight page, as question delivery is presented. Choosing an incorrect solution will injure the player hit points. Upon exhausting an enemy combatant's hit points, the enemy is defeated and the next enemy tier is given, up unto a final Boss enemy character. Players may log out and save through a button functionality on the "Fight" page at any given time. User victories are saved as a means of prestige in the gaming application. A user exhausting their hit points through incorrect solutions will bring them to a game over screen, where they may try again with reset statistics at their last save point. Upon winning the game by defeating all enemies and their questions, the user is taken to a "Winning" screen to show their educator. The user victory information is saved, a cosmetic upgrade is acquired, and the user is invited to play again.

# Contributors
## TEAM WEB WARRIORS

Name | Team Role
--   | ----
Terrance Usher     |    Team Lead / Sprite Management
Jonathon Renaud    |    Front End Programming
Chad Solomon       |    Backend Programming / PlayerBox
James "Sid" Hinson |    Backend Programming/ EnemyBox
Kris Wasserman     |    Front End Programming



# License Information

This project is licensed under the MIT license.
