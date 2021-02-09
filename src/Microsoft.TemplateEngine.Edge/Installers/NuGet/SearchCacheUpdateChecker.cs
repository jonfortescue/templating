// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading.Tasks;
using Microsoft.TemplateEngine.Abstractions.TemplatesSources;

namespace Microsoft.TemplateEngine.Edge.Installers.NuGet
{
    internal class SearchCacheUpdateChecker : IUpdateChecker
    {
        public bool CanCheckForUpdate(NuGetManagedTemplatesSource source)
        {
            throw new NotImplementedException();
        }

        public Task<ManagedTemplatesSourceUpdate> GetLatestVersionAsync(NuGetManagedTemplatesSource source) => throw new NotImplementedException();
    }
}
