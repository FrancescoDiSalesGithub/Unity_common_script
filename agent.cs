using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*

[script di inseguimento]

script che insegue il giocatore ( o qualsiasi altro gameobject )
se raggiunge il giocatore/gameobject l'agente si ferma.

se il giocatore/gameobject si muove di nuovo l'agente insegue nuovamente
il giocatore/gameobject

*/

public class agent : MonoBehaviour {

    public Transform target;
    public NavMeshAgent agente;
    
	// Use this for initialization
	void Start ()
    {

        

	}
	
	// Update is called once per frame
	void Update ()
    {

        agente.SetDestination(target.position);
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            agente.Stop();
            agente.ResetPath();
        }
        else
        {
            agente.Resume();
            
        }
           
        
    }

}
