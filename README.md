<div align="center">

  <img src="https://sbox.game/img/sbox-logo-square.svg" width="90px" alt="s&box logo">

  <br><br>

  [Website] • [Getting Started] • [Forums] • [Documentation] • [Contributing]
</div>

---

# s&box – Toward a Multi-Platform Open-Source Engine

s&box is a modern game engine built on Valve’s Source 2 and the latest .NET technologies.  
This repository expands on that foundation with an experimental, open-source effort led by **Baw Studios** to explore a truly multi-platform future for the engine.

> This project was born from technical frustration.  
> I want to offer the community what no one has dared to build.  
> I enjoy pushing the limits of what is possible.

---

# Why This Project Exists

Today:

- s&box depends entirely on **Source 2**, a proprietary engine.  
- Most of s&box’s work has been shaped around **Windows-only** support.  
- Several critical dependencies are **not cross-platform**.  
- Developers exporting standalone builds must request **Valve’s approval/license** to commercialize them.  
- The community remains stuck between a brilliant engine… and a locked-down ecosystem.

This repository explores an alternative path:  
a low-level, open-source reconstruction that aims to **mimic the Source 2 API** closely enough for s&box and all s&box games to run on:

- Linux  
- macOS  
- Windows  
- Android  
- iOS  
- and eventually **consoles** and multiple CPU architectures (x86_64, ARM, etc.)

The goal is simple:  
**give creators the freedom to choose** between Valve’s engine and an open-source counterpart — with zero friction.

---

# Vision: OS2 (Codename)

This experimental branch introduces **OS2**, an initiative by Baw Studios.

**OS2** (*Open Source 2*, codename) is a long-term effort to:

- faithfully reproduce the Source 2 API  
- provide full backward compatibility with s&box  
- enable seamless switching between proprietary and open engines  
- unlock true multi-platform deployment  
- offer a durable, extensible foundation for the community  

OS2 is not about replacing Source 2.  
It is about giving it a **free, open, portable mirror** driven by real community needs.

---

# Objectives

## Technical Objectives

- Recreate a low-level open-source engine mirroring the Source 2 API.  
- Ensure **maximum backward compatibility** with s&box projects.  
- Replace non-portable dependencies with **cross-platform alternatives**.  
- Enable the s&box editor to run natively on:
  - Linux  
  - macOS  
  - Windows  
  - Android  
  - iOS  
  - and, where possible, **console environments**
- Support multiple CPU architectures:
  - x86_64  
  - ARM (desktop + mobile)  
  - emerging architectures

## Community Objectives

- Free creators from the restrictive Source 2 standalone licensing process.  
- Provide an engine that can be audited, extended, forked.  
- Enable experimentation in systems engineering and portability.  
- Offer something the ecosystem needed — but no one attempted.

---

# Progress

In the first days of development:

- **58,812 additions**  
- **247 deletions**

These numbers highlight:

- the pace of progress  
- the technical depth of the work  
- the commitment to rebuilding foundations rather than patching symptoms  

The first components of Source 2 reverse engineering on Linux are in place,  
and the multi-platform pipeline is beginning to emerge.

Upcoming:

- Stabilizing low-level subsystems  
- Mapping core API surfaces  
- Migrating dependencies  
- Exploring Android, iOS, and console targets (within legal boundaries)

---

# Who This Project Is For

Ideal for:

- developers passionate about s&box and Source 2  
- Linux/macOS users seeking native support  
- indie studios looking for engine flexibility  
- reverse-engineering and systems-engineering enthusiasts  
- recruiters searching for profiles capable of:
  - understanding complex engines  
  - deconstructing them  
  - rebuilding them more freely  

---

# Using or Contributing

If your goal is simply to build games with s&box, please see:

- [Getting Started](https://sbox.game/dev/doc/about/getting-started/first-steps/)  
- [Documentation](https://sbox.game/dev/doc/)

This repository is for:

- understanding inner engine systems  
- experimenting with Linux & multi-platform support  
- contributing to a future open-source engine

---

# Getting the Engine

### Steam

Download the official s&box editor from [Steam](https://sbox.game/give-me-that).

### Compiling from Source

```bash
git clone https://github.com/bawdeveloppement/sbox-public-linux.git
cd sbox-public-linux
git checkout test-silk-0.1
./Bootstrap.sh
````

---

# Contributing

Contributions are welcome, especially if you:

* know Linux, macOS, Android, iOS, or console development
* enjoy reverse engineering
* want to help build cross-platform foundations
* improve documentation or tooling

---

# Follow the Journey

* 🌐 Newsletter: [https://goldyrust.com/newsletter](https://goldyrust.com/newsletter)
* ⭐ Support the vision by starring the repository
* 🏹 Maintained by **Baw Studios — Hermann Vincent**

---

# License

This project uses the [MIT License](LICENSE.md), like the official s&box engine.

Some binaries in `game/bin` remain under the s&box EULA.
Third-party components retain their original licenses.

This experimental work exists to **remove or replace all non-permissive dependencies** wherever legally possible.
---

<div align="center">
  <img src="https://www.bawstudios.org/assets/baw-logo-D-_lyi4S.jpg" width="160px" alt="Baw Studios logo">

  <p><strong>Maintained by <a href="https://www.bawstudios.org">Baw Studios</a> — Hermann Vincent</strong></p>
</div>

---
