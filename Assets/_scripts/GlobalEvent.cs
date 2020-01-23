using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalEvent : Singleton<GlobalEvent>
{
    public GameObject Poem;

    public enum event_g : byte
    {
        None = 0,
        C1_spawn = 1,
        C1_stones = 2,
        C1_ring = 3,
    }

    public void happen(event_g e)
    {
        switch (e) {
            case event_g.None:
                break;
            case event_g.C1_spawn:
                process_C1_spawn();
                break;
            case event_g.C1_stones:
                process_C1_stones();
                break;
            default:
                break;
        }
    }

    private void process_C1_spawn()
    {
        hide_C1_Poem();
    }

    private void process_C1_stones()
    {
        Poem.SetActive(true);
        Invoke("hide_C1_Poem", 5);
    }

    private void hide_C1_Poem()
    {
        Poem.SetActive(false);
    }
}
