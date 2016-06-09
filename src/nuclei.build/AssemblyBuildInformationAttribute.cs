//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;

namespace Nuclei.Build
{
    /// <summary>
    /// An attribute used to indicate which build and revision were used to create the current package.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public sealed class AssemblyBuildInformationAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyBuildInformationAttribute"/> class.
        /// </summary>
        /// <param name="buildNumber">The number of the build that created the current package.</param>
        /// <param name="versionControlInformation">
        /// A string which provides information about the revision under which the current package is
        /// committed in the version control system.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     Thrown if <paramref name="versionControlInformation"/> is <see langword="null" />.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     Thrown if <paramref name="versionControlInformation"/> is a string which is empty or filled with whitespace.
        /// </exception>
        public AssemblyBuildInformationAttribute(int buildNumber, string versionControlInformation)
        {
            if (versionControlInformation == null)
            {
                throw new ArgumentNullException("versionControlInformation", "The version control information string should not be null");
            }

            if (string.IsNullOrWhiteSpace(versionControlInformation))
            {
                throw new ArgumentException("The version control information string should not be an empty string.", "versionControlInformation");
            }

            BuildNumber = buildNumber;
            VersionControlInformation = versionControlInformation;
        }

        /// <summary>
        /// Gets the number of the build that created the current package.
        /// </summary>
        public int BuildNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a string which provides information about the revision under which the current package is
        /// committed in the version control system.
        /// </summary>
        public string VersionControlInformation
        {
            get;
            private set;
        }
    }
}
