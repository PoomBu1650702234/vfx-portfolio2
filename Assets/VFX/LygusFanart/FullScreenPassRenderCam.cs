using UnityEngine;

public class FullScreenPassRenderCam : MonoBehaviour
{
    [SerializeField] Camera parentCam;
    
    private Camera thisCamera;
    private void Start()
    {
        thisCamera = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        if (parentCam != null) 
        {
            thisCamera.fieldOfView = parentCam.fieldOfView;
            this.transform.position = parentCam.transform.position;
            this.transform.rotation = parentCam.transform.rotation;
        }
    }
}
