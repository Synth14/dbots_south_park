using bot_common;
using Discord;
using Discord.WebSocket;
using discord_bot_garrisson;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

class Program
{


    public static async Task Main(string[] args)
    {
        var config = new DiscordSocketConfig { GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent };
        var client = new DiscordSocketClient();
        var client2 = new DiscordSocketClient(config);

        Ascii.Garrisson();
        Assembly thisAssem = typeof(Program).Assembly;
        AssemblyName thisAssemName = thisAssem.GetName();
        Version ver = thisAssemName.Version;
        Console.WriteLine($"Dbot_south_park version: {ver}");

        var garrisson = new Bot(client, Bot.MonsieurGarrissonID, new Repliques());
        var monsieurEsclave = new Bot(client2, Bot.MonsieurEsclaveID, new Repliques());

        var garrissonThread = new Thread(new ThreadStart(() => garrisson.StartAsync()));
        garrissonThread.Start();

        // monsieurEsclave bot thread
        var monsieurEsclaveThread = new Thread(new ThreadStart(() => monsieurEsclave.StartAsync()));
        monsieurEsclaveThread.Start();
        await Task.Delay(-1);

    }

}
