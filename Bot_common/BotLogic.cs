using Discord;
using Discord.WebSocket;
using System.Text.Json;

namespace Bot_common
{
    public class BotLogic_Garrisson
    {
        public readonly DiscordSocketClient _client;

        public BotLogic_Garrisson(string token)
        {
            _client = new DiscordSocketClient();
            _client.Log += LogAsync;
            _client.Ready += ReadyAsync;
            _client.MessageReceived += MessageReceivedAsync;

            InitializeAsync(token).GetAwaiter().GetResult();

        }
        public void StartBot()
        {
        }
        private Task ReadyAsync()
        {
            Console.WriteLine("Garrisson est prêt.");
            return Task.CompletedTask;
        }
        private async Task InitializeAsync(string token)
        {
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
        }

        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log);
            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(SocketMessage message)
        {

            // Vérifiez que le message n'est pas envoyé par le bot lui-même ou par Monsieur Esclave
            if (message.Author.IsBot)
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

    public class BotLogic_M_Esclave
    {
        public readonly DiscordSocketClient _client;

        public BotLogic_M_Esclave(string token)
        {
            var config = new DiscordSocketConfig
            {
                GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent
            };
            _client = new DiscordSocketClient(config);
            _client.Log += LogAsync;
            _client.Ready += ReadyAsync;
            _client.MessageReceived += MessageReceivedAsync;

            InitializeAsync(token).GetAwaiter().GetResult();
        }
        public void StartBot()
        {
        }
        private Task ReadyAsync()
        {
            Console.WriteLine("M. Esclave est prêt.");
            return Task.CompletedTask;
        }
        private async Task InitializeAsync(string token)
        {
           
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

        }


        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log);
            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(SocketMessage message)
        {
            Bot monsieurEsclave = new();
            monsieurEsclave.Id = BotIdentifier.MonsieurEsclaveID;
            Channels channels = new();
            monsieurEsclave.authorizedChannels[0] = channels.AideAuxDevoirsChan;
            channels.ChannelPermission(message, channels.AideAuxDevoirsChan, monsieurEsclave.Id);

            if (message.Content.Contains("Monsieur Esclave", StringComparison.OrdinalIgnoreCase))
            {

                Repliques slaveReplies = new Repliques();
                var randomMessages = slaveReplies.GetEntries_M_Esclave(message.Author.GlobalName);

                Random random = new Random();
                int randomKey = random.Next(1, randomMessages.Count + 1);
                if (randomMessages.TryGetValue(randomKey, out string randomMessage))
                {
                    // Envoyez le message aléatoire dans le même canal où le message a été reçu
                    await message.Channel.SendMessageAsync(randomMessage);
                }
            }
        }
    }
}
