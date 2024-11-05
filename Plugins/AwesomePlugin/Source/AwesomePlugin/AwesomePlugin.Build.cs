// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AwesomePlugin : ModuleRules
{
	public AwesomePlugin(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "CoreUObject", //added this from PrivateDependencyModuleNames below 
                "Engine", //added this from PrivateDependencyModuleNames below
                "AwesomePluginLibrary",
				"Projects"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				// ... add private dependencies that you statically link with here ...	
				// THIS MAKES THE PROJECT WORK I.E DOSENT COMPLAIN ABOUT cant find GameFramework
				
				/*
				 "CoreUObject",
                "Engine"
				"Slate",
                "SlateCore", 
				 */
                
            }
            );
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
