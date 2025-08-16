<p align="center">
  <img alt="LateStation" src="https://raw.githubusercontent.com/LateStation14/Late-station-14/refs/heads/master/Resources/Textures/Logo/logo.png" />
</p>

# LateStation14

**LateStation** is a custom content fork of the official [Space Station 14](https://github.com/space-wizards/space-station-14) project. We aim to create our own gameplay experience, with original mechanics, stations, and assets — all while staying aligned with the upstream SS14 codebase.

We are currently building our own identity on top of the core SS14 platform. While much of the game is still similar to upstream, LateStation is actively developing unique systems, content, and balance changes to support our own long-term vision.

**Space Station 14** is a remake of the classic SS13, running on [RobustToolbox](https://github.com/space-wizards/RobustToolbox) — an open-source game engine written in C# and built specifically for multiplayer, tile-based simulation games like SS14.

---

## 🔗 Links

- 🌐 LateStation Website: http://www.lateStation14.space/
- 🧭 SS14 Website: https://spacestation14.io/
- 🛠️ SS14 Standalone Download: https://spacestation14.io/about/nightlies/
- 🎮 SS14 on Steam: https://store.steampowered.com/app/1255460/Space_Station_14/
- 📁 LateStation Resources: https://www.lateStation14.space/

---

## 📚 Documentation & Wiki

- SS14 Docs: https://docs.spacestation14.io/ — Covers the engine, content, game design, mapping, modding, and more.
- LateStation Contributions: See CONTRIBUTING.md — Read this first if you’re new and want to help out!

---

## 🤝 Contributing

We welcome contributions of all kinds — coding, spriting, mapping, balancing, and feedback.

- Check out our CONTRIBUTING.md file.
- Open a pull request or issue if you’d like to get involved.

---

## 🧱 Building the Project

1. Clone this repo:

   git clone https://github.com/LateStation14/Late-station-14.git

2. Enter the project folder and run the setup script:

   cd Late-station-14
   python RUN_THIS.py

3. Build the solution:

   dotnet build

For full build and IDE setup instructions, see the SS14 Developer Docs:
https://docs.spacestation14.com/en/general-development/setup.html

---

## ⚖️ License

### Code

- All original code created by the LateStation team (typically in `_LateStation/` folders) is **dual-licensed under MIT and AGPL-3.0-or-later** (as of this commit everything before this commit is still MIT)
- Upstream code from [Wizards Den's Space Station 14](https://github.com/space-wizards/space-station-14) remains under the original **MIT License** and is preserved unmodified unless there have to be changes in order to make certain things work, but then its commented.
- Contributors must follow licensing rules defined in our [CONTRIBUTING.md](CONTRIBUTING.md).

### Ported Code

This repository contains content ported from other SS14 forks. These are stored in namespaced folders like:

- `_AXOLOTL/` — [Axolotl MRP](https://github.com/Axolotl-MRP/axolotl-mrp-14)
- `_CD/` — [Cosmatic Drift](https://github.com/cosmatic-drift-14/cosmatic-drift)
- `_DV/` — [Delta-V](https://github.com/DeltaV-Station/Delta-v)
- `_Harmony/` — [Harmony](https://github.com/ss14-harmony/ss14-harmony)
- `_NF/` — [Frontier](https://github.com/new-frontiers-14/frontier-station-14)

Only code that is **MIT-licensed or dual-licensed** is ported into LateStation. All code is used in compliance with its original license, and attribution is preserved where applicable.

⚠️ **Note**: Some code files do not yet include SPDX license headers. We are currently in the process of adding them to all original LateStation content.

Code ported or modified from upstream (Wizards Den) or other SS14 forks retains its original license (typically MIT OR AGPL) and is marked or attributed where appropriate. Licensing is preserved even when changes are made.

### 🖼️ Assets

- Most assets (sprites, sounds, etc.) are licensed under Creative Commons Attribution-ShareAlike 3.0:
  https://creativecommons.org/licenses/by-sa/3.0/
  - Requires proper attribution
  - Requires derivative works to use the same license (share-alike)
- Each asset directory includes a metadata file specifying its license and authorship.
  Example: `hop_turtle.rsi/meta.json`

⚠️ **Note**: Some assets may be under non-commercial licenses, such as:
https://creativecommons.org/licenses/by-nc-sa/3.0/

These assets **cannot be used in commercial projects**. If you intend to use this project commercially, you will need to review and replace these assets.
