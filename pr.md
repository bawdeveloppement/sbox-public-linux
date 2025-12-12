
## **Summary**

This PR introduces a **modular engine-selection system** and the initial architectural implementation of an **experimental alternative engine backend**, **OS27**, developed by Baw Studios.

OS27 is **not functional yet**.
This PR does **not** replace Source 2.
Instead, it introduces a *clean, isolated, reviewable architecture* that allows s&box to optionally load a different engine implementation **without modifying any existing Source 2 behavior**.

This PR is intentionally minimal and safe:
**no rendering, no gameplay changes, no regressions, no risk.**
It only adds the foundation required for modular engine support.

---

# **Motivation**

## 1. Encourage extensibility through community experimentation

A recent discussion in the Discord community highlighted an interesting point:
instead of stripping s&box down to isolate Source 2, it would be far more impressive — and far more valuable — to **reimplement the open-source side** of the engine and provide a compatible, community-driven backend.

This PR takes that idea seriously and represents the **first step** in that direction.

As Laylad said:

> *“If you want to do something impressive, implement all the binds and provide your own engine for the open-source side.”*

OS27 aims to do exactly that.

---

## 2. Provide the groundwork for long-term multi-platform support

s&box currently relies heavily on proprietary Source 2 binaries and a Windows-centric environment.
OS27 explores an alternative: an **open, portable, cross-platform** implementation that respects the exact Source 2 API surface.

This potentially opens the door for future builds targeting:

* Linux (x64 + ARM64)
* Windows (x64 + ARM64)
* macOS (Intel + ARM)
* Android
* iOS
* Raspberry Pi OS
* and more

This PR does **not** modify official build processes or platforms — it only prepares the architecture.

---

## 3. Avoid future architectural friction

Introducing modularity *now*, while the open-source transition is fresh, prevents future large diffs, conflicts, and regressions.
This PR is deliberately small, reviewable, and designed to evolve safely.

---

## 4. No file conflicts with Source 2

All files are isolated under OS27.
There is **zero overlap** or conflict with existing Sandbox code, only little change have been made to make the arg loader --engine.

---

# **What This PR Includes**

### ✔ 1. Engine Loader

A modular engine loader allowing s&box to be launched with:

```
./game/sbox --engine=source2
./game/sbox --engine=OS27
```

* defaults to Source 2
* no changes to default behavior
* OS27 loads only when explicitly requested

---

### ✔ 2. OS27 Backend (Architecture Only)

OS27 is implemented as a **NativeAOT /.NET 10** dynamic library that mirrors the ABI of
`libengine2.so` / `engine2.dll`.

### Current OS27 Capabilities

OS27 currently provides **functional bindings** for:

* Audio
* Camera
* Common
* CUtl
* Engine
* Input
* Material
* PerformanceTrace
* Physics
* Platform
* RenderAttributes
* Rendering
* Resource
* Scene
* ShaderTools
* Texture
* Vfx
* Video

Additionally:

* full logging layer
* filesystem-compatible ABI
* clean, maintainable folder structure
* cross-platform–ready build system

---

### Rendering Status

There is **no graphical output yet**.

Work is in progress to understand how Valve builds VFX attribute data inside their shader pipeline.
I have experimented with multiple approaches, but shader compilation (HLSL (-> SPIRV-CROSS -> GLSL)) to GLSL is not functional yet.

Launching OS27 currently results in a **black screen**, which is expected until a minimal shader pipeline is implemented to render the main menu.

### Content status

To keep functionnaly with models format of valve, i've found a python lib for blender to parse/compile the model so i have to port it into c# 

---


### ✔ 3. Daily Rebase Compatibility

OS27 is kept up-to-date with upstream:

* daily rebase on `facepunch/sbox:main`
* ABI synchronized with current engine2 exports
* clear error surfaces for mismatches

---

### ✔ 4. Documentation

A concise technical document is included covering:

* design philosophy
* loader behavior
* roadmap
* how to contribute or test

---

# **What This PR Does *Not* Include**

* no rendering output
* no gameplay behavior changes
* no overrides or replacements of Source 2
* no file conflicts

This PR is strictly architectural groundwork.

---

# **Rationale**

### **Why submit now instead of waiting for full functionality?**

* A fully functional backend would create a PR too large to reasonably review.
* Architectural direction must be validated early.
* Incremental contribution is the correct approach for engine work.
* Early visibility allows better alignment with s&box’s long-term vision.
* Feedback loops start sooner, improving quality and compatibility.

---

# **Roadmap (Post-PR)**

1. Rendering backend (needer shader handling & parsing models / textures)
2. Shader pipeline:

   * HLSL → SPIR-V → GLSL
   * Multiple profiles:

     * GLSL120
     * GLSL130
     * GLSL330
     * GLES300
     * GLES100
     * Vulkan (VK1)
3. Metal backend (macOS/iOS)
4. DirectX backend (Windows)
5. Physics implementation
6. Audio implementation
7. Asset-system compatibility
8. CI integration
9. Headless mode (servers, CI, cloud builds)

---

# **Business & Community Value**

* Keep the existants games fully compatible without need to rewrite anything at the game developer side
* Enables long-term multi-platform opportunities
* Reduces dependency on proprietary systems
* Improves ecosystem durability and longevity
* Makes s&box more accessible on lightweight hardware
* Encourages experimentation, research, and innovation
* Supports automated tests and server environments
* Offers an alternative implementation without requiring migration from developers, since OS27 is **fully API-compatible**

This is not a fork.
This is a **proposal for a modular future**, entirely optional.

---

# **Final Notes**

This PR is submitted with respect for Facepunch’s standards and vision.
My goals are to:

* contribute seriously
* collaborate with the core team
* offer a long-term benefit to the entire community
* continue maintaining and improving OS27
* ensure full compatibility so that developers do **not** have to migrate anything

Thank you for reviewing — and thank you in advance for any help understanding Valve’s VFX shader attributes.

This PR was crafted over **two intense weeks**.

— **Hermann Vincent (Baw Studios)**
Maintainer of OS27
