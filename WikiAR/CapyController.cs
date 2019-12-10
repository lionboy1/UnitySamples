using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace WikiAR
{
	public class CapyController : MonoBehaviour
	{
	    public GameObject capyPrefab;
	    public Button sleepbtn;
	    public Button attackbtn;
	    public Button standbtn;
	    public Button sitbtn;
	    void Start()
	    {
	        if (capyPrefab == null)
	        {
	            capyPrefab = GameObject.FindWithTag("capy");
	        }

	    }

	    void clickSleep()
	    {
	    	sleepbtn.onClick.AddListener(Sleep);
	    }

	    void Sleep()
	    {
	    	if (capyPrefab == null)
	        {
	            capyPrefab = GameObject.FindWithTag("capy");
	            capyPrefab.GetComponent<Animator>().SetTrigger("LieDown");
	        }
	    }

	    void clickSit()
	    {
	    	sitbtn.onClick.AddListener(Sit);
	    }

	    void Sit()
	    {
	    	if (capyPrefab == null)
	        {
	            capyPrefab = GameObject.FindWithTag("capy");
	            capyPrefab.GetComponent<Animator>().SetTrigger("Sit");
	        }
	    }

	    void clickStand()
	    {
	    	standbtn.onClick.AddListener(Stand);
	    }

	    void Stand()
	    {
	    	if (capyPrefab == null)
	        {
	            capyPrefab = GameObject.FindWithTag("capy");
	            capyPrefab.GetComponent<Animator>().SetTrigger("StandUp");
	        }
	    }

	    void clickAttack()
	    {
	    	attackbtn.onClick.AddListener(Attack);
	    }

	    void Attack()
	    {
	    	if (capyPrefab == null)
	        {
	            capyPrefab = GameObject.FindWithTag("capy");
	            capyPrefab.GetComponent<Animator>().SetTrigger("Attack");
	        }
	    }
	}    
}
