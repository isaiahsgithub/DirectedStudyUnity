
[System.Serializable]
public class UserGameInfo
{

    public int appid;
    public string name;
    public int playtime_2weeks;
    public int playtime_forever;
    public string img_icon_url;
    public bool has_community_visible_stats;
    public int playtime_windows_forever;
    public int playtime_mac_forever;
    public int playtime_linux_forever;
    public int rtime_last_played;
    public int playtime_disconnected;
    public UserGameInfo(int a, string n, int p2w, int pf, string i, bool hcvs, int pwf, int pmf, int plf, int rlp, int pd)
    {
        this.appid = a;
        this.name = n;
        this.playtime_2weeks = p2w;
        this.playtime_forever = pf;
        this.img_icon_url = i;
        this.has_community_visible_stats = hcvs;
        this.playtime_windows_forever = pwf;
        this.playtime_mac_forever = pmf;
        this.playtime_linux_forever = plf;
        this.rtime_last_played = rlp;
        this.playtime_disconnected = pd;
    }
}


