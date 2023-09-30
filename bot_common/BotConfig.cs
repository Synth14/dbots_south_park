public class BotRightsContainer
{
    public Channels Channels { get; set; }
    public BotRights MonsieurGarrissonID { get; set; }
    public BotRights MonsieurEsclaveID { get; set; }
}
public class BotRights
{
    public List<string> AuthorizedChannels { get; set; }
}
//public class Monsieurgarrissonid
//{
//    public string[] AuthorizedChannels { get; set; }
//}

//public class Monsieuresclaveid
//{
//    public string[] AuthorizedChannels { get; set; }
//}
