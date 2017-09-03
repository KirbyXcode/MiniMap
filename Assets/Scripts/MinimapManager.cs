using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimapManager : MonoBehaviour 
{
    public static MinimapManager Instance;
    public Transform player;

    void Awake()
    {
        Instance = this;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void OnApplicationQuit()
    {
        Instance = null;
    }

    public Sprite LoadIcon(string iconName)
    {
        return Resources.Load<Sprite>(iconName);
    }

    public GameObject CreateMinimapIcon(GameObject enemyIcon, string iconName)
    {
        GameObject go = Instantiate(enemyIcon);
        go.GetComponent<Image>().sprite = LoadIcon(iconName);
        go.transform.SetParent(this.transform, true);
        go.transform.localPosition = new Vector3(0, 0, 0);
        go.transform.localRotation = Quaternion.EulerRotation(0, 0, 0);
        return go;
    }
}
