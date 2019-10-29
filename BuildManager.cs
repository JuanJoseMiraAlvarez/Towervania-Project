using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject turretToBuild;
    [SerializeField]
    public BuildManager instance;
    private Node selectedNode;
    private NodeUI nodeUI;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Hay más de un BuildManager");
            return;
        }
        instance = this;
    }




    public GameObject standardTurretPrefab;

    private void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
    public void SelectNode(Node node)
    {
        if (selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }
    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuild(GameObject torre)
    {
        turretToBuild = torre;
        DeselectNode();

    }
    
}
