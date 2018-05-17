# G12 Zombie Battle
![alt text](https://github.com/bryan-wu/ZombieBattleUnity/blob/new_map/updatedsample.PNG "In-game capture")

1. List precise instructions to build and execute your system. Be sure to tell us about necessary libraries, and about any operating system or other restrictions.
2. Include any necessary details about where to store data files too.
3. Also include any other special information we need to know in order to test your system properly (a list of known bugs, for example).
**list of bugs**
* The player (survivor) can move outside the game scene
* Shop doesn't work properly in some special cases, for example: 1. Once a button for a particular type of soldiers greys out because user doesn't have enough money for that kind of soldiers, user also can't purchase other types of soldiers that user can afford. 2. Once a button is lightened because user now has enough money by collecting coins, user still can't buy those soldiers that user can afford.
* After all the zombies pass, some soldiers are still shooting but others don't
* Sometimes, the player (survivor) is shooting but there's no zombies or is not shooting but zombies are getting close **Not sure about the problems with shooting**
* You can't really win or lose the game right now. Winning and losing conditions haven't been implemented yet
4. Finally include brief guidance about how to use the system (e.g., how to play the game).
* First, the main menu will be displayed with our game logo and options to play the game or see the instructions. If you choose to see the instructions first, you can click the quit button on the instruction page to return to the main menu
* When you are in the game scene, zombies will automatically start coming from the right of the screen. You can control the police which is the only survivor you can choose to be right now using A,S,W,D on the keyboard to move the police left, down, up, right respectively. You can also purchase soldiers to help you shoot the zombies by first clicking the button that corresponds to a particular kind of soldiers and then click the grid that you want your soldier to be placed on. Money will be subducted automatically after your purchase given the price listed in the shop. Also, 50 coins will be added to your account after a zombie is killed. You can also collect coins generated from the money maker. Each one is worth 20 coins. 
* Soldiers and the police will be dead if they are touched by zombies too many times.
* You can't control the shooting of soldiers and player. They will automatically start shooting once the zombies are in a given range.
* You can't really win or lose the game right now. As if now, After waves of zombies pass, the game can be deemed as over. You can just close the window to exit 
