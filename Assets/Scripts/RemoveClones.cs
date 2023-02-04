using UnityEngine;
using System.Linq;

public class RemoveClones : MonoBehaviour
{
    public float destroyDelay = 2f;
    private void Update()
    {
        RemoveDuplicates();
        RemiveDuplicateBulleetTotem();
    }
    void RemoveDuplicates()
    {
        GameObject[] duplicates = GameObject.FindObjectsOfType<GameObject>().Where(g => g.name == "Bullet(Clone)").ToArray();

        for (int i = 0; i < duplicates.Length; i++)
        {
            Destroy(duplicates[i], destroyDelay);
        }
    }

    void RemiveDuplicateBulleetTotem()
    {
        GameObject[] duplicates = GameObject.FindObjectsOfType<GameObject>().Where(g => g.name == "Bullet_totem(Clone)").ToArray();

        for (int i = 0; i < duplicates.Length; i++)
        {
            Destroy(duplicates[i], destroyDelay);
        }
    }
}

