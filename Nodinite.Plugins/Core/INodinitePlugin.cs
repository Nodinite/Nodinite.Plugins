using System;

namespace Nodinite.Plugins.Core
{
    /// <summary>
    /// Common interface for all Nodinite Plugins
    /// </summary>
    public interface INodinitePlugin
    {
        /// <summary>
        /// The unique identifier of this plugin. This GUID is used to check with registered plugins. Make sure to create a new GUID once and hard code this GUID in the plugin component. This GUID should never change. Changing the GUID will re-register this plugin as a new plugin
        /// </summary>
        Guid PluginGuid { get; }
        /// <summary>
        /// The name to register the plugin with
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The description that this plugin will be registered with
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Address where to find more information that this plugin will be registered with
        /// </summary>
        string WebSite { get; }
        /// <summary>
        /// The version that this plugin will be registered with
        /// </summary>
        string Version { get; }
    }
}
