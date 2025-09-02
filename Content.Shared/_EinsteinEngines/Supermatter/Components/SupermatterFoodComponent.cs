// SPDX-FileCopyrightText: 2025 Lachryphage (GitHub)
// SPDX-FileCopyrightText: 2024 Dark <darkwindleaf@hotmail.co.uk>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

namespace Content.Shared._EinsteinEngines.Supermatter.Components;

[RegisterComponent]
public sealed partial class SupermatterFoodComponent : Component
{
    [DataField]
    public int Energy { get; set; } = 1;
}
