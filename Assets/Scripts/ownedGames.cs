// https://www.mongodb.com/developer/code-examples/csharp/saving-data-in-unity3d-using-sqlite/
// https://www.youtube.com/watch?v=m43DZbH7bzw

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;
using System.Net;
using System.IO;
using System.Linq;
using Mono.Data.Sqlite;
using System.Data;
using Newtonsoft.Json;
using System;

public class ownedGames : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        //getAchievementRateInContentDescriptorID("5", 0);
        //getAchievementRateInMyContentDescriptors(0.25);
        //getAchievementRateInMyContentDescriptors(0.25);
        //getAchievementRateInContentDescriptorID("1", 0.25);
        //getPlayTimeInContentDescriptorID("1", 5);
        //getPlayTimeInContentDescriptorID("1", 5);
        //getPlayTimeInContentDescriptorID("67", 5);
        //getPlayTimeInContentDescriptor("Some Nudity or Sexual Content", 5);
        //getPlayTimeInContentDescriptor("Some Nudity or Sexual ContentWJERWHWJEHRJWEHRTJKWEH", 5);

        //getAchievementRateInContentDescriptorID("8", 0.25);
        //getAchievementRateInContentDescriptorID("8", 0);
        //getAchievementRateInContentDescriptor("Some Nudity or Sexual Content", 0.25);
        //getAchievementRateInContentDescriptor("Some Nudity or Sexual ContentWJERWHWJEHRJWEHRTJKWEH", 0.25);



        //getPlayTimeInOtherGenre("Strategy", 5);
        //getPlayTimeInOtherTags("Zombies", 5);

        //getAchievementRateInContentDescriptor("Some Nudity or Sexual Content", 0.25);
        //getAchievementRateInOurDeveloperGames(0.25);
        //getAchievementRateInOurPublisherGames(0.25);
        //getAchievementRateInOurDevelopersAndPublishersGames(0.25);


        //getAchievementRateByOtherDevelopersAndPublishers("BlankMediaGames", 0.25); // <- Does NOT Check BlankMediaGames LLC
        //getAchievementRateByOtherDevelopersAndPublishers("BlankMediaGames", 0.06); 

        //getAchievementRateByOtherDevelopersAndPublishers("BlankMediaGames LLC", 0.25);
        //getAchievementRateByOtherDevelopersAndPublishers("BlankMediaGames LLC", 0.06);


        //getAchievementRateByOtherDevelopers("BlankMediaGames", 0.25); //<- Does NOT Check BlankMediaGames LLC
        //getAchievementRateByOtherDevelopers("BlankMediaGames", 0.06);

        //getAchievementRateByOtherDevelopers("BlankMediaGames LLC", 0.25);
        //getAchievementRateByOtherDevelopers("BlankMediaGames LLC", 0.06);

        //getAchievementRateByOtherPublishers("BlankMediaGames", 0.25); //<- Does NOT Check BlankMediaGames LLC
        //getAchievementRateByOtherPublishers("BlankMediaGames", 0.06);

        //getAchievementRateByOtherPublishers("BlankMediaGames LLC", 0.25);
        //getAchievementRateByOtherPublishers("BlankMediaGames LLC", 0.06);


        //getAchievementRateInGames("Town of Salem", 0.25); //<- Checks both ToS 1 and 2
        //getAchievementRateInGames("Town of Salem", 0.06);
        //getAchievementRateInGames("Town of Salem 2", 0.25);
        //getAchievementRateInGames("Town of Salem 2", 0.06);


        //getAchievementRateInGenre(0.25);


        //getAchievementRateInTags(0.25);

        //getAchievementRateInOtherTags("Werewolves", 0.25);
        //getAchievementRateInOtherTags("Werewolves", 0.06);

        //getAchievementRateInOtherGenre("Strategy", 0.01);
        //getAchievementRateInOtherGenre("Strategy", 0.00);


        //getPlayTimeInOtherTags("Werewolves", 5);
        //getPlayTimeInTags(5);

        //getPlayTimeInTags(764353467);

        //getPlayTimeInDevelopers(5);
        //getPlayTimeInPublishers(5);
        //getPlayTimeInDevelopersAndPublishers(5);
        //getAchievementRateInPublishers(0.1);
        //getAchievementRateInDevelopers(0.1);
        //getAchievementRateInDevelopersAndPublishers(0.1);
        //getAchievementRateInOtherDevelopersAndPublishers("Nexon", 0.1);
        //getAchievementRateInOtherDevelopers("Nexon", 0.1);
        //getAchievementRateInOtherPublishers("Nexon America Inc.", 0.1);
        //getPlayTimeInOtherDevelopersAndPublishers("Nexon", 5);
        getPlayTimeInOtherDevelopers("Nexon", 5);
        getPlayTimeInOtherPublishers("Nexon America Inc.", 5);

        //FIND OTHER GENRE THAT IS UNIQUE  TEST SOON - NEEDS TESTING AS OF 2023-08-13

        //getAchievementRateInOtherGenre("Strategy", 0.25);
        //getAchievementRateInOtherGenre("Strategy", 0.06);
        //getAchievementRateInOtherGenre("Strategy", 0.01);


        //getPlayTimeInMyContentDescriptors(5);


        //getPlayTimeInMyContentDescriptors(5);

        //getPlayTimeInOurDeveloperGames(5);
        //getPlayTimeInOurPublisherGames(5);
        //getPlayTimeInOurDevelopersAndPublishersGames(5);

        //getPlayTimeByOtherPublishers("Nexon", 5);
        //getPlayTimeByOtherDevelopers("Nexon", 5);
        //getPlayTimeByOtherPublishers("Nexon America Inc.", 5);
        //getPlayTimeByOtherDevelopers("Nexon America Inc.", 5);

        //getPlayTimeByOtherPublishers("Square Enix", 5);
        //getPlayTimeByOtherDevelopers("Square Enix", 5);
        //getPlayTimeByOtherPublishers("Nexon", 5);
        //getPlayTimeByOtherDevelopers("Nexon", 5);
        //getPlayTimeByOtherDevelopersAndPublishers("Nexon", 5);
        //getPlayTimeInTags(5);

        //getPlayTimeInGenre(5);
        //getPlayTimeInGenre(9000000);

        //getPlayTimeInGames("Call of Duty", 60);
        //getPlayTimeInGames("Call of Duty", 60000000);
    }

    //Sets up database
    private void databaseSetup()
    {
        IDbConnection databaseConnection = generateDB();
        IDbCommand dbRead = databaseConnection.CreateCommand();
        dbRead.CommandText = "SELECT * FROM GameInformationTable";
        IDataReader dataReader = dbRead.ExecuteReader();
        databaseConnection.Close();
    }


    private IDbConnection generateDB()
    {
        string dbURI = "URI=file:SteamInformation.sqlite";
        IDbConnection dbConnection = new SqliteConnection(dbURI);
        dbConnection.Open();

        IDbCommand dbCreate = dbConnection.CreateCommand();

        //SQLite does not support arrays, so genres will be separted via | in one big string.
        dbCreate.CommandText = "CREATE TABLE IF NOT EXISTS GameInformationTable (aid INTEGER PRIMARY KEY, gameName STRING, devName STRING, pubName STRING, genres STRING, tags STRING, descriptors STRING)";
        dbCreate.ExecuteReader();

        return dbConnection;
    }

    //Retrives game from database. If there was any error retrieving the game, a empty shell of a game is returned.
    public game dbGetGame(int theaid, int totalPlayTime)
    {

        string[] tempErr = { "ERR" };

        game dbGame = new game(-9999, "ERR GAME", -9999, tempErr, tempErr, tempErr, tempErr, tempErr);

        IDbConnection databaseConnection = generateDB();
        IDbCommand dbGet = databaseConnection.CreateCommand();
        dbGet.CommandText = "SELECT * FROM GameInformationTable WHERE aid=" + theaid;
        IDataReader dbRead = dbGet.ExecuteReader();
        while (dbRead.Read())
        {
            dbGame = new game(dbRead.GetInt32(0), dbRead.GetString(1), totalPlayTime, restoreArray(dbRead.GetString(2)), restoreArray(dbRead.GetString(3)), restoreArray(dbRead.GetString(4)), restoreArray(dbRead.GetString(5)), restoreArray(dbRead.GetString(6)));

        }

        databaseConnection.Close();

        //Debug.Log(dbGame.applicationid + " " + dbGame.gamename + " " + printArray(dbGame.developers) + " " + printArray(dbGame.publishers) + " " + printArray(dbGame.genres) + " " + printArray(dbGame.tags));

        return dbGame;
    }

    //Check if a game exists in the database.
    //Returns true if game exists in DB. Returns false otherwise. 
    public bool checkIfExists(int theaid)
    {
        IDbConnection databaseConnection = generateDB();
        IDbCommand dbExists = databaseConnection.CreateCommand();
        dbExists.CommandText = "SELECT 1 FROM GameInformationTable WHERE aid=" + theaid;

        object result = dbExists.ExecuteScalar();
        databaseConnection.Close();
        if (result != null && result != System.DBNull.Value)
        {
            return true;
        }
        return false;
    }

    //Inserts a game into the database (if it is not there already).
    public void insertIntoDB(int aid, string gN, string dN, string pN, string g, string t, string desc)
    {
        IDbConnection databaseConnection = generateDB();
        IDbCommand dbInsert = databaseConnection.CreateCommand();
        //Debug.Log("INSERT INTO GameInformationTable (aid, gameName, devName, pubName, genres, tags) VALUES (" + aid + ", \"" + gN + "\", \"" + dN + "\", \"" + pN + "\", \"" + g + "\", \"" + t + "\")");
        dbInsert.CommandText = "INSERT INTO GameInformationTable (aid, gameName, devName, pubName, genres, tags, descriptors) VALUES ("+aid + ", \"" + gN + "\", \"" + dN + "\", \"" + pN + "\", \"" + g + "\", \"" + t + "\", \"" + desc + "\"  )";
        dbInsert.ExecuteNonQuery();
        databaseConnection.Close();



    }



        public int getPlayTimeInMyContentDescriptors(int minimumCDPlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        /*foreach(UserGameInfo individualGame in usersGames.games) {
            Debug.Log(individualGame.appid + " " + individualGame.name + " " + individualGame.playtime_forever);
        }*/

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);

        /*
        foreach(game myGame in gameDetails)
        {
            
            Debug.Log(myGame.applicationid + " " + myGame.gamename + " " + printArray(myGame.developers) + " " +
                printArray(myGame.publishers) + " " + printArray(myGame.genres) + " " + printArray(myGame.tags) + " " + printArray(decodeContentDescriptors(myGame.descriptors)));
        }
        */

        string[] myContentDescriptors = whatAreMyContentDescriptors();
        
        int totalTime = 0;

        //If the game I am making does not have any content descriptors, it can be declared as a "safe" game.
        //Check for other "safe" games.
        if(myContentDescriptors.Length == 0)
        {
            foreach (game myGame in gameDetails)
            {
                if(myGame.descriptors.Length == 0)
                {
                    totalTime += myGame.playtimeforever;
                }
            }

        }
        else
        {
            foreach (game myGame in gameDetails)
            {
                if (myContentDescriptors.Any(myGame.descriptors.Contains))
                {
                    totalTime += myGame.playtimeforever;
                }
            }
        }


        Debug.Log("Player has: " + totalTime + " minutes in:  " + printArray(myContentDescriptors) + ".");

        if (totalTime >= minimumCDPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;

        }
        Debug.Log("The player is NOT qualified to skip contents.");
        return 0;


    }



    public int getAchievementRateInMyContentDescriptors(double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);

        string gameBeingMadeID = whatGameIDAmI();

        string[] myContentDescriptors = whatAreMyContentDescriptors();
        if(myContentDescriptors == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }



        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;
       

        //If the game I am making does not have any content descriptors, it can be declared as a "safe" game.
        //Check for other "safe" games.
        if (myContentDescriptors.Length == 0)
        {
            foreach (game myGame in gameDetails)
            {
                if (myGame.descriptors.Length == 0)
                {
                    if(myGame.applicationid.ToString() != gameBeingMadeID)
                    {
                        relevantGames.Add(myGame);
                        relevantGamesAdded += 1;
                    }
                   
                }
            }

        }
        else
        {
            foreach (game myGame in gameDetails)
            {
                if (myContentDescriptors.Any(myGame.descriptors.Contains))
                {
                    if(myGame.applicationid.ToString() != gameBeingMadeID)
                    {
                        relevantGames.Add(myGame);
                        relevantGamesAdded += 1;

                    }
                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }


        //Check if any games are below the minimum achievement threshold. If they are, they are not able to skip contents.
        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;
        

    }

    public int getAchievementRateInContentDescriptorID(string desiredDescriptorId, double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);

        string gameBeingMadeID = whatGameIDAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;
        foreach (game myGame in gameDetails)
        {
            if (myGame.descriptors.Contains(desiredDescriptorId))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;

                }
                    
            }
        }

        if(relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;


        //bool passedMinimumCheck = true;

        /*IDictionary<int, double> achievementRate = getTotalAchievements(relevantGames);
        foreach (int theKey in achievementRate.Keys)
        {
            if (achievementRate[theKey] < achievementThreshold)
            {
                passedMinimumCheck = false;
            }
        }
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;

        */
    }

    public int getPlayTimeInContentDescriptorID(string desiredDescriptorId, int minimumCDPlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);

       
            int totalTime = 0;

            foreach (game myGame in gameDetails)
            {
                if (myGame.descriptors.Contains(desiredDescriptorId))
                {
                    totalTime += myGame.playtimeforever;
                }
            }

            Debug.Log("Player has: " + totalTime + " minutes in:  " + getContentDescriptorFromID(desiredDescriptorId) + ".");
            if (totalTime >= minimumCDPlayTime)
            {
                Debug.Log("The player is qualified to skip contents.");
                return 1;

            }
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        
        

    }
    
    public int getAchievementRateInContentDescriptor(string desiredDescriptor, double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;
        foreach (game myGame in gameDetails)
        {
            if (decodeContentDescriptors(myGame.descriptors).Contains(desiredDescriptor))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;
                }
                    
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;
    }




    public int getPlayTimeInContentDescriptor(string desiredDescriptor, int minimumCDPlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);

        int totalTime = 0;
        foreach(game myGame in gameDetails)
        {
            if (decodeContentDescriptors(myGame.descriptors).Contains(desiredDescriptor))
            {
                totalTime += myGame.playtimeforever;
            }
        }

        Debug.Log("Player has: " + totalTime + " minutes in:  " + desiredDescriptor + ".");
        if (totalTime >= minimumCDPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;

        }
        Debug.Log("The player is NOT qualified to skip contents.");
        return 0;

       
    }
    
    public int getAchievementRateInDevelopers(double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);

        string gameBeingMadeID = whatGameIDAmI();

        string[] whoMadeMe = whoDevelopedMe();
        
        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach(game myGame in gameDetails)
        {
            if (whoMadeMe.Any(myGame.developers.Contains))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;

                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;


    }

    
    public int getPlayTimeInDevelopers(int minimumDeveloperPlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {

        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if(usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }


        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        
        string[] whoMadeMe = whoDevelopedMe();

        int totalTime = 0;
        int totalGames = 0;

        foreach(game myGame in gameDetails)
        {
            if (whoMadeMe.Any(myGame.developers.Contains))
            {
                totalTime += myGame.playtimeforever;
                totalGames += 1;
            }
        }

        Debug.Log("Player has played: " + totalGames + " games and has: " + totalTime + " minutes in " + printArray(whoMadeMe) + " games.");
        if(totalTime >= minimumDeveloperPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }

        Debug.Log("The player is NOT qualified to skip contents.");
        return 0;

    }

    
    public int getAchievementRateInPublishers(double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        string[] whoMadeMe = whoPublishedMe();
        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach(game myGame in gameDetails)
        {
            if (whoMadeMe.Any(myGame.publishers.Contains))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;
                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;

    }
    
    public int getPlayTimeInPublishers(int minimumPublisherPlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);

        string[] whoMadeMe = whoPublishedMe();

        int totalTime = 0;
        int totalGames = 0;

        foreach (game myGame in gameDetails)
        {
            if (whoMadeMe.Any(myGame.publishers.Contains))
            {
                totalTime += myGame.playtimeforever;
                totalGames += 1;
            }
        }

        Debug.Log("Player has played: " + totalGames + " games and has: " + totalTime + " minutes in " + printArray(whoMadeMe) + " games.");
        if (totalTime >= minimumPublisherPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }

        Debug.Log("The player is NOT qualified to skip contents.");
        return 0;

    }


    public int getAchievementRateInDevelopersAndPublishers(double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        string[] whoDev = whoDevelopedMe();
        string[] whoPub = whoPublishedMe();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach (game myGame in gameDetails)
        {
            if (whoDev.Any(myGame.developers.Contains) || whoPub.Any(myGame.publishers.Contains))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;
                }
                    
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;
    }
    
    public int getPlayTimeInDevelopersAndPublishers(int minimumPublisherPlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);

        string[] whoDev = whoDevelopedMe();
        string[] whoPub = whoPublishedMe();

        int totalTime = 0;
        int totalGames = 0;

        foreach (game myGame in gameDetails)
        {
            if (whoDev.Any(myGame.developers.Contains) || whoPub.Any(myGame.publishers.Contains))
            {
                totalTime += myGame.playtimeforever;
                totalGames += 1;
            }
        }

        Debug.Log("Player has played: " + totalGames + " games and has: " + totalTime + " minutes in " + printArray(whoDev) + " and " + printArray(whoPub) + " games.");
        if (totalTime >= minimumPublisherPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }

        Debug.Log("The player is NOT qualified to skip contents.");
        return 0;

    }

    public int getAchievementRateInOtherDevelopersAndPublishers(string creatorName, double achievementThreshold, int minimumGamePlayTime=300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach (game myGame in gameDetails)
        {
            if (myGame.developers.Contains(creatorName) || myGame.publishers.Contains(creatorName))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;
                }
                    
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;

    }

    public int getPlayTimeInOtherDevelopersAndPublishers(string creatorName, int minimumCreatorPlayTime, int minimumGamePlayTime=300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        int totalTime = 0;
        int totalGames = 0;
        foreach(game myGame in gameDetails)
        {
            if(myGame.developers.Contains(creatorName) || myGame.publishers.Contains(creatorName))
            {
                totalTime += myGame.playtimeforever;
                totalGames += 1;
            }
        }

        Debug.Log("Player has played: " + totalGames + " games and has: " + totalTime + " minutes in " + creatorName + " games.");
        if(totalTime >= minimumCreatorPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }
        Debug.Log("The player is NOT qualified to skip contents.");
        return 0;
    }


    public int getAchievementRateInOtherDevelopers(string developerName, double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach (game myGame in gameDetails)
        {
            if (myGame.developers.Contains(developerName))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;
                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;

    }


    public int getPlayTimeInOtherDevelopers(string developerName, int minimumDeveloperPlayTime, int minimumGamePlayTime=300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        int totalTimeWithDeveloper = 0;
        int totalGamesWithDeveloper = 0;
        foreach(game myGame in gameDetails)
        {
            if (myGame.developers.Contains(developerName))
            {
                totalTimeWithDeveloper += myGame.playtimeforever;
                totalGamesWithDeveloper += 1;
            }
        }

        Debug.Log("Player has played: " + totalGamesWithDeveloper + " games and has: " + totalTimeWithDeveloper + " minutes in " + developerName + " games.");

        if(totalTimeWithDeveloper >= minimumDeveloperPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }
        Debug.Log("The player is NOT qualified to skip contents.");
        return 0;

    }

    public int getAchievementRateInOtherPublishers(string publisherName, double achievementThreshold, int minimumGamePlayTime=300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach (game myGame in gameDetails)
        {
            if (myGame.publishers.Contains(publisherName))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;

                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;

    }

    public int getPlayTimeInOtherPublishers(string publisherName, int minimumPublisherPlayTime, int minimumGamePlayTime=300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        int totalTimeWithPublisher = 0;
        int totalGamesWithPublisher = 0;
        foreach(game myGame in gameDetails)
        {
            if (myGame.publishers.Contains(publisherName))
            {
                totalTimeWithPublisher += myGame.playtimeforever;
                totalGamesWithPublisher += 1;
            }
        }

        Debug.Log("Player has played: " + totalGamesWithPublisher + " games and has: " + totalTimeWithPublisher + " minutes in " + publisherName + " games.");

        if(totalTimeWithPublisher >= minimumPublisherPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }
        Debug.Log("The player is NOT qualified to skip contents.");
        return 0;


    }

    public int getAchievementRateInOtherTags(string tagName, double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

         foreach (game myGame in gameDetails)
        {
            if (myGame.tags.Contains(tagName))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;
                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;
    }

    public int getPlayTimeInOtherTags(string tagName, int minimumTagPlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();


        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        IDictionary<string, int> tagTable = createGameTagTable(gameDetails);
        bool isQualified = true;

        if (tagTable.ContainsKey(tagName))
        {
            Debug.Log(tagName + " has been played by the user for " + tagTable[tagName] + " minutes.");
            if (tagTable[tagName] < minimumTagPlayTime)
            {
                isQualified = false;
            }
        }
        else
        {
            Debug.Log(tagName + " has NOT been played by the user.");
            isQualified = false;
        }

        if (isQualified == true)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }
        else
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
    }


    public int getAchievementRateInTags(double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        string[] myTags = whatGameTagAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach (game myGame in gameDetails)
        {
            if (myTags.Any(myGame.tags.Contains))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;
                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;

    }






    public int getPlayTimeInTags(int minimumTagPlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        IDictionary<string, int> tagTable = createGameTagTable(gameDetails);

        string[] myTags = whatGameTagAmI();
        bool isQualified = true;

        if (myTags == null)
        {
            Debug.Log("An error has occured with getting my game info. Returning as if the player can NOT skip the contents.");
            return 0;
        }

        foreach (string tag in myTags)
        {
            if (tagTable.ContainsKey(tag))
            {
                Debug.Log(tag + " has been played by the user for " + tagTable[tag] + " minutes.");
                if (tagTable[tag] < minimumTagPlayTime)
                {
                    isQualified = false;
                }
            }
            else
            {
                Debug.Log(tag + " has NOT been played by the user.");
                isQualified = false;
            }
        }

        if (isQualified == true)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }
        else
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

    }

    public int getAchievementRateInOtherGenre(string genreName, double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach (game myGame in gameDetails)
        {
            if (myGame.genres.Contains(genreName))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {
                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;
                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;

    }


    public int getPlayTimeInOtherGenre(string genreName, int minimumGenrePlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();


        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        IDictionary<string, int> genreTable = createGameGenreTable(gameDetails);

        bool isQualified = true;

        if (genreTable.ContainsKey(genreName))
        {
            Debug.Log(genreName + " has been played by the user for " + genreTable[genreName] + " minutes.");
            if (genreTable[genreName] < minimumGenrePlayTime)
            {
                isQualified = false;
            }
            
        }
        else
        {
            Debug.Log(genreName + " has NOT been played by the user.");
            isQualified = false;
        }

        if (isQualified == true)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }
        else
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

    }

    public int getAchievementRateInGenre(double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        string[] myGenres = whatGameGenreAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach(game myGame in gameDetails)
        {
            if (myGenres.Any(myGame.genres.Contains))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {

                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;

                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;

    }

    

    public int getPlayTimeInGenre(int minimumGenrePlayTime, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {
        databaseSetup();


        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        IDictionary<string, int> genreTable = createGameGenreTable(gameDetails);
        

        string[] myGenres = whatGameGenreAmI();
        bool isQualified = true;


        if (myGenres == null)
        {
            Debug.Log("An error has occured with getting my game info. Returning as if the player can NOT skip the contents.");
            return 0;
        }

        foreach (string genre in myGenres)
        {
            if (genreTable.ContainsKey(genre))
            {
                Debug.Log(genre + " has been played by the user for " + genreTable[genre] + " minutes.");
                if (genreTable[genre] < minimumGenrePlayTime)
                {
                    isQualified = false;
                }
            }
            else
            {
                Debug.Log(genre + " has NOT been played by the user.");
                isQualified = false;
            }
        }

        if (isQualified == true)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }
        else
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

    }


    public int getAchievementRateInGames(string gameName, double achievementThreshold, int minimumGamePlayTime = 300, int topGamesChecked = 100)
    {

        databaseSetup();
        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        List<game> gameDetails = getGameInformation(usersGames, minimumGamePlayTime, topGamesChecked);
        string gameBeingMadeID = whatGameIDAmI();

        List<game> relevantGames = new List<game>();
        int relevantGamesAdded = 0;

        foreach (game myGame in gameDetails)
        {
            if (myGame.gamename.Contains(gameName))
            {
                if (myGame.applicationid.ToString() != gameBeingMadeID)
                {

                    relevantGames.Add(myGame);
                    relevantGamesAdded += 1;

                }
            }
        }

        if (relevantGamesAdded == 0)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        bool passedMinimumCheck = meetAchievementRequirements(relevantGames, achievementThreshold);
        if (passedMinimumCheck == false)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }
        Debug.Log("The player is qualified to skip contents.");
        return 1;
    }


    public int getPlayTimeInGames(string gameName, int requiredPlayTime)
    {

        databaseSetup();

        response usersGames = getUsersPlayedGames();
        if (usersGames == null)
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

        int currentPlayTime = 0;
        foreach (UserGameInfo individualGame in usersGames.games)
        {
            if (individualGame.name.Contains(gameName))
            {
                currentPlayTime += individualGame.playtime_forever;
                Debug.Log(gameName + " was found, actual title: " + individualGame.name + ". Playtime in game: " + individualGame.playtime_forever + " minute(s).");
            }
        }

        if(currentPlayTime >= requiredPlayTime)
        {
            Debug.Log("The player is qualified to skip contents.");
            return 1;
        }
        else
        {
            Debug.Log("The player is NOT qualified to skip contents.");
            return 0;
        }

    }


    //This function gets the players steam library info, including all the games they have played and their playtime.
    //The data is stored in a "response"(gamecount, games) called playedGames
    public response getUsersPlayedGames()
    {

        //Get SteamID of Player.
        CSteamID steamID = Steamworks.SteamUser.GetSteamID();
        string SID = (steamID.ToString());

        //Get a link to the players profile
        string profileURL = "https://steamcommunity.com/profiles/" + SID;

        

        string THEKEY = "";
        if (File.Exists(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_api_key.txt"))))
        {
            THEKEY = File.ReadAllText(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_api_key.txt")));
        }
        else
        {
            return null;
        }

        if(THEKEY == "")
        {
            return null;
        }


        //-----------Get players owned games in Steam Library.-----------

        
        string url = "https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + THEKEY + "&steamid=" + SID + "&include_appinfo=true&include_played_free_games=true/";

        //Create API call to get owned games in players steam library
        HttpWebRequest userInfoRequest = (HttpWebRequest)(WebRequest.Create(url));
        HttpWebResponse userInfoResponse = (HttpWebResponse)userInfoRequest.GetResponse();
        StreamReader userInfoReader = new StreamReader(userInfoResponse.GetResponseStream());
        string json = userInfoReader.ReadToEnd();

        //Store results of API call (players steam library game data)
        string json2 = json;
        json2 = json2.Remove(0, 12);
        json2 = json2.Remove(json2.Length - 1);

        response playedGames = JsonUtility.FromJson<response>(json2);

        //Sorts the games by highest playtime (used for optimization).
        UserGameInfo[] sortedPlayedGames = playedGames.games.OrderByDescending(myPT => myPT.playtime_forever).ToArray();
        playedGames.games = sortedPlayedGames;

        return playedGames;
    }

    //This gets the data on the top games in the players steam library.
    //Not all games due to limitations with the steam API.
    public List<game> getGameInformation(response playedGames, int TIMETHRESHOLD, int GAMENUMBERTHRESHOLD)
    {
        //-----------Get info on the games the player has played (genres)-----------

        //http://store.steampowered.com/api/appdetails?appids={APPID}
        string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";
        string baseCMDurl = "https://api.steamcmd.net/v1/info/";

        //Create a list of games that meet the playtime criteria, and store the info: (appid, name, playtime, genre(s))
        List<game> games = new List<game>();

        //Tempcounter can be removed, OR can be developed further to limit the maximum number of games the developer wants to check (e.g. top 100 games)
        //int gamesAdded = 0;

        int errorCount = 0;

        //Store the players top game info
        foreach (UserGameInfo individualGame in playedGames.games)
        {

            //If the game exists in the DB, there is no need to look it up.
            if (checkIfExists(individualGame.appid) == false)
            //if(TIMETHRESHOLD < individualGame.playtime_forever)
            {

                try
                {

                
                
               HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + individualGame.appid+ "&l=en"));
                HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
                StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
                string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
                string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
                SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);
               
                int tempID = individualGame.appid;
                string tempName = individualGame.name;
                int tempPlayTime = individualGame.playtime_forever;


                //If there was an error, do not try to add to db.
                if (steamInfoOnGame.success == false){
                    //Debug.Log("skipping " + tempID + " " + tempName);
                    specificGameInfoReader.Close();
                    continue;
                }

                string[] tempGenres = getGenres(steamInfoOnGame.data.genres).ToArray();
                string[] tempDevs = steamInfoOnGame.data.developers;
                string[] tempPubs = steamInfoOnGame.data.publishers;
                int[] tempContentDescriptorsInt = steamInfoOnGame.data.content_descriptors.ids;
                string[] tempContentDescriptors = tempContentDescriptorsInt.Select(y => y.ToString()).ToArray();

                specificGameInfoReader.Close();

               
                HttpWebRequest specificCMDInfoRequest = (HttpWebRequest)(WebRequest.Create(baseCMDurl + individualGame.appid));
                HttpWebResponse specificCMDInfoResponse = (HttpWebResponse)specificCMDInfoRequest.GetResponse();
                StreamReader specificCMDInfoReader = new StreamReader(specificCMDInfoResponse.GetResponseStream());
                string specificCMDInfoJSON = specificCMDInfoReader.ReadToEnd();
                string croppedCMDJSON = removeEnding(findAppropriateJSON(findAppropriateJSON(specificCMDInfoJSON)));
                //REQUIRED, steamcmd api returns variable names that start with raw numbers (e.g. 0). In order for this to work, we must rename those values to "_<number>"
                croppedCMDJSON = croppedCMDJSON.Replace("\"0\":", "\"_0\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"1\":", "\"_1\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"2\":", "\"_2\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"3\":", "\"_3\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"4\":", "\"_4\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"5\":", "\"_5\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"6\":", "\"_6\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"7\":", "\"_7\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"8\":", "\"_8\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"9\":", "\"_9\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"10\":", "\"_10\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"11\":", "\"_11\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"12\":", "\"_12\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"13\":", "\"_13\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"14\":", "\"_14\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"15\":", "\"_15\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"16\":", "\"_16\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"17\":", "\"_17\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"18\":", "\"_18\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"19\":", "\"_19\":");
                gameCMDInfo steamCMDInfo = JsonUtility.FromJson<gameCMDInfo>(croppedCMDJSON);

                string[] tempTags = (decodeTags(steamCMDInfo.common.store_tags.getAllTags()));

                specificCMDInfoReader.Close();

                game currentGame = new game(tempID, tempName, tempPlayTime, tempDevs, tempPubs, tempGenres,tempTags,tempContentDescriptors);
                games.Add(currentGame);

                /*Debug.Log(currentGame.applicationid + " " + currentGame.gamename + " " + currentGame.playtimeforever + " " +
                    printArray(currentGame.developers) + " " + printArray(currentGame.publishers) + " " + printGenres(steamInfoOnGame.data.genres) + " " + 
                    printArray(currentGame.tags));
                */

        insertIntoDB(currentGame.applicationid, currentGame.gamename, breakUpArray(currentGame.developers), breakUpArray(currentGame.publishers), breakUpArray(currentGame.genres), breakUpArray(currentGame.tags), breakUpArray(currentGame.descriptors));
                }
                catch(WebException e)
                {
                    errorCount += 1;

                    
                    Debug.Log(e.Message);
                    if (e.Message.Contains("Bad Gateway"))
                    {
                        Debug.Log("Skipping " + individualGame.appid + " and attempting resume.");
                    }
                    else
                    {
                        Debug.Log("Exiting.");
                        break;
                    }


                    if (errorCount >= 3)
                    {
                        Debug.Log("ERR: Too many errors. Exiting.");
                        break;
                    }
                }


                //gamesAdded += 1;
            }
            else
            {
                //Retrieves the game and its info from the database.

                game tempGame = dbGetGame(individualGame.appid, individualGame.playtime_forever);

                //If there was an error getting the game from the DB, do not add it to the overall game list.
                if(tempGame.gamename != "ERR GAME")
                {
                    games.Add(tempGame);
                }
            }
            

            //If user has a bunch of games above the time threshold, then a cap on the number of "top games" is restricted.
            /*if(gamesAdded >= GAMENUMBERTHRESHOLD)
            {
                break;
            }*/

        }
        //Return the list of games that meet the playtime criteria, and store the info: (appid, name, playtime, genre(s))
        return games;
    }

    //This function creates a "genre table" that contains the playtime of each genre, and the genre name.
    public IDictionary<string, int> createGameGenreTable(List<game> games)
    {
        //Format: gameID, GameName, playtime, genres

        //Create dictionary 
        IDictionary<string, int> genrePlayTimes = new Dictionary<string, int>();

        //Loop through all the top games, and then their genres
        foreach(game currentGame in games)
        {
            foreach(string currentGenre in currentGame.genres)
            {

                //Append the playtime forever to the genre value in the dictionary.

                //If the genre exists in the genre library
                if (genrePlayTimes.ContainsKey(currentGenre))
                {
                    genrePlayTimes[currentGenre] += currentGame.playtimeforever;
                }
                else
                {
                    genrePlayTimes.Add(currentGenre, currentGame.playtimeforever);
                }

            }
        }
        printGenreDictionary(genrePlayTimes);
        return genrePlayTimes;
    }

    public string whatGameIDAmI()
    {
        string IAmAppID = "";
        if (File.Exists(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt"))))
        {
            IAmAppID = File.ReadAllText(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt")));
        }
        else
        {
            return null;
        }

        return IAmAppID;
    }


    //Gets information about the game currently being developed.
    public string[] whatGameGenreAmI()
    {
        
        //Source for Path.GetFullPath: https://forum.unity.com/threads/how-to-get-the-location-or-path-of-above-folder-of-the-current-script.885391/
        //If there is a valid path to the game info, proceed, else return nothing (error)
        
        string IAmAppID = "";
        if (File.Exists(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt"))))
        {
            IAmAppID = File.ReadAllText(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt")));
        }
        else
        {
            return null;
        }


        //If the game exists in the DB, there is no need to look it up.
        if (checkIfExists(int.Parse(IAmAppID)) == false)
        {
            //Look up my game in the steam API.
            string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";

            HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + IAmAppID));
            HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
            StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
            string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
            string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
            SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);

            string[] thisGameGenres = getGenres(steamInfoOnGame.data.genres).ToArray();

            Debug.Log(" I am: " + IAmAppID + " and my genres are: " + printStringGenres(thisGameGenres));

            specificGameInfoReader.Close();

            return thisGameGenres;

        }
        else
        {
            //Get instance of game (-9999 is just a placeholder value - it will not be used.)
            game tempGame = dbGetGame(int.Parse(IAmAppID), -9999);
            
            if (tempGame.gamename == "ERR GAME")
            {
                Debug.Log("Game Lookup failed.");
                //Look up my game in the steam API.
                string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";

                HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + IAmAppID));
                HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
                StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
                string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
                string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
                SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);

                string[] thisGameGenres = getGenres(steamInfoOnGame.data.genres).ToArray();

                Debug.Log(" I am: " + IAmAppID + " and my genres are: " + printStringGenres(thisGameGenres));

                specificGameInfoReader.Close();

                return thisGameGenres;
            }
            else
            {
                Debug.Log("Game retrieved from DB Successfully.");
                string[] thisGameGenres = tempGame.genres;
                Debug.Log(" I am: " + IAmAppID + " and my genres are: " + printStringGenres(thisGameGenres));
                return thisGameGenres;

            }
        }
        

    }



    //This function creates a "genre table" that contains the playtime of each genre, and the genre name.
    public IDictionary<string, int> createGameTagTable(List<game> games)
    {
        //Format: gameID, GameName, playtime, genres

        //Create dictionary 
        IDictionary<string, int> tagPlayTimes = new Dictionary<string, int>();

        //Loop through all the top games, and then their genres
        foreach (game currentGame in games)
        {
            foreach (string currentTag in currentGame.tags)
            {

                //Append the playtime forever to the genre value in the dictionary.

                //If the genre exists in the genre library
                if (tagPlayTimes.ContainsKey(currentTag))
                {
                    tagPlayTimes[currentTag] += currentGame.playtimeforever;
                }
                else
                {
                    tagPlayTimes.Add(currentTag, currentGame.playtimeforever);
                }

            }
        }
        printGenreDictionary(tagPlayTimes);
        return tagPlayTimes;
    }




    //Gets information about the game currently being developed.
    public string[] whatGameTagAmI()
    {

        //Source for Path.GetFullPath: https://forum.unity.com/threads/how-to-get-the-location-or-path-of-above-folder-of-the-current-script.885391/
        //If there is a valid path to the game info, proceed, else return nothing (error)

        string IAmAppID = "";
        if (File.Exists(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt"))))
        {
            IAmAppID = File.ReadAllText(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt")));
        }
        else
        {
            return null;
        }


        //If the game exists in the DB, there is no need to look it up.
        if (checkIfExists(int.Parse(IAmAppID)) == false)
        {
            //Look up my game in the steam API.
            string baseCMDurl = "https://api.steamcmd.net/v1/info/";


            HttpWebRequest specificCMDInfoRequest = (HttpWebRequest)(WebRequest.Create(baseCMDurl + IAmAppID));
            HttpWebResponse specificCMDInfoResponse = (HttpWebResponse)specificCMDInfoRequest.GetResponse();
            StreamReader specificCMDInfoReader = new StreamReader(specificCMDInfoResponse.GetResponseStream());
            string specificCMDInfoJSON = specificCMDInfoReader.ReadToEnd();
            string croppedCMDJSON = removeEnding(findAppropriateJSON(findAppropriateJSON(specificCMDInfoJSON)));
            //REQUIRED, steamcmd api returns variable names that start with raw numbers (e.g. 0). In order for this to work, we must rename those values to "_<number>"
            croppedCMDJSON = croppedCMDJSON.Replace("\"0\":", "\"_0\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"1\":", "\"_1\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"2\":", "\"_2\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"3\":", "\"_3\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"4\":", "\"_4\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"5\":", "\"_5\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"6\":", "\"_6\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"7\":", "\"_7\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"8\":", "\"_8\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"9\":", "\"_9\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"10\":", "\"_10\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"11\":", "\"_11\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"12\":", "\"_12\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"13\":", "\"_13\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"14\":", "\"_14\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"15\":", "\"_15\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"16\":", "\"_16\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"17\":", "\"_17\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"18\":", "\"_18\":");
            croppedCMDJSON = croppedCMDJSON.Replace("\"19\":", "\"_19\":");
            gameCMDInfo steamCMDInfo = JsonUtility.FromJson<gameCMDInfo>(croppedCMDJSON);

            string[] thisGameTags = (decodeTags(steamCMDInfo.common.store_tags.getAllTags()));

            Debug.Log(" I am: " + IAmAppID + " and my tags are: " + printArray(thisGameTags));

            specificCMDInfoReader.Close();

            return thisGameTags;


        }
        else
        {
            //Get instance of game (-9999 is just a placeholder value - it will not be used.)
            game tempGame = dbGetGame(int.Parse(IAmAppID), -9999);

            if (tempGame.gamename == "ERR GAME")
            {
                Debug.Log("Game Lookup failed.");
                //Look up my game in the steam API.
                string baseCMDurl = "https://api.steamcmd.net/v1/info/";


                HttpWebRequest specificCMDInfoRequest = (HttpWebRequest)(WebRequest.Create(baseCMDurl + IAmAppID));
                HttpWebResponse specificCMDInfoResponse = (HttpWebResponse)specificCMDInfoRequest.GetResponse();
                StreamReader specificCMDInfoReader = new StreamReader(specificCMDInfoResponse.GetResponseStream());
                string specificCMDInfoJSON = specificCMDInfoReader.ReadToEnd();
                string croppedCMDJSON = removeEnding(findAppropriateJSON(findAppropriateJSON(specificCMDInfoJSON)));
                //REQUIRED, steamcmd api returns variable names that start with raw numbers (e.g. 0). In order for this to work, we must rename those values to "_<number>"
                croppedCMDJSON = croppedCMDJSON.Replace("\"0\":", "\"_0\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"1\":", "\"_1\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"2\":", "\"_2\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"3\":", "\"_3\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"4\":", "\"_4\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"5\":", "\"_5\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"6\":", "\"_6\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"7\":", "\"_7\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"8\":", "\"_8\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"9\":", "\"_9\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"10\":", "\"_10\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"11\":", "\"_11\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"12\":", "\"_12\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"13\":", "\"_13\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"14\":", "\"_14\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"15\":", "\"_15\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"16\":", "\"_16\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"17\":", "\"_17\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"18\":", "\"_18\":");
                croppedCMDJSON = croppedCMDJSON.Replace("\"19\":", "\"_19\":");
                gameCMDInfo steamCMDInfo = JsonUtility.FromJson<gameCMDInfo>(croppedCMDJSON);

                string[] thisGameTags = (decodeTags(steamCMDInfo.common.store_tags.getAllTags()));

                Debug.Log(" I am: " + IAmAppID + " and my tags are: " + printArray(thisGameTags));

                specificCMDInfoReader.Close();

                return thisGameTags;
            }
            else
            {
                Debug.Log("Game retrieved from DB Successfully.");
                string[] thisGameTags = tempGame.tags;
                Debug.Log(" I am: " + IAmAppID + " and my tags are: " + printArray(thisGameTags));
                return thisGameTags;

            }
        }


    }


    public string[] whatAreMyContentDescriptors()
    {
        //Source for Path.GetFullPath: https://forum.unity.com/threads/how-to-get-the-location-or-path-of-above-folder-of-the-current-script.885391/
        //If there is a valid path to the game info, proceed, else return nothing (error)
        string IAmAppID = "";
        if (File.Exists(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt"))))
        {
            IAmAppID = File.ReadAllText(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt")));
        }
        else
        {
            return null;
        }

        //If the game exists in the DB, there is no need to look it up.
        if (checkIfExists(int.Parse(IAmAppID)) == false)
        {
            //Look up my game in the steam API
            string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";

            HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + IAmAppID));
            HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
            StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
            string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
            string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
            SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);

           

            int[] thisGameContentDescriptorsInt = steamInfoOnGame.data.content_descriptors.ids;
            string[] thisGameContentDescriptors = thisGameContentDescriptorsInt.Select(y => y.ToString()).ToArray();
            specificGameInfoReader.Close();

            return thisGameContentDescriptors;
        }
        else
        {
            //Get instance of game (-9999 is just a placeholder value - it will not be used.)
            game tempGame = dbGetGame(int.Parse(IAmAppID), -9999);

            if(tempGame.gamename == "ERR GAME")
            {
                Debug.Log("Game Lookup failed."); ;

                //Look up my game in the steam API.
                string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";

                HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + IAmAppID));
                HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
                StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
                string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
                string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
                SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);



                int[] thisGameContentDescriptorsInt = steamInfoOnGame.data.content_descriptors.ids;
                string[] thisGameContentDescriptors = thisGameContentDescriptorsInt.Select(y => y.ToString()).ToArray();
                specificGameInfoReader.Close();

                return thisGameContentDescriptors;
            }
            else
            {
                Debug.Log("Game retrieved from DB Successfully.");
                string[] thisGameContentDescriptors = tempGame.descriptors;
                Debug.Log("I am: " + IAmAppID + " and my content descriptors are: " + printStringGenres(thisGameContentDescriptors) + " | " + printStringGenres(decodeContentDescriptors(thisGameContentDescriptors)));
                return thisGameContentDescriptors;
            }

        }

    }


    //Gets information about the game currently being developed.
    public string[] whoDevelopedMe()
    {

        //Source for Path.GetFullPath: https://forum.unity.com/threads/how-to-get-the-location-or-path-of-above-folder-of-the-current-script.885391/
        //If there is a valid path to the game info, proceed, else return nothing (error)

        string IAmAppID = "";
        if (File.Exists(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt"))))
        {
            IAmAppID = File.ReadAllText(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt")));
        }
        else
        {
            return null;
        }


        //If the game exists in the DB, there is no need to look it up.
        if (checkIfExists(int.Parse(IAmAppID)) == false)
        {
            //Look up my game in the steam API.
            string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";

            HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + IAmAppID));
            HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
            StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
            string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
            string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
            SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);

            string[] thisGameDevelopers = steamInfoOnGame.data.developers.ToArray();

            Debug.Log(" I am: " + IAmAppID + " and my developers are: " + printStringGenres(thisGameDevelopers));

            specificGameInfoReader.Close();

            return thisGameDevelopers;

        }
        else
        {
            //Get instance of game (-9999 is just a placeholder value - it will not be used.)
            game tempGame = dbGetGame(int.Parse(IAmAppID), -9999);

            if (tempGame.gamename == "ERR GAME")
            {
                Debug.Log("Game Lookup failed.");
                //Look up my game in the steam API.
                string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";

                HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + IAmAppID));
                HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
                StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
                string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
                string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
                SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);

                string[] thisGameDevelopers = steamInfoOnGame.data.developers.ToArray();

                Debug.Log(" I am: " + IAmAppID + " and my developers are: " + printStringGenres(thisGameDevelopers));

                specificGameInfoReader.Close();

                return thisGameDevelopers;
            }
            else
            {
                Debug.Log("Game retrieved from DB Successfully.");
                string[] thisGameDevelopers = tempGame.developers;
                Debug.Log(" I am: " + IAmAppID + " and my developers are: " + printStringGenres(thisGameDevelopers));
                return thisGameDevelopers;

            }
        }


    }


    //Gets information about the game currently being developed.
    public string[] whoPublishedMe()
    {

        //Source for Path.GetFullPath: https://forum.unity.com/threads/how-to-get-the-location-or-path-of-above-folder-of-the-current-script.885391/
        //If there is a valid path to the game info, proceed, else return nothing (error)

        string IAmAppID = "";
        if (File.Exists(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt"))))
        {
            IAmAppID = File.ReadAllText(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_appid.txt")));
        }
        else
        {
            return null;
        }


        //If the game exists in the DB, there is no need to look it up.
        if (checkIfExists(int.Parse(IAmAppID)) == false)
        {
            //Look up my game in the steam API.
            string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";

            HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + IAmAppID));
            HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
            StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
            string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
            string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
            SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);

            string[] thisGamePublishers = steamInfoOnGame.data.publishers.ToArray();

            Debug.Log(" I am: " + IAmAppID + " and my publishers are: " + printStringGenres(thisGamePublishers));

            specificGameInfoReader.Close();

            return thisGamePublishers;

        }
        else
        {
            //Get instance of game (-9999 is just a placeholder value - it will not be used.)
            game tempGame = dbGetGame(int.Parse(IAmAppID), -9999);

            if (tempGame.gamename == "ERR GAME")
            {
                Debug.Log("Game Lookup failed.");
                //Look up my game in the steam API.
                string basegameurl = "https://store.steampowered.com/api/appdetails?appids=";

                HttpWebRequest specificGameInfoRequest = (HttpWebRequest)(WebRequest.Create(basegameurl + IAmAppID));
                HttpWebResponse specificGameInfoResponse = (HttpWebResponse)specificGameInfoRequest.GetResponse();
                StreamReader specificGameInfoReader = new StreamReader(specificGameInfoResponse.GetResponseStream());
                string specificGameInfoJSON = specificGameInfoReader.ReadToEnd();
                string croppedJSON = findAppropriateJSON(specificGameInfoJSON);
                SteamStoreGameInfo steamInfoOnGame = JsonUtility.FromJson<SteamStoreGameInfo>(croppedJSON);

                string[] thisGamePublishers = steamInfoOnGame.data.publishers.ToArray();

                Debug.Log(" I am: " + IAmAppID + " and my publishers are: " + printStringGenres(thisGamePublishers));

                specificGameInfoReader.Close();

                return thisGamePublishers;
            }
            else
            {
                Debug.Log("Game retrieved from DB Successfully.");
                string[] thisGamePublishers = tempGame.publishers;
                Debug.Log(" I am: " + IAmAppID + " and my publishers are: " + printStringGenres(thisGamePublishers));
                return thisGamePublishers;

            }
        }


    }


    public bool meetAchievementRequirements(List<game> games, double minThreshold)
    {
        bool passedCheck = true;
        foreach (game currentGame in games)
        {
            double gameAchievementScore = sumAchievements(currentGame.applicationid.ToString());
            if(gameAchievementScore < minThreshold)
            {
                passedCheck = false;
                break;
            }
        }
        if (passedCheck == true)
        {
            return true;
        }
        return false;
    }


    //This function gets the completion achievement % per game for ALL games.

    public IDictionary<int, double> getTotalAchievements(List<game> games)
    {
        //Create Dictionary
        IDictionary<int, double> achievements = new Dictionary<int, double>();

        
        //Loop through all the top games, and then their genres
        foreach (game currentGame in games)
        {
            achievements.Add(currentGame.applicationid, sumAchievements(currentGame.applicationid.ToString()));
        }
        return achievements;
    }
    

    //This function gets the fractional value of the amount of achievements a player has for a game.
    public double sumAchievements(string aid)
    {
        
        string THEKEY = "";
        if (File.Exists(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_api_key.txt"))))
        {
            THEKEY = File.ReadAllText(Path.GetFullPath(Path.Combine(Application.dataPath, "../steam_api_key.txt")));
        }
        else
        {
            return -9999.0;
        }

        if (THEKEY == "")
        {
            return -9999.0;
        }


        //-----------Get players STEAMID.-----------
        CSteamID steamID = Steamworks.SteamUser.GetSteamID();
        string SID = (steamID.ToString());

        
        string url = "https://api.steampowered.com/ISteamUserStats/GetPlayerAchievements/v0001/?appid=" + aid + "&key=" + THEKEY + "&steamid=" + SID;


        try
        {

            //Create API call to total achievements for a game that a player has
            HttpWebRequest userAchievementRequest = (HttpWebRequest)(WebRequest.Create(url));
            HttpWebResponse userAchievementResponse = (HttpWebResponse)userAchievementRequest.GetResponse();
            StreamReader userAchievementReader = new StreamReader(userAchievementResponse.GetResponseStream());
            string achievementsJSON = userAchievementReader.ReadToEnd();
            userAchievementReader.Close();
            playerAchievements gameAchievement = JsonUtility.FromJson<playerAchievements>(achievementsJSON);

            if (gameAchievement.playerstats.achievements is null == false)
            {
                try
                {
                    double totalAchievementPercent = gameAchievement.playerstats.getAchievementInfo();
                    return totalAchievementPercent;
                }

                catch (Exception e)
                {
                    Debug.Log("Error trying to find achievements for game: " + aid + ". Giving 100% completion rate. The following error was found: " + e);
                    return 1.0;
                }

            }
            else
            {
                Debug.Log("Error trying to find achievements for game: " + aid + ". Giving 100% completion rate.");
                return 1.0;
            }

            

        }
        catch (WebException e)
        {
            //If the app has no achievements/if an error occured, give it a rate of 1.0.
            Debug.Log(aid + " is being given 100% completion rate due to the following error : "+  e);
            return 1.0;
        }


    }




    //Used to modify steam store api JSON return
    string findAppropriateJSON(string jsonToModify)
    {
        string modifiedJson = "";
        for (int i =1; i< jsonToModify.Length; i++)
        {
            if (jsonToModify[i].Equals('{'))
            {
                modifiedJson = jsonToModify;
                modifiedJson = modifiedJson.Remove(0, i);
                modifiedJson = modifiedJson.Remove(modifiedJson.Length - 1);
                break;
            }
        }

        return modifiedJson;
    }

    //Used to print out for "foreach (UserGameInfo individualGame in playedGames.games)" section
    string printGenres(Genre[] genreList)
    {
        string allGenres = "";

        if(genreList == null)
        {
            return allGenres;
        }

        foreach (Genre i in genreList)
        {
            allGenres += (i.description + " ");
        }
        return allGenres;
    }

    string printStringGenres(string[] genreList)
    {
        string allGenres = "";

        if (genreList == null)
        {
            return allGenres;
        }

        foreach (string i in genreList)
        {
            allGenres += (i  + " ");
        }
        return allGenres;
    }

    string printArray(string[] myArray)
    {
        string element = "";

        if (myArray == null)
        {
            return element;
        }

        foreach (string i in myArray)
        {
            element += (i + " ");
        }
        return element;
    }

    //Used to append genres to the game list.
    List<string> getGenres(Genre[] genreList)
    {
        List<string> genreTitles = new List<string>();

        if(genreList == null)
        {
            return genreTitles;
        }

        foreach (Genre i in genreList)
        {
            genreTitles.Add(i.description);
        }
        return genreTitles;
    }

    


    public void printGameGenreInfo(List<game> games)
    {
        foreach (game currentGame in games)
        {
            //printGenres 
            Debug.Log(currentGame.applicationid + " " + currentGame.gamename + " " + currentGame.playtimeforever + " " + printStringGenres(currentGame.genres));

        }
    }


    public void printGenreDictionary(IDictionary<string, int> gameGenreInfo)
    {
        foreach (KeyValuePair<string, int> genre in gameGenreInfo)
        {
            Debug.Log(genre.Key + " " + genre.Value);
        }
    }


    public string breakUpArray(string[] myArray)
    {
        if (myArray == null)
        {
            return "";
        }

        string finalString = "";
        foreach(string subsetString in myArray)
        {
            string stringDelimited = subsetString + "|";
            finalString += stringDelimited;
        }
        return finalString;
    }


    public string[] restoreArray(string delimitedString)
    {
        string element = "";
        List<string> restoredList = new List<string>();
        for (int i =0; i< delimitedString.Length; i++)
        {
            if(delimitedString[i].Equals('|'))
            {
                restoredList.Add(element);
                element = "";
            }
            else
            {
                element += delimitedString[i];
            }
        }

        string[] restoredArray = restoredList.ToArray();
        return restoredArray;
    }


    public string removeEnding(string toBeRemoved)
    {
        //, "status": "success"
        toBeRemoved = toBeRemoved.Remove(toBeRemoved.Length - 21);
        //toBeRemoved = toBeRemoved.Replace(", \"status\": \"success\"}", "");
        return toBeRemoved;
    }


    public string[] decodeTags(string[] encodedTags)
    {
        IDictionary<string, string> decodedTags = new Dictionary<string, string>() { { "492", "Indie" }, { "1003823", "Profile Features Limited" }, { "19", "Action" }, { "4182", "Singleplayer" }, { "597", "Casual" }, { "21", "Adventure" }, { "599", "Simulation" }, { "9", "Strategy" }, { "122", "RPG" }, { "3871", "2D" }, { "4191", "3D" }, { "4166", "Atmospheric" }, { "1664", "Puzzle" }, { "1684", "Fantasy" }, { "3964", "Pixel Graphics" }, { "1742", "Story Rich" }, { "4305", "Colorful" }, { "3834", "Exploration" }, { "4726", "Cute" }, { "113", "Free to Play" }, { "3859", "Multiplayer" }, { "493", "Early Access" }, { "3839", "First-Person" }, { "1773", "Arcade" }, { "4085", "Anime" }, { "1774", "Shooter" }, { "4106", "Action-Adventure" }, { "4136", "Funny" }, { "3942", "Sci-fi" }, { "1654", "Relaxing" }, { "12095", "Sexual Content" }, { "6650", "Nudity" }, { "1625", "Platformer" }, { "1667", "Horror" }, { "5350", "Family Friendly" }, { "4004", "Retro" }, { "4667", "Violent" }, { "7208", "Female Protagonist" }, { "3993", "Combat" }, { "1697", "Third Person" }, { "7948", "Soundtrack" }, { "4252", "Stylized" }, { "3799", "Visual Novel" }, { "1695", "Open World" }, { "4791", "Top-Down" }, { "7481", "Controller" }, { "1662", "Survival" }, { "4175", "Realistic" }, { "4345", "Gore" }, { "21978", "VR" }, { "701", "Sports" }, { "5379", "2D Platformer" }, { "1719", "Comedy" }, { "6426", "Choices Matter" }, { "1775", "PvP" }, { "4026", "Difficult" }, { "1685", "Co-op" }, { "3916", "Old School" }, { "4195", "Cartoony" }, { "1663", "FPS" }, { "5716", "Mystery" }, { "3968", "Physics" }, { "4342", "Dark" }, { "7250", "Linear" }, { "6971", "Multiple Endings" }, { "699", "Racing" }, { "65443", "Adult Content" }, { "3810", "Sandbox" }, { "4172", "Medieval" }, { "4094", "Minimalist" }, { "4747", "Character Customization" }, { "4255", "Shoot 'Em Up" }, { "6730", "PvE" }, { "1721", "Psychological Horror" }, { "1698", "Point & Click" }, { "1756", "Great Soundtrack" }, { "1755", "Space" }, { "128", "Massively Multiplayer" }, { "4231", "Action RPG" }, { "3843", "Online Co-Op" }, { "6815", "Hand-drawn" }, { "4057", "Magic" }, { "1708", "Tactical" }, { "1643", "Building" }, { "3798", "Side Scroller" }, { "1716", "Rogue-like" }, { "12472", "Management" }, { "3959", "Rogue-lite" }, { "4295", "Futuristic" }, { "5537", "Puzzle-Platformer" }, { "17389", "Tabletop" }, { "7743", "1980s" }, { "6129", "Logic" }, { "5395", "3D Platformer" }, { "1741", "Turn-Based Strategy" }, { "4486", "Choose Your Own Adventure" }, { "4562", "Cartoon" }, { "5984", "Drama" }, { "1702", "Crafting" }, { "5125", "Procedural Generation" }, { "4947", "Romance" }, { "4325", "Turn-Based Combat" }, { "11014", "Interactive Fiction" }, { "7368", "Local Multiplayer" }, { "1738", "Hidden Object" }, { "10695", "Party-Based RPG" }, { "5611", "Mature" }, { "14139", "Turn-Based Tactics" }, { "4604", "Dark Fantasy" }, { "1677", "Turn-Based" }, { "3978", "Survival Horror" }, { "1036", "Education" }, { "4434", "JRPG" }, { "1646", "Hack and Slash" }, { "84", "Design & Illustration" }, { "4885", "Bullet Hell" }, { "42804", "Action Roguelike" }, { "9204", "Immersive Sim" }, { "8945", "Resource Management" }, { "5608", "Emotional" }, { "1720", "Dungeon Crawler" }, { "3835", "Post-apocalyptic" }, { "1678", "War" }, { "1659", "Zombies" }, { "9551", "Dating Sim" }, { "30358", "Nature" }, { "3987", "Historical" }, { "6691", "1990's" }, { "7332", "Base Building" }, { "4711", "Replay Value" }, { "5900", "Walking Simulator" }, { "1710", "Surreal" }, { "9130", "Hentai" }, { "4637", "Top-Down Shooter" }, { "5154", "Score Attack" }, { "3841", "Local Co-Op" }, { "31275", "Text-Based" }, { "1687", "Stealth" }, { "24904", "NSFW" }, { "5851", "Isometric" }, { "4975", "2.5D" }, { "1666", "Card Game" }, { "4168", "Military" }, { "3814", "Third-Person Shooter" }, { "5094", "Narration" }, { "4145", "Cinematic" }, { "4115", "Cyberpunk" }, { "44868", "LGBTQ+" }, { "87", "Utilities" }, { "1676", "RTS" }, { "8013", "Software" }, { "379975", "Clicker" }, { "1038", "Web Publishing" }, { "10235", "Life Sim" }, { "1770", "Board Game" }, { "8369", "Investigation" }, { "1673", "Aliens" }, { "4400", "Abstract" }, { "5752", "Robots" }, { "5613", "Detective" }, { "3877", "Precision Platformer" }, { "4234", "Short" }, { "17305", "Strategy RPG" }, { "1734", "Fast-Paced" }, { "15172", "Conversation" }, { "5547", "Arena Shooter" }, { "5923", "Dark Humor" }, { "1644", "Driving" }, { "10397", "Memes" }, { "1645", "Tower Defense" }, { "4695", "Economy" }, { "3813", "Real Time Tactics" }, { "16689", "Time Management" }, { "15045", "Flight" }, { "5577", "RPGMaker" }, { "1759", "Perma Death" }, { "9541", "Demons" }, { "4328", "City Builder" }, { "6869", "Nonlinear" }, { "3854", "Lore-Rich" }, { "4064", "Thriller" }, { "5711", "Team-Based" }, { "1621", "Music" }, { "21725", "Tactical RPG" }, { "5186", "Psychological" }, { "1628", "Metroidvania" }, { "12057", "Tutorial" }, { "4840", "4 Player Local" }, { "4684", "Wargame" }, { "1714", "Psychedelic" }, { "4158", "Beat 'em up" }, { "7926", "Artificial Intelligence" }, { "5673", "Modern" }, { "1693", "Classic" }, { "1751", "Comic Book" }, { "10808", "Supernatural" }, { "5030", "Dystopian" }, { "4700", "Movie" }, { "8666", "Runner" }, { "5652", "Collectathon" }, { "13782", "Experimental" }, { "29482", "Souls-like" }, { "1743", "Fighting" }, { "4236", "Loot" }, { "4736", "2D Fighter" }, { "4598", "Alternate History" }, { "615955", "Idler" }, { "8122", "Level Editor" }, { "5363", "Destruction" }, { "3878", "Competitive" }, { "1100687", "Automobile Sim" }, { "32322", "Deckbuilding" }, { "6276", "Inventory Management" }, { "4758", "Twin Stick Shooter" }, { "7569", "Grid-Based Movement" }, { "4036", "Parkour" }, { "6378", "Crime" }, { "4474", "CRPG" }, { "791774", "Card Battler" }, { "1669", "Moddable" }, { "16094", "Mythology" }, { "1752", "Rhythm" }, { "872", "Animation & Modeling" }, { "1665", "Match 3" }, { "13906", "Game Development" }, { "17894", "Cats" }, { "16598", "Space Sim" }, { "19995", "Dark Comedy" }, { "4150", "World War II" }, { "4364", "Grand Strategy" }, { "5411", "Beautiful" }, { "15277", "Philosophical" }, { "6506", "3D Fighter" }, { "1754", "MMORPG" }, { "5794", "Science" }, { "7432", "Lovecraftian" }, { "5055", "eSports" }, { "6052", "Noir" }, { "4608", "Swordplay" }, { "176981", "Battle Royale" }, { "220585", "Colony Sim" }, { "916648", "Creature Collector" }, { "87918", "Farming Sim" }, { "11104", "Vehicular Combat" }, { "4155", "Class-Based" }, { "4046", "Dragons" }, { "4835", "6DOF" }, { "3955", "Character Action Game" }, { "255534", "Automation" }, { "198631", "Mystery Dungeon" }, { "5765", "Gun Customization" }, { "24003", "Word Game" }, { "10816", "Split Screen" }, { "1027", "Audio Production" }, { "620519", "Hero Shooter" }, { "29363", "3D Vision" }, { "13190", "America" }, { "4845", "Capitalism" }, { "13070", "Solitaire" }, { "784", "Video Production" }, { "1732", "Voxel" }, { "5796", "Bullet Time" }, { "22602", "Agriculture" }, { "4878", "Parody" }, { "4777", "Spectacle fighter" }, { "4102", "Combat Racing" }, { "1100689", "Open World Survival Craft" }, { "4821", "Mechs" }, { "6625", "Time Manipulation" }, { "1777", "Steampunk" }, { "353880", "Looter Shooter" }, { "5372", "Conspiracy" }, { "3920", "Cooking" }, { "11123", "Mouse only" }, { "1445", "Software Training" }, { "3952", "Gothic" }, { "6915", "Martial Arts" }, { "4202", "Trading" }, { "4508", "Co-op Campaign" }, { "1651", "Satire" }, { "4853", "Political" }, { "13276", "Tanks" }, { "5228", "Blood" }, { "1084988", "Auto Battler" }, { "1681", "Pirates" }, { "5300", "God Game" }, { "1730", "Sokoban" }, { "21006", "Underground" }, { "1717", "Hex Grid" }, { "10679", "Time Travel" }, { "18594", "FMV" }, { "1670", "4X" }, { "1688", "Ninja" }, { "5981", "Mining" }, { "9564", "Hunting" }, { "4559", "Quick-Time Events" }, { "1638", "Dog" }, { "9271", "Trading Card Game" }, { "4242", "Episodic" }, { "31579", "Otome" }, { "9157", "Underwater" }, { "4018", "Vampire" }, { "9592", "Dynamic Narration" }, { "1718", "MOBA" }, { "1723", "Action RTS" }, { "5502", "Hacking" }, { "4161", "Real-Time" }, { "15564", "Fishing" }, { "5160", "Dinosaurs" }, { "1647", "Western" }, { "1616", "Trains" }, { "5432", "Programming" }, { "4190", "Addictive" }, { "7702", "Narrative" }, { "26921", "Political Sim" }, { "6910", "Naval" }, { "180368", "Faith" }, { "5708", "Remake" }, { "1671", "Superhero" }, { "4754", "Politics" }, { "7178", "Party Game" }, { "809", "Photo Editing" }, { "4376", "Assassin" }, { "14153", "Dungeons & Dragons" }, { "17770", "Asynchronous Multiplayer" }, { "1674", "Typing" }, { "3934", "Immersive" }, { "10383", "Transportation" }, { "8093", "Minigames" }, { "7107", "Real-Time with Pause" }, { "5179", "Cold War" }, { "7782", "Cult Classic" }, { "769306", "Escape Room" }, { "7108", "Party" }, { "1091588", "Roguelike Deckbuilder" }, { "97376", "Cozy" }, { "1680", "Heist" }, { "13382", "Archery" }, { "4994", "Naval Combat" }, { "7478", "Illuminati" }, { "56690", "On-Rails Shooter" }, { "6310", "Diplomacy" }, { "9803", "Snow" }, { "10437", "Trivia" }, { "1254546", "Football (Soccer)" }, { "552282", "Wholesome" }, { "5390", "Time Attack" }, { "13577", "Sailing" }, { "8253", "Music-Based Procedural Generation" }, { "454187", "Traditional Roguelike" }, { "25085", "Touch-Friendly" }, { "16250", "Gambling" }, { "7622", "Offroad" }, { "776177", "360 Video" }, { "51306", "Foreign" }, { "1649", "GameMaker" }, { "11333", "Villain Protagonist" }, { "5230", "Sequel" }, { "9994", "Experience" }, { "6702", "Mars" }, { "14720", "Nostalgia" }, { "6041", "Horses" }, { "7423", "Sniper" }, { "5153", "Kickstarter" }, { "4184", "Chess" }, { "4137", "Transhumanism" }, { "17015", "Werewolves" }, { "12190", "Boxing" }, { "71389", "Spelling" }, { "92092", "Jet" }, { "7038", "Golf" }, { "15339", "Documentary" }, { "5348", "Mod" }, { "1100686", "Outbreak Sim" }, { "1100688", "Medical Sim" }, { "198913", "Motorbike" }, { "5382", "World War I" }, { "4520", "Farming" }, { "6948", "Rome" }, { "1736", "LEGO" }, { "6621", "Pinball" }, { "1733", "Unforgiving" }, { "123332", "Bikes" }, { "4291", "Spaceships" }, { "745697", "Social Deduction" }, { "61357", "Electronic Music" }, { "19780", "Submarine" }, { "1746", "Basketball" }, { "3965", "Epic" }, { "922563", "Roguevania" }, { "29855", "Ambient" }, { "856791", "Asymmetric VR" }, { "150626", "Gaming" }, { "8075", "TrackIR" }, { "15954", "Silent Protagonist" }, { "1254552", "Football (American)" }, { "5310", "Games Workshop" }, { "22955", "Mini Golf" }, { "7113", "Crowdfunded" }, { "12286", "Warhammer 40K" }, { "3796", "Based On A Novel" }, { "1753", "Skateboarding" }, { "47827", "Wrestling" }, { "11634", "Vikings" }, { "189941", "Instrumental Music" }, { "5727", "Baseball" }, { "17927", "Pool" }, { "5914", "Tennis" }, { "19568", "Cycling" }, { "96359", "Skating" }, { "176733", "Tile-Matching" }, { "15868", "Motocross" }, { "17337", "Lemmings" }, { "14906", "Intentionally Awkward Controls" }, { "324176", "Hockey" }, { "33572", "Mahjong" }, { "337964", "Rock Music" }, { "35079", "Job Simulator" }, { "11095", "Boss Rush" }, { "117648", "8-bit Music" }, { "7328", "Bowling" }, { "28444", "Snowboarding" }, { "42089", "Jump Scare" }, { "7309", "Skiing" }, { "252854", "BMX" }, { "129761", "ATV" }, { "143739", "Electronic" }, { "8461", "Well-Written" }, { "27758", "Voice Control" }, { "233824", "Feature Film" }, { "603297", "Hardware" }, { "5407", "Benchmark" }, { "348922", "Steam Machine" }, { "91114", "Shop Keeper" }, { "323922", "Musou" }, { "158638", "Cricket" }, { "49213", "Rugby" }, { "847164", "Volleyball" }, { "42329", "Coding" }, { "6214", "Birds" }, { "363767", "Snooker" }, { "5941", "Reboot" }, { "30927", "Fox" }, { "1220528", "Hobby Sim" } };
        List<string> decodedList = new List<string>();
        foreach(string encodedTag in encodedTags)
        {
            if(encodedTag != null)
            {
                decodedList.Add(decodedTags[encodedTag]);

            }
        }

        string[] decodedArray = decodedList.ToArray();
        return decodedArray;
    }

    public string[] decodeContentDescriptors(string[] encodedButDecodedCDID)
    {
        IDictionary<string, string> decodedID = new Dictionary<string, string>() { { "1", "Some Nudity or Sexual Content" }, { "2", "Frequent Violence or Gore" }, { "3", "Adult Only Sexual Content" }, { "4", "Frequent Nudity or Sexual Content" }, { "5", "General Mature Content" } };
        List<string> contentDescriptorsDecoded = new List<string>();
        foreach(string CDID in encodedButDecodedCDID)
        {
            contentDescriptorsDecoded.Add(decodedID[CDID]);
        }

        string[] contentDescriptorsDecodedArray = contentDescriptorsDecoded.ToArray();
        return contentDescriptorsDecodedArray;
    }


    public string getContentDescriptorFromID(string encodedID)
    {
        IDictionary<string, string> decodedID = new Dictionary<string, string>() { { "1", "Some Nudity or Sexual Content" }, { "2", "Frequent Violence or Gore" }, { "3", "Adult Only Sexual Content" }, { "4", "Frequent Nudity or Sexual Content" }, { "5", "General Mature Content" } };
        if (decodedID.ContainsKey(encodedID)){
            return decodedID[encodedID];
        }
        return "Unknown";
    }
}
