using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public enum MyScenes
{
    Welcome,
    LevelOne,
    LevelTwo,
    LevelThree,
    EndScreen
}

public class Manager : MonoBehaviour
{
    public TMP_InputField ipfKidsname;
    public TMP_Text displayKidsName;

    private SoRuntimeData runtimeData;

    public void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        if(SceneManager.GetActiveScene().buildIndex == (int)MyScenes.LevelOne)
        {
            displayKidsName.text = runtimeData.nameKid;
        }
    }

    public void SwitchTheScene(int x)
    {
        Debug.Log("BTN pressed, get kidsname  " + ipfKidsname.text);
        runtimeData.nameKid = ipfKidsname.text;
        SceneManager.LoadScene(x);
    }

    public void SwitchTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }

    //    public void SwitchtoEnd()
    //    {
    //        SceneManager.LoadScene((int)MyScenes.EndScreen);
    //    }

    private void Update()
    {
        Debug.Log("Name:  " + ipfKidsname.text);
    }
}
