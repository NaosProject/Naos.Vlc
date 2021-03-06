// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProcessHelpers.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in Naos.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Diagnostics.Recipes
{
    using System;
    using System.Diagnostics;
    using System.Security.Principal;

    /// <summary>
    /// Various helper methods related to a processes.
    /// </summary>
#if NaosDiagnosticsRecipes
    public
#else
    [System.CodeDom.Compiler.GeneratedCode("Naos.Diagnostics", "See package version number")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    internal
#endif
    static class ProcessHelpers
    {
        /// <summary>
        /// Gets a value indicating whether or not the executing process is running as administrator.
        /// </summary>
        /// <remarks>I'm not certain if this works on a thread that is impersonating or not.</remarks>
        /// <returns>Value indicating whether or not the executing process is running as administrator.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "The caller will be the consumer of this recipe.")]
        public static bool IsCurrentlyRunningAsAdmin()
        {
            var result = WindowsIdentity.GetCurrent().Owner?.IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid) ?? false;
            return result;
        }

        /// <summary>
        /// Gets the currently running process.
        /// </summary>
        /// <returns>
        /// The currently running process.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Don't want to use a property for this kind of active call.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "The caller will be the consumer of this recipe.")]
        public static Process GetRunningProcess()
        {
            var result = Process.GetCurrentProcess();
            return result;
        }

        /// <summary>
        /// Gets the process' name.
        /// </summary>
        /// <param name="process">The process</param>
        /// <returns>
        /// The process' name.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "The caller will be the consumer of this recipe.")]
        public static string GetName(
            this Process process)
        {
            if (process == null)
            {
                throw new ArgumentNullException(nameof(process));
            }

            var result = process.ProcessName;
            return result;
        }

        /// <summary>
        /// Gets the file path of a process.
        /// </summary>
        /// <param name="process">The process</param>
        /// <returns>
        /// The file path of the a process.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "The caller will be the consumer of this recipe.")]
        public static string GetFilePath(
            this Process process)
        {
            if (process == null)
            {
                throw new ArgumentNullException(nameof(process));
            }

            var result = process.MainModule.FileName;
            return result;
        }

        /// <summary>
        /// Gets the file version of a process.
        /// </summary>
        /// <param name="process">The process</param>
        /// <returns>
        /// The file version of a process.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "The caller will be the consumer of this recipe.")]
        public static string GetFileVersion(
            this Process process)
        {
            if (process == null)
            {
                throw new ArgumentNullException(nameof(process));
            }

            var result = process.MainModule.FileVersionInfo.FileVersion;
            return result;
        }

        /// <summary>
        /// Gets the product version of a process.
        /// </summary>
        /// <param name="process">The process</param>
        /// <returns>
        /// The product version of a process.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "The caller will be the consumer of this recipe.")]
        public static string GetProductVersion(
            this Process process)
        {
            if (process == null)
            {
                throw new ArgumentNullException(nameof(process));
            }

            var result = process.MainModule.FileVersionInfo.ProductVersion;
            return result;
        }
    }
}
