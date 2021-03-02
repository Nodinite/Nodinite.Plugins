using Nodinite.Plugins.AutoFields;

namespace Nodinite.Plugins.Core
{
    public interface IAutoFieldConfigurable
    {
        /// <summary>
        /// A Nodinite extension of https://github.com/JustMaier/angular-autoFields-bootstrap
        /// The schema used to edit configuration of this plugin, and will be registered with the plugin
        /// </summary>
        AutoField AutoField { get; }

        /// <summary>
        /// Method to update configuration for the plugin only called after version updates
        /// </summary>
        /// <param name="configuration">Configuration to update</param>
        /// <returns>untouched or updated configuration</returns>
        string Update(string configuration);
    }
}
