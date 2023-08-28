/*[System.Serializable]
public class gameinformation
{
    public didItPass id;
}

[System.Serializable]
public class didItPass
{
    public string yesorno;
    public gd gamedata;
}
[System.Serializable]
public class gd
{

}*/



[System.Serializable]
public class Rootobject
{
    public _10 _10;
}

[System.Serializable]
public class _10
{
    public bool success;
    public Data data;
}



[System.Serializable]
public class SteamStoreGameInfo
{
    public bool success;
    public Data data;
}
[System.Serializable]
public class Data
{
    public string type;
    public string name;
    public int steam_appid;
    public int required_age;
    public bool is_free;
    public string detailed_description;
    public string about_the_game;
    public string short_description;
    public string supported_languages;
    public string header_image;
    public string capsule_image;
    public string capsule_imagev5;
    public object website;
    public Pc_Requirements pc_requirements;
    public Mac_Requirements mac_requirements;
    public Linux_Requirements linux_requirements;
    public string[] developers;
    public string[] publishers;
    public Price_Overview price_overview;
    public int[] packages;
    public Package_Groups[] package_groups;
    public Platforms platforms;
    public Metacritic metacritic;
    public Category[] categories;
    public Genre[] genres;
    public Screenshot[] screenshots;
    public Recommendations recommendations;
    public Release_Date release_date;
    public Support_Info support_info;
    public string background ;
    public string background_raw ;
    public Content_Descriptors content_descriptors ;
}
[System.Serializable]
public class Pc_Requirements
{
    public string minimum ;
}
[System.Serializable]
public class Mac_Requirements
{
    public string minimum ;
}
[System.Serializable]
public class Linux_Requirements
{
    public string minimum ;
}
[System.Serializable]
public class Price_Overview
{
    public string currency ;
    public int initial ;
    public int final ;
    public int discount_percent ;
    public string initial_formatted ;
    public string final_formatted ;
}
[System.Serializable]
public class Platforms
{
    public bool windows ;
    public bool mac ;
    public bool linux ;
}
[System.Serializable]
public class Metacritic
{
    public int score ;
    public string url ;
}
[System.Serializable]
public class Recommendations
{
    public int total ;
}
[System.Serializable]
public class Release_Date
{
    public bool coming_soon ;
    public string date ;
}
[System.Serializable]
public class Support_Info
{
    public string url ;
    public string email ;
}
[System.Serializable]
public class Content_Descriptors
{
    public int[] ids ;
    public string notes ;

}
[System.Serializable]
public class Package_Groups
{
    public string name ;
    public string title ;
    public string description ;
    public string selection_text ;
    public string save_text ;
    public int display_type ;
    public string is_recurring_subscription ;
    public Sub[] subs ;
}
[System.Serializable]
public class Sub
{
    public int packageid ;
    public string percent_savings_text ;
    public int percent_savings ;
    public string option_text ;
    public string option_description ;
    public string can_get_free_license ;
    public bool is_free_license ;
    public int price_in_cents_with_discount ;
}
[System.Serializable]
public class Category
{
    public int id ;
    public string description ;
}
[System.Serializable]
public class Genre
{
    public string id ;
    public string description ;
}
[System.Serializable]
public class Screenshot
{
    public int id ;
    public string path_thumbnail ;
    public string path_full ;
}





