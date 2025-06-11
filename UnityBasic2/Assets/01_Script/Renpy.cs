using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; // ���
    [SerializeField] Image[] img_Character; // ĳ����
    [SerializeField] TextMeshProUGUI txt_Name; // ĳ���� �̸�
    [SerializeField] TextMeshProUGUI txt_NameTitle; // ĳ���� Ÿ��Ʋ
    [SerializeField] TextMeshProUGUI txt_Dialogue; // ���

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
        int characterID = SData.GetDialogueData(id).Character; // ��� ���̺��� 1�� ID�� characterID�� ������ �´�.
        txt_Name.text = SData.GetCharacterData(characterID).Name; // ĳ���� ���̺��� characterID�� �ش��ϴ� name�� ������ �´�.
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; // ĳ���� ���̺��� Ÿ��Ʋ�� ������ �´�.
        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    
    }
}
