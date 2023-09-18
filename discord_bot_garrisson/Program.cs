using Bot_common;
using Discord.WebSocket;
using discord_bot_garrisson;
using System.Reflection;


class Program
{
    private DiscordSocketClient? _client;
    private BotLogic_Garrisson _bot1;
    private BotLogic_M_Esclave _bot2;

    static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();


    public async Task RunBotAsync()
    {
        Ascii.Garrisson();
        Assembly thisAssem = typeof(Program).Assembly;
        AssemblyName thisAssemName = thisAssem.GetName();

        Version ver = thisAssemName.Version;
        Console.WriteLine($"Dbot_south_park version: {ver}");

        _bot1 = new BotLogic_Garrisson(Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN_GAR"));
        _bot2 = new BotLogic_M_Esclave(Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN_SLAVE"));

        _bot2._client.Ready += Bot2ReadyAsync;
        _bot1._client.Ready += Bot1ReadyAsync;

        await Task.Delay(-1);
    }

    private async Task Bot1ReadyAsync()
    {
        Console.WriteLine("Garrisson est prêt.");

        // Start Bot 1 on a separate thread
        Thread bot1Thread = new Thread(() => _bot1.StartBot());
        bot1Thread.Start();
    }

    private async Task Bot2ReadyAsync()
    {
        Console.WriteLine("M. Esclave est prêt.");

        // Start Bot 2 on a separate thread
        Thread bot2Thread = new Thread(() => _bot2.StartBot());
        bot2Thread.Start();
    }
  
}
