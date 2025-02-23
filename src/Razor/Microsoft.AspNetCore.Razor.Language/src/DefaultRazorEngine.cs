﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Razor.Language
{
    internal class DefaultRazorEngine : RazorEngine
    {
        public DefaultRazorEngine(IRazorEngineFeature[] features, IRazorEnginePhase[] phases)
        {
            if (features == null)
            {
                throw new ArgumentNullException(nameof(features));
            }

            if (phases == null)
            {
                throw new ArgumentNullException(nameof(phases));
            }

            Features = features;
            Phases = phases;

            for (var i = 0; i < features.Length; i++)
            {
                features[i].Engine = this;
            }

            for (var i = 0; i < phases.Length; i++)
            {
                phases[i].Engine = this;
            }
        }

        public override IReadOnlyList<IRazorEngineFeature> Features { get; }

        public override IReadOnlyList<IRazorEnginePhase> Phases { get; }

        public override void Process(RazorCodeDocument document)
        {
            if (document == null)
            {
                throw new ArgumentNullException(nameof(document));
            }

            for (var i = 0; i < Phases.Count; i++)
            {
                var phase = Phases[i];
                phase.Execute(document);
            }
        }
    }
}
