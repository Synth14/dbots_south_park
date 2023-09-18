using Discord;
using Discord.WebSocket;
using System.Text.Json;

public class Channels
{
    public ulong AideAuxDevoirsChan { get; set; }

    public void ChannelPermission(SocketMessage message, ulong channelId, ulong? botId)
    {
        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        string jsonContent = File.ReadAllText(fullPath);
        var channels = JsonSerializer.Deserialize<Channels>(jsonContent);

        if (message.Channel is SocketTextChannel textChannel && textChannel.Id != channelId)
            return;
    } 

}