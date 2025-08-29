// SPDX-FileCopyrightText: 2024 ShadowCommander <10494922+ShadowCommander@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 ReboundQ3 <ReboundQ3@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Power.Components;

namespace Content.Client.Power.Components;

[RegisterComponent]
public sealed partial class ApcPowerReceiverComponent : SharedApcPowerReceiverComponent
{
    public override float Load { get; set; }
}
