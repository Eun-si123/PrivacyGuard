using PrivacyGuard.Core;
using System.Text.Json;
using System.Text.Json.Serialization;

if (args.Length != 1 || args[0] != "capabilities")
{
    Console.Error.WriteLine("Usage: PrivacyGuard.Cli capabilities");
    return 2;
}
var options = new JsonSerializerOptions { WriteIndented = true };
options.Converters.Add(new JsonStringEnumConverter());
Console.WriteLine(JsonSerializer.Serialize(Capabilities.Current(), options));
return 0;
