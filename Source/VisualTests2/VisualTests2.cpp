// Fill out your copyright notice in the Description page of Project Settings.

#include "VisualTests2.h"

DEFINE_LOG_CATEGORY(MyShaders);


void FVisualTestsModule::StartupModule()
{
	UE_LOG(MyShaders, Log, TEXT("Shaders module has started!"));
	// Find the static location of the shader folder on your computer
	FString ShaderDirectory = FPaths::Combine(FPaths::ProjectDir(), TEXT("Shaders"));


	////////////////////////
	// Define the name you will use in the engine to access this folder
	//
	// FORMALISM SUGGESTION: 
	// 
	// linking from a project: TEXT("/Project/YourProjectName")
	// linking from a plugin: TEXT("/Plugin/YourPluginName")

	AddShaderSourceDirectoryMapping(TEXT("/Project/ShaderProject"), ShaderDirectory);

	///////////////////////
}

void FVisualTestsModule::ShutdownModule()
{
	ResetAllShaderSourceDirectoryMappings();
}


IMPLEMENT_GAME_MODULE(FVisualTestsModule, VisualTests2)



