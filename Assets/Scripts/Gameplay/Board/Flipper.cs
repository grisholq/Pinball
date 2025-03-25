using UnityEngine;
using UnityEngine.Serialization;

public class Flipper : MonoBehaviour
{
    [SerializeField] private HingeJoint _hingeJoint;
    [SerializeField] private float _releaseTargetPosition;
    [SerializeField] private float _pressTargetPosition;

    public bool Pressed
    {
        get => _pressed; 
        set
        {
            if (_pressed != value)
            {
                if (value) Press();
                else Release();
            }
            
            _pressed = value;
        }
    }
    
    private bool _pressed;
    
    public void Press()
    {
        SetTargetSpringAngle(_pressTargetPosition);
    }

    public void Release()
    {
        SetTargetSpringAngle(_releaseTargetPosition);
    }

    private void SetTargetSpringAngle(float targetPosition)
    {
        var spring = _hingeJoint.spring;
        spring.targetPosition = targetPosition;
        _hingeJoint.spring = spring;
    }
}