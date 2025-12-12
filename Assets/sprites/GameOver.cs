using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;

    void Start()
    {
        gameOverText.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            StartCoroutine(GameOverRoutine());
        }
    }

    IEnumerator GameOverRoutine()
    {
        gameOverText.SetActive(true);   // نوري الرسالة
        Time.timeScale = 0f;            // نوقّفو اللعبة (Freeze)

        yield return new WaitForSecondsRealtime(5f); // نستناو 5 ثواني حقيقيين

        Time.timeScale = 1f;            // نرجّعو الوقت
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
