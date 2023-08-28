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

[System.Serializable]
public class steamcmdClass
{
    public DataCMD data;
    public string status;
}




[System.Serializable]
public class DataCMD
{
    public gameCMDInfo cmdInfo;
}


[System.Serializable]
public class gameCMDInfo
{
    public int _change_number;
    public bool _missing_token;
    public string _sha;
    public int _size;
    public string appid;
    public Common common;
    public Config config;
    public Depots depots;
    public Extended extended;
}


[System.Serializable]
public class Common
{
    public Associations associations;
    public CategoryCMD category;
    public string clienticon;
    public string clienttga;
    public string community_hub_visible;
    public string controller_support;
    public Controllervr controllervr;
    public string exfgls;
    public string gameid;
    public Genres genres;
    public Header_Image header_image;
    public string icon;
    public Library_Assets library_assets;
    public string logo;
    public string logo_small;
    public string name;
    public string openvrsupport;
    public string osarch;
    public string oslist;
    public Playareavr playareavr;
    public string primary_genre;
    public string releasestate;
    public string review_percentage;
    public string review_score;
    public Small_Capsule small_capsule;
    public Steam_Deck_Compatibility steam_deck_compatibility;
    public string steam_release_date;
    public string store_asset_mtime;
    public Store_Tags store_tags;
    public Supported_Languages supported_languages;
    public string type;
}

[System.Serializable]
public class Associations
{
    public _0 _0;
    public _1 _1;
}


[System.Serializable]
public class _0
{
    public string name;
    public string type;
}


[System.Serializable]
public class _1
{
    public string name;
    public string type;
}
[System.Serializable]
public class CategoryCMD
{
    public string category_18;
    public string category_2;
}
[System.Serializable]
public class Controllervr
{
    public string kbm;
    public string xinput;
}
[System.Serializable]
public class Genres
{
    public string _0;
    public string _1;
    public string _2;
}
[System.Serializable]
public class Header_Image
{
    public string english;
}
[System.Serializable]
public class Library_Assets
{
    public string library_capsule;
    public string library_hero;
    public string library_logo;
    public Logo_Position logo_position;
}
[System.Serializable]
public class Logo_Position
{
    public string height_pct;
    public string pinned_position;
    public string width_pct;
}
[System.Serializable]
public class Playareavr
{
    public string seated;
}
[System.Serializable]
public class Small_Capsule
{
    public string english;
}
[System.Serializable]
public class Steam_Deck_Compatibility
{
    public string category;
    public Configuration configuration;
    public string test_timestamp;
    public string tested_build_id;
    public Tests tests;
}
[System.Serializable]
public class Configuration
{
    public string gamescope_frame_limiter_not_supported;
    public string non_deck_display_glyphs;
    public string primary_player_is_controller_slot_0;
    public string recommended_runtime;
    public string requires_h264;
    public string requires_internet_for_setup;
    public string requires_internet_for_singleplayer;
    public string requires_manual_keyboard_invoke;
    public string requires_non_controller_launcher_nav;
    public string small_text;
    public string supported_input;
}
[System.Serializable]
public class Tests
{
    public _01 _0;
    public _11 _1;
    public _2 _2;
}

[System.Serializable]
public class _01
{
    public string display;
    public string token;
}
[System.Serializable]
public class _11
{
    public string display;
    public string token;
}
[System.Serializable]
public class _2
{
    public string display;
    public string token;
}

[System.Serializable]
public class Store_Tags
{
    public string _0;
    public string _1 ;
    public string _10 ;
    public string _11 ;
    public string _12 ;
    public string _13 ;
    public string _14 ;
    public string _15 ;
    public string _16 ;
    public string _17 ;
    public string _18 ;
    public string _19 ;
    public string _2 ;
    public string _3 ;
    public string _4 ;
    public string _5 ;
    public string _6 ;
    public string _7 ;
    public string _8 ;
    public string _9 ;

    public string[] getAllTags()
    {
        string[] theTags = { this._0, this._1, this._2, this._3, this._4, this._5, this._6, this._7, this._8, this._9, this._10, this._11, this._12, this._13, this._14, this._15, this._16, this._17, this._18, this._19 };
        return theTags;
    }
    /*
    /*
    public tag0 tag00;
    public tag1 tag01;
    public tag10 tag10;
    public tag11 tag11;
    public tag12 tag12;
    public tag13 tag13;
    public tag14 tag14;
    public tag15 tag15;
    public tag16 tag16;
    public tag17 tag17;
    public tag18 tag18;
    public tag19 tag19;
    public tag2 tag02;
    public tag3 tag03;
    public tag4 tag04;
    public tag5 tag05;
    public tag6 tag06;
    public tag7 tag07;
    public tag8 tag08;
    public tag9 tag09;
    */
}

[System.Serializable]
public class tag0
{
    public string _0;
}
[System.Serializable]
public class tag1
{
    public string _1;
}
[System.Serializable]
public class tag2
{
    public string _2;
}
[System.Serializable]
public class tag3
{
    public string _3;
}
[System.Serializable]
public class tag4
{
    public string _4;
}
[System.Serializable]
public class tag5
{
    public string _5;
}
[System.Serializable]
public class tag6
{
    public string _6;
}
[System.Serializable]
public class tag7
{
    public string _7;
}
[System.Serializable]
public class tag8
{
    public string _8;
}
[System.Serializable]
public class tag9
{
    public string _9;
}
[System.Serializable]
public class tag10
{
    public string _10;
}
[System.Serializable]
public class tag11
{
    public string _11;
}
[System.Serializable]
public class tag12
{
    public string _12;
}
[System.Serializable]
public class tag13
{
    public string _13;
}
[System.Serializable]
public class tag14
{
    public string _14;
}
[System.Serializable]
public class tag15
{
    public string _15;
}
[System.Serializable]
public class tag16
{
    public string _16;
}
[System.Serializable]
public class tag17
{
    public string _17;
}
[System.Serializable]
public class tag18
{
    public string _18;
}
[System.Serializable]
public class tag19
{
    public string _19;
}
[System.Serializable]
public class Supported_Languages
{
    public English english;
}
[System.Serializable]
public class English
{
    public string supported;
}
[System.Serializable]
public class Config
{
    public string installdir;
    public Launch launch;
    public string steamconfigurator3rdpartynative;
}
[System.Serializable]
public class Launch
{
    public _02 _0;
}
[System.Serializable]
public class _02
{
    public Config1 config;
    public string executable;
    public string type;
}
[System.Serializable]
public class Config1
{
    public string osarch;
    public string oslist;
}

public class Depots
{
    public _660881 _660881;
    public Branches branches;
    public string workshopdepot;
}

public class _660881
{
    public Manifests manifests;
}

public class Manifests
{
    public _10_Update8version _10_update8version;
    public _11_Update9version _11_update9version;
    public _12_Update10version _12_update10version;
    public _13_Update11version _13_update11version;
    public _14_Update12version _14_update12version;
    public _15_Update13version _15_update13version;
    public _16_Update14version_Rc _16_update14version_rc;
    public _17_Update14version _17_update14version;
    public _18_Update15version_Mod_Support_Beta _18_update15version_mod_support_beta;
    public _19_Update15version _19_update15version;
    public _7_Update6version _7_update6version;
    public _8_Experimental _8_experimental;
    public _9_Update7version _9_update7version;
    public Lastunity5 lastunity5;
    public Modcandidate modcandidate;
    public Originalreleasedversion originalreleasedversion;
    public Preliminaryvr preliminaryvr;
    public Public _public;
    public Unity2017 unity2017;
    public Update3version update3version;
}

public class _10_Update8version
{
    public string download;
    public string gid;
    public string size;
}

public class _11_Update9version
{
    public string download;
    public string gid;
    public string size;
}

public class _12_Update10version
{
    public string download;
    public string gid;
    public string size;
}

public class _13_Update11version
{
    public string download;
    public string gid;
    public string size;
}

public class _14_Update12version
{
    public string download;
    public string gid;
    public string size;
}

public class _15_Update13version
{
    public string download;
    public string gid;
    public string size;
}

public class _16_Update14version_Rc
{
    public string download;
    public string gid;
    public string size;
}

public class _17_Update14version
{
    public string download;
    public string gid;
    public string size;
}

public class _18_Update15version_Mod_Support_Beta
{
    public string download;
    public string gid;
    public string size;
}

public class _19_Update15version
{
    public string download;
    public string gid;
    public string size;
}

public class _7_Update6version
{
    public string download;
    public string gid;
    public string size;
}

public class _8_Experimental
{
    public string download;
    public string gid;
    public string size;
}

public class _9_Update7version
{
    public string download;
    public string gid;
    public string size;
}

public class Lastunity5
{
    public string download;
    public string gid;
    public string size;
}

public class Modcandidate
{
    public string download;
    public string gid;
    public string size;
}

public class Originalreleasedversion
{
    public string download;
    public string gid;
    public string size;
}

public class Preliminaryvr
{
    public string download;
    public string gid;
    public string size;
}

public class Public
{
    public string download;
    public string gid;
    public string size;
}

public class Unity2017
{
    public string download;
    public string gid;
    public string size;
}

public class Update3version
{
    public string download;
    public string gid;
    public string size;
}

public class Branches
{
    public _10_Update8version1 _10_update8version;
    public _11_Update9version1 _11_update9version;
    public _12_Update10version1 _12_update10version;
    public _13_Update11version1 _13_update11version;
    public _14_Update12version1 _14_update12version;
    public _15_Update13version1 _15_update13version;
    public _16_Update14version_Rc1 _16_update14version_rc;
    public _17_Update14version1 _17_update14version;
    public _18_Update15version_Mod_Support_Beta1 _18_update15version_mod_support_beta;
    public _19_Update15version1 _19_update15version;
    public _7_Update6version1 _7_update6version;
    public _8_Experimental1 _8_experimental;
    public _9_Update7version1 _9_update7version;
    public Lastunity51 lastunity5;
    public Modcandidate1 modcandidate;
    public Originalreleasedversion1 originalreleasedversion;
    public Preliminaryvr1 preliminaryvr;
    public Public1 _public;
    public Unity20171 unity2017;
    public Update3version1 update3version;
}

public class _10_Update8version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _11_Update9version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _12_Update10version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _13_Update11version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _14_Update12version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _15_Update13version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _16_Update14version_Rc1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _17_Update14version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _18_Update15version_Mod_Support_Beta1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _19_Update15version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _7_Update6version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _8_Experimental1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class _9_Update7version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class Lastunity51
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class Modcandidate1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class Originalreleasedversion1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class Preliminaryvr1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class Public1
{
    public string buildid;
    public string timeupdated;
}

public class Unity20171
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class Update3version1
{
    public string buildid;
    public string description;
    public string timeupdated;
}

public class Extended
{
    public string developer;
    public string gamemanualurl;
    public string homepage;
    public string isfreeapp;
    public string publisher;
    public string vrheadsetstreaming;
}



// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

/*
 public class _0
{
    public string name ;
    public string type ;
    public string display ;
    public string token ;
    public Config config ;
    public string executable ;
}

 public class _1
{
    public string name ;
    public string type ;
    public string display ;
    public string token ;
}

 public class _10Update8version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _11Update9version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _12Update10version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _13Update11version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _14Update12version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _15Update13version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _16Update14versionRc
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _17Update14version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _18Update15versionModSupportBeta
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _19Update15version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _2
{
    public string display ;
    public string token ;
}

[System.Serializable]
 public class _660880
{
    public int _change_number ;
    public bool _missing_token ;
    public string _sha ;
    public int _size ;
    public string appid ;
    public Common common ;
    public Config config ;
    public Depots depots ;
    public Extended extended ;
}

 public class _660881
{
    public Manifests manifests ;
}

 public class _7Update6version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _8Experimental
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class _9Update7version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class Associations
{
    [JsonProperty("0")]
    public _0 _0 ;

    [JsonProperty("1")]
    public _1 _1 ;
}

 public class Branches
{
    [JsonProperty("10_update8version")]
    public _10Update8version _10_update8version ;

    [JsonProperty("11_update9version")]
    public _11Update9version _11_update9version ;

    [JsonProperty("12_update10version")]
    public _12Update10version _12_update10version ;

    [JsonProperty("13_update11version")]
    public _13Update11version _13_update11version ;

    [JsonProperty("14_update12version")]
    public _14Update12version _14_update12version ;

    [JsonProperty("15_update13version")]
    public _15Update13version _15_update13version ;

    [JsonProperty("16_update14version_rc")]
    public _16Update14versionRc _16_update14version_rc ;

    [JsonProperty("17_update14version")]
    public _17Update14version _17_update14version ;

    [JsonProperty("18_update15version_mod_support_beta")]
    public _18Update15versionModSupportBeta _18_update15version_mod_support_beta ;

    [JsonProperty("19_update15version")]
    public _19Update15version _19_update15version ;

    [JsonProperty("7_update6version")]
    public _7Update6version _7_update6version ;

    [JsonProperty("8_experimental")]
    public _8Experimental _8_experimental ;

    [JsonProperty("9_update7version")]
    public _9Update7version _9_update7version ;
    public Lastunity5 lastunity5 ;
    public Modcandidate modcandidate ;
    public Originalreleasedversion originalreleasedversion ;
    public Preliminaryvr preliminaryvr ;
    public Public @public ;
    public Unity2017 unity2017 ;
    public Update3version update3version ;
}

 public class CategoryCMD
{
    public string category_18 ;
    public string category_2 ;
}

[System.Serializable]
public class Common
{
    public Associations associations ;
    public Category category ;
    public string clienticon ;
    public string clienttga ;
    public string community_hub_visible ;
    public string controller_support ;
    public Controllervr controllervr ;
    public string exfgls ;
    public string gameid ;
    public Genres genres ;
    public HeaderImage header_image ;
    public string icon ;
    public LibraryAssets library_assets ;
    public string logo ;
    public string logo_small ;
    public string name ;
    public string openvrsupport ;
    public string osarch ;
    public string oslist ;
    public Playareavr playareavr ;
    public string primary_genre ;
    public string releasestate ;
    public string review_percentage ;
    public string review_score ;
    public SmallCapsule small_capsule ;
    public SteamDeckCompatibility steam_deck_compatibility ;
    public string steam_release_date ;
    public string store_asset_mtime ;
    public StoreTags store_tags ;
    public SupportedLanguages supported_languages ;
    public string type ;
}

 public class Config
{
    public string installdir ;
    public Launch launch ;
    public string steamconfigurator3rdpartynative ;
    public string osarch ;
    public string oslist ;
}

 public class Configuration
{
    public string gamescope_frame_limiter_not_supported ;
    public string non_deck_display_glyphs ;
    public string primary_player_is_controller_slot_0 ;
    public string recommended_runtime ;
    public string requires_h264 ;
    public string requires_internet_for_setup ;
    public string requires_internet_for_singleplayer ;
    public string requires_manual_keyboard_invoke ;
    public string requires_non_controller_launcher_nav ;
    public string small_text ;
    public string supported_input ;
}

 public class Controllervr
{
    public string kbm ;
    public string xinput ;
}
[System.Serializable]
public class DataCMD
{
    [JsonProperty("660880")]
    public _660880 _660880 ;
}

 public class Depots
{
    [JsonProperty("660881")]
    public _660881 _660881 ;
    public Branches branches ;
    public string workshopdepot ;
}

 public class English
{
    public string supported ;
}

 public class Extended
{
    public string developer ;
    public string gamemanualurl ;
    public string homepage ;
    public string isfreeapp ;
    public string publisher ;
    public string vrheadsetstreaming ;
}

 public class Genres
{
    [JsonProperty("0")]
    public string _0 ;

    [JsonProperty("1")]
    public string _1 ;

    [JsonProperty("2")]
    public string _2 ;
}

 public class HeaderImage
{
    public string english ;
}

 public class Lastunity5
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class Launch
{
    [JsonProperty("0")]
    public _0 _0 ;
}

 public class LibraryAssets
{
    public string library_capsule ;
    public string library_hero ;
    public string library_logo ;
    public LogoPosition logo_position ;
}

 public class LogoPosition
{
    public string height_pct ;
    public string pinned_position ;
    public string width_pct ;
}

 public class Manifests
{
    [JsonProperty("10_update8version")]
    public _10Update8version _10_update8version ;

    [JsonProperty("11_update9version")]
    public _11Update9version _11_update9version ;

    [JsonProperty("12_update10version")]
    public _12Update10version _12_update10version ;

    [JsonProperty("13_update11version")]
    public _13Update11version _13_update11version ;

    [JsonProperty("14_update12version")]
    public _14Update12version _14_update12version ;

    [JsonProperty("15_update13version")]
    public _15Update13version _15_update13version ;

    [JsonProperty("16_update14version_rc")]
    public _16Update14versionRc _16_update14version_rc ;

    [JsonProperty("17_update14version")]
    public _17Update14version _17_update14version ;

    [JsonProperty("18_update15version_mod_support_beta")]
    public _18Update15versionModSupportBeta _18_update15version_mod_support_beta ;

    [JsonProperty("19_update15version")]
    public _19Update15version _19_update15version ;

    [JsonProperty("7_update6version")]
    public _7Update6version _7_update6version ;

    [JsonProperty("8_experimental")]
    public _8Experimental _8_experimental ;

    [JsonProperty("9_update7version")]
    public _9Update7version _9_update7version ;
    public Lastunity5 lastunity5 ;
    public Modcandidate modcandidate ;
    public Originalreleasedversion originalreleasedversion ;
    public Preliminaryvr preliminaryvr ;
    public Public @public ;
    public Unity2017 unity2017 ;
    public Update3version update3version ;
}

 public class Modcandidate
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class Originalreleasedversion
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class Playareavr
{
    public string seated ;
}

 public class Preliminaryvr
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class Public
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string timeupdated ;
}

 [System.Serializable]public class Root
{
    public DataCMD data ;
    public string status ;
}

 public class SmallCapsule
{
    public string english ;
}

 public class SteamDeckCompatibility
{
    public string category ;
    public Configuration configuration ;
    public string test_timestamp ;
    public string tested_build_id ;
    public Tests tests ;
}

[System.Serializable]
public class StoreTags
{
    [JsonProperty("0")]
    public string _0 ;

    [JsonProperty("1")]
    public string _1 ;

    [JsonProperty("10")]
    public string _10 ;

    [JsonProperty("11")]
    public string _11 ;

    [JsonProperty("12")]
    public string _12 ;

    [JsonProperty("13")]
    public string _13 ;

    [JsonProperty("14")]
    public string _14 ;

    [JsonProperty("15")]
    public string _15 ;

    [JsonProperty("16")]
    public string _16 ;

    [JsonProperty("17")]
    public string _17 ;

    [JsonProperty("18")]
    public string _18 ;

    [JsonProperty("19")]
    public string _19 ;

    [JsonProperty("2")]
    public string _2 ;

    [JsonProperty("3")]
    public string _3 ;

    [JsonProperty("4")]
    public string _4 ;

    [JsonProperty("5")]
    public string _5 ;

    [JsonProperty("6")]
    public string _6 ;

    [JsonProperty("7")]
    public string _7 ;

    [JsonProperty("8")]
    public string _8 ;

    [JsonProperty("9")]
    public string _9 ;
}

 public class SupportedLanguages
{
    public English english ;
}

 public class Tests
{
    [JsonProperty("0")]
    public _0 _0 ;

    [JsonProperty("1")]
    public _1 _1 ;

    [JsonProperty("2")]
    public _2 _2 ;
}

 public class Unity2017
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

 public class Update3version
{
    public string download ;
    public string gid ;
    public string size ;
    public string buildid ;
    public string description ;
    public string timeupdated ;
}

*/
