using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TicTacToeCodes : MonoBehaviour
{
    bool checker;
    int plusone;


    public Text A1 = null;
    public Text A2 = null;
    public Text A3 = null;
    public Text B1 = null;
    public Text B2 = null;
    public Text B3 = null;
    public Text C1 = null;
    public Text C2 = null;
    public Text C3 = null;

    public Text ResetGame = null;
    public Text MsgFeedBack = null;

    public Text txtPlayerX = null;
    public Text txtPlayerO = null;

    public void score()
    {
        if (A1.text == "X" && A2.text == "X" && A3.text == "X")
        {
            A1.color = Color.red;
            A2.color = Color.red;
            A3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);

        }
        if (B1.text == "X" && B2.text == "X" && B3.text == "X")
        {
            B1.color = Color.red;
            B2.color = Color.red;
            B3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);
        }
        if (C1.text == "X" && C2.text == "X" && C3.text == "X")
        {
            C1.color = Color.red;
            C2.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);

        }
        if (A1.text == "X" && B1.text == "X" && C1.text == "X")
        {
            A1.color = Color.red;
            B1.color = Color.red;
            C1.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);
        }
        if (A2.text == "X" && B2.text == "X" && C2.text == "X")
        {
            A2.color = Color.red;
            B2.color = Color.red;
            C2.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);

        }
        if (A3.text == "X" && B3.text == "X" && C3.text == "X")
        {
            A3.color = Color.red;
            B3.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);
        }
        if (A1.text == "X" && B2.text == "X" && C3.text == "X")
        {
            A1.color = Color.red;
            B2.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);

        }
        if (A3.text == "X" && B2.text == "X" && C1.text == "X")
        {
            A3.color = Color.red;
            B2.color = Color.red;
            C1.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);
        }
        // ============================================player O=============================================
        if (A1.text == "X" && A2.text == "X" && A3.text == "X")
        {
            A1.color = Color.red;
            A2.color = Color.red;
            A3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);

        }
        if (B1.text == "X" && B2.text == "X" && B3.text == "X")
        {
            B1.color = Color.red;
            B2.color = Color.red;
            B3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);
        }
        if (C1.text == "X" && C2.text == "X" && C3.text == "X")
        {
            C1.color = Color.red;
            C2.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);

        }
        if (A1.text == "X" && B1.text == "X" && C1.text == "X")
        {
            A1.color = Color.red;
            B1.color = Color.red;
            C1.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);
        }
        if (A2.text == "X" && B2.text == "X" && C2.text == "X")
        {
            A2.color = Color.red;
            B2.color = Color.red;
            C2.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);

        }
        if (A3.text == "X" && B3.text == "X" && C3.text == "X")
        {
            A3.color = Color.red;
            B3.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);
        }
        if (A1.text == "X" && B2.text == "X" && C3.text == "X")
        {
            A1.color = Color.red;
            B2.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);

        }
        if (A3.text == "X" && B2.text == "X" && C1.text == "X")
        {
            A3.color = Color.red;
            B2.color = Color.red;
            C1.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);
        }



    }
}
