<p align="center">
  <img alt="LateStation" src="https://raw.githubusercontent.com/LateStation14/Late-station-14/refs/heads/master/Resources/Textures/Logo/logo.png" />
</p>

# LateStation14

[![REUSE status](https://api.reuse.software/badge/github.com/LateStation14/Late-station-14)](https://api.reuse.software/info/github.com/LateStation14/Late-station-14)
[![Build & Test Debug](https://github.com/LateStation14/Late-station-14/actions/workflows/build-test-debug.yml/badge.svg?branch=master)](https://github.com/LateStation14/Late-station-14/actions/workflows/build-test-debug.yml)
[![YAML Linter](https://github.com/LateStation14/Late-station-14/actions/workflows/yaml-linter.yml/badge.svg?branch=master)](https://github.com/LateStation14/Late-station-14/actions/workflows/yaml-linter.yml)
[![YAML map schema validator](https://github.com/LateStation14/Late-station-14/actions/workflows/validate_mapfiles.yml/badge.svg?branch=master)](https://github.com/LateStation14/Late-station-14/actions/workflows/validate_mapfiles.yml)
[![Validate RSIs](https://github.com/LateStation14/Late-station-14/actions/workflows/validate-rsis.yml/badge.svg?branch=master)](https://github.com/LateStation14/Late-station-14/actions/workflows/validate-rsis.yml)
[![YAML RGA schema validator](https://github.com/LateStation14/Late-station-14/actions/workflows/validate-rgas.yml/badge.svg?branch=master)](https://github.com/LateStation14/Late-station-14/actions/workflows/validate-rgas.yml)

**LateStation** is a custom-content fork of the official [Space Station 14](https://github.com/space-wizards/space-station-14) project.
We aim to create our own gameplay experience, with original mechanics, stations, and assets — while staying aligned with the upstream SS14 codebase.

LateStation is steadily building its own identity on top of the SS14 platform. While much of the game remains familiar to upstream, LateStation actively develops new systems, balance changes, and unique content to support our long-term vision.

**Space Station 14** is a remake of the classic SS13, running on [RobustToolbox](https://github.com/space-wizards/RobustToolbox) — an open-source engine written in C# and purpose-built for multiplayer, tile-based simulation games.

---

## 🔗 Links

- 🌐 LateStation Website: http://www.lateStation14.space/
- 🧭 SS14 Website: https://spacestation14.io/
- 🛠️ SS14 Standalone Download: https://spacestation14.io/about/nightlies/
- 🎮 SS14 on Steam: https://store.steampowered.com/app/1255460/Space_Station_14/
- 📁 LateStation Resources: https://www.lateStation14.space/

---

## 📚 Documentation & Wiki

- SS14 Docs: https://docs.spacestation14.io/ — covers engine, content, mapping, modding, and more.
- LateStation Contributions: see [CONTRIBUTING.md](CONTRIBUTING.md) — read this first if you want to contribute!

---

## 🤝 Contributing

We welcome contributions of all kinds — coding, spriting, mapping, balancing, and feedback.

- Check out [CONTRIBUTING.md](CONTRIBUTING.md)
- Open a pull request or issue to get involved

---

## 🧱 Building the Project

1. Clone this repo:

   git clone https://github.com/LateStation14/Late-station-14.git

2. Enter the project folder and run the setup script:

   cd Late-station-14
   python RUN_THIS.py

3. Build the solution:

   dotnet build

For full IDE and build setup, see the [SS14 Developer Docs](https://docs.spacestation14.com/en/general-development/setup.html).

---

## ⚖️ License

### Code

- All **original LateStation code** (generally in `_LateStation/` folders) is **dual-licensed under MIT OR AGPL-3.0-or-later**.
  (Code written before the switch remains MIT-only.)
- **Upstream code** from [Wizards Den / Space Station 14](https://github.com/space-wizards/space-station-14) remains under the **MIT License**.
  If changes are required to upstream files, they are commented to make merges and attribution clear.
- Contributors agree to these terms when submitting code (see [CONTRIBUTING.md](CONTRIBUTING.md)).

⚠️ **Note**: SPDX license headers are being added across the codebase to make licensing explicit.
Files without headers are covered by the project-wide license policy until complete.

### Ported Code

This repository also includes code ported from other SS14 forks, organized in namespaced folders:

- `_AXOLOTL/` — [Axolotl MRP](https://github.com/Axolotl-MRP/axolotl-mrp-14)
- `_CD/` — [Cosmatic Drift](https://github.com/cosmatic-drift-14/cosmatic-drift)
- `_DV/` — [Delta-V](https://github.com/DeltaV-Station/Delta-v)
- `_Harmony/` — [Harmony](https://github.com/ss14-harmony/ss14-harmony)
- `_NF/` — [Frontier](https://github.com/new-frontiers-14/frontier-station-14)

- Ported code retains its **original license** (MIT or AGPL).
- Where dual-licensing is offered by the source, both options are preserved.
- SPDX headers and comments are used to mark provenance and ensure compliance.

### 🖼️ Assets

- Most assets (sprites, sounds, etc.) are licensed under **CC BY-SA 3.0**:
  https://creativecommons.org/licenses/by-sa/3.0/
  - Requires attribution
  - Requires derivative works to use the same license (share-alike)

- Each asset folder contains a `meta.json` file that defines authorship and license.
  Example: `hop_turtle.rsi/meta.json`

⚠️ **Note**: Some assets are licensed under **CC BY-NC-SA 3.0** (non-commercial):
https://creativecommons.org/licenses/by-nc-sa/3.0/
These cannot be used in commercial projects. Review and replace them if commercial use is intended.
