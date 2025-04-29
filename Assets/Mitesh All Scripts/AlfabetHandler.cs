using UnityEngine;
using UnityEngine.UI;

public class AlfabetHandler : MonoBehaviour
{
    public Button Button;
    public Text Text;

    public GameObject Tickimg, Lockimg;

    public void AbcLockOnOff(bool IsTrue)
    {
        Lockimg.SetActive(IsTrue);
        Button.interactable = !IsTrue;
    }
    public void AbcTickOnOff(bool IsTrue)
    {
        Tickimg.SetActive(IsTrue);
    }

}
