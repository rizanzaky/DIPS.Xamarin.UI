﻿using DIPS.Xamarin.UI.Internal.Utilities;

namespace DIPS.Xamarin.UI.Android
{
    /// <summary>
    /// A static class to use when having to interact with the library on Android platform
    /// </summary>
    public static class Library
    {
        private static bool s_isInitialized;

        /// <summary>
        /// Method to call at startup of the app in order to keep assemblies and to run other initializing methods in the library
        /// </summary>
        public static void Initialize()
        {
            if (s_isInitialized) return;
            Inspector.Instance = new Util.Inspector();
            InternalDatePickerRenderer.Initialize();
            InternalButtonRenderer.Initialize();

            var vibrationService = new VibrationService();
            Vibration.Vibration.Initialize(vibrationService);
            VibrationService.Initialize();
            s_isInitialized = true;
        }
    }
}