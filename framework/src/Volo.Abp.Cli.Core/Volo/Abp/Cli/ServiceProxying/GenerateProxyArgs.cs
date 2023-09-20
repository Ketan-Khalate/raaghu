﻿using System.Collections.Generic;
using JetBrains.Annotations;

namespace Volo.Abp.Cli.ServiceProxying;

public class GenerateProxyArgs
{
    [NotNull]
    public string CommandName { get; }

    [NotNull]
    public string WorkDirectory { get; }

    public string Module { get; }

    public string Url { get; }

    public string Output { get; }

    public string Target { get; }

    public string ApiName { get; }

    public string Source { get; }

    public string Folder { get; }
    public string EntryPoint { get; }

    public ServiceType? ServiceType { get; }

    public bool WithoutContracts { get; }

    [NotNull]
    public Dictionary<string, string> ExtraProperties { get; set; }

    public GenerateProxyArgs(
        [NotNull] string commandName,
        [NotNull] string workDirectory,
        string module,
        string url,
        string output,
        string target,
        string apiName,
        string source,
        string folder,
        ServiceType? serviceType,
        string entryPoint,
        bool withoutContracts,
        Dictionary<string, string> extraProperties = null)
    {
        CommandName = Check.NotNullOrWhiteSpace(commandName, nameof(commandName));
        WorkDirectory = Check.NotNullOrWhiteSpace(workDirectory, nameof(workDirectory));
        Module = module;
        Url = url;
        Output = output;
        Target = target;
        ApiName = apiName;
        Source = source;
        Folder = folder;
        ServiceType = serviceType;
        EntryPoint = entryPoint;
        WithoutContracts = withoutContracts;
        ExtraProperties = extraProperties ?? new Dictionary<string, string>();
    }
}
