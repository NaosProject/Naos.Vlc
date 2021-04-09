// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VlcBsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Vlc.Serialization.Bson
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Naos.CodeAnalysis.Recipes;
    using Naos.Protocol.Serialization.Bson;
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    /// <inheritdoc />
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Vlc", Justification = NaosSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
    public class VlcBsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters =>
            new[]
            {
                Naos.Vlc.Domain.ProjectInfo.Namespace,
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<BsonSerializationConfigurationType> DependentBsonSerializationConfigurationTypes =>
            new[]
            {
                typeof(ProtocolBsonSerializationConfiguration).ToBsonSerializationConfigurationType(),
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson => new Type[0]
            .Concat(new[] { typeof(IModel) })
            .Concat(Naos.Vlc.Domain.ProjectInfo.Assembly.GetPublicEnumTypes())
            .Select(_ => _.ToTypeToRegisterForBson())
            .ToList();
    }
}