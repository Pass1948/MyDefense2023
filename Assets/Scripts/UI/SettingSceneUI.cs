using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingSceneUI : SceneUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["InfoButton"].onClick.AddListener(() => { Debug.Log("Á¤º¸Ã¢!"); });
        buttons["VolumeButton"].onClick.AddListener(() => { Debug.Log("º¼·ý!"); });
        buttons["SettingButton"].onClick.AddListener(() => { OpenPausePopUp(); });
    }

    public void OpenPausePopUp() 
    {
        GameManager.UI.ShowPopUpUI<PopUpUI>("UI/SettingPopUpUI");
    }

}
