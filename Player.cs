using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    public void DoDamage(int amount)
    {
        //
    }

    /*IDamageable doDamage;

void Start()
{
   doDamage = GetComponent<IDamageable>();
}*/
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DoDamage(1);
        }
    }
}