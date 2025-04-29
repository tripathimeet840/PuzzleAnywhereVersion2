using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingModelsCaptain : MonoBehaviour
{

    [SerializeField]
    Transform[] PlayinModels;

    GameManager gameManager;


    [SerializeField]
    List<PlayinModels> selectedPrefabs = new List<PlayinModels>();

    [SerializeField]
    List<string> selectedPrefabsName = new List<string>();

    //Start is called before the first frame update
    void Start()
    {

        gameManager = ApplicationManager.Instance.GameManager;


        //??>>>>>> Demo of prefab loading models from the resources folder or directory
        //Debug.Log(" Playing Models Start >>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+gameManager);
        //GameObject myPrefab = Resources.Load<GameObject>("Apple");
        //GameObject instance = Instantiate(myPrefab,this.transform.position,Quaternion.identity);
        ObjectSelection();


        //Debug.Log(" starty model captain " + this.gameObject.name);
        ////Debug.Log(" starty model captain parentName "+this.gameObject.transform.parent.name);   
        //Debug.Log(" starty model captain local pos" + this.gameObject.transform.localPosition);
        //Debug.Log(" starty model captain POS " + this.gameObject.transform.position);
    }




    #region Prefabs Set Up

    /// <summary>
    /// This methosd is used to select the models to place in AR section
    /// </summary>
    /// 
    char rc;
    string stringDict;
    void ObjectSelection()
    {

        Debug.Log("  current aplhabet >>>>>>"+ApplicationManager.Instance.currentAplhabet);
        //selectedPrefabsName[0] = "Red";
        //Debug.Log("  current aplhabet >>>>>>" + ApplicationManager.Instance.currentAplhabet);

        selectedPrefabsName.Add(ApplicationManager.Instance.currentAplhabet);


        for (int i = 1; i < 4; i++)
        {

            rc = ((char)('A' + Random.Range(0, 26)));

            //selectedPrefabsName[i] =  ((char)('A' + Random.Range(0, 26))).ToString();

            if (rc.ToString() != ApplicationManager.Instance.currentAplhabet)
            {
                //selectedPrefabsName[i] = rc.ToString();
                stringDict = StringDictionary.charValues[rc];

                selectedPrefabsName.Add(stringDict);

            }

            if (i == 3)
            {
                ObjectSpawn();
            }

        }


    }

    /// <summary>
    /// Used to spawn objects and place it 
    /// </summary>
    /// 
    GameObject temp;
    GameObject preFab;
    void ObjectSpawn()
    {

        Debug.Log(" ObjectSpawn Start >>>>>>>>>>>>>>>>>>>>>>>>>>>>>" );
        for (int i = 0; i < selectedPrefabsName.Count; i++)
        {
            preFab = Resources.Load<GameObject>(selectedPrefabsName[i]);
            //Debug.LogWarning("paying models pos " + PlayinModels[i].position+ "paying models Localpos " + PlayinModels[i].localPosition);
            temp = Instantiate(preFab, PlayinModels[i].localPosition,Quaternion.identity,this.gameObject.transform);
          //  Debug.LogWarning("  temp POS >>"+temp.transform.position+"playuing Models local pos " + PlayinModels[i].localPosition); 
            temp.transform.position = PlayinModels[i].localPosition;
          //  Debug.LogWarning("  temp POS 2>>"+temp.transform.position);  
            selectedPrefabs.Add(temp.GetComponent<PlayinModels>());
            selectedPrefabs[i].transform.localPosition = PlayinModels[i].localPosition;
        }

        Debug.LogWarning(" selected prefab 1 pos" + selectedPrefabs[0].transform.position+ " selected prefab 1 LOcalpos" + selectedPrefabs[0].transform.localPosition);
        //    Debug.Log(" Playing Models Start >>>>>>>>>>>>>>>>>>>>>>>>>>>>>" + gameManager);
        //    GameObject myPrefab = Resources.Load<GameObject>("Apple");
        //    GameObject instance = Instantiate(myPrefab, this.transform.position, Quaternion.identity);
    }



    #endregion



}
