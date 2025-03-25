using UnityEngine;

public class PCFlippersInput : IFlippersInput
{
    public bool LeftFlipperPressed => Input.GetKey(KeyCode.A);
    public bool RightFlipperPressed => Input.GetKey(KeyCode.D);
}
