using Nodinite.Plugins.Core.Models;
using System.Collections.Generic;
using System.IO;

namespace Nodinite.Plugins.Types.SearchField.Interfaces
{
    public interface IExpressionTypeContextBody : IExpressionType
    {
        /// <summary>
        /// Call to plugin to retrieve multiple values from the message
        /// </summary>
        /// <param name="expression">Expression is a string to use, if the plugin is a RegEx plugin the expression would be a RegEx expression</param>
        /// <param name="contextProperties">A dictionary with context properties and usually string as the object</param>
        /// <param name="bodyStream">The event body as a stream</param>
        /// <returns>Should return a list of values found, for the specific Search Field</returns>
        HashSet<string> Extract(string expression, IDictionary<string, object> contextProperties, DisposableList<Stream> bodyStreams);
    }
}
