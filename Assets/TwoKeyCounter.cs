using UnityEngine;

public class TwoKeyCounter : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        bool changed = false;

        if (Input.GetKeyDown(KeyCode.A))
        {
            count++;
            changed = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            count--;
            changed = true;
        }

        if (changed)
        {
            Debug.Log("Count: " + count);

            if (count < 0)
            {
                Debug.Log("Negative!");
                count = 0;
            }
            else if (count == 5)
            {
                Debug.Log("Max reached!");
                count = 0;
            }
        }
    }
}