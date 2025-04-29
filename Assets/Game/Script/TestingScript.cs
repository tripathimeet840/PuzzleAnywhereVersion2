using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestingScript : MonoBehaviour
{

    int i;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(" name   >>>>" + this.gameObject.name);

        //for(i = 'A';i<= 'Z';i++)
        //{

        //    Debug.Log(((char)i));
        //}


        //??>>>>>> Demo of prefab loading models from the resources folder or directory
        //Debug.Log(" Playing Models Start >>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+gameManager);
        //GameObject myPrefab = Resources.Load<GameObject>("Apple");
        //GameObject instance = Instantiate(myPrefab,this.transform.position,Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(" collision name >>>>"+this.gameObject.name);
    //}

    private void OnMouseDown()
    {
        Debug.Log(" collision name >>>>" + this.gameObject.name);

    }


    //public void ReplayBTN()
    //{

    //    SceneManager.LoadScene(StringDictionary.Gamescene);

    //}

    //public void NextBtn()
    //{
    //    ApplicationManager.Instance.IncreaseLevel();
    //    SceneManager.LoadScene(StringDictionary.Gamescene);
    //}

    //public void HomeBtn()
    //{
    //    ApplicationManager.Instance.IncreaseLevel();
    //    SceneManager.LoadScene(StringDictionary.Homescene);
    //}
}
