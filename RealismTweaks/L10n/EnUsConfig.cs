// <copyright file="EnUsConfig.cs" company="Luca Rager">
// Copyright (c) Luca Rager. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace RealismTweaks.L10n {
    using System.Collections.Generic;

    using Colossal;

    using RealismTweaks.Settings;

    /// <summary>
    /// Configures the English (US) localization for Realism Tweaks.
    /// </summary>
    public class EnUsConfig : IDictionarySource {
        private readonly Dictionary<string, string> m_Localization;
        private readonly RT_Settings                m_Setting;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnUsConfig"/> class.
        /// </summary>
        /// <param name="setting">The mod's settings.</param>
        public EnUsConfig(RT_Settings setting) {
            m_Setting = setting;

            m_Localization = new Dictionary<string, string> {
                { m_Setting.GetSettingsLocaleID(), "Realism Tweaks" },

                // Groups
                { m_Setting.GetOptionGroupLocaleID(RT_Settings.GeneralGroupStr), "General" },
                { m_Setting.GetOptionGroupLocaleID(RT_Settings.DebugGroupStr), "Debug" },
                { m_Setting.GetOptionGroupLocaleID(RT_Settings.AboutGroupStr), "About" },

                // Debug
                { m_Setting.GetOptionLabelLocaleID(nameof(RT_Settings.DebugMode)), "Debug Mode" },
                { m_Setting.GetOptionDescLocaleID(nameof(RT_Settings.DebugMode)), "Enables verbose debug behavior across the mod's systems." },

                // About
                { m_Setting.GetOptionLabelLocaleID(nameof(RT_Settings.Version)), "Version" },
                { m_Setting.GetOptionLabelLocaleID(nameof(RT_Settings.InformationalVersion)), "Informational Version" },
                { m_Setting.GetOptionLabelLocaleID(nameof(RT_Settings.Credits)), string.Empty },
                { m_Setting.GetOptionLabelLocaleID(nameof(RT_Settings.Github)), "GitHub" },
                { m_Setting.GetOptionDescLocaleID(nameof(RT_Settings.Github)), "Opens a browser window to https://github.com/lucarager/CS2-RealismTweaks" },
                { m_Setting.GetOptionLabelLocaleID(nameof(RT_Settings.Discord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(RT_Settings.Discord)), "Opens link to join the CS:2 Modding Discord" },
            };
        }

        /// <inheritdoc/>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts) {
            return m_Localization;
        }

        /// <inheritdoc/>
        public void Unload() { }
    }
}
