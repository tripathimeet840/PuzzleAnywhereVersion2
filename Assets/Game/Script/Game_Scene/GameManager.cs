using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{

    #region Public Var

    [SerializeField]
    public int array;
    public int startinglevel;

    #endregion

    //ApplicationManager applicationManager;

    #region Private Var

    int selectedType;
    List<ARRaycastHit> arHits = new List<ARRaycastHit>();

    [SerializeField]
    List<PlayingModelsCaptain> alphabets;

    [SerializeField]
    List<PlayingModelsCaptain> numericals;

    //List<Models> models;

    [SerializeField]
    ARRaycastManager raycastManager;

    [SerializeField]
    ARPlaneManager planeManager;

    [SerializeField]
    Camera arCamera;

    [SerializeField]
    List<GameObject> planList = new List<GameObject>();

    [SerializeField]
    PlayingModelsCaptain spawnedBattleField;

    [SerializeField]
    string currentAplhabet;

    bool spawned;
    private GameObject planeIndicatorInstance;
    private GameObject defaultPlaneIndicator;
    private float initialAngle;
    private Quaternion initialRotation;
    private float initialDistance;
    private Vector3 initialScale;
    public bool rotateOn;
    public GameObject targetObject;
    #endregion


    #region UI

    [Header("UI")]

    public GameObject pop_UpPanel;
    public GameObject wrongPanel;
    public TextMeshProUGUI AlphabetIcon;


    [SerializeField]
    Sprite rotateSpriteOn,rotateSpriteOff;

    [SerializeField]
    GameObject rotateImg;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        //applicationManager = FindAnyObjectByType<ApplicationManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

        ApplicationManager.Instance.GameManager = this;

        AlphabetIcon.text = ApplicationManager.Instance.currentAplhabet.Remove(1);

        //if (applicationManager != null)
        //{
        //    selectedType = applicationManager.selectedtype;
        //    if (selectedType == 0)
        //    {

        //        Debug.Log("  selected Type " + selectedType);
        //        startinglevel = PlayerPrefs.GetInt("ALPHABET");
        //    }
        //    else
        //    {
        //        startinglevel = PlayerPrefs.GetInt("NUMERICAL");
        //        Debug.Log("  selected Type " + selectedType);

        //    }

        //    GameDataExecution();
        //}

        //else
        //{
        //    Debug.LogWarning("<color=red>Application Manager is Null</color>");
        //    return;
        //}
        // GameDataExecution();

        ///sets the current string to use by playingCaptain to spawn Models
        
        //currentAplhabet = StringDictionary.A;
        //ApplicationManager.Instance.currentAplhabet = currentAplhabet;


    }
    //bool temp = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameDataExecution(this.gameObject.transform);

        }

        ///used to rotate the object
        if(spawned && rotateOn)
        {
            //// change the position gameobject
            //if (Input.touchCount == 1)
            //{
            //    Touch touch = Input.GetTouch(0);
            //    if (touch.phase == TouchPhase.Moved && spawnedBattleField != null)
            //    {
            //        List<ARRaycastHit> hits = new List<ARRaycastHit>();
            //        if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
            //        {
            //            Pose pose = hits[0].pose;
            //            spawnedBattleField.transform.position = pose.position;
            //        }
            //    }
            //}


            if (Input.touchCount == 2)
            {
                Touch touch0 = Input.GetTouch(0);
                Touch touch1 = Input.GetTouch(1);

                if (touch1.phase == TouchPhase.Began)
                {
                    initialAngle = AngleBetweenTouches(touch0, touch1);
                    initialRotation = spawnedBattleField.transform.rotation;
                }
                else if (touch0.phase == TouchPhase.Moved || touch1.phase == TouchPhase.Moved)
                {
                    float currentAngle = AngleBetweenTouches(touch0, touch1);
                    float angleDelta = currentAngle - initialAngle;

                    spawnedBattleField.transform.rotation = initialRotation * Quaternion.Euler(0, -angleDelta, 0);
                }
            }

            ///used to scale the object
            if (Input.touchCount == 2)
            {
                Touch touch0 = Input.GetTouch(0);
                Touch touch1 = Input.GetTouch(1);

                // Detect pinch start
                if (touch1.phase == TouchPhase.Began)
                {
                    initialDistance = Vector2.Distance(touch0.position, touch1.position);
                    initialScale = spawnedBattleField.transform.localScale;
                }
                // Pinch in progress
                else if (touch0.phase == TouchPhase.Moved || touch1.phase == TouchPhase.Moved)
                {
                    float currentDistance = Vector2.Distance(touch0.position, touch1.position);
                    if (Mathf.Approximately(initialDistance, 0)) return;

                    float scaleFactor = currentDistance / initialDistance;
                    spawnedBattleField.transform.localScale = initialScale * scaleFactor;
                }
            }



        }

       

        //Debug.Log(" arcamera " + arCamera.name);
        //Ray rayOrigin = arCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));

        //if (raycastManager == null)
        //{
        //    Debug.LogWarning(" Raycast  null >>>");
        //}

        //if (raycastManager.Raycast(rayOrigin, arHits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        //{

        //    if (spawned || temp)
        //    {
        //        return;
        //    }
        //    Debug.LogWarning("<color=blue> Raycast innnn >>> </color>");
        //    ShowPlaneIndicator(arHits[0].pose.position, arHits[0].pose.rotation);

        //    if (arHits != null)
        //    {
        //        Debug.LogWarning(" ARHIT NOT null >>>");
        //    }
        //    else
        //    {
        //        Debug.LogWarning(" <color=red> ARHIT  null >>> </color>");

        //    }

        //    if (Input.touchCount == 1)
        //    {

        //        Debug.Log("<color=green>  Spawn battle field</color>");
        //        SpawnBattlefield(arHits[0].pose.position, arHits[0].pose.rotation);
        //    }
        //    temp = true;
        //}
        //else
        //{
        //    if (planeIndicatorInstance != null)
        //    {
        //        Destroy(planeManager);

        //    }

        //}


    }

    #endregion

    #region Game Logic Execution

    public void GameDataExecution(Transform spawnPoition)
    {
        if (spawned)
        {
            return;
        }

        Debug.Log("  SpawnBattlefield >>>>>>>>>>>>>>>>>>> ");
        Debug.Log("  SpawnBattlefield Models  >>>>>>>>>>>>>>>>>>> " + alphabets[0].gameObject.name);

        selectedType = 0;

        if (selectedType == 0)
        {
            Debug.Log("Game Execution");
            SpawnBattlefield(spawnPoition, Quaternion.identity,selectedType);

        }
        else
        {
            

        }

      
    }

    void SpawnBattlefield(Transform vector3, Quaternion rot,int type)
    {

        
        Debug.Log("<color=pink> models present in touch click >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> </color>");

       
            if(selectedType == 0) 
            {
                spawnedBattleField = Instantiate(alphabets[type], vector3.position, rot);
                Debug.LogWarning(" before pos  ?????>>>" + spawnedBattleField.transform.rotation+" elur angles "+spawnedBattleField.transform.eulerAngles);

                spawnedBattleField.transform.rotation = Quaternion.LookRotation(Camera.main.transform.position);   
                spawned = true;
                ClearPlane();
                Debug.Log(spawnedBattleField.name);

            }
            else
            {
                spawnedBattleField = Instantiate(numericals[type], vector3.position, Quaternion.LookRotation(Camera.main.transform.position));
                spawnedBattleField.transform.LookAt(Camera.main.transform.position);
                //spawnedBattleField.transform.rotation = Quaternion.LookRotation(Camera.main.transform.position);

            spawned = true;
                ClearPlane();
                Debug.Log(spawnedBattleField.name);
            }



    }

    private void ClearPlane()
    {
         planeManager.enabled = false;
        

        foreach (ARPlane plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(false); // Optional: disable it first
            //Destroy(plane.gameObject);
        }

        //for (int i = 1; i <= planList.Count; i++)
        //{
        //    {
        //        Destroy(planList[i].gameObject);
        //    }

        //    planList.Clear();
        //}
    }
    #endregion

    #region UI Callbacks

    public void ReplayBTN()
    {
        SceneManager.LoadScene(StringDictionary.Gamescene);
    }

    public void NextBtn()
    {
        if(ApplicationManager.Instance.GetInt(StringDictionary.LastPlayed) == StringDictionary.Z)
        {
            SceneManager.LoadScene(StringDictionary.Homescene);
            return;
        }



        Debug.LogWarning(" next btrn ");
        ApplicationManager.Instance.IncreaseLevel(StringDictionary.Gamescene);
        //SceneManager.LoadScene(StringDictionary.Gamescene);
    }

    public void HomeBtn(int type)
    {
        Debug.LogWarning(" Home btrn ");
        if (type == 0)
        {
            if (ApplicationManager.Instance.GetInt(StringDictionary.LastPlayed) == StringDictionary.Z)
            {
                SceneManager.LoadScene(StringDictionary.Homescene);
                return;
            }

            ApplicationManager.Instance.IncreaseLevel(StringDictionary.Homescene);

        }
        else
        {
            SceneManager.LoadScene(StringDictionary.Homescene);

        }
        //ApplicationManager.Instance.IncreaseLevel(StringDictionary.Homescene);
        //SceneManager.LoadScene(StringDictionary.Homescene);

        //SceneManager.LoadScene(StringDictionary.Homescene);
    }

    public void RotateButton()
    {

        
        Image image = rotateImg.gameObject.transform.GetComponent<Image>();
        if (rotateOn)
        {
            rotateOn = false;
            image.sprite = rotateSpriteOff;
        }
        else
        {
            rotateOn = true;
           image.sprite = rotateSpriteOn;

        }

    }
    #endregion


    #region AR function


    //private void ShowPlaneIndicator(Vector3 pos, Quaternion rot)
    //{

    //    Debug.Log("Spawn Battle field >>>>>>>>>>>>>>>>>" + pos);
    //    if (planeIndicatorInstance == null)
    //    {
    //        planeIndicatorInstance = Instantiate(defaultPlaneIndicator,
    //            pos, rot);
    //        planList.Add(planeIndicatorInstance);

    //    }
    //    else
    //    {
    //        planeIndicatorInstance.transform.position = pos;
    //    }
    //}

    float AngleBetweenTouches(Touch t1, Touch t2)
    {
        Vector2 from = t2.position - t1.position;
        return Mathf.Atan2(from.y, from.x) * Mathf.Rad2Deg;
    }


    #endregion

    //public class Models
    //{
    //    public List<PlayingModelsCaptain> modelsType;
    //}
    //public List<First> nestedList = new List<First>();

}
