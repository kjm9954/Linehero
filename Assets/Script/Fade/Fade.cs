using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [SerializeField] [Range(0.01f, 10f)] private float fadetime;
    private Image image;
    // Start is called before the first frame update
    private void Awake()
    {
        image = GetComponent<Image>();
        transform.gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowBack()
    {
        transform.gameObject.SetActive(true);
        StartCoroutine(FadeEffect(0, 1));
    }

    public void ShowOut()
    {
        StartCoroutine(FadeEffect(1, 0));
    }
    private IEnumerator FadeEffect (float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;
        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadetime;

            Color color = image.color;
            color.a = Mathf.Lerp(start, end, percent);
            image.color = color;

            yield return null;
        }
    }
}
