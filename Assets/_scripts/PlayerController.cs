using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject InteractHint;

    void Start()
    {
        GlobalEvent.Instance.happen(GlobalEvent.event_g.C1_spawn);
    }
    
    void Update()
    {
        InteractHint.SetActive(false);
        Ray camerRay = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit cameraHit;
        if (Physics.Raycast(camerRay, out cameraHit))
        {
            GameObject go = cameraHit.transform.gameObject;
            Vector3 Opos = go.transform.position;
            Vector3 Ppos = GameObject.Find("Player").transform.position;
            float dis = (Opos - Ppos).magnitude;
            if (go.tag == "interact_entity" && dis < 2)
            {
                InteractHint.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    if (go.name == "Ring_Inter")
                    {
                        GlobalState.Instance.set_state(GlobalState.state_g.C1_torii);
                    }
                    if (go.name == "Stones_Inter")
                    {
                        GlobalEvent.Instance.happen(GlobalEvent.event_g.C1_stones);
                        GlobalState.Instance.set_state(GlobalState.state_g.C1_ring);
                    }
                }
            }
        }
    }
}
