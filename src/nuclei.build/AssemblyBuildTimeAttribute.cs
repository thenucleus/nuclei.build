//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Nuclei.Build.Properties;

namespace Nuclei.Build
{
    /// <summary>
    /// An attribute used to indicate at which date and time an assembly was build.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    [SuppressMessage(
        "Microsoft.Design",
        "CA1019:DefineAccessorsForAttributeArguments",
        Justification = "There is an accessor, it just changes the type to a DateTimeOffset.")]
    public sealed class AssemblyBuildTimeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyBuildTimeAttribute"/> class.
        /// </summary>
        /// <param name="buildTime">The date and time the assembly was build.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="buildTime"/> is an <see langword="null" /> reference.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if <paramref name="buildTime"/> is a string that is empty or filled with whitespace.
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown if <paramref name="buildTime"/> does not contain a round-trippable date and time.
        /// </exception>
        public AssemblyBuildTimeAttribute(string buildTime)
        {
            if (buildTime == null)
            {
                throw new ArgumentNullException(nameof(buildTime));
            }

            if (string.IsNullOrWhiteSpace(buildTime))
            {
                throw new ArgumentException(
                    Resources.Exceptions_Messages_ParameterShouldNotBeAnEmptyString,
                    nameof(buildTime));
            }

            BuildTime = DateTimeOffset.ParseExact(buildTime, "o", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the date and time on which the assembly was build.
        /// </summary>
        public DateTimeOffset BuildTime
        {
            get;
            private set;
        }
    }
}
