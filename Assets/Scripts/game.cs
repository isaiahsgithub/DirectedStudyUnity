[System.Serializable]
public class game
{
   public int applicationid;
   public string gamename;
   public int playtimeforever;
   public string[] developers;
   public string[] publishers;
   public string[] genres;
   public string[] tags;
   public string[] descriptors;

    public game(int aid, string name, int pTF,  string[] dev, string[] pub, string[] g, string[] t, string[] des)
    {
        this.applicationid = aid;
        this.gamename = name;
        this.playtimeforever = pTF;
        this.developers = dev;
        this.publishers = pub;
        this.genres = g;
        this.tags = t;
        this.descriptors = des;
    }


}
