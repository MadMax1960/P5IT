using Persona_5_Investigation_Team.Configuration;
using Persona_5_Investigation_Team.Template;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using CriFs.V2.Hook;
using CriFs.V2.Hook.Interfaces;

namespace Persona_5_Investigation_Team
{
	/// <summary>
	/// Your mod logic goes here.
	/// </summary>
	public class Mod : ModBase // <= Do not Remove.
	{
		/// <summary>
		/// Provides access to the mod loader API.
		/// </summary>
		private readonly IModLoader _modLoader;

		/// <summary>
		/// Provides access to the Reloaded.Hooks API.
		/// </summary>
		/// <remarks>This is null if you remove dependency on Reloaded.SharedLib.Hooks in your mod.</remarks>
		private readonly IReloadedHooks? _hooks;

		/// <summary>
		/// Provides access to the Reloaded logger.
		/// </summary>
		private readonly ILogger _logger;

		/// <summary>
		/// Entry point into the mod, instance that created this class.
		/// </summary>
		private readonly IMod _owner;

		/// <summary>
		/// Provides access to this mod's configuration.
		/// </summary>
		private Config _configuration;

		/// <summary>
		/// The configuration of the currently executing mod.
		/// </summary>
		private readonly IModConfig _modConfig;

		public Mod(ModContext context)
		{
			_modLoader = context.ModLoader;
			_hooks = context.Hooks;
			_logger = context.Logger;
			_owner = context.Owner;
			_configuration = context.Configuration;
			_modConfig = context.ModConfig;


			// For more information about this template, please see
			// https://reloaded-project.github.io/Reloaded-II/ModTemplate/

			// If you want to implement e.g. unload support in your mod,
			// and some other neat features, override the methods in ModBase.

			// TODO: Implement some mod logic

			var criFsController = _modLoader.GetController<ICriFsRedirectorApi>();
			if (criFsController == null || !criFsController.TryGetTarget(out var criFsApi))
			{
				_logger.WriteLine($"Something shit it's pants", System.Drawing.Color.Red);
				return;
			}

			if (_configuration.MainIT)
			{
				criFsApi.AddProbingPath("MainIT");
			}

			if (_configuration.Yu)
			{
				criFsApi.AddProbingPath("Yu");
			}

			if (_configuration.Yosuke)
			{
				criFsApi.AddProbingPath("Yosuke");
			}

			if (_configuration.NeverDisable)
			{
				criFsApi.AddProbingPath("Vibin Naoto");
			}

			if (_configuration.Mid)
			{
				criFsApi.AddProbingPath("Rise");
			}

			if (_configuration.Kanji)
			{
				criFsApi.AddProbingPath("Kanji");
			}

			if (_configuration.Noot)
			{
				criFsApi.AddProbingPath("Naoto");
			}

			if (_configuration.Trashit)
			{
				criFsApi.AddProbingPath("Marie"); //Change this later? Watched P4GA and she wasn't so bad
			}

			if (_configuration.Yuk)
			{
				criFsApi.AddProbingPath("Yukiko");
			}

			if (_configuration.ADACHI)
			{
				criFsApi.AddProbingPath("Adachi");
			}

			if (_configuration.Chie)
			{
				criFsApi.AddProbingPath("Chie");
			}

			if (_configuration.Dojima)
			{
				criFsApi.AddProbingPath("Dojima");
			}

			if (_configuration.Marg)
			{
				criFsApi.AddProbingPath("Marg");
			}

			if (_configuration.Nanako)
			{
				criFsApi.AddProbingPath("Nanako");
			}

			if (_configuration.English)
			{
				criFsApi.AddProbingPath("Text");
			}

			if (_configuration.Test)
			{
				criFsApi.AddProbingPath("Test");
			}
		}

		#region Standard Overrides
		public override void ConfigurationUpdated(Config configuration)
		{
			// Apply settings from configuration.
			// ... your code here.
			_configuration = configuration;
			_logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
		}
		#endregion

		#region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public Mod() { }
#pragma warning restore CS8618
		#endregion
	}
}