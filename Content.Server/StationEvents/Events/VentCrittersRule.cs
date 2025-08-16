using Content.Server.StationEvents.Components;
using Content.Shared.GameTicking.Components;
using Content.Shared.Station.Components;
using Content.Shared.Storage;
using Robust.Shared.Map;
using Robust.Shared.Random;
// LateStation edit: scale critter spawns by player count, add player manager
using System; // LateStation edit
using Robust.Server.Player; // LateStation edit

namespace Content.Server.StationEvents.Events;

public sealed class VentCrittersRule : StationEventSystem<VentCrittersRuleComponent>
{
    /*
     * DO NOT COPY PASTE THIS TO MAKE YOUR MOB EVENT.
     * USE THE PROTOTYPE.
     */

    // LateStation edit: player manager for player-count-based scaling
    [Dependency] private readonly IPlayerManager _playerManager = default!; // LateStation edit

    protected override void Started(EntityUid uid, VentCrittersRuleComponent component, GameRuleComponent gameRule, GameRuleStartedEvent args)
    {
        base.Started(uid, component, gameRule, args);

        if (!TryGetRandomStation(out var station))
        {
            return;
        }

        var locations = EntityQueryEnumerator<VentCritterSpawnLocationComponent, TransformComponent>();
        var validLocations = new List<EntityCoordinates>();
        while (locations.MoveNext(out _, out _, out var transform))
        {
            if (CompOrNull<StationMemberComponent>(transform.GridUid)?.Station == station)
            {
                validLocations.Add(transform.Coordinates);

                // LateStation edit: original vent-based spawning disabled
                /*
                foreach (var spawn in EntitySpawnCollection.GetSpawns(component.Entries, RobustRandom))
                {
                    Spawn(spawn, transform.Coordinates);
                }
                */
            }
        }

        if (validLocations.Count == 0)
        {
            return;
        }

        // LateStation edit: Spawn attempts = baseline + step formula independent of vents
        var playerCount = _playerManager.PlayerCount; // LateStation edit
        var totalAttempts = component.MinSpawns; // LateStation edit
        if (component.PlayersPerSpawn > 0) // LateStation edit
        {
            var effective = Math.Max(0, playerCount - component.BaselinePlayers); // LateStation edit
            var fromPlayers = effective / component.PlayersPerSpawn; // LateStation edit
            totalAttempts = component.BaseSpawns + fromPlayers; // LateStation edit
        }
        totalAttempts = Math.Clamp(totalAttempts, component.MinSpawns, component.MaxSpawns); // LateStation edit

        // LateStation edit: perform N spawn attempts at random valid vents
        for (var i = 0; i < totalAttempts; i++)
        {
            var coords = RobustRandom.Pick(validLocations);
            var spawnedAny = false;
            var spawns = EntitySpawnCollection.GetSpawns(component.Entries, RobustRandom);
            foreach (var spawn in spawns)
            {
                Spawn(spawn, coords);
                spawnedAny = true;
            }

            // LateStation edit: ensure at least 1 critter per attempt if probabilities yield none
            if (!spawnedAny && component.Entries.Count > 0)
            {
                // pick any valid entry
                foreach (var entry in component.Entries)
                {
                    if (entry.PrototypeId != null)
                    {
                        Spawn(entry.PrototypeId, coords);
                        break;
                    }
                }
            }
        }

        // guaranteed spawn (specialEntries): keep a single guaranteed special spawn if defined
        if (component.SpecialEntries.Count > 0)
        {
            var specialEntry = RobustRandom.Pick(component.SpecialEntries);
            var specialSpawn = RobustRandom.Pick(validLocations);
            Spawn(specialEntry.PrototypeId, specialSpawn);
        }

        // LateStation edit: original special per-vent spawning disabled
        /*
        foreach (var location in validLocations)
        {
            foreach (var spawn in EntitySpawnCollection.GetSpawns(component.SpecialEntries, RobustRandom))
            {
                Spawn(spawn, location);
            }
        }
        */
        // End of LateStation edits
    }
}
