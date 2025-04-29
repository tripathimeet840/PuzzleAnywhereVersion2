using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationManager : MonoBehaviour
{

    public static ApplicationManager Instance;

    #region Public Var
    public GameManager GameManager;

    public int selectedtype = 0;
    public int lastPlayedObject = 0;

    public string currentAplhabet;

    #endregion

    #region Private Var

    

    #endregion


    #region Unity Callbacks

    private void Awake()
    {
        //Instance = this;
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        selectedtype = 0;

        PlayerPrefs.GetString(StringDictionary.LastPlayed, StringDictionary.A);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion




    #region Data Management

    public void ExecuteSpawn(Transform POS)
    {
        Debug.LogWarning("Execute Spawn >>>");


        if (GameManager == null)
        {
            Debug.Log("nullll >>>>>>>>>>>>>>>>>>>>>> GAme Manager");
        }
        else
        {

            Debug.Log("<color=green>NOT NULLLLL >>>>>>>>>>>>>>>>>>>>>> Game Manager</color>");
        }
        GameManager.GameDataExecution(POS);
    }


    int jp = 0;
    string tempstring;
    public void IncreaseLevel(string sceneName)
    {
        jp = 1;
        for (char i = 'A'; i <= 'Z'; i++)
        {
            if (currentAplhabet == StringDictionary.charValues[i])
            {
                Debug.Log(" char values before" + StringDictionary.charValues[i] );
                i++;
                Debug.Log(" char values after " + StringDictionary.charValues[i] );
                currentAplhabet = StringDictionary.charValues[i];
                SetInt(StringDictionary.LastPlayed,currentAplhabet);
                Debug.Log("   new current alphabet >>>>>>>>>>>" + currentAplhabet );
                SceneManager.LoadScene(sceneName);
                return;
            }
            jp++;
        }
    }

    #region PlayPref Allotment

    public void SetInt(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }
    public string GetInt(string key)
    {
        return PlayerPrefs.GetString(key, StringDictionary.A);
    }

    #endregion


    #endregion


}
