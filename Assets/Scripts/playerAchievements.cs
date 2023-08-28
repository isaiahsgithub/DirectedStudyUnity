using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerAchievements
{
    public Playerstats playerstats;
}

[System.Serializable]
public class Playerstats
{
    public string steamID;
    public string gameName;
    public Achievement[] achievements;
    public bool success;

    public double getAchievementInfo()
    {
        int completedAchievements = 0;
        int totalAchievements = 0;
        foreach (Achievement a in this.achievements)
        {
            if(a.achieved == 1)
            {
                //Debug.Log("Achievement"+ a.apiname);
                completedAchievements += 1;
            }
            totalAchievements += 1;
        }

        //If a game has no achievements, then we can say that the player did all that they could. AKA completed 100% of achievements.
        if(totalAchievements == 0)
        {
            return 1.0;
        }
        double achievementCompletionRate = (double)completedAchievements / (double)totalAchievements;
        return achievementCompletionRate;
    }
}

[System.Serializable]
public class Achievement
{
    public string apiname;
    public int achieved;
    public int unlocktime;
}

