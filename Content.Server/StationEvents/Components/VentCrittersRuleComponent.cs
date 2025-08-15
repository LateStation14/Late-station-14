using Content.Server.StationEvents.Events;
using Content.Shared.Storage;

namespace Content.Server.StationEvents.Components;

[RegisterComponent, Access(typeof(VentCrittersRule))]
public sealed partial class VentCrittersRuleComponent : Component
{
    [DataField("entries")]
    public List<EntitySpawnEntry> Entries = new();

    /// <summary>
    /// At least one special entry is guaranteed to spawn
    /// </summary>
    [DataField("specialEntries")]
    public List<EntitySpawnEntry> SpecialEntries = new();

    // LateStation edit: per-player scaling config
    [DataField("playersPerSpawn")]
    public int PlayersPerSpawn = 12;

    [DataField("minSpawns")]
    public int MinSpawns = 1;

    [DataField("maxSpawns")]
    public int MaxSpawns = 3;

    // Players below this baseline are ignored in the per-player math
    // Example: with baselinePlayers=6 and playersPerSpawn=3:
    //   at 15 players -> floor((15 - 6) / 3) = 3 attempts (before min/max clamp)
    [DataField("baselinePlayers")]
    public int BaselinePlayers = 0; // LateStation edit

    // Constant number of attempts added regardless of player count
    // Example: baseSpawns=2 means you always get +2 attempts even if players are below baseline
    [DataField("baseSpawns")]
    public int BaseSpawns = 0; //End of Latestation Edits
}
