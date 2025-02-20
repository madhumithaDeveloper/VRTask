using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject uIMenu;

    void Start()
    {
        
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            uIMenu.SetActive(true);
        }
    }
}
