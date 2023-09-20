using Discord;
using Discord.WebSocket;
using System.Reflection;
using System.Text.Json;

public class Channels
{
    public ulong AideAuxDevoirsChan { get; set; }

    public bool HasChannelRights(SocketMessage message, string botName)
    {
        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        string jsonContent = File.ReadAllText(fullPath);
        var botsRights = JsonSerializer.Deserialize<Botsrights>(jsonContent);
        var authorizedChannels = botsRights.GetType().GetProperty(botName).GetValue(botsRights) as string[];

        foreach (var authorizedChannel in authorizedChannels)
        {
            var channelId = ulong.Parse(authorizedChannel.Substring(10));
            if (message.Channel is SocketTextChannel textChannel && textChannel.Id == channelId)
            {
                return true;
            }
        }

        return false;
    } 

}