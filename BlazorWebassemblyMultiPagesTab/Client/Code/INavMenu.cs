namespace BlazorWebassemblyMultiPagesTab.Client.Code
{
    public interface INavMenu
    {
        public Task GoTo(string title, string url);
    }
}
