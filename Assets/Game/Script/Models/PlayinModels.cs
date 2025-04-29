using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayinModels : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    string modelName;

    #region Unity callbacks

    private void OnMouseDown()
    {
        Debug.Log(" collision name >>>>" + this.gameObject.name);

        ClickOnObject();
    }

    #endregion


    #region Onclick Execution
    /// <summary>
    /// Function used to execute on mouse click task for right answer+
    /// </summary>
    void ClickOnObject()
    {
        if (ApplicationManager.Instance.currentAplhabet + "(Clone)" == this.gameObject.name)
        {
            Debug.Log(" Right >>>>>");
            ApplicationManager.Instance.GameManager.pop_UpPanel.SetActive(true);
            this.transform.parent.gameObject.SetActive(false);

        }
        else
        {
            Debug.Log(" wrong >>>>>");
            ApplicationManager.Instance.GameManager.wrongPanel.SetActive(true);
        }

    }

    #endregion
}
