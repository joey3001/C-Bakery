# Joe's Bakery 

#### 12/11/2020

### 📖 Description

This application utilizes custom classes and namespaces to determine the cost of a bread & pastry order based on input from the user. This application also uses auto-implemented properties and private fields. Finally, the application uses TDD & all functionality for the models are tested. 

#### By Joseph Nero 

## 🔧 Setup/Installation Requirements
#### If you have difficulty following any of the steps/instructions listed below, please contact me at josephnero111@gmail.com 

1. Git Bash (or another terminal program) & Git.  
    - To clone the repository from Github using git commands in the terminal, you need a terminal program & Git. For Windows OS, I recommend the Git Bash terminal program. Installing Git Bash will also install Git. 

2. VSCode (or another code editor)
    - To view/edit this code, you need a code editor. I recommend VSCode. 

3. For Detailed instructions on how to install Git Bash & VSCode, visit the Setup/Installation Requirements section of the README for [this repo.](https://github.com/joey3001/first-friday-project)

4. C# & .NetCore
    - To run this project you will need C# & .NET Core. You can check if you have these installed by entering the following command into your terminal program :

            dotnet --version 

    - if C# & .NET Core are downloaded, the .NET Core version number will be presented. An example of this is as follows : 

            2.2.203

    - If no version number is presented, visit [this website](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer) to download C# & .NET Core. Once the download is complete, you can execute "dotnet --version" in your terminal again to verify its successful installation. 

5. dotnet script REPL
    - The dotnet script REPL allows you to run compiled code one line at a time. To install dotnet script enter the following command into your terminal program (only do this after completing the above step) : 

            dotnet tool install -g dotnet-script

#### To clone this project using git commands in the terminal : 

1. Open your terminal program and use the cd command to navigate to the directory in which you wish to clone this project. 
2. Use [this link](https://github.com/joey3001/CSharpBakery) go to this project's repository on github. Click on the green button labeled "code" towards the right side of the page's center. Click on the HTTPS option and copy the presented URL. 
3. Use the following command in your terminal program to clone the repo :

            git clone https://github.com/joey3001/CSharpBakery.git

#### To run the project using commands in the terminal : 

1. Use the cd command to navigate to the "Bakery" directory. 
2. Use the following command in your terminal program to compile the code : 

            dotnet build 

3. Next, use the following command in your terminal program to execute the compiled code : 

            dotnet run 

#### To test the project's models using commands in the terminal : 

1. Use the cd command to navigate to the "Bakery.Tests" directory. 
2. Use the following command in your terminal program to download neccesary packages :

            dotnet restore 

3. Use the following command in your terminal program to execute the tests : 

            dotnet test 

#### To view the code in the VSCode editor using commands in the terminal :  

1. Navigate to the project's root directory with the cd command. 

2. Once you are within the project's root directory, enter the following command into your terminal program to view all of the project's code in VSCode : 

            code . 

#### To download a file containing the contents of this repository to a location of your choice :  

1. Use a web browser to go to the repository webpage at [this link.](https://github.com/joey3001/CSharpBakery)
2. Click on the green button labeled "code" towards the right side of the page's center. In the drop-down menu that opens, click on the button labeled "Download Zip."
3. Once your download is complete, open the zipped file. Click on the button labeled "Extract All" at the top of your file explorer. 
4. Choose the location in which you want to extract the files, and navigate to that location once this process is complete. 

## 🐛 Known Bugs

No known bugs are present at this time. 

## 📫 Support and contact details

If you have an issue, reach out to me at josephnero111@gmail.com

## 🛠️ Technologies Used

  * C# V7.3
  * .NET Core V2.2
  * dotnet script REPL
  * VSCode 
  * Git
  * Github 
  * Git Bash


### 📘 License

[MIT License](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 Joseph Nero 
