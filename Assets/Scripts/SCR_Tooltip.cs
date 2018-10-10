using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_Tooltip : MonoBehaviour
{

    GameObject tooltipPanel;
    public Text tooltipText;
    CanvasRenderer myCanvasRenderer;

    RaycastHit hitInfo;

    private void Start()
    {
        myCanvasRenderer = GetComponent<CanvasRenderer>();
        hitInfo = new RaycastHit();
        myCanvasRenderer.SetAlpha(0);
        tooltipText.text = "";
    }

    private void Update()
    {
        transform.position = Input.mousePosition;

        //if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
        //{
        //    if(hitInfo.transform.CompareTag("Unit") && hitInfo.transform.GetComponent<UnitStatus>())
        //    {
        //        UnitStatus tempStats = hitInfo.transform.GetComponent<UnitStatus>();
        //        ShowTooltip(tempStats);
        //    }
        //    else
        //    {
        //        HideTooltip();
        //    }
        //}
    }

    public void ShowTooltip(UnitStatus _stats)
    {
        myCanvasRenderer.SetAlpha(1);
        tooltipText.text = "HP: " + _stats.hitPoints + "\n" +
            "Atk: " + _stats.attack + "\n" +
            "M.Atk: " + _stats.mAttack + "\n" +
            "Armor: " + _stats.armor + "\n" +
            "M.Armor: " + _stats.mArmor + "\n" +
            "Speed: " + _stats.attack;
    }

    public void HideTooltip()
    {
        myCanvasRenderer.SetAlpha(0);
        tooltipText.text = "";
    }

}
