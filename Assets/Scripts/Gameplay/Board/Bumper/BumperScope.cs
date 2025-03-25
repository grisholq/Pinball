using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;
using VContainer.Unity;

public class BumperScope : LifetimeScope
{
    [SerializeField] private Bumper _bumper;
    [SerializeField] private Transform _view;
    [SerializeField] private BumperAnimations.Config _animationsConfig;

    protected override void Configure(IContainerBuilder builder)
    {
         builder.RegisterComponent(_bumper);
         builder.RegisterComponent(_view);
        
         builder.Register<BumperAnimations>(Lifetime.Scoped).AsSelf().AsImplementedInterfaces();
         builder.RegisterInstance(_animationsConfig);
    }
}