using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraConstantWidth : MonoBehaviour
{
    public Vector2 DefaultResolution = new Vector2(720, 1280);
    [Range(0f, 1f)] public float WidthOrHeight = 0;

    private Cinemachine.CinemachineVirtualCamera componentCamera;
    
    private float initialSize;
    private float targetAspect;

    private float initialFov;
    //private float horizontalFov = 120f;

    private void Start()
    {
        componentCamera = GetComponent<CinemachineVirtualCamera>();
        initialSize = componentCamera.m_Lens.OrthographicSize;

        targetAspect = DefaultResolution.x / DefaultResolution.y;

        //initialFov = componentCamera.fieldOfView;
        //horizontalFov = CalcVerticalFov(initialFov, 1 / targetAspect);
    }

    private void Update()
    {
        
            float constantWidthSize = initialSize * (targetAspect / componentCamera.m_Lens.Aspect);
            componentCamera.m_Lens.OrthographicSize = Mathf.Lerp(constantWidthSize, initialSize, WidthOrHeight);
        
        //else
        //{
            //float constantWidthFov = CalcVerticalFov(horizontalFov, componentCamera.aspect);
            //componentCamera.fieldOfView = Mathf.Lerp(constantWidthFov, initialFov, WidthOrHeight);
        //}
    }

    private float CalcVerticalFov(float hFovInDeg, float aspectRatio)
    {
        float hFovInRads = hFovInDeg * Mathf.Deg2Rad;

        float vFovInRads = 2 * Mathf.Atan(Mathf.Tan(hFovInRads / 2) / aspectRatio);

        return vFovInRads * Mathf.Rad2Deg;
    }
}