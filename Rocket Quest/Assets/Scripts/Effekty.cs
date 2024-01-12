using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Effekty : MonoBehaviour
{
    public Transform cameraTransform;
    public float shakeDuration = 0.1f;
    public float shakeStrength = 0.1f;

    public void ShakeCamera()
    {
        cameraTransform.DOShakePosition(shakeDuration, shakeStrength);
    }
}
