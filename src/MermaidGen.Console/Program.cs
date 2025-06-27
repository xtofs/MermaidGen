namespace Templating;

using MermaidGen;
using Serilog;

class Program
{
    static void Main()
    {
        // Set up Serilog to log to console without timestamp
        Serilog.Log.Logger = new Serilog.LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console(
                outputTemplate: "[{Level:u3}] {Message:lj}{NewLine}{Exception}",
                theme: Serilog.Sinks.SystemConsole.Themes.SystemConsoleTheme.Colored)
            .CreateLogger();

        GetGraphData(out var nodes, out var links);
        Generator.WriteGraphAsHtml("output.html", nodes, links, "Demo Graph");

        Log.Information("Output written to 'output.html'.");
        Log.CloseAndFlush();
    }

    private static void GetGraphData(
        out List<(string Id, string Label, string? Category)> nodes,
        out List<(string Source, string Target, string Type)> links)
    {
#pragma warning disable format
        nodes =
        [
            // Primordials
            ("Uranus",     "Uranus - Sky Father",           "Primordials"),
            ("Gaia",       "Gaia - Mother Earth",           "Primordials"),
            ("Erebus",     "Erebus - God of Darkness",      "Primordials"),
            ("Nyx",        "Nyx - Goddess of Night",        "Primordials"),
            ("Tartarus",   "Tartarus - Deep Abyss",         "Primordials"),
            ("Eros",       "Eros - God of Love",            "Primordials"),
            ("Chaos",      "Chaos - Primordial Void",       "Primordials"),    
            ("Hemera",     "Hemera - Goddess of Day",       "Primordials"),
            ("Aether",     "Aether - God of Light",         "Primordials"),
            ("Ananke",     "Ananke - Goddess of Necessity", "Primordials"),

            // Titans 
            ("Kronos",     "Kronos - Titan of Time",         "Titans"),
            ("Rhea",       "Rhea - Mother of Gods",          "Titans"),
            ("Oceanus",    "Oceanus - Titan of Ocean",       "Titans"),
            ("Tethys",     "Tethys - Titaness of Rivers",    "Titans"),
            ("Hyperion",   "Hyperion - Titan of Light",      "Titans"),
            ("Theia",      "Theia - Titaness of Sight",      "Titans"),
            ("Coeus",      "Coeus - Titan of Intelligence",  "Titans"),
            ("Phoebe",     "Phoebe - Titaness of Prophecy",  "Titans"),
            ("Crius",      "Crius - Titan of Constellations", "Titans"),
            ("Iapetus",    "Iapetus - Titan of Mortality",   "Titans"),

            // Olympians
            ("Zeus",       "Zeus - King of Gods",           "Olympians"),
            ("Hera",       "Hera - Queen of Gods",          "Olympians"),
            ("Poseidon",   "Poseidon - God of Sea",         "Olympians"),
            ("Demeter",    "Demeter - Goddess of Harvest",  "Olympians"),
            ("Athena",     "Athena - Goddess of Wisdom",    "Olympians"),
            ("Apollo",     "Apollo - God of Sun",           "Olympians"),
            ("Artemis",    "Artemis - Goddess of Hunt",     "Olympians"),
            ("Ares",       "Ares - God of War",             "Olympians"),
            ("Aphrodite",  "Aphrodite - Goddess of Love",   "Olympians"),
            ("Hephaestus", "Hephaestus - God of Fire",      "Olympians"),
            ("Hermes",     "Hermes - Messenger God",        "Olympians"),
            ("Dionysus",   "Dionysus - God of Wine",        "Olympians"),

         
            // Heroes
            ("Heracles",   "Heracles/Hercules",             "Heroes"),
            ("Perseus",    "Perseus",                       "Heroes"),
            ("Theseus",    "Theseus",                       "Heroes"),
            ("Achilles",   "Achilles",                      "Heroes"),
        ];
       

        links =
        [
            // Parent-Child
            ("Kronos",     "Zeus",      "parent"),
            ("Kronos",     "Hera",      "parent"),
            ("Kronos",     "Poseidon",  "parent"),
            ("Kronos",     "Demeter",   "parent"),
            ("Rhea",       "Zeus",      "parent"),
            ("Rhea",       "Hera",      "parent"),
            ("Rhea",       "Poseidon",  "parent"),
            ("Rhea",       "Demeter",   "parent"),
            ("Zeus",       "Athena",    "parent"),
            ("Zeus",       "Apollo",    "parent"),
            ("Zeus",       "Artemis",   "parent"),
            ("Zeus",       "Ares",      "parent"),
            ("Zeus",       "Hermes",    "parent"),
            ("Zeus",       "Dionysus",  "parent"),
            ("Zeus",       "Heracles",  "parent"),
            ("Zeus",       "Perseus",   "parent"),
            ("Poseidon",   "Theseus",   "parent"),

            // ancestors
            // ("Uranus",     "Kronos",    "ancestor"),
            // ("Gaia",       "Kronos",    "ancestor"),
            // ("Erebus",     "Nyx",       "ancestor"),
            // ("Nyx",        "Hemera",    "ancestor"),
            // ("Hemera",     "Aether",    "ancestor"),
            // ("Chaos",      "Ananke",    "ancestor"),
            // ("Oceanus",    "Tethys",    "ancestor"),
            // ("Hyperion",   "Theia",     "ancestor"),
            // ("Coeus",      "Phoebe",    "ancestor"),
            // ("Crius",      "Iapetus",   "ancestor"),
            ("Tethys",     "Achilles",  "ancestor"),

            // Marriages
            ("Zeus",       "Hera",      "married"),
            ("Kronos",     "Rhea",      "married"),
            ("Oceanus",    "Tethys",    "married"),
            ("Hephaestus", "Aphrodite", "married")
        ];
#pragma warning restore format

    }
}
