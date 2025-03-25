using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameScope : LifetimeScope
{
    [SerializeField] private Flippers _flippers;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponent(_flippers);
        
        builder.Register<PCFlippersInput>(Lifetime.Scoped).AsImplementedInterfaces();
        
        builder.Register<GameStateMachine>(Lifetime.Scoped).AsSelf().AsImplementedInterfaces();
        builder.Register<PlayState>(Lifetime.Scoped).AsSelf().AsImplementedInterfaces();
    }
}