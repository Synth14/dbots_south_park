using Bot_common;
using Discord;
using Discord.WebSocket;
using discord_bot_garrisson;
using System.Reflection;
using System.Text.Json;

class Program
{
    private DiscordSocketClient? _client;
    static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();


    public async Task RunBotAsync()
    {
        Ascii.Garrisson();
        Assembly thisAssem = typeof(Program).Assembly;
        AssemblyName thisAssemName = thisAssem.GetName();

        Version ver = thisAssemName.Version;
        Console.WriteLine($"Discord_bot_Garrisson version: {ver}");

        _client = new DiscordSocketClient();
        _client.Log += LogAsync;
        _client.Ready += ReadyAsync;
        _client.MessageReceived += MessageReceivedAsync;
        string discordToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
        await _client.LoginAsync(TokenType.Bot, discordToken);
        await _client.StartAsync();
        await Task.Delay(-1);
    }

    private Task LogAsync(LogMessage log)
    {
        Console.WriteLine(log);
        return Task.CompletedTask;
    }

    private Task ReadyAsync()
    {
        Console.WriteLine("Garrisson est prêt.");
        return Task.CompletedTask;
    }

    private async Task MessageReceivedAsync(SocketMessage message)
    {

        // Vérifiez que le message n'est pas envoyé par le bot lui-même
        if (message.Author.Id == _client.CurrentUser.Id)
            return;
        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        string jsonContent = File.ReadAllText(fullPath);
        Channels channels = JsonSerializer.Deserialize<Channels>(jsonContent);

        if (message.Channel is SocketTextChannel textChannel && textChannel.Id != channels.AideAuxDevoirsChan)
            return;
        Repliques garReplies = new Repliques();
        var randomMessages = garReplies.GetEntries_Garrisson(message.Author.GlobalName);

        Random random = new Random();
        int randomKey = random.Next(1, randomMessages.Count + 1);
        if (randomMessages.TryGetValue(randomKey, out string randomMessage))
        {
            // Envoyez le message aléatoire dans le même canal où le message a été reçu
            await message.Channel.SendMessageAsync(randomMessage);
        }
    }
}
