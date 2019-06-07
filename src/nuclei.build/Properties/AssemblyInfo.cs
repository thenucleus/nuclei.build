//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Nuclei.Build;

[assembly: AssemblyCulture("")]

// Resources
[assembly: NeutralResourcesLanguage("en-US")]

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTrademark("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Indicate that the assembly is CLS compliant.
[assembly: CLSCompliant(true)]

// The time the assembly was build
[assembly: AssemblyBuildTime(buildTime: "1900-01-01T00:00:00.0000000+00:00")]

// The version from which the assembly was build
[module: SuppressMessage(
    "Microsoft.Usage",
    "CA2243:AttributeStringLiteralsShouldParseCorrectly",
    Justification = "It's a VCS revision, not a version")]
[assembly: AssemblyBuildInformation(buildNumber: 0, versionControlInformation: "1234567890123456789012345678901234567890")]
