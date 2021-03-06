// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionHelper.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Reflection.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Reflection.Recipes
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Reflection;

    /// <summary>
    /// Provides useful methods related to reflection.
    /// </summary>
#if !OBeautifulCodeReflectionSolution
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Reflection.Recipes", "See package version number")]
    internal
#else
    public
#endif
    static partial class ReflectionHelper
    {
        /// <summary>
        /// Gets all types in an assembly that have an attribute of a specified type.
        /// </summary>
        /// <typeparam name="TAttribute">The type of attribute to search for.</typeparam>
        /// <param name="assembly">The assembly to search.</param>
        /// <param name="attributeFilter">
        /// Optional.  When provided, requires that this filter
        /// return true when attributes of the specified type are passed-in,
        /// before the type having the specified attribute is returned.
        /// </param>
        /// <returns>
        /// The types in an assembly where the specified attribute has been
        /// applied at least one, or an empty collection if none of the
        /// types in the assembly have that attribute.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="assembly"/> is null.</exception>
        public static IReadOnlyCollection<Type> GetTypesHaving<TAttribute>(
            this Assembly assembly,
            Func<TAttribute, bool> attributeFilter = null)
            where TAttribute : Attribute
        {
            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            var attributeType = typeof(TAttribute);
            var result = assembly.GetTypes()
                .Where(
                    _ =>
                        attributeFilter == null
                            ? _.GetCustomAttributes(attributeType, false).Any()
                            : _.GetCustomAttributes(attributeType, false).Cast<TAttribute>().Where(attributeFilter).Any())
                .ToList()
                .AsReadOnly();

            return result;
        }
    }
}
