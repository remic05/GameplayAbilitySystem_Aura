// Copyright Remi Cyr

using UnrealBuildTool;
using System.Collections.Generic;

public class Aura_1EditorTarget : TargetRules
{
	public Aura_1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Aura_1" } );
	}
}
