using UnityEngine;


[CreateAssetMenu(fileName = "Fauna", menuName = "Fauna/New Insect", order = 0)]
public class Fauna : ScriptableObject
{
    [SerializeField] GameObject _animal;
    [SerializeField] Transform _spawnPoint;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnFauna()
    {
        GameObject animalRef = Instantiate(_animal, _spawnPoint.position, _spawnPoint.rotation);
        // Debug.Log("Spawning ");
    }
}
