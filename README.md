# G12 Zombie Battle
![alt text](https://github.com/bryan-wu/ZombieBattleUnity/blob/new_map/updatedsample.PNG "In-game capture")

## 1. List precise instructions to build and execute your system. Be sure to tell us about necessary libraries, and about any operating system or other restrictions.
* Our game is a desktop game
* Only support OS X or Windows system
### How to build our project
* In order to build our project, unity must be downloaded and used to open our project then build
### How to run our project (NO NEED TO DOWNLOAD UNITY, SKIP "HOW TO BUILD OUR PROJECT" IF YOU ONLY NEED TO RUN)
#### For Windows computer:
* Download the zip file [A link to our game in google drive for Windows](https://drive.google.com/open?id=1S9sYeDLZjktDaNnRKx7R9n4cP51AWZRx)
* Unzip it
* Open the executable. 1. make sure to check the Windowed option so that you can close the game window. 2. select the screen resolution to be 1600 * 900 (if your computer doesn't have that option, then just keep the default value but cutting off of the scenes will be unpredictable). 3. click play
* Play the game according to the instructions under number 4
* Exit by closing the window
#### For Mac:
* Download the zip file [A link to our game in google drive for Mac](https://drive.google.com/file/d/1SbfHrpfKzpbxfp86QZHHqG2XzWpd2glB/view?usp=sharing)
* unzip it
* May need to change the setting in system preference, security & privacy, allow app downloaded from: check "anywhere" so that Mac won'r prevent you from running our game
* Double clicks to open the upzipped file. 1. make sure to check the Windowed option so that you can close the game window. 2. can keep the default screen resolution but some parts of the battle ground will be cut off depending on different kinds of Mac (can also try 720 * 480 resolution if that's an option). That's something we need to fix later (mentioned below). 3. click play
* Play the game according to the instructions under number 4
* Exit by closing the window
## 2. Include any necessary details about where to store data files too.
* All the data files will be in the downloaded folder
## 3. Also include any other special information we need to know in order to test your system properly (a list of known bugs, for example).
##### List of bugs
* The player (survivor) can move outside the game scene
* After all the zombies pass, some soldiers are still shooting but others don't
* Sometimes, the player (survivor) is shooting but there's no zombies or is not shooting but zombies are getting closer
* You can't really win or lose the game right now. Winning and losing conditions haven't been implemented yet
* We didn't really consider various screen resolutions among different monitors when we started building the game. Therefore, the game gets partially cut off depending on the resolution of the computer because it was built with free aspect. As a result of that, the shop overlaps with some of the tiles. The UI doens't look very nice right now.
##### Note
* Our source code is in the Assets folder, under C# Script
## 4. Finally include brief guidance about how to use the system (e.g., how to play the game).
* First, the main menu will be displayed with our game logo and options to play the game or see the instructions. If you choose to see the instructions first, you can click the back button on the instruction page to return to the main menu
* When you are in the game scene, zombies will automatically start coming from the right of the screen. You can control the police which is the only survivor you can choose to be right now using A,S,W,D on the keyboard to move the police left, down, up, right respectively. You can also purchase soldiers to help you shoot the zombies by first clicking the button that corresponds to a particular kind of soldiers and then click the grid that you want your soldier to be placed on (You have to click an empty grid after choosing the soldier because the system won't let you place multiple soldiers on the same tile). Money will be subducted automatically after your purchase given the price listed in the shop. Also, 50 coins will be added to your account after a zombie is killed. You can also collect coins generated from the money maker by clicking on it. Each one is worth 20 coins. 
* Soldiers and the police will be dead if they are touched by zombies too many times.
* You can't control the shooting of soldiers and player. They will automatically start shooting once the zombies are in a given range.
* You can't really win or lose the game right now. As if now, after waves of zombies pass, the game can be deemed as over. You can just exit the application by closing the window
## 5. All the resources(tutorials) we referred to
* <https://unity3d.com/learn/tutorials/projects/space-shooter/spawning-waves?playlist=17147>
* Download the html file and then the source file. Then, double clicks to open the html file
<https://drive.google.com/file/d/1Vc7xmYOnRlfmHbRI0YvK9OHkuM6Ig3wL/view?usp=sharing> <https://drive.google.com/drive/folders/1rlHqTyTCo0Z7EsxgeXxXXECEhIbOOlVv?usp=sharing>
* <https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial/controlling-player>
  <https://www.youtube.com/watch?v=wDtNnD6HncU>


