using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{

    [SerializeField]
    Slider slider;
    float value;
    bool loadingComplete;

    void Start()
    {
        //if (slider.value == slider.minValue && loadingComplete == false)
        //{
            // IncreaseSliderValue(slider.value);
            InvokeRepeating("IncreaseSliderValue", 0, 1);
        //}
    }

    void Update()
    {



    }

    private void IncreaseSliderValue()
    {

        value = slider.value;
        value = value + 0.1f;
        // yield return new WaitForSeconds(1);
        slider.value = value;

        //if (loadingComplete == false && slider.value == slider.maxValue)
        if (slider.value == slider.maxValue)
        {
            //Debug.Log(" if");

            // loadingComplete = true;
            SceneManager.LoadScene(1);

        }
        else
        {
            //Debug.Log("else");
        }
    }

}
