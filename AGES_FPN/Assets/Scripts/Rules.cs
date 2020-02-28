using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Rules : MonoBehaviour
{

    [SerializeField] PlayerController pcontroller;
    [SerializeField] GameObject Player;
    [SerializeField] Text rulestext;
    [SerializeField] CamMouseLook maincamera;
    [SerializeField] Text SohoText;
    [SerializeField] CarDest Car;
    [SerializeField] GameObject car_tbd;
    [SerializeField] GameObject newcar;
    private int sohotalk = 175;
    private int Ruleset;
    private float mountainview = 720;
    private string m_tostring = "\n\n The mountain has seen you. Your mind feels numb and listless. \n\n";


    void Update()
    {
        sohotalk--;
        sohoconverse();
        FollowRules();
        RuleText();
        Ruleset = pcontroller.rules;

        if (pcontroller.PlayerFail == true)
        {
            rulestext.text = "YOU HAVE FAILED. \n You disobeyed a rule.";
        }
    }

    void RuleText()
    {
        if (Ruleset == 1)
        {
            rulestext.text = "Newest Rules: \n\n Do not enter the treeline. \n\n Do not stare at the mountain. \n\n Rules never go away.";
        }

        if (Ruleset == 2)
        {
            rulestext.text = "Newest Rules: \n\n Do not turn Around. \n\n Rules never go away";
        }

        if (maincamera.SeenMountain == true)
        {
            rulestext.text = m_tostring + mountainview;
            mountainview--;
            if (mountainview <= 0)
            {
                maincamera.SeenMountain = false;
                mountainview = 720;
                RuleText();
            }
        }

       
    }

    void FollowRules()
    {
        if (Ruleset == 2)
        {
            if (Player.transform.rotation.eulerAngles.y >= 179 || Player.transform.rotation.eulerAngles.y <= 0)
            {
                pcontroller.PlayerFail = true;
            }
        }

    }

    void sohoconverse()
    {
        if (sohotalk >= 0)
        {
            SohoText.text = "I'm surprised it lasted as long as it did. \n\n But you'll need to go on foot from here.";
        }


        if (sohotalk <= 0)
        {
            SohoText.text = "";
        }
    }




}
