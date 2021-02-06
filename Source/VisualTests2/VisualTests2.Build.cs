// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class VisualTests2 : ModuleRules
{
	public VisualTests2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject","RenderCore", "RHI", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {"Projects",  });

        PublicIncludePaths.AddRange(new string[] { "Shaders/Public" });

        PrivateIncludePaths.AddRange(new string[] { "Shaders/Private" });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
