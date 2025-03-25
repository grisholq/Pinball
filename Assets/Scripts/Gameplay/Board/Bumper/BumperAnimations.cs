using UnityEngine;
using VContainer.Unity;
using DG.Tweening;
using System;

public class BumperAnimations : IInitializable
{
    [Serializable]
    public class Config
    {
        public Vector3 SmallScale;
        public Vector3 NormalScale;
        public float DecreaseDuration;
        public float IncreaseDuration;
    }
    
    private Sequence _hitAnimation;
    private Transform _view;
    private Config _config;

    public BumperAnimations(Transform view, Config config)
    {
        _view = view;
        _config = config;
    }
    
    public void Initialize()
    {
        CreateHitAnimation();
    }
    
    private void CreateHitAnimation()
    {
        _hitAnimation = DOTween.Sequence();
        _hitAnimation.Append(_view.DOScale(_config.SmallScale, _config.DecreaseDuration));
        _hitAnimation.Append(_view.DOScale(_config.NormalScale, _config.IncreaseDuration));
        _hitAnimation.SetAutoKill(false);
        _hitAnimation.Complete();
    }
    
    public void PlayHitAnimation()
    {
        _hitAnimation.Restart();
    }
}