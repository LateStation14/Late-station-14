// SPDX-FileCopyrightText: 2025 Lachryphage (GitHub)
// SPDX-FileCopyrightText: 2025 imcb <irismessage@protonmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Eui;
using Robust.Shared.Serialization;

namespace Content.Shared._Impstation.Thaven;

[Serializable, NetSerializable]
public sealed class ThavenMoodsEuiState : EuiStateBase
{
    public List<ThavenMood> Moods { get; }
    public NetEntity Target { get; }
    public ThavenMoodsEuiState(List<ThavenMood> moods, NetEntity target)
    {
        Moods = moods;
        Target = target;
    }
}

[Serializable, NetSerializable]
public sealed class ThavenMoodsSaveMessage : EuiMessageBase
{
    public List<ThavenMood> Moods { get; }
    public NetEntity Target { get; }

    public ThavenMoodsSaveMessage(List<ThavenMood> moods, NetEntity target)
    {
        Moods = moods;
        Target = target;
    }
}
