using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimapItem : MonoBehaviour 
{
    public GameObject iconPrefab;
    private GameObject iconGo;

    void Start()
    {
        iconGo = MinimapManager.Instance.CreateMinimapIcon(iconPrefab, "M-3");
    }

    void FixedUpdate()
    {
        Vector3 offset = transform.position - MinimapManager.Instance.player.position;
        iconGo.transform.localPosition = new Vector3(offset.x, offset.z, 0) * 5;
        if (Mathf.Abs(iconGo.transform.localPosition.x) > 150f || Mathf.Abs(iconGo.transform.localPosition.y) > 150f)
        {
            iconGo.GetComponent<CanvasGroup>().alpha = 0;
        }
        else if ((Mathf.Abs(iconGo.transform.localPosition.x) <= 150f || Mathf.Abs(iconGo.transform.localPosition.y) <= 150f))
        {
            iconGo.GetComponent<CanvasGroup>().alpha = 1;
        }
    }

    void OnDestroy()
    {
        Destroy(iconGo);
    }
}
