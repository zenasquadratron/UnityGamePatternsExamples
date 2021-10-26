using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelBuilder : MonoBehaviour
{
    public GameObject panelPrefab;
    public GameObject labelPrefab;
    public GameObject descPrefab;
    public GameObject buttonPrefab;

    public GameObject parentPanel;

    public PanelInfo[] panels;

    // Start is called before the first frame update
    void Start()
    {
        CreatePanels();
    }

    void CreatePanels()
    {
        // create some panels
        foreach (PanelInfo pi in panels)
        {
            GameObject panelClone = Instantiate(panelPrefab, panelPrefab.transform.position, panelPrefab.transform.rotation );
            panelClone.SetActive(false);
            panelClone.transform.parent = parentPanel.transform;
            panelClone.GetComponent<Image>().color = pi.color;

            GameObject labelClone = Instantiate(labelPrefab, labelPrefab.transform.position, labelPrefab.transform.rotation);
            labelClone.transform.parent = panelClone.transform;
            labelClone.GetComponent<Text>().text = pi.name;

            GameObject descClone = Instantiate(descPrefab, descPrefab.transform.position, descPrefab.transform.rotation);
            descClone.transform.parent = panelClone.transform;
            descClone.GetComponent<Text>().text = pi.description;

            GameObject buttonClone = Instantiate(buttonPrefab, buttonPrefab.transform.position, buttonPrefab.transform.rotation);
            buttonClone.transform.parent = panelClone.transform;
            
        }

    }
}

[System.Serializable]
public class PanelInfo
{
    public string name;
    public string description;
    public Color color;
}