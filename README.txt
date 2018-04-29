
README
Ian Nevills
Nicholas Reid
James Laubach
Purpose:
          Our purpose in this program is to create an army building program that eases the burden of the army building process 
of Warhammer 40k, while not eliminating the need for the book. This program allows the user to search through units with an easy 
to use interface. This program does not allow the full use of the game without the book, which is still required to fully understand 
the game. Our program focuses on the simplification of one aspect of the game, the army building process, by allowing the user to use 
a program instead of flipping through pages of the user manual to look at the base stats of units. 

Files used:
       All files that are required to run this program are in the repo and we did not use any special files in the program.

How to use:
       On startup, there is a message box that pops up telling you the basic controls. One thing that we must emphasize though,
is that you MUST select a point value or make your own before you select units. Because the point system is one of the most important
part of this program, if you try to add units before you select a point value, the program breaks. After you have selected or made a
point value, you may add units. You do so by clicking on one of the drop-down menus. On a single click, the unit’s information is
displayed in the text box above the drop-down menus. This is where the book would play its role. The text box displays the page
number, point value, and the base stats which require the book to understand the stat line. On a double click the unit gets added 
to the list and your current army is displayed in the large text box to the right. This text box displays all your units in the army 
as well as the number of points you have left and the index of each unit. If you wish to remove a unit, you may type in the index of 
the unit into the text box under the text, “Enter a Unit Index”, and then click the “Remove Unit” button to remove it from the list. 
Once you have run out of points for your army, you may print out your army list by double clicking the “Save List” button.

Challenges:
     Our biggest challenge was getting the information from the database to display correctly in the program which took most of our time.
 Also trying to figure out exactly how much we could realistically place in the program in the time allotted to us.

Design decisions:
     For our program there is one class that acts as the central hub to the entire program. UnitManager is the class that ties all the 
other class functionality together and was by far the most difficult to build. It takes all the functionality of the other classes and 
allows the user via the UI to interact with the other classes. After some time, we broke down the unit class into three distinct unit 
types: Walker, Vehicle and Infantry. With these classes we created a factory pattern, again controlled by UnitManager. Also, we had to
create a decorator for the Infantry class because infantry usually have more than one person per unit and therefore had more than one 
stat-line where the other classes only had one. Also, we had a class, FileManager, that is the only class that accesses the database. 
this class is, again, accessed by the UnitManager. This in turn makes sure that the only class that the user interacts with is the 
UnitManager which then uses the other classes for the other functionality required in this program.

Bugs:
      As of now, there is only one thing that is not completely done. The selection of points has a small problem with it requiring 
the user to remember that you absolutely MUST select the point value before you select a unit or it breaks. 

Results:
     As of now, we have our main functionality accomplished. The ability to see unit information and add units to the list, and the 
restriction of how many units you may have via the point system.
     

