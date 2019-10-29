using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public GameObject torre;

    void OnMouseDown()
    {
        
        GameObject temp;
        Vector3 pos = this.transform.position;
        pos.y = pos.y + 105f;
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.x = -90;
        transform.rotation = Quaternion.Euler(rotationVector);
        Destroy(this.gameObject);
        temp = (GameObject)Instantiate(torre, pos, transform.rotation);
        temp.transform.position = pos;
        temp.layer = 7;
        temp.GetComponent<Torre>().Esta_activa1 = true;
               
    }

    /*private Color hoverColor;
    private Vector3 positionOffset;

    [SerializeField]
    private GameObject torre;
    private Renderer rend;
    private Color startColor;
    public TurretBlueprint turretBlueprint;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        //GameObject turretToBuild = BuildManager.instance.GetTurretToBuild;
        //buildManager = BuildManager.instance;

    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (torre != null)
        {
            buildManager.SelectNode(this);
            return;
        }

        //if (!buildManager.CanBuild)
            return;

        //BuildTurret(buildManager.GetTurretToBuild());
    }
    void BuildTurret(TurretBlueprint blueprint)
    {
        

        GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        torre = _turret;
        turretBlueprint = blueprint;


        Debug.Log("Turret build!");
        public void UpgradeTurret ()
	{
		if (PlayerStats.Money < turretBlueprint.upgradeCost)
		{
			Debug.Log("Not enough money to upgrade that!");
			return;
		}

		PlayerStats.Money -= turretBlueprint.upgradeCost;

		
		Destroy(turret);

		
		GameObject _turret = (GameObject)Instantiate(turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
		turret = _turret;

		

		isUpgraded = true;

		Debug.Log("Turret upgraded!");
	}

	public void SellTurret ()
	{
		PlayerStats.Money += turretBlueprint.GetSellAmount();

		

		Destroy(turret);
		turretBlueprint = null;
	}
    }*/
}


