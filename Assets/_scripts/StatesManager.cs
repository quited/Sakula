using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesManager : MonoBehaviour
{
    public GameObject ring;
    public GameObject sakura;

    private GlobalState.state_g lastState;

    void Start()
    {
        lastState = GlobalState.Instance.get_state();
        GlobalState.Instance.set_state(GlobalState.state_g.C1_stones);
    }
    
    void Update()
    {
        if (GlobalState.Instance.get_state() != lastState)
        {
            switch (GlobalState.Instance.get_state())
            {
                case GlobalState.state_g.C1_stones:
                    set_C1_stones();
                    break;
                case GlobalState.state_g.C1_ring:
                    set_C1_ring();
                    break;
                case GlobalState.state_g.C1_torii:
                    set_C1_torii();
                    break;
                default:
                    break;

            }
            lastState = GlobalState.Instance.get_state();
        }
    }

    private void set_C1_stones()
    {

    }

    private void set_C1_ring()
    {
        GameObject ring_entity = Instantiate(ring, new Vector3(0, 1, 0.3f), Quaternion.identity, GameObject.Find("Entities").transform);
        ring_entity.name = "Ring";
    }

    private void set_C1_torii()
    {
        GameObject r = GameObject.Find("Ring");
        GameObject.Destroy(r);
        Instantiate(sakura, r.transform.position, Quaternion.identity);
    }
}
