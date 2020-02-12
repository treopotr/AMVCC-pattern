
using UnityEngine;




[CreateAssetMenu(fileName = "New EntitiesBehaviour", menuName = "Entities Behaviour", order = 51)]
public class EntitiesBehaviour : ScriptableObject
{

    public Application Application;

    //[SerializeField] private string _entityName;
    //[SerializeField] private string _description;
    //[SerializeField] private Sprite _icon;
    //[SerializeField] private string _attackDamage;
    //[SerializeField] private string _experience;
    //[SerializeField] private string _goldCost;
    //[SerializeField] private GameObject prefab;
    

    //public string EntityName { get { return _entityName; } }
    //public string Description { get { return _description; } }
    //public Sprite Icon { get { return _icon; } }
    //public string AttackDamage { get { return _attackDamage; } }
    //public string Ecperience { get { return _experience; } }
    //public string GoldCost { get { return _goldCost; } }
    //public GameObject Prefab { get{ return prefab; } }


    


    public void WolfMovePattern()
    {
        Application app = FindObjectOfType<Application>();
        app.view.wolfView.transform.position += Vector3.left * Time.deltaTime;
    }

    public void RavenMovePattern()
    {
        Application app = FindObjectOfType<Application>();
        app.view.ravenView.transform.position += Vector3.up * Time.deltaTime * 5;
    }

    public void WolfDoLikeRaven()
    {
        Application app = FindObjectOfType<Application>();
        app.view.wolfView.transform.position += Vector3.up * Time.deltaTime * 5;
    }

    public void RavenDoLikeWolf()
    {
        Application app = FindObjectOfType<Application>();
        app.view.ravenView.transform.position += Vector3.left * Time.deltaTime;
    }


}