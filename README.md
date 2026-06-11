# Simple Plants

`Simple Plants` is a Subnautica 1 quality-of-life mod for BepInEx 5 and Nautilus. It makes a small set of vanilla plant-derived resources occupy a single inventory slot.

## Overview

The mod changes these items to `1x1`:

- Creepvine samples
- Creepvine seed clusters
- Blood oil

It does not add new items, recipes, prefabs, or save data.

## Requirements

- Subnautica 1
- BepInEx 5
- Nautilus

## Installation

1. Download the release archive or build the project from source.
2. Copy `SimplePlants.dll` into `Subnautica/BepInEx/plugins/`.
3. Launch the game and load a save.

## Compatibility

This mod is intentionally small and usually plays well with other content mods.

Load order matters if another mod edits the same item sizes:

- the last mod to write the value wins
- existing saves do not need to be restarted

## Technical Details

At startup, the plugin calls Nautilus' supported item-size API:

```csharp
CraftDataHandler.SetItemSize(TechType, 1, 1);
```

This applies directly to vanilla `TechType` metadata, so the change is global rather than save-specific.

## Build Notes

- Target framework: `net472`
- Release artifact: `SimplePlants.dll`

## Changelog

### 1.0.0

- Initial release
- Added `1x1` inventory sizing for creepvine samples, creepvine seed clusters, and blood oil
