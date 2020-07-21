using UnityEngine;
using UnityEngine.SceneManagement;

public class Bakery_Dialoge : MonoBehaviour
{
    public GameObject BakeryDialoge;
    public GameObject BakeryHalf;
    public GameObject BakeryBody;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            BakeryDialoge.SetActive(true);
            BakeryHalf.SetActive(true);
            BakeryBody.SetActive(false);
        }
    }

}
        
