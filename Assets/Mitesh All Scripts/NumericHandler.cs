using UnityEngine;
using UnityEngine.UI;

public class NumericHandler : MonoBehaviour
{
    public Button Button;
    public Text Text;

    public GameObject Tickimg, Lockimg;

    public void NumLockOnOff(bool IsTrue)
    {
        Lockimg.SetActive(IsTrue);
        Button.interactable = !IsTrue;
    }
    public void NumTickOnOff(bool IsTrue)
    {
        Tickimg.SetActive(IsTrue);
    }
}
