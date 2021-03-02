using Nodinite.Plugins.Core.Models;
using Nodinite.Plugins.Types.SearchField.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Nodinite.Plugins.Types.SearchField
{
    public abstract class ExpressionTypeContextBody<T> : IExpressionTypeContextBody
    {
        public ExpressionTypeContextBody(Guid pluginGuid, string name, string description, string webSite)
        {
            PluginGuid = pluginGuid;
            Name = name;
            Description = description;
            WebSite = webSite;

            Assembly assembly = Assembly.GetAssembly(typeof(T));
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Version =  fvi.FileVersion;
        }

        public Guid PluginGuid { get; }
        public string Name { get; }
        public string Description { get; }
        public string WebSite { get; }
        public string Version { get; }

        public abstract HashSet<string> Extract(string expression, IDictionary<string, object> contextProperties, DisposableList<Stream> bodyStreams);
    }
}
