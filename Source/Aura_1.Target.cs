// Copyright Remi Cyr

using UnrealBuildTool;
using System.Collections.Generic;

public class Aura_1Target : TargetRules
{
	public Aura_1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Aura_1" } );
	}
}
