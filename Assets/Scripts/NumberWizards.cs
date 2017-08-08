using UnityEngine;

public class NumberWizards : MonoBehaviour
{
    public int min = 1;
    public int max = 1000;
    public int guess = 500;

    // Use this for initialization
    public void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        max++;
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + " ?");
        print("Up = for higher, down = lower, return = equals");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
        }
    }
    public void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Up = for higher, down = lower, return = equals");
    }
}
