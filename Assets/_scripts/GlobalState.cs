using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalState : Singleton<GlobalState>
{
    public enum state_g : byte {
        None = 0,
        C1_stones = 1,
        C1_ring = 2,
        C1_torii = 3,
    }
    private state_g state = state_g.None;
    
    public void set_state(state_g s)
    {
        if (s > state)
        {
            state = s;
        }
    }

    public state_g get_state()
    {
        return state;
    }
}
