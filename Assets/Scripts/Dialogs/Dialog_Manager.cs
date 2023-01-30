using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog_Manager : MonoBehaviour
{
    public Text nameText;
    public Text dialogText;
    public GameObject dialogWindow;


    private Queue<string> senteces;
    void Start()
    {
        senteces = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        senteces.Clear();
        nameText.text = dialog.name;
        foreach (string sentence in dialog.senteces)
        {
            senteces.Enqueue(sentence);
        }
        DisplayNext();
    }

    public void DisplayNext()
    {
        if(senteces.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentece = senteces.Dequeue();
        dialogText.text = sentece;
    }
    public void EndDialog()
    {
        dialogWindow.SetActive(false);
    }
    void Update()
    {
        
    }
}
