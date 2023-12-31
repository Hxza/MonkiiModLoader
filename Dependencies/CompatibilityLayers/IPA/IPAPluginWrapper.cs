﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using IllusionPlugin;
using IllusionInjector;

namespace MonkiiLoader.CompatibilityLayers
{
	internal class IPAPluginWrapper : MonkiiMod
	{
		internal IPlugin pluginInstance;
		public override void OnInitializeMonkii() => pluginInstance.OnApplicationStart();
		public override void OnDeinitializeMonkii() => pluginInstance.OnApplicationQuit();
		public override void OnSceneWasLoaded(int buildIndex, string sceneName) => pluginInstance.OnLevelWasLoaded(buildIndex);
		public override void OnSceneWasInitialized(int buildIndex, string sceneName) => pluginInstance.OnLevelWasInitialized(buildIndex);
		public override void OnUpdate() => pluginInstance.OnUpdate();
		public override void OnFixedUpdate() => pluginInstance.OnFixedUpdate();
		public override void OnLateUpdate() { if (pluginInstance is IEnhancedPlugin plugin) plugin.OnLateUpdate(); }
	}
}