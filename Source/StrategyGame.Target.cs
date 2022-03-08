// Copyright 2020 Devon Krisch. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class StrategyGameTarget : TargetRules
{
	public StrategyGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "StrategyGame" } );
	}
}
