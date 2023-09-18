public class Bot
{
    public ulong? Id { get; set; }
    public string? Name { get; set; }
    public ulong[]? authorizedChannels { get; set; } = new ulong[10];
}