namespace RyujinxTools;

public sealed record LdnSession(string RoomId, string TitleId, bool Private, bool InProgress, int Players);

public static class LdnBrowser
{
    public static IEnumerable<LdnSession> Visible(IEnumerable<LdnSession> all, ISet<string>? owned = null) =>
        all.Where(s => !s.Private && !s.InProgress && (owned is null || owned.Contains(s.TitleId)));
}
