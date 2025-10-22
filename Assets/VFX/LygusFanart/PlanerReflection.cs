using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanarReflection : MonoBehaviour
{
    private Vector2 Resolution;

    [SerializeField] private Camera MainCam;
    [SerializeField] private Camera ReflectionCamera;
    [SerializeField] private RenderTexture ReflectionRenderTexture;
    [SerializeField] private int ReflectionResloutionScale;


    // Unity Message: 0 references
    private void LateUpdate()
    {
        ReflectionCamera.fieldOfView = MainCam.fieldOfView;
        ReflectionCamera.transform.position = new Vector3(MainCam.transform.position.x, -MainCam.transform.position.y, MainCam.transform.position.z);
        ReflectionCamera.transform.rotation = Quaternion.Euler(-MainCam.transform.eulerAngles.x, MainCam.transform.eulerAngles.y, MainCam.transform.eulerAngles.z);

        Resolution = new Vector2(MainCam.pixelWidth, MainCam.pixelHeight);

        ReflectionRenderTexture.Release();

        ReflectionRenderTexture.width = Mathf.RoundToInt(Resolution.x) / ReflectionResloutionScale;
        ReflectionRenderTexture.height = Mathf.RoundToInt(Resolution.y) / ReflectionResloutionScale;
    }
}
