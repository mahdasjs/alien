using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchChar : MonoBehaviour
{
    public GameObject avatar1, avatar2;
    int whichAvatarIsOn = 1;

    // Start is called before the first frame update
    void Start()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);
    }

    public void SwitchAvatar()
    {
        switch (whichAvatarIsOn)
        {
            case 1:
                whichAvatarIsOn = 2;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);
                break;

            case 2:
                whichAvatarIsOn = 1;
                avatar1.gameObject.SetActive(true);
                avatar2.gameObject.SetActive(false);
                break;

        }
    }
}
