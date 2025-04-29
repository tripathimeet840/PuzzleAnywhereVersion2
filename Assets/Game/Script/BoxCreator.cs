using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class BoxCreator : MonoBehaviour
{
  //  [SerializeField]
   // ARPlaneManager planeManager;
    [SerializeField]
    GameObject box;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("ON mOuse Down ");
        if (ApplicationManager.Instance == null)
        {
            Debug.Log("nullll >>>>>>>>>>>>>>>>>>>>>> Application Manager");
        }
        else
        {

            Debug.Log("<color=green>NOT NULLLLL >>>>>>>>>>>>>>>>>>>>>> Application Manager</color>");
        }

        ApplicationManager.Instance.ExecuteSpawn(this.gameObject.transform);
        //Instantiate(box, this.gameObject.transform.position, Quaternion.identity);
    }


}
