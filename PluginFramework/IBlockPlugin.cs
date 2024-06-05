namespace PluginFramework
{
    public interface IBlockPlugin
    {
        string Name { get; }

        string Color { get; }

        bool LightForeground { get; }
    }
}
