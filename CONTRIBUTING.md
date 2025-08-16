# LateStation Contributing Guidelines

LateStation is a custom-content fork of [Space Station 14](https://github.com/space-wizards/space-station-14), built to extend and reshape the game with our own mechanics, assets, and content (all in due time).

We follow upstream's PR guidelines:
https://docs.spacestation14.com/en/general-development/codebase-info/pull-request-guidelines.html

> Do **not** use GitHub’s web editor to submit PRs.
> PRs submitted through the web editor may be closed without review.

All contributors are expected to have a working development environment:
https://docs.spacestation14.com/en/general-development/setup/setting-up-a-development-environment.html

By submitting a PR, you agree that your code contributions are licensed under the **MIT License** and **AGPL-3.0-or-later**, in line with LateStation’s dual-licensing model for original content.

---

## Table of Contents

- LateStation-specific Content
- Changes to Upstream Files
  - Commenting Example
- Porting (Importing from Other Forks)
- Mapping
- Art and Spriting
- Before You Submit
- Changelogs
- Additional Resources

---

## LateStation-specific Content

When adding new content, create it under `_LateStation` folders whenever possible. This keeps our content cleanly separated from upstream code and simplifies merges.

Examples:
- Content.Server/_LateStation/Speech/EntitySystems/IlleismAccentSystem.cs
- Resources/Prototypes/_LateStation/game_presets.yml
- Resources/Textures/_LateStation/Clothing/Shoes/Misc/ducky-galoshes.rsi
- Resources/Locale/en-US/_LateStation/game-ticking/game-presets/preset-deathmatchpromod.ftl

---

## Changes to Upstream Files

If you need to modify upstream files (C#, YAML, etc.), you **must comment your changes**. This helps with resolving future merge conflicts and makes your intent clear.

- Always comment near the lines you change
- Do **not** delete upstream code — comment it out
- For large additions, use partial classes when appropriate
- Fluent (`.ftl`) files don’t support inline comments — edit with care

### Commenting Example

**YAML – Inline field comment:**
  hidden: false # LateStation change for various Vox masks

**YAML – Block comment:**
  # Begin LateStation Personal trinkets
  - ItemJamesCane
  - ItemAnnabellePlushie
  - ItemPititiRockGorb
  # End LateStation Personal trinkets

**C# – Inline logic comment:**
  if (!_actionBlocker.CanSpeak(source, true) && !ignoreActionBlocker) // LateStation: support hypophonia trait

**C# – Enclosing block:**
  // LateStation - start of additional statuses into the criminal records computer system from CD
  SecurityStatus.Monitor => "SecurityIconMonitor",
  SecurityStatus.Search => "SecurityIconSearch",
  // LateStation - end of additional statuses into the criminal records computer system from CD

---

## Porting (Importing from Other Forks)

When porting content (code, YAML, assets) from other SS14 forks (e.g., Delta-V, Harmony, Frontier, etc.):

- Use a clearly named subfolder with a `_` prefix (e.g., `_DV`, `_NF`, `_Harmony`)
- Avoid mixing ported code into `_LateStation` or upstream folders
- Use a short, recognizable name for the fork — e.g.:
  - `_DV/` from Delta-V
  - `_NF/` from Frontier

  **this all to ensure that if we have to pull anything we can do it easily by nuking the folder**

**License Requirements:**

- You must verify that the source project uses the **MIT license**, or is clearly dual-licensed
- You may import AGPL-licensed code, but you **must clearly label it** it in its own folder.
  - Use a descriptive folder name (e.g., `DeltaV/`)
  - Include an SPDX license header at the top of each file: `SPDX-License-Identifier: AGPL-3.0-or-later`
  - Any server deployment using AGPL code must comply with the AGPL terms (e.g., source disclosure).
- If you’re unsure, **ask in Discord** before submitting

---

## Mapping

- Follow upstream mapping guidelines: https://docs.spacestation14.com/en/space-station-14/mapping.html
- Test maps thoroughly — power, atmos, gravity, lighting must work
- LateStation-exclusive maps (e.g., shuttles, wrecks) should support immersive MRP
- Submit upstream map changes to upstream when possible

---

## Art and Spriting

- Test sprites in-game (not just in the editor)
- Include in-game screenshots with your PR
- Palette flexibility is allowed — consistency is good, but creativity is welcome

---

## Before You Submit

Before opening a PR:

- Double-check your diff:
  - Look for unintended changes
  - Avoid whitespace-only or newline-only diffs
- Confirm your target is correct:
  - **Repository:** `LateStation14/Late-station-14`
  - **Branch:** `master`

To undo accidental changes to `RobustToolbox`:
  git checkout upstream/master RobustToolbox

(Replace `upstream` with the name of your `space-wizards` remote.)

---

## Changelogs

Use the `:cl:` tag in your PR body to describe player-facing changes.

**Valid types:** `add`, `remove`, `tweak`, `fix`

**Example:**
:cl:
- add: Added a new gun to the armory.
- fix: Fixed crew manifest showing dead people.

Only entries **after** `:cl:` are read by Weh Bot.
LateStation does **not** maintain a separate Admin changelog.

---

## Additional Resources

- 🧱 SS14 Developer Docs: https://docs.spacestation14.io/
