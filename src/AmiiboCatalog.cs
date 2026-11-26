namespace RyujinxTools;

public sealed record AmiiboEntry(string Id, string Name, string Series, string[] SupportedTitleIds);

public static class AmiiboCatalog
{
    public static IEnumerable<AmiiboEntry> ForTitle(IEnumerable<AmiiboEntry> items, string titleId) =>
        items.Where(a => a.SupportedTitleIds.Contains(titleId, StringComparer.OrdinalIgnoreCase));
}
