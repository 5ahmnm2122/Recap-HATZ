using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource shoot;
    public Text countText;
    public int counter = 0;
    public GameObject target;
    public int xPosition;
    public int yPosition;
    public int targetCount;

    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
    }

    IEnumerator TargetLoad()
    {
        while (targetCount < 10)
        {
            xPosition = Random.Range(-399, 399);
            yPosition = Random.Range(-230, 230);
            Instantiate(target, new Vector3(xPosition, yPosition, -5400), Quaternion.identity);
            yield return new WaitForSeconds(2);
            targetCount += 1;
        }
    }

    void OnMouseDown()
    {
        shoot.Play();
        counter += 1;
    }
    void SetCountText()
    {
        countText.text = "Count: " + counter.ToString();
    }
}
