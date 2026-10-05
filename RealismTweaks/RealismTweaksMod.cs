// <copyright file="RealismTweaksMod.cs" company="Luca Rager">
// Copyright (c) Luca Rager. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace RealismTweaks {
    using Colossal;       // IDictionarySource
    using Game;           // UpdateSystem
    using Game.Modding;   // IMod, ModSetting

    using LucaModsCommon.Mod;

    using RealismTweaks.L10n;
    using RealismTweaks.Settings;

    /// <summary>
    /// Mod entry point. Shared lifecycle (logging, settings, localization, Harmony, tests, asset
    /// host registration) is provided by <see cref="LucaModBase{TSelf}"/>.
    /// </summary>
    public sealed class RealismTweaksMod : LucaModBase<RealismTweaksMod>, IMod {
        /// <inheritdoc/>
        public override string ModName => "RealismTweaks";

        /// <inheritdoc/>
        public override string Id => "RealismTweaks";

        /// <inheritdoc/>
        protected override string UiHostPrefix => "rt";

        /// <summary>
        /// Gets the mod's settings, typed as <see cref="RT_Settings"/>.
        /// </summary>
        public new RT_Settings Settings => (RT_Settings)base.Settings;

        /// <inheritdoc/>
        protected override ModSetting CreateSettings(IMod mod) => new RT_Settings(mod);

        /// <inheritdoc/>
        protected override IDictionarySource CreateEnUsLocalization(ModSetting settings) =>
            new EnUsConfig((RT_Settings)settings);

        /// <inheritdoc/>
        protected override void RegisterSystems(UpdateSystem updateSystem) {
        }

        /// <summary>
        /// Exports the en-US dictionary to L10n/lang/en-US.json on the I18N build configuration so
        /// translators have an up-to-date source file.
        /// </summary>
        protected override void GenerateLanguageFile() => ExportEnUsLocalization();
    }
}
