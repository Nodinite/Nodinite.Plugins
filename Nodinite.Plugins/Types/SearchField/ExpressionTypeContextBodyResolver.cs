using Nodinite.Plugins.Types.SearchField.Interfaces;
using Nodinite.Plugins.Types.SearchField.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Nodinite.Plugins.Types.SearchField
{
    public abstract class ExpressionTypeContextBodyResolver<T> : ExpressionTypeContextBody<T>, IExpressionResolver
    {
        protected ExpressionTypeContextBodyResolver(Guid pluginGuid, string name, string description, string webSite) 
            : base(pluginGuid, name, description, webSite)
        {

        }

        public abstract HashSet<string> Resolve(IDictionary<string, object> contextProperties, Stream bodyStream, InputSelection bodyInputSelection, string contextKeySelected, InputSelection contextInputSelection);
    }
}
