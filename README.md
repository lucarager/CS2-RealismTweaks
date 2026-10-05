# Realism Tweaks

A Cities: Skylines 2 mod bundling a series of construction and simulation adjustments for a more realistic game.

## Development

Clone with submodules (the shared [LucaModsCommon](https://github.com/lucarager/CS2-LucaModsCommon) library lives at `RealismTweaks/Common`):

```
git clone --recurse-submodules https://github.com/lucarager/CS2-RealismTweaks.git
```

Requires the CSII Modding Toolchain (`CSII_TOOLPATH` and `CSII_USERDATAPATH` user environment variables) and Node 18+.

Build via the solution:

```
dotnet build CS2-RealismTweaks.slnx
```

The build compiles the mod, runs `npm run build` in `RealismTweaks/UI`, and deploys both to the game's local `Mods` folder.

## License

MIT. See [LICENSE.txt](LICENSE.txt).
