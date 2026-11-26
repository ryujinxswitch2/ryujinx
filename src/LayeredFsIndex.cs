namespace RyujinxTools;

public static class LayeredFsIndex
{
    public static IReadOnlyList<string> DiscoverTitleDirs(string contentsRoot) =>
        Directory.Exists(contentsRoot)
            ? Directory.GetDirectories(contentsRoot).Select(Path.GetFileName).Where(n => n is { Length: 16 }).ToList()!
            : Array.Empty<string>();
}
