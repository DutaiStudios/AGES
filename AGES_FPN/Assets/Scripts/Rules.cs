using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Rules : MonoBehaviour
{

    [SerializeField] PlayerController pcontroller;
    [SerializeField] GameObject Player;
    [SerializeField] Text rulestext;

    private int Ruleset;


    void Update()
    {

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
            rulestext.text = "Newest Rules: \n\n Do not turn Around. \n\n Always go opposite the light. \n\n Rules never go away";
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
}
