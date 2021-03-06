# Investment Tracker

The 3 layer project helps you to store your income and expenditure and can be viewed anytime we want.

## Project Goal
* To Track household expenditure 

## Definition Of Done
- [ ] Track my Income and my Expenditure.
- [ ] Updating my database with my new income and new expenditure.
- [ ] Show me how much I save.

### Sprint 1
#### Goal: To create 3Layer project with minimum functionality
* Create a database using **Model first entity** framework approach.
* To create a business layer to act as inteface between database and GUI.
* To create a WPF project to add a GUI layer.

#### Screenshot of project Board Before and after Sprint 1

##### Before Sprint 1
 <img src ="ProjectBoardStart.PNG" width = "3000" />

##### After Sprint 1
<img src ="Sprint1end.PNG" width = "3000" />

#### Output Sprint 1 Review

* List of Sprint Backlog items that were completed: 
    * Console App created to start the Project.
    * Investment class and expenditure class Added.
    * Class Library created to add the business layer.
    * Model first approach Entity framework used to create the database.
    * GUI layer created to get inputs from the user to add to database.
    * Method is added in business layer to populate the selected item in GUI.
    * README File created and updated as and when necessary.

* List of Sprint Backlog items that could not be completed.
    * Writing testcase to test the data addition to the database. 

* Suggestions to add categories of Expenditure Ex: Seperate category for Groceries, for  EMI etc.


#### Sprint 1 Retrospective
* Things that went well:
    * Planning and doing things ahead of time.
    * Project board was very helpful in planning and organising.
    * Simple to Complex approach in adding functionality to the application is helping in moving one step at a time.
    

* Things to Improve:
    * Commit to GitHub for each user story. 

### Sprint 2
#### Goal: To Add Source column for Income Table and purpose column for Expenditure table and to calculate Total Income and Expenditure.
* To add Source column in Income Table and Purpose of expenditure in Expenditure table.
* To add delete option in GUI.
* To calculate Total Income and Total expenditure. 
* To claculate the balance.

#### Screenshot of project Board Before and after Sprint 2

##### Before Sprint 2
<img src ="Sprint2Start.PNG" width = "3000" />

##### After Sprint 2
<img src ="Sprint2End.PNG" width = "3000" />

#### Output of Sprint 2 Review

* List of Sprint Backlog items that were completed: 
    * Adding Source column in Income table and purpose column in my expenditure Table.
    * Day of adding entry to the database is implicitly added.
    * To calculate the Total Income and Total expenditure so far.
    * Updating README File.
    * Adding Unit Tests to Test whether the Total Income , Total Expenditure and balance calculated are correct.
    * To delete the wrong entry made to the table.
    * Making changes to the GUI so that it handles all the new methods added in my business layer.

* Could Complete All the tasks planned for Sprint2.

* Suggestions made format date, add functionality to calculate monthly expenditure, Which were previously included in the project backlog.

#### Sprint 2 Retrospective
* Things that went well:
    * Could Demo the project with most of CRUD functionality.
    * As before, planning ahead helped in finishing the decided task on time.

* Things to Improve:
    * Due to last minute changes in the code resulted in a bug while demo. Avoid it or make sure everything is working before demo.

### Sprint 3
#### Goal: To add functionality to update the wrong entry made and handle exceptions and claculate monthly income and Expenditure.
* To add update method in business layer.
* Make sure GUI doesnt take in any invalid data.
* Handle Exceptions.
* To add monthly income and expenditure.

#### Screenshot of project Board Before and after Sprint 3

##### Before Sprint 3
<img src ="Sprint3Start.PNG" width = "3000" />

##### After Sprint 3
<img src ="Sprint3End.PNG" width = "3000" />

#### Output of Sprint 3 Review

* List of Sprint Backlog items that were completed:
    * Adding Method to calculate Monthy Income and Expenditure.
    * Adding Update method to correct the wrong entry made.
    * Exception handling: Making sure invalid input or empty string are not added to database.
    * Updating README File.
    * Adding Tests To check the working of monthy income and expenditure methods.
    * Adding Tests to verify the functioning of exception handling methods.
    * Made necessary changes in GUI to replicate all the functions involved.

* Could complete the tasks planned for Sprint3.

* Suggestions made to display all the details to be included is a single window.

#### Sprint 3 Retrospective
* Things that went well:
    * Could demo the work with all the functionalities.
    * Completed well ahead of Sprint review, got me time to think about other exceptions.

* Things to Improve:
    * While doing Exception handling could have thought about other exceptions.

### Sprint 4
#### Goal: To work on GUI and documentation and add categories.
* To make GUI more user friendly and attractive.
* To check for more exceptions and handle them.
* Add Categories for source of Income and Purpose of Expenditure.

#### Screenshot of project Board Before and after Sprint 4

##### Before Sprint 4
<img src ="Sprint4Start.PNG" width = "3000" />

##### After Sprint 4
<img src ="Sprint4End.PNG" width = "3000" />

#### Output of Sprint 4 Review

* List of Sprint Backlog items that were completed:
    * Updating README file after Sprint 3.
    * Adding Class diagram.
    * To add Category of Source of Income and Purpose of Expenditure.
    * To Check for more Exceptions Handling.
    * To make GUI attractive by adding images and deleting extra windows that were not necessary.
 
* List of Sprint Backlog items that could not be completed.
    * Preparing Slides for Presentation.

#### Sprint 4 Retrospective
* Things that went well:
    * Could Complete the tasks as planned except one.

* Things to Improve:
    * Could have given more time to Design part of GUI.
    * Could not give enough time to project as planned for Sprint 4.

### Project Retrospective:

#### What Did I learn?

* How to Update the database once created using Entity Framework migrations.
* Different features present in WPF:
    * Message Box
    * Using different window.
    * How to add icon to  the button.
    * How to handle exceptions within WPF.
* Writing Complex LINQ queries using Groupby and sum.
* Usage of GitHub, writing user stories, Usage of Kanban Board, Project planning and execution process.
* Using C# Programming language to create an application.
* Writing documents using *Markdown*.

#### What could I do differenthy next time?

* WPF more atrractive and user friendly.
* Use different pages instead of Windows in WPF to display different contents.
* Would have written more classes and linked them. Ex Expenditure class, Income class , People class, Savings class and relate each other using foreign key.
* Once this was done it would have been easier to use OOPs concepts and SOLID principles.

#### What could I do next?

* Create an other class my name People and link them to Expenditure and Income class.
* Using that to relate differents peoples income and expenditure and compare, calculate total household expenditure and add methods to calculate who borrowed from whom.

### Screenshot of Class Diagram:
<img src ="ClassDiagram.PNG" width = "3000" />

### Screenshot of after completion of the project:
<img src ="ProjectEnd.PNG" width = "3000" />
    
   






