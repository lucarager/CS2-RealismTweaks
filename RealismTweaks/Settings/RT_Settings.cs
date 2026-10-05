// <copyright file="RT_Settings.cs" company="Luca Rager">
// Copyright (c) Luca Rager. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace RealismTweaks.Settings {
    using System;

    using Colossal.IO.AssetDatabase;

    using Game.Modding;
    using Game.Settings;

    using UnityEngine;

    /// <summary>
    ///     The mod's settings.
    /// </summary>
    [FileLocation("RealismTweaks")]
    [SettingsUIGroupOrder(GeneralGroupStr, DebugGroupStr, AboutGroupStr)]
    [SettingsUIShowGroupName(GeneralGroupStr, DebugGroupStr, AboutGroupStr)]
    public class RT_Settings : ModSetting {
        private const string CreditStr = "Made with <3 by Luca.";
        public const string GeneralGroupStr = "GeneralGroupStr";
        public const string DebugGroupStr = "DebugGroupStr";
        public const string AboutGroupStr = "AboutGroupStr";

        /// <summary>
        ///     Initializes a new instance of the <see cref="RT_Settings" /> class.
        /// </summary>
        /// <param name="mod"><see cref="IMod" /> instance.</param>
        public RT_Settings(IMod mod)
            : base(mod) {
        }

        /// <summary>
        ///     Enables verbose debug behavior across the mod's systems.
        /// </summary>
        [SettingsUISection(DebugGroupStr)]
#if !IS_DEBUG
        [SettingsUIHidden]
#endif
        public bool DebugMode { get; set; }

        [SettingsUISection(AboutGroupStr)]
        public bool Discord {
            set {
                try {
                    Application.OpenURL("https://discord.gg/QFxmPa2wCa");
                } catch (Exception e) {
                    Debug.LogException(e);
                }
            }
        }

        [SettingsUISection(AboutGroupStr)]
        public bool Github {
            set {
                try {
                    Application.OpenURL("https://github.com/lucarager/CS2-RealismTweaks");
                } catch (Exception e) {
                    Debug.LogException(e);
                }
            }
        }

        [SettingsUISection(AboutGroupStr)] public string Credits => CreditStr;

        [SettingsUISection(AboutGroupStr)] public string InformationalVersion => RealismTweaksMod.Instance.InformationalVersion;

        [SettingsUISection(AboutGroupStr)] public string Version => RealismTweaksMod.Instance.Version;

        /// <summary>
        ///     Restores mod settings to default.
        /// </summary>
        public override void SetDefaults() {
            DebugMode = false;
        }
    }
}
