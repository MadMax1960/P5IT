using Persona_5_Investigation_Team.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;
using System.ComponentModel;

namespace Persona_5_Investigation_Team.Configuration
{
	public class Config : Configurable<Config>
	{
		/*
            User Properties:
                - Please put all of your configurable properties here.

            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs

            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

		[DisplayName("Main P5IT")]
		[Description("Disable if you like breaking things!")]
		[DefaultValue(true)]
		public bool MainIT { get; set; } = true;

		[DisplayName("Yu")]
		[Description("Yu Narukami on the Nintendo DS")]
		[DefaultValue(true)]
		public bool Yu { get; set; } = true;

		[DisplayName("Yosuke")]
		[Description("Enable to Enable... Yosuke")]
		[DefaultValue(true)]
		public bool Yosuke { get; set; } = true;

		[DisplayName("Vibin Naoto")]
		[Description("Don't disable :(")]
		[DefaultValue(true)]
		public bool NeverDisable { get; set; } = true;

		[DisplayName("Rise")]
		[Description("Mid.")]
		[DefaultValue(true)]
		public bool Mid { get; set; } = true;

		[DisplayName("Kanji")]
		[Description("Kanji Tatsumi")]
		[DefaultValue(true)]
		public bool Kanji { get; set; } = true;

		[DisplayName("Naoto")]
		[Description("Peak. Don't Disable This or I will find you, there will be no running, there will be no place you are safe from me. Mark my words the wrath of god will smite you.")]
		[DefaultValue(true)]
		public bool Noot { get; set; } = true;

		[DisplayName("Marie")]
		[Description("Kinda garbo")]
		[DefaultValue(true)]
		public bool Trashit { get; set; } = true;

		[DisplayName("Yukiko")]
		[Description("Midiko.")]
		[DefaultValue(true)]
		public bool Yuk { get; set; } = true;

		[DisplayName("ADACHI")]
		[Description("ADACHI TRUE.")]
		[DefaultValue(true)]
		public bool ADACHI { get; set; } = true;

		[DisplayName("Chie")]
		[Description("Aiya's beef bowl does look pretty good tbh.")]
		[DefaultValue(true)]
		public bool Chie { get; set; } = true;

		[DisplayName("Dojima")]
		[Description("Dojima.")]
		[DefaultValue(true)]
		public bool Dojima { get; set; } = true;

		[DisplayName("Margaret or however you spell it")]
		[Description("Grammar.")]
		[DefaultValue(true)]
		public bool Marg { get; set; } = true;

		[DisplayName("Nanako Attendents")]
		[Description("I'm not seperating each attendent bro")]
		[DefaultValue(true)]
		public bool Nanako { get; set; } = true;

		[DisplayName("Message")]
		[Description("All the Text edits.")]
		[DefaultValue(true)]
		public bool English { get; set; } = true;

		[DisplayName("Testing Stuff!")]
		[Description("Stuff for letting public (or me) test with easy disabling/enabling!")]
		[DefaultValue(true)]
		public bool Test { get; set; } = true;

		//Add folder is added to pakemu now, so can adjust these for whenever spr is merged? 
		//GRAHHHHHH

	}

	/// <summary>
	/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
	/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
	/// </summary>
	public class ConfiguratorMixin : ConfiguratorMixinBase
	{
		// 
	}
}