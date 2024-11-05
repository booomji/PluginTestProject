// Fill out your copyright notice in the Description page of Project Settings.


#include "TestActor.h"
#include "../../ThirdParty/AwesomePluginLibrary/Public/AwesomePluginLibrary/ExampleLibrary.h"

// Sets default values
ATestActor::ATestActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ATestActor::BeginPlay()
{
	Super::BeginPlay();
	float test_num = ExampleLibraryFunctionAdd(50.0, 50.0 );
	GEngine->AddOnScreenDebugMessage(-1, 10.0, FColor::White, FString::Printf(TEXT("adding numbers %f"), test_num));
	
}

// Called every frame
void ATestActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

