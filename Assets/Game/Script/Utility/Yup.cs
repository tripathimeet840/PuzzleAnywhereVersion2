using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Yup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            Application.RequestUserAuthorization(UserAuthorization.WebCam);
        }

        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            // If not, request the permission
            Permission.RequestUserPermission(Permission.Camera);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
