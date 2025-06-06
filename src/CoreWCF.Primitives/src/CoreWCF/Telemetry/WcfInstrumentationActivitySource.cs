// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using CoreWCF.Channels;

namespace CoreWCF.Telemetry;

/// <summary>
/// WCF instrumentation.
/// </summary>
internal static class WcfInstrumentationActivitySource
{
    internal static readonly Assembly Assembly = typeof(WcfInstrumentationActivitySource).Assembly;
    internal static readonly AssemblyName AssemblyName = Assembly.GetName();
    internal static readonly string ActivitySourceName = AssemblyName.Name!;
    internal static readonly string IncomingRequestActivityName = ActivitySourceName + ".IncomingRequest";

    public static ActivitySource ActivitySource { get; } = new(ActivitySourceName, Assembly.GetPackageVersion());
}
