using UnityEngine;
using UnityEngine.Rendering;

public class Teleport : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    int nextIndex = 1;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            

            GetComponent<CharacterController>().enabled = false;
            GameObject platform = GetPlatform();

            MovePlayrToTransform(platform.transform);

            ChangeIndex();
            GetComponent<CharacterController>().enabled = true;
        }
    }

    void MovePlayrToTransform(Transform platformTransform)
    {
        transform.position = platformTransform.position;
    }

    private GameObject GetPlatform()
    {
        if (nextIndex == 1)
            return platform1;
        else
            return platform2;
    }

    void ChangeIndex()
    {
        if (nextIndex == 1)
            nextIndex = 2;
        else
            nextIndex = 1;
    }
}
