// Copyright 2020 Devon Krisch. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class StrategyGameEditorTarget : TargetRules
{
	public StrategyGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "StrategyGame" } );
	}
}
