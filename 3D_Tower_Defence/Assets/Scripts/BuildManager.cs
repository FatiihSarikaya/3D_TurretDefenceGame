using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject standardTurretPreFab;
    public GameObject missileLauncherPrefab;



    


    private TurretBluePrint turretToBuild;


   public bool CanBuild { get { return turretToBuild != null; } }

    public void BuildTurretOn(Node node)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money to build");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;


       GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log("Turret build' Money left: " + PlayerStats.Money);
    }
   

    public void SelectTurretToBuild(TurretBluePrint turret)
    {
        turretToBuild = turret;
    }
}
