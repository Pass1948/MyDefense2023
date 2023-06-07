using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopUpUI : PopUpUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["ContinueButten"].onClick.AddListener(() => { GameManager.UI.ClosePopUpUI(); });
        buttons["SettingButten"].onClick.AddListener(() => { GameManager.UI.ShowPopUpUI<PopUpUI>("UI/ConfigPopUpUI"); });
    }
}
