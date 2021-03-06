﻿using Nitrogen.Enums;
using Nitrogen.GameVariants;
using Nitrogen.GameVariants.Base;
using Nitrogen.GameVariants.Megalo;
using Nitrogen.Metadata;
using Nitrogen.Shared;
using System;

namespace Nitrogen.VariantBuilder
{
	[OutputPath("C:/Users/Matt/Desktop/race.game")]
	public sealed class Race : IMegaloVariant
	{
		void IMegaloVariant.Create (GameVariant gt, MegaloData megalo)
		{
			gt.HasWeaponTuning = false;
			
			#region Base Variant

			// Metadata
			var metadata = new ContentMetadata
			{
				Name = "Race v2.0",
				Description = "Gentlemen, start your engines.",
				CreatedBy = new ContentAuthor("synth92"),
				ModifiedBy = new ContentAuthor("synth92"),
				VariantIcon = VariantIcon.Race,
			};
			gt.Metadata = metadata;


			// General Settings
			var generalSettings = new GeneralSettings
			{
				PointsSystemEnabled = false,
				NumberOfRounds = 1,
				TeamsEnabled = false,
			};
			gt.GeneralSettings = generalSettings;


			// Respawn Settings
			var respawnSettings = new RespawnSettings
			{
				BetrayalPenalty = 0,
				SuicidePenalty = 0,
				InitialRespawnDuration = 3,
				MinimumRespawnDuration = 3,
			};
			gt.RespawnSettings = respawnSettings;


			// Social Settings
			var socialSettings = new SocialSettings
			{
				BetrayalBooting = false,
				FriendlyFireEnabled = false,
				OpenChannelVoice = true,
				DeadPlayerVoice = true,
				EnemyVoice = true,
			};
			gt.SocialSettings = socialSettings;


			// Map Overrides
			var mapOverrides = new MapOverrides
			{
				ArmorAbilitiesOnMap = false,
				GrenadesOnMap = false,
				IndestructibleVehicles = true,
				VehicleSet = VehicleSet.DeleteAllExceptMongoose,
				WeaponSet = WeaponSet.NoWeapons,
			};
			gt.MapOverrides = mapOverrides;


			#region Base Player Traits

			var baseTraits = new PlayerTraits();
			gt.MapOverrides.BasePlayerTraits = baseTraits;

			// Base Player Traits -> Appearance
			baseTraits.Appearance.DeathEffect = ArmorEffect.GruntBirthdayParty;
			baseTraits.Appearance.GamertagVisibility = HudVisibility.VisibleToEveryone;
			baseTraits.Appearance.WaypointVisibility = HudVisibility.VisibleToEveryone;

			// Base Player Traits -> Armor
			baseTraits.Armor.AssassinationImmunity = TraitFlag.Enabled;
			baseTraits.Armor.Invincibility = TraitFlag.Enabled;

			// Base Player Traits -> Appearance
			baseTraits.Equipment.InitialPrimaryWeapon = Weapon.SpartanLaser;
			baseTraits.Equipment.InitialSecondaryWeapon = Weapon.NoWeapon;
			baseTraits.Equipment.TacticalPackage = ArmorMod.NoTacticalPackage;
			baseTraits.Equipment.SupportUpgrade = ArmorMod.NoSupportUpgrade;

			// Base Player Traits -> Movement
			baseTraits.Movement.Sprint = TraitFlag.Disabled;
			baseTraits.Movement.VehicleUsage = VehicleUsageMode.DriverOnly;

			// Base Player Traits -> Screen & Audio
			baseTraits.ScreenAndAudio.MotionSensor = MotionSensorMode.Enhanced;
			baseTraits.ScreenAndAudio.ShieldHud = TraitFlag.Disabled;

			#endregion


			// Loadouts
			var loadouts = new LoadoutSettings
			{
				PersonalLoadoutsEnabled = false,
				MapLoadoutsEnabled = false,
			};
			gt.LoadoutSettings = loadouts;


			// Teams
			var teams = new TeamSettings();
			gt.TeamSettings = teams;
			teams[0].Name.Set("Racers");
			teams[1].Name.Set("Observers");


			// Ordnance
			var ordnanceSettings = new OrdnanceSettings
			{
				InitialOrdnanceEnabled = false,
				RandomOrdnanceEnabled = false,
				PersonalOrdnanceEnabled = false,
			};
			gt.OrdnanceSettings = ordnanceSettings;


			#endregion

		}
	}
}
