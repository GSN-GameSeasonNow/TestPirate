using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Trigger : MonoBehaviour
{
    public Dialog dialog;

    public void TriggerDialog()
    {
        FindObjectOfType<Dialog_Manager>().StartDialog(dialog);
    }
}
