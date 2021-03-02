using Nodinite.Plugins.Types.SearchField.Models;
using System.Collections.Generic;
using System.IO;

namespace Nodinite.Plugins.Types.SearchField.Interfaces
{
    public interface IExpressionResolver
    {
        /// <summary>
        /// Resolve expressions from current position
        /// </summary>
        /// <param name="contextProperties">A dictionary with context properties and usually string as the object</param>
        /// <param name="bodyStream">The event body as a stream</param>
        /// <param name="bodyInputSelection">Selection with index 1 for line number and index 1 for char(column) of the body</param>
        /// <param name="contextKeySelected">Selected context</param>
        /// <param name="contextInputSelection">Selection with index 1 for line number and index 1 for char(column) of the selected context</param>
        /// <returns></returns>
        HashSet<string> Resolve(IDictionary<string, object> contextProperties, Stream bodyStream, InputSelection bodyInputSelection, string contextKeySelected, InputSelection contextInputSelection);
    }
}
