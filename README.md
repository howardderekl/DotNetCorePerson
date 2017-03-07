# DotNetCorePerson
Example Project of Asp.Net Core, Entity Framework, Bootstrap and Angular Person Repository Web App

# Pre Reqs
First make sure you have installed these prerequisites. Things will not work without them!

* Visual Studio 2015 Update 3. Note that Update 2 is not enough. You need Update 3, because it fixes some issues with NPM, plus it’s a prerequisite for TypeScript 2.0. [link](https://www.visualstudio.com/en-us/news/releasenotes/vs2015-update3-vs)
* .NET Core 1.0.1 [Link](https://www.microsoft.com/net/core#windowscmd)
* TypeScript 2.0 for Visual Studio 2015. If Visual Studio keeps complaining Cannot find name 'require', it’s because you forgot to install this.
* Node.js version 4 or later. We temporarily don’t support Node 0.x because of this issue, but might re-add support for Node 0.x in the future. To check your Node version, run node -v in a command prompt. [Link](https://nodejs.org/en/)

# Project Setup
* Clone the project in Visual studio
* Build and restore packages
* from a command prompt at the HumansOfNewYork project level run: dotnet ef database update
* Run the project
* enjoy
