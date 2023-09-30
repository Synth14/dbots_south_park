using bot_common;
using Discord;
using Discord.WebSocket;
using System.Configuration;
using System.Reflection;
using System.Text.Json;

public class Channels
{
    public ulong AideAuxDevoirsChan { get; set; } = 831280945947607096;

    public Channels()
    {

    }
    public bool HasChannelRights(SocketMessage message, string botName)
    {
        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        string jsonContent = File.ReadAllText(fullPath);
        
        Rootobject config = JsonSerializer.Deserialize<Rootobject>(jsonContent);
        

        var botAuthorizedChannels = botName switch
        {
            "MonsieurGarrissonID" => config.BotsRights.MonsieurGarrissonID.AuthorizedChannels,
            "MonsieurEsclaveID" => config.BotsRights.MonsieurEsclaveID.AuthorizedChannels,
            _ => throw new NotImplementedException()
        };
        foreach (var botChannel in botAuthorizedChannels)
        {
            var authorizedChan = ulong.Parse(config.Channels.GetType().GetProperty(botChannel).GetValue(config.Channels).ToString());
            if (message.Channel is SocketTextChannel textChannel && textChannel.Id== authorizedChan)
            {
                return true;
            }
        }
        return false;
    }
}






//public ulong AideAuxDevoirsChan { get; set; }

//public static bool HasChannelRights(SocketMessage message, string botName)
//{
//    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
//    string jsonContent = File.ReadAllText(fullPath);
//    var botsRights = JsonSerializer.Deserialize<Botsrights>(jsonContent);
//    var authorizedChannels = botsRights.GetType().GetProperty(botName).GetValue(botsRights) as string[];

//    foreach (var authorizedChannel in authorizedChannels)
//    {
//        var channelId = ulong.Parse(authorizedChannel.Substring(10));
//        if (message.Channel is SocketTextChannel textChannel && textChannel.Id == channelId)
//        {
//            return true;
//        }
//    }

//    return false;
//} 

