//  Copyright (c) 2019 Agora.io. All rights reserved.

using UnrealBuildTool;
using System.IO;

public class AgoraVideoCall : ModuleRules
{
    public AgoraVideoCall(ReadOnlyTargetRules Target) : base(Target)
    {
        bEnableExceptions = true;

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

        PrivateDependencyModuleNames.AddRange(new string[] { "AgoraPlugin" });

        // Uncomment if you are using Slate UI
        PrivateDependencyModuleNames.AddRange(new string[] { "UMG", "Slate", "SlateCore" });

        PublicIncludePaths.Add(ModuleDirectory);
        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
        
    }
}
