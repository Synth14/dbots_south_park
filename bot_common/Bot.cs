using bot_common;
using Discord;
using Discord.WebSocket;
using Newtonsoft.Json.Linq;
using System.Threading.Channels;

public class Bot
{
    private readonly DiscordSocketClient client;
    private readonly ulong botId;
    private readonly Repliques repliques;
    public const ulong MonsieurEsclaveID = 1153372652149416048;
    public const ulong MonsieurGarrissonID = 1152906364218245140;
    public string Name;

    public Bot(DiscordSocketClient client, ulong botId, Repliques repliques)
    {
        this.client = client;
        this.botId = botId;
        this.repliques = repliques;
        this.Name = botId == MonsieurEsclaveID ? "MonsieurEsclaveID" : "MonsieurGarrissonID";
        client.MessageReceived += OnMessageReceived;
        client.Log += LogAsync;
        client.Ready += ReadyAsync;
        InitializeAsync().GetAwaiter().GetResult();

    }
    public async Task StartAsync()
    {
    }

    private async Task InitializeAsync()
    {
        var token = botId == MonsieurGarrissonID ? Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN_GAR") : Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN_SLAVE");
        await client.LoginAsync(TokenType.Bot, token);
        await client.StartAsync();
    }

    private Task ReadyAsync()
    {
        Console.WriteLine(botId == MonsieurGarrissonID ? "Garrisson est prêt" : "Monsieur Esclave est prêt");
        return Task.CompletedTask;
    }
    private Task LogAsync(LogMessage log)
    {
        Console.WriteLine(log);
        return Task.CompletedTask;
    }
    public async Task OnMessageReceived(SocketMessage message)
    {
        // Get a random message from the bot's dictionary.
        Dictionary<int, string> randomMessages = new();
        if (this.botId == MonsieurEsclaveID)
        {
            if (message.Content.Contains("Esclave"))
                randomMessages = repliques.GetEntries(this.botId, message.Author.GlobalName);
        }
        else if (!message.Author.IsBot && !message.Content.Contains("Esclave"))
        {
            randomMessages = repliques.GetEntries(this.botId, message.Author.GlobalName);
        }
        else
        {
            return;
        }
        var channels = new Channels();
        var isAuthorized = channels.HasChannelRights(message, this.Name);

        //If the bot is not authorized, return.
        if (!isAuthorized)
        {
            return;
        }
        Random random = new Random();
        int randomKey = random.Next(1, randomMessages.Count + 1);
        
        if (randomMessages.TryGetValue(randomKey, out string randomMessage))
        {
            // Envoyez le message aléatoire dans le même canal où le message a été reçu
            await message.Channel.SendMessageAsync(randomMessage);
        }
    }
}