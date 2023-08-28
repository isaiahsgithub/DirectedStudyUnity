# Directed Study

The work is done under Assets/Scripts/ownedGames.cs .
The other files are classes.

## IMPORTANT NOTES
1) Steam MUST be open.
2) For Steamworks, there must be a Steam game hooked into this package. Navigate to the root of this project (where the Assets, Library, Logs, obj, Packages, ProjectSettings, Temp, UserSettings folder are located), and create a file called "steam_appid.txt". Inside this file, insert the ID of a Steam game. This is the game that is being developed by the developer. To find the application ID for a Steam game, open your Steam library, right click any game, click properties -> updates, the App ID is the number you want to write down in this section.
3) For gathering achievements, you must have a Steam API developer key. This can be obtained from the following URL: https://steamcommunity.com/dev/apikey . Once the API key is obtained, create a file called "steam_api_key.txt" (in the same directory as the steam_appid.txt file as discussed in previous section) and put the key in here.

If the error "InvalidProgramException: Invalid IL code in Mono.Data.Sqlite" appears, follow the steps in the following video: https://www.youtube.com/watch?v=m43DZbH7bzw
 