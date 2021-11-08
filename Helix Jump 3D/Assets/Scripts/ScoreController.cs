using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private int currentlevel;

    [SerializeField] private Text scoreText1;
    [SerializeField] private Text scoreText2;

    [SerializeField] private Animator _animation;

    private int _score = 0;

    private const string Score = "Score";

    private void GetScore()
    {
        _score += currentlevel;

        scoreText1.text = _score.ToString();

        _animation.SetTrigger("Play");

        scoreText2.text = "+" + _score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Score))
        {
            GetScore();
        }

    }

}
