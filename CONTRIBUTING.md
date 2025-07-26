# LateStation Contributing Guidelines

LateStation is a custom-content fork of Space Station 14 (https://github.com/space-wizards/space-station-14), built to extend and reshape the game with our own mechanics, assets, and content. (all in due time)

We follow upstream's PR guidelines:
https://docs.spacestation14.com/en/general-development/codebase-info/pull-request-guidelines.html

> Do **not** use GitHub’s web editor to submit PRs.
> PRs submitted through the web editor may be closed without review.

All contributors are expected to have a working development environment:
https://docs.spacestation14.com/en/general-development/setup/setting-up-a-development-environment.html

By submitting a PR, you agree that your code contributions are licensed under the **MIT License**, in line with LateStation’s licensing.

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

When adding new content, create it under `_LateStation` folders whenever possible. This avoids conflicts with upstream and keeps our changes cleanly separated.

Examples:
- Content.Server/_LateStation/Speech/EntitySystems/IlleismAccentSystem.cs
- Resources/Prototypes/_LateStation/game_presets.yml
- Resources/Textures/_LateStation/Clothing/Shoes/Misc/ducky-galoshes.rsi
- Resources/Locale/en-US/_LateStation/game-ticking/game-presets/preset-deathmatchpromod.ftl

---

## Changes to Upstream Files

If you need to modify upstream files (C#, YAML, etc.), you must comment your changes to help future merges and reduce conflict risk.

- Always comment on or near the lines you change
- Do not delete upstream code — comment it out instead
- For large additions to upstream files, consider using a partial class if applicable
- .ftl (fluent) files do not support inline comments — edit carefully

### Commenting Example

YAML - Inline field comment:
  hidden: false # LateStation change for various Vox masks

YAML - Begin/End block comment:
  # Begin LateStation Personal trinkets
  - ItemJamesCane
  - ItemAnnabellePlushie
  - ItemPititiRockGorb
  # End LateStation Personal trinkets

C# - Inline logic comment:
  if (!_actionBlocker.CanSpeak(source, true) && !ignoreActionBlocker) // LateStation: support hypophonia trait

C# - Enclosing block comment:
  // LateStation - start of additional statuses
  SecurityStatus.Monitor => "SecurityIconMonitor",
  SecurityStatus.Search => "SecurityIconSearch",
  // LateStation - end of additional statuses

---

## Porting (Importing from Other Forks)

When porting features, assets, or code from other SS14 forks (such as Delta-V, Frontier, Harmony, etc.), you must:

- Place the content into a clearly named subfolder with an underscore prefix.
- This keeps LateStation's structure clean and avoids mixing upstream, original, and imported content.

Example:
- Resources/Prototypes/_Example/
- Content.Server/_Example/Systems/MyPortedSystem.cs

Use a short, recognizable fork name or abbreviation as the folder name. For example: _DV, _NF, _Harmony, _AXOLOTL.

Licensing Requirements:
- You must verify that the original source uses the MIT License.
- Do not import code or assets with incompatible licenses (e.g., AGPL, proprietary, or commercial-restricted).
- If you're unsure about the license or how to format the port, ask in Discord.

---

## Mapping

- Follow upstream mapping guidelines: https://docs.spacestation14.com/en/space-station-14/mapping.html
- Maps must be tested in a development environment
- Ensure power, atmos, gravity, and lighting all work before submission
- LateStation maps (e.g., salvage, shuttles) should support immersive MRP
- Submit upstream map changes directly to upstream when possible

---

## Art and Spriting

- Test all sprites in-game
- Provide in-game screenshots in your PR
- We do not enforce a strict palette — good art is good art

---

## Before You Submit

- Double-check your diff for:
  - Accidental changes
  - Whitespace or line-ending junk
- Make sure you're targeting:
  - Repo: LateStation14/Late-station-14
  - Branch: master

To fix accidental RobustToolbox changes:
  git checkout upstream/master RobustToolbox

(Replace "upstream" with your remote for space-wizards/space-station-14.)

---

## Changelogs

Use the :cl: tag in your PR body to list player-facing changes.

Valid types: add, remove, tweak, fix

Example:
:cl:
- add: Added a new gun to the armory.
- fix: Fixed crew manifest showing dead people.

Only entries after :cl: are read by Weh Bot.
LateStation does not maintain a separate Admin changelog.

---

## Additional Resources

- SS14 Docs: https://docs.spacestation14.io/
- Join #latestation-contributors on Discord for help or questions
