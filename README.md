# ryujinx

C# / Avalonia Nintendo Switch emulator continuation (`git.ryujinx.app` / Ryubing line) built around accuracy, multiplayer LDN room browsing, and LayeredFS mod support.

<img width="280" height="280" alt="images1" src="https://github.com/user-attachments/assets/4e3f09b6-9e54-48a7-81c8-131b4764f6c2" />
<img width="1200" height="675" alt="images2" src="https://github.com/user-attachments/assets/a96699b7-6111-40a0-9faa-e4faf9f85fe1" />


## LDN & Amiibo

The integrated **LDN Game Viewer** lists active rooms in a compatibility-style table, hiding private and in-progress lobbies by default with an owned-titles filter. The redesigned **Amiibo Window** moves figure selection to a left-hand dock with live artwork previews and per-game filtering.

<img width="898" height="513" alt="images3" src="https://github.com/user-attachments/assets/12aead09-9919-4066-b699-877c9f28f943" />

## Compatibility & Span Caching

Array span caching (`AsSpan`, `AsNodes`, `AsArray`) eliminates cutscene stutter during heavy overlap lookups. Audio renderer updates add compatibility for *Tears of the Kingdom* (`v1.4.x`), *Breath of the Wild* (`v1.8.x`), Nintendo Classics titles, and *Hollow Knight: Silksong*, paired with Avalonia scroll and settings UI refinements.

<img width="739" height="415" alt="images4" src="https://github.com/user-attachments/assets/b17080f4-457c-4142-951b-ff68d6e2983c" />

## Building Local Helpers

```bash
dotnet build RyujinxTools.csproj
```

Supply system firmware and `prod.keys` dumped strictly from your own Switch hardware.

<img width="1200" height="675" alt="images5" src="https://github.com/user-attachments/assets/bc7724a4-6e0a-48c8-92fc-0412ed5a4c68" />

<img width="1300" height="855" alt="images6" src="https://github.com/user-attachments/assets/1698dfd6-506b-4303-ac20-ab292892b8cc" />
