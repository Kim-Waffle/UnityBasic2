using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; // 배경
    [SerializeField] Image[] img_Character; // 캐릭터
    [SerializeField] TextMeshProUGUI txt_Name; // 캐릭터 이름
    [SerializeField] TextMeshProUGUI txt_NameTitle; // 캐릭터 타이틀
    [SerializeField] TextMeshProUGUI txt_Dialogue; // 대사

    int id = 1;

    void Start()
    {
        RefreshUI();

    }

    public void OnClickButton()
    {
        id++;
        RefreshUI();
    }

    // Update is called once per frame
    void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character; // 대사 테이블의 1번 ID의 characterID를 가지고 온다.
        txt_Name.text = SData.GetCharacterData(characterID).Name; // 캐릭터 테이블에서 characterID에 해당하는 name을 가지고 온다.
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; // 캐릭터 테이블에서 타이틀을 가지고 온다.
        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    
    }
}
