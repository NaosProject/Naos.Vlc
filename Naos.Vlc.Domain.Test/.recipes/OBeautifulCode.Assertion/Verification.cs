// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Verification.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Assertion.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Assertion.Recipes
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;

    /// <summary>
    /// Specifies a verification, a condition that the subject must satisfy.
    /// </summary>
#if !OBeautifulCodeAssertionSolution
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Assertion.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class Verification
    {
        /// <summary>
        /// Gets or sets the name of the verification.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the rationale for the verification.
        /// </summary>
        public string Because { get; set; }

        /// <summary>
        /// Gets or sets a value that determines how to apply the <see cref="Because"/>.
        /// </summary>
        public ApplyBecause ApplyBecause { get; set; }

        /// <summary>
        /// Gets or sets the handler for the verification.
        /// </summary>
        public Delegates.VerificationHandler Handler { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="VerificationParameter"/>s.
        /// </summary>
        public IReadOnlyList<VerificationParameter> VerificationParameters { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="TypeValidation"/>s to apply.
        /// </summary>
        public IReadOnlyCollection<TypeValidation> TypeValidations { get; set; }

        /// <summary>
        /// Gets or sets a collection of key/value pairs that provide additional user-defined information
        /// that is added to the exception's <see cref="Exception.Data"/> property, if thrown.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = ObcSuppressBecause.CA2227_CollectionPropertiesShouldBeReadOnly_PublicInterfaceNeverExposesTheObject)]
        public IDictionary Data { get; set; }
    }
}
