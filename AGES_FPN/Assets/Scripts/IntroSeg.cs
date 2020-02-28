using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class IntroSeg : MonoBehaviour
{

    [SerializeField] Text ruletext;
    [SerializeField] Text titletext;
    [SerializeField] CarMove carcontroller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TitleScreen();
        ruletext.text = "Press space to speed up. \n\n Press shift to slow down. \n\n A and D to turn.";
    }

    void TitleScreen()
    {
        if (carcontroller.text1 == true)
        {
            titletext.text = "...\n\nHello? Can you hear me?";
        }

        if (carcontroller.text2 == true)
        {
            titletext.text = "I'm glad you're coming back.";
        }

        if (carcontroller.text3 == true)
        {
            titletext.text = "But it's not for me, is it?\n\n...\n\nThe road is getting dark.";
        }

        if (carcontroller.text4 == true)
        {
            titletext.text = "But you knew that already.\n\nI'll see you soon.";
        }

        if (carcontroller.titletext == true)
        {
            titletext.text = "SOHO\n\nA game by eric lovelock.";
        }
    }
}
