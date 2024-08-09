

using UnrealBuildTool;
using System.Collections.Generic;

public class HorrorEngineTarget : TargetRules
{
	public HorrorEngineTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "HorrorEngine" } );
	}
}
