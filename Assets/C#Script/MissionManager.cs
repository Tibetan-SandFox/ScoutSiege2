using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    private int mTotal;
    Text cText;
    private float dispTime;
    private bool isDisplay;

    // Start is called before the first frame update
    void Start()
    {
        mTotal = 4;
        cText = GameObject.Find("ClearText").GetComponent<Text>();
        isDisplay = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDisplay == true)
        {
            dispTime += Time.deltaTime;
        }

        if (dispTime >= 5.0f)
        {
            cText.text = "";
            isDisplay = false;
            dispTime = 0.0f;
        }
    }

    public void mManager()
    {
        mTotal = mTotal - 1;
        if (mTotal <= 0)
        {
            cText.text = "�S�~�b�V�����B���I���߂łƂ��I";
        }
        else
        {
            cText.text = "�~�b�V�����N���A�I �c��~�b�V������" + mTotal + "��";
            isDisplay = true;

            if(dispTime >= 5.0f)
            {
                cText.text = "";
                isDisplay = false;
                dispTime = 0.0f;
            }
        }
    }
}
