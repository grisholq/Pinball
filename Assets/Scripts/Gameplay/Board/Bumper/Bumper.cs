using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;

public class Bumper : MonoBehaviour
{
    [SerializeField] private float _pushForce;
    [SerializeField] private Transform _centre;

    [Inject] private BumperAnimations _bumperAnimations;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out Ball ball))
        {
            HandleBallHit(ball);
        }
    }

    private void HandleBallHit(Ball ball)
    {
        PushBall(ball);
        _bumperAnimations.PlayHitAnimation();
    }

    private void PushBall(Ball ball)
    {
        var pushForce = CalculatePushForce(ball);
        ball.Force(pushForce);
    }

    private Vector3 CalculatePushForce(Ball ball)
    {
        var direction = (_centre.position - ball.transform.position).normalized;
        direction.y = 0;
        return direction * _pushForce;
    }
}