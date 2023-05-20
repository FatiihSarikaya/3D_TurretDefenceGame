using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject standardTurretPreFab;
    public GameObject anotherTurretPreFab;



    


    private GameObject turretToBuild;


    public GameObject GetTurretToBuild()
    {
        return turretToBuild; 
    }
   

    public void SetTurretToBuild (GameObject turret)
    {
        turretToBuild = turret;
    }
}
