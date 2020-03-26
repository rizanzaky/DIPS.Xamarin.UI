﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DIPS.Xamarin.UI
{
    /// <summary>
    /// A static class to initialize DIPS.Xamarin.UI Library
    /// </summary>
    public static class Library
    {
        /// <summary>
        /// Initializes the DIPS.Xamarin.UI Library, enables custom namespace http://dips.xamarin.ui.com to be used in XAML.
        /// <remarks>This should be called once per application, typically in the `App.xaml.cs` constructor. </remarks>
        /// </summary>
        [ExcludeFromCodeCoverage]
        public static void Initialize(){}

        /// <summary>
        ///     A static class used to enable features that are in preview.
        /// </summary>
        public static class PreviewFeatures
        {

            /// <summary>
            ///     Enable a feature that's in preview.
            /// </summary>
            /// <param name="previewFeature">A string specifying which preview feature you want to enable.</param>
            public static void EnableFeature(string previewFeature)
            {
                if (previewFeature == MenuButtonBadgeAnimationString) MenuButtonBadgeAnimation = true;
            }

            /// <summary>
            ///     Toggles animations for the badge on the <code>MenuButton</code>.
            /// </summary>
            public static bool MenuButtonBadgeAnimation { get; set; }
            
            
            internal static readonly string MenuButtonBadgeAnimationString = "MenuButtonBadgeAnimation";
        }

    }
}
