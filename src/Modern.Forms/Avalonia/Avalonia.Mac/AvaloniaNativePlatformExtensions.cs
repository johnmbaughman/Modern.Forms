﻿#nullable disable

// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Avalonia.Controls;
using Avalonia.Native;

namespace Avalonia
{
    internal static class AvaloniaNativePlatformExtensions
    {
        //public static T UseAvaloniaNative<T>(this T builder)
        //    where T : AppBuilderBase<T>, new()
        //{
        //    builder.UseWindowingSubsystem(() =>
        //    {
        //        var platform = AvaloniaNativePlatform.Initialize(
        //            AvaloniaLocator.Current.GetService<AvaloniaNativePlatformOptions>() ??
        //            new AvaloniaNativePlatformOptions());

        //            builder.AfterSetup (x=>
        //            {
        //                platform.SetupApplicationName();
        //                platform.SetupApplicationMenuExporter();
        //            });
        //    });

        //    return builder;
        //}
    }

    internal class AvaloniaNativePlatformOptions
    {
        public bool UseDeferredRendering { get; set; } = false;
        public bool UseGpu { get; set; } = true;
        public bool OverlayPopups { get; set; }
        public string AvaloniaNativeLibraryPath { get; set; }
    }

    // ReSharper disable once InconsistentNaming
    internal class MacOSPlatformOptions
    {
        public bool ShowInDock { get; set; } = true;
    }
}
