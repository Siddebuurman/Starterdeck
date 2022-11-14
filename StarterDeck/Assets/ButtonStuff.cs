using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonStuff : MonoBehaviour
{
    public GameObject buttonTemplate;
    public List<GameObject> engineers = new();

    private void Awake()
    {
        StartCoroutine(PlaceButtons());
    }

    IEnumerator PlaceButtons()
    {
        foreach (var engineer in engineers)
        {
            for (int i = 0; i < 18; i++)
            {
                var o = Instantiate(buttonTemplate, new(), Quaternion.identity, engineer.transform);
                o.name = "button " + i;
                o.transform.GetChild(0).GetComponent<TMP_Text>().text = "button " + i;
                yield return new WaitForSeconds(0.01f);
            }
            yield return new WaitForSeconds(0.01f);
        }
    }
}
