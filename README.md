# G12 Zombie Battle
## Everthing we have for the final project is on the DemoProject branch, including our latest version of project and all the instructions
![alt text](https://github.com/bryan-wu/ZombieBattleUnity/blob/master/sample.PNG "In-game capture")

![alt text](https://github.com/bryan-wu/ZombieBattleUnity/blob/new_map/updatedsample.PNG "In-game capture")

## 1. List precise instructions to build and execute your system. Be sure to tell us about necessary libraries, and about any operating system or other restrictions.
* Our game is a desktop game
* Only support OS X or Windows system
### How to build our project
* In order to build our project, Unity must be downloaded and used to open our project then build
### How to run our project (NO NEED TO DOWNLOAD UNITY, SKIP "HOW TO BUILD OUR PROJECT" IF YOU ONLY NEED TO RUN)
#### For Windows computer:
* Download the zip file [Windows 64 bit Installation](https://drive.google.com/open?id=1S9sYeDLZjktDaNnRKx7R9n4cP51AWZRx)
* Unzip it
* Run the executable "Zombie Battle G12.exe". 
  1. Make sure to check the Windowed option so that you can close the game window. 
  2. Select the screen resolution to be 1600 * 900 (if your computer doesn't have that option, then just keep the default value but cutting off of the scenes will be unpredictable). 
  3. Click "Play!"
* Play the game according to the instructions under number 4
* Exit by closing the window
#### For Mac:
* Download the zip file [OS X Installation](https://drive.google.com/file/d/1SbfHrpfKzpbxfp86QZHHqG2XzWpd2glB/view?usp=sharing)
* Unzip it
* May need to change the setting in system preference, security & privacy, allow app downloaded from: check "anywhere" so that Mac won'r prevent you from running our game
* Double clicks to open the upzipped file. 
  1. Make sure to check the Windowed option so that you can close the game window. 
  2. Can keep the default screen resolution but some parts of the battle ground will be cut off depending on different kinds of Mac (can also try 720 * 480 resolution if that's an option). That's something we need to fix later (mentioned below). 
  3. Click play
* Play the game according to the instructions under number 4
* Exit by closing the window
## 2. Include any necessary details about where to store data files too.
* All the data files will be in the downloaded folder
## 3. Also include any other special information we need to know in order to test your system properly (a list of known bugs, for example).
##### List of bugs
* We didn't really consider various screen resolutions among different monitors when we started building the game. Therefore, the game gets partially cut off depending on the resolution of the computer because it was built with free aspect. As a result of that, the shop overlaps with some of the tiles.
##### Note
* Our source code is in the Assets folder, under C# Script
## 4. Finally include brief guidance about how to use the system (e.g., how to play the game).
* First, the main menu will be displayed with our game logo and options to play the game or see the instructions. If you choose to see the instructions first, you can click the back button on the instruction page to return to the main menu
* When you are in the game scene, zombies will automatically start coming from the right of the screen. You can control the police which is the only survivor you can choose to be right now using A,S,W,D on the keyboard to move the police left, down, up, right respectively. You can also purchase soldiers to help you shoot the zombies by first clicking the button that corresponds to a particular kind of soldiers and then click the grid that you want your soldier to be placed on (You have to click an empty grid after choosing the soldier because the system won't let you place multiple soldiers on the same tile). Money will be subducted automatically after your purchase given the price listed in the shop. Also, 50 coins will be added to your account after a zombie is killed. You can also collect coins generated from the money maker by clicking on it. Each one is worth 20 coins. 
* Soldiers and the player will be dead if they are touched by zombies too many times.
* You can't control the shooting of soldiers and player. They will automatically start shooting once the zombies are in a given range.
* You can choose to go back to the main menu anytime during the game by clicking the back to menu button.
* You would lose the game if the player dies or a certain amount of zombies passes the last line in the leftmost of the battle ground. You can choose to restart the game by pressing 'N' key after you lose.
* You would win the game if you make it till the end. You can choose to restart the game by pressing 'N' key after you win.
* You can just exit the application by closing the window
## 5. All the resources(tutorials) we referred to
* <https://unity3d.com/learn/tutorials/projects/space-shooter/spawning-waves?playlist=17147>
* Download the html file and then the source file. Then, double clicks to open the html file
<https://drive.google.com/file/d/1Vc7xmYOnRlfmHbRI0YvK9OHkuM6Ig3wL/view?usp=sharing> <https://drive.google.com/drive/folders/1rlHqTyTCo0Z7EsxgeXxXXECEhIbOOlVv?usp=sharing>
* <https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial/controlling-player>
  <https://www.youtube.com/watch?v=wDtNnD6HncU>

