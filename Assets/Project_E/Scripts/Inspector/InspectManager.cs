using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class InspectManager : SingleTon<InspectManager>
{
    // Object Name, Detail ȭ�鿡 ����Ѵ�.
    // UI - Image - BG, TMP - text

    [Header("Object Name UI")]
    public TextMeshProUGUI objectNameText;
    public GameObject objectNameBG;

    [Header("Object Detail UI")]
    public TextMeshProUGUI objectDetailText;
    public GameObject objectDetailBG;

    [Header("Timer")]
    public float onScreenTimer = 5f;
    public float fadeDuration = 1f;

    private CanvasGroup objectDetailCanvasGroup;
    private bool startTimer;
    private float timer;

    protected override void Awake()
    {
        base.Awake();
        objectDetailCanvasGroup = objectDetailBG.GetComponent<CanvasGroup>();
        objectNameBG.SetActive(false);
        objectDetailCanvasGroup.alpha = 0;
    }

    public void ShowName(string objectName, bool show)
    {
        if(show)
        {
            objectNameBG.SetActive(true);
            objectNameText.text = objectName;
        }
        else
        {
            objectNameBG.SetActive(false);
            objectNameText.text = "";
        }
    }

    public void ShowObjectDetail(string info)
    {
        objectDetailText.text = info;
        // BG Ȱ��ȭ, ��Ȱ��ȭ
        // Fade In, Out
        // �ڷ�ƾ
    }

}