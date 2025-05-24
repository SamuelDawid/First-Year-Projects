using UnityEngine.UI;
using UnityEngine;

public class MasterMind : MonoBehaviour {
    public Image[] row0, row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11;
   
    public static int howManyRight;
    int currentRow;
    int pegCount;
    public Text[] numbers;
    Color[] colorOrder;
    int peg0, peg1, peg2, peg3;
    int pegGuess0, pegGuess1, pegGuess2, pegGuess3;
    [SerializeField] GameObject CheatMenu;
    [SerializeField] GameObject WON;
    [SerializeField] GameObject loose;
    // Use this for initialization
    void Start () {
        foreach (Text t in numbers)
        {
            t.text = "";
        }
        {
            peg0 = Random.Range(0, 6);
            peg1 = Random.Range(0, 6);
            peg2 = Random.Range(0, 6);
            peg3 = Random.Range(0, 6);
        }
        // Color selection
        {
            colorOrder = new Color[6];
            colorOrder[0] = Color.red;
            colorOrder[1] = new Color(1f, 0.5f, 0f, 1f);
            colorOrder[2] = Color.blue;
            colorOrder[3] = Color.cyan;
            colorOrder[4] = Color.green;
            colorOrder[5] = Color.black;
        }
        // Loop for the imagies

        Image[] cheaters = CheatMenu.GetComponentsInChildren<Image>();

        cheaters[0].color = colorOrder[peg0];
        cheaters[1].color = colorOrder[peg1];
        cheaters[2].color = colorOrder[peg2];
        cheaters[3].color = colorOrder[peg3];


    }

	
	// Update is called once per frame
	void Update () {
        
        
        
   
       
        

        if(Input.GetKeyDown(KeyCode.C))
        {
            CheatMenu.SetActive(!CheatMenu.activeSelf);
            
     
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pegGuess0++;
            if(pegGuess0 > 5)
            {
                pegGuess0 = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pegGuess1++;
            if (pegGuess1 > 5)
            {
                pegGuess1 = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            pegGuess2++;
            if (pegGuess2 > 5)
            {
                pegGuess2 = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            pegGuess3++;
            if (pegGuess3 > 5)
            {
                pegGuess3 = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckColors();
        }
        UpdateColors();
		
	}
    void CheckColors()
    {
        howManyRight = 0;
        if (pegGuess0 == peg0)
        {
            howManyRight++;
        }
        if (pegGuess1 == peg1)
        {
            howManyRight++;
        }
        if (pegGuess2 == peg2)
        {
            howManyRight++;
        }
        if (pegGuess3 == peg3)
        {
            howManyRight++;
        }

        numbers[currentRow].text = howManyRight.ToString();
        pegCount++;
        currentRow++;


        
    }
    
    
   
    void UpdateColors()
    {
        switch (pegCount)
        {
            case 0:
                row0[0].color = colorOrder[pegGuess0];
                row0[1].color = colorOrder[pegGuess1];
                row0[2].color = colorOrder[pegGuess2];
                row0[3].color = colorOrder[pegGuess3];
                break;
            case 1:
                row1[0].color = colorOrder[pegGuess0];
                row1[1].color = colorOrder[pegGuess1];
                row1[2].color = colorOrder[pegGuess2];
                row1[3].color = colorOrder[pegGuess3];
                break;
            case 2:
                row2[0].color = colorOrder[pegGuess0];
                row2[1].color = colorOrder[pegGuess1];
                row2[2].color = colorOrder[pegGuess2];
                row2[3].color = colorOrder[pegGuess3];
                break;
            case 3:
                row3[0].color = colorOrder[pegGuess0];
                row3[1].color = colorOrder[pegGuess1];
                row3[2].color = colorOrder[pegGuess2];
                row3[3].color = colorOrder[pegGuess3];
                break;
            case 4:
                row4[0].color = colorOrder[pegGuess0];
                row4[1].color = colorOrder[pegGuess1];
                row4[2].color = colorOrder[pegGuess2];
                row4[3].color = colorOrder[pegGuess3];
                break;
            case 5:
                row5[0].color = colorOrder[pegGuess0];
                row5[1].color = colorOrder[pegGuess1];
                row5[2].color = colorOrder[pegGuess2];
                row5[3].color = colorOrder[pegGuess3];
                break;
            case 6:
                row6[0].color = colorOrder[pegGuess0];
                row6[1].color = colorOrder[pegGuess1];
                row6[2].color = colorOrder[pegGuess2];
                row6[3].color = colorOrder[pegGuess3];
                break;
            case 7:
                row7[0].color = colorOrder[pegGuess0];
                row7[1].color = colorOrder[pegGuess1];
                row7[2].color = colorOrder[pegGuess2];
                row7[3].color = colorOrder[pegGuess3];
                break;
            case 8:
                row8[0].color = colorOrder[pegGuess0];
                row8[1].color = colorOrder[pegGuess1];
                row8[2].color = colorOrder[pegGuess2];
                row8[3].color = colorOrder[pegGuess3];
                break;
            case 9:
                row9[0].color = colorOrder[pegGuess0];
                row9[1].color = colorOrder[pegGuess1];
                row9[2].color = colorOrder[pegGuess2];
                row9[3].color = colorOrder[pegGuess3];
                break;
            case 10:
                row10[0].color = colorOrder[pegGuess0];
                row10[1].color = colorOrder[pegGuess1];
                row10[2].color = colorOrder[pegGuess2];
                row10[3].color = colorOrder[pegGuess3];
                break;
            case 11:
                row11[0].color = colorOrder[pegGuess0];
                row11[1].color = colorOrder[pegGuess1];
                row11[2].color = colorOrder[pegGuess2];
                row11[3].color = colorOrder[pegGuess3];
                break;


        }

    }
    private void FixedUpdate()
    {
        if (currentRow == 12 && howManyRight <= 3)
        {
            loose.SetActive(true);

        }
        else
        {
            loose.SetActive(false);
        }
        if (howManyRight == 4)
        {
            WON.SetActive(true);

        }
        else
        {
            WON.SetActive(false);

        }
       
    }
}
