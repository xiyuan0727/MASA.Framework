// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.Contrib.Configuration;

public class ConfigurationOptions
{
    public Assembly[] Assemblies { get; set; }

    public List<Type> ExcludeConfigurationSourceTypes { get; set; }

    public List<Type> ExcludeConfigurationProviderTypes { get; set; }

    public ConfigurationOptions()
    {
        Assemblies = MasaApp.GetAssemblies();
        ExcludeConfigurationSourceTypes = Internal.ConfigurationExtensions.DefaultExcludeConfigurationSourceTypes;
        ExcludeConfigurationProviderTypes = Internal.ConfigurationExtensions.DefaultExcludeConfigurationProviderTypes;
    }
}
