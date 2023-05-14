using Microsoft.Maui.Controls.Shapes;

namespace Team9.Connect4.MAUI
{
    public partial class MainPage : ContentPage
    {
        //string[] values = new string[156];
        string[][] plays = new string[6][];
        int turn = 1;
        bool firstMove = true;
        bool localGame = false;
        bool remoteGame = false;
        bool aiGame = false;
        int nextAvailableCol1 = 39;
        int nextAvailableCol2 = 51;
        int nextAvailableCol3 = 63;
        int nextAvailableCol4 = 75;
        int nextAvailableCol5 = 87;
        int nextAvailableCol6 = 99;
        int nextAvailableCol7 = 111;
        int aiSpotPlace = 0;
        Color playerColor = Color.FromRgb(255, 0, 0);
        Color player1Color = Color.FromRgb(255, 0, 0);
        Color player2Color = Color.FromRgb(255, 255, 0);
        Color boardColor = Color.FromRgb(0, 0, 255);
        int playerNumber = 1;

        public MainPage()
        {
            InitializeComponent();

            ClearAll();

            plays[0] = new string[5];
            plays[1] = new string[5];
            plays[2] = new string[5];
            plays[3] = new string[5];
            plays[4] = new string[5];
            plays[5] = new string[5];
            plays[6] = new string[5];
        }

        #region ComputerRandom
        private void ComputerRandom()
        {
            turn = 2;
            playerColor = player2Color;
            int choice = 0;
            if (aiSpotPlace > 0)
            {
                choice = aiSpotPlace;
                aiSpotPlace = 0;
            }
            else
            {
                Random rnd = new Random();
                choice = rnd.Next(1, 8);
            }
            switch (choice)
            {
                case 1:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[0][i] == "0")
                        {
                            plays[0][i] = turn.ToString();
                            int nextAvailableCol1 = 39 + i + 1;

                            switch (i)
                            {
                                case 0:
                                    e6x1.Fill = new SolidColorBrush(playerColor);
                                    //r6x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x1.Fill = new SolidColorBrush(playerColor);
                                    //r5x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x1.Fill = new SolidColorBrush(playerColor);
                                    //r4x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x1.Fill = new SolidColorBrush(playerColor);
                                    //r3x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x1.Fill = new SolidColorBrush(playerColor);
                                    //r2x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x1.Fill = new SolidColorBrush(playerColor);
                                    //r1x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            //EndTurn();
                        }
                        else if (i == 5)
                        {
                            //DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[1][i] == "0")
                        {
                            plays[1][i] = turn.ToString();
                            int nextAvailableCol2 = 51 + i + 1;

                            switch (i)
                            {
                                case 0:
                                    e6x2.Fill = new SolidColorBrush(playerColor);
                                    //r6x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x2.Fill = new SolidColorBrush(playerColor);
                                    //r5x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x2.Fill = new SolidColorBrush(playerColor);
                                    //r4x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x2.Fill = new SolidColorBrush(playerColor);
                                    //r3x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x2.Fill = new SolidColorBrush(playerColor);
                                    //r2x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x2.Fill = new SolidColorBrush(playerColor);
                                    //r1x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            //EndTurn();
                        }
                        else if (i == 5)
                        {
                            //DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[2][i] == "0")
                        {
                            plays[2][i] = turn.ToString();
                            int nextAvailableCol3 = 63 + i + 1;

                            switch (i)
                            {
                                case 0:
                                    e6x3.Fill = new SolidColorBrush(playerColor);
                                    //r6x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x3.Fill = new SolidColorBrush(playerColor);
                                    //r5x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x3.Fill = new SolidColorBrush(playerColor);
                                    //r4x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x3.Fill = new SolidColorBrush(playerColor);
                                    //r3x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x3.Fill = new SolidColorBrush(playerColor);
                                    //r2x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x3.Fill = new SolidColorBrush(playerColor);
                                    //r1x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            //EndTurn();
                        }
                        else if (i == 5)
                        {
                            //DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[3][i] == "0")
                        {
                            plays[3][i] = turn.ToString();
                            int nextAvailableCol4 = 75 + i + 1;

                            switch (i)
                            {
                                case 0:
                                    e6x4.Fill = new SolidColorBrush(playerColor);
                                    //r6x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x4.Fill = new SolidColorBrush(playerColor);
                                    //r5x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x4.Fill = new SolidColorBrush(playerColor);
                                    //r4x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x4.Fill = new SolidColorBrush(playerColor);
                                    //r3x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x4.Fill = new SolidColorBrush(playerColor);
                                    //r2x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x4.Fill = new SolidColorBrush(playerColor);
                                    //r1x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            //EndTurn();
                        }
                        else if (i == 5)
                        {
                            //DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[4][i] == "0")
                        {
                            plays[4][i] = turn.ToString();
                            int nextAvailableCol5 = 87 + i + 1;

                            switch (i)
                            {
                                case 0:
                                    e6x5.Fill = new SolidColorBrush(playerColor);
                                    //r6x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x5.Fill = new SolidColorBrush(playerColor);
                                    //r5x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x5.Fill = new SolidColorBrush(playerColor);
                                    //r4x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x5.Fill = new SolidColorBrush(playerColor);
                                    //r3x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x5.Fill = new SolidColorBrush(playerColor);
                                    //r2x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x5.Fill = new SolidColorBrush(playerColor);
                                    //r1x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            //EndTurn();
                        }
                        else if (i == 5)
                        {
                            //DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 6:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[5][i] == "0")
                        {
                            plays[5][i] = turn.ToString();
                            int nextAvailableCol6 = 99 + i + 1;

                            switch (i)
                            {
                                case 0:
                                    e6x6.Fill = new SolidColorBrush(playerColor);
                                    //r6x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x6.Fill = new SolidColorBrush(playerColor);
                                    //r5x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x6.Fill = new SolidColorBrush(playerColor);
                                    //r4x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x6.Fill = new SolidColorBrush(playerColor);
                                    //r3x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x6.Fill = new SolidColorBrush(playerColor);
                                    //r2x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x6.Fill = new SolidColorBrush(playerColor);
                                    //r1x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            //EndTurn();
                        }
                        else if (i == 5)
                        {
                            //DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 7:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[6][i] == "0")
                        {
                            plays[6][i] = turn.ToString();
                            int nextAvailableCol7 = 111 + i + 1;

                            switch (i)
                            {
                                case 0:
                                    e6x7.Fill = new SolidColorBrush(playerColor);
                                    //r6x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x7.Fill = new SolidColorBrush(playerColor);
                                    //r5x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x7.Fill = new SolidColorBrush(playerColor);
                                    //r4x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x7.Fill = new SolidColorBrush(playerColor);
                                    //r3x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x7.Fill = new SolidColorBrush(playerColor);
                                    //r2x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x7.Fill = new SolidColorBrush(playerColor);
                                    //r1x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            //EndTurn();
                        }
                        else if (i == 5)
                        {
                            //DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
            }
            turn = 1;
            lblPlayerTurn.Text = "Player 1's Turn";
            firstMove = false;
            playerColor = player1Color;
        }
        #endregion

        private void ComputerWin()
        {
            string[] values = UnJaggedArray(plays);
            for (int i = 39; i < 117; i++)
            {
                string winner = values[i];
                if ((values[i] == "2" && values[i + 1] == "2" && values[i + 2] == "2" && (nextAvailableCol1 == i + 3 || nextAvailableCol2 == i + 3 || nextAvailableCol3 == i + 3 || nextAvailableCol4 == i + 3 || nextAvailableCol5 == i + 3 || nextAvailableCol6 == i + 3 || nextAvailableCol7 == i + 3))
                    || (values[i] == "2" && values[i + 1] == "2" && values[i + 3] == "2" && (nextAvailableCol1 == i + 2 || nextAvailableCol2 == i + 2 || nextAvailableCol3 == i + 2 || nextAvailableCol4 == i + 2 || nextAvailableCol5 == i + 2 || nextAvailableCol6 == i + 2 || nextAvailableCol7 == i + 2))
                    || (values[i] == "2" && values[i + 2] == "2" && values[i + 3] == "2" && (nextAvailableCol1 == i + 1 || nextAvailableCol2 == i + 1 || nextAvailableCol3 == i + 1 || nextAvailableCol4 == i + 1 || nextAvailableCol5 == i + 1 || nextAvailableCol6 == i + 1 || nextAvailableCol7 == i + 1))
                    || (values[i + 1] == "2" && values[i + 2] == "2" && values[i + 3] == "2" && (nextAvailableCol1 == i || nextAvailableCol2 == i || nextAvailableCol3 == i || nextAvailableCol4 == i || nextAvailableCol5 == i || nextAvailableCol6 == i || nextAvailableCol7 == i)))
                {
                    if (i >= 39 && i <= 44)
                        aiSpotPlace = 1;
                    else if (i >= 51 && i <= 56)
                        aiSpotPlace = 2;
                    else if (i >= 63 && i <= 68)
                        aiSpotPlace = 3;
                    else if (i >= 75 && i <= 80)
                        aiSpotPlace = 4;
                    else if (i >= 87 && i <= 92)
                        aiSpotPlace = 5;
                    else if (i >= 99 && i <= 104)
                        aiSpotPlace = 6;
                    else if (i >= 111 && i <= 116)
                        aiSpotPlace = 7;
                    //ComputerRandom();
                    //ClearAll();
                }
                if ((values[i] == "2" && values[i + 13] == "2" && values[i + 26] == "2" && (nextAvailableCol1 == i + 39 || nextAvailableCol2 == i + 39 || nextAvailableCol3 == i + 39 || nextAvailableCol4 == i + 39 || nextAvailableCol5 == i + 39 || nextAvailableCol6 == i + 39 || nextAvailableCol7 == i + 39))
                    || (values[i] == "2" && values[i + 13] == "2" && values[i + 39] == "2" && (nextAvailableCol1 == i + 26 || nextAvailableCol2 == i + 26 || nextAvailableCol3 == i + 26 || nextAvailableCol4 == i + 26 || nextAvailableCol5 == i + 26 || nextAvailableCol6 == i + 26 || nextAvailableCol7 == i + 26))
                    || (values[i] == "2" && values[i + 13] == "2" && values[i + 26] == "2" && (nextAvailableCol1 == i + 13 || nextAvailableCol2 == i + 13 || nextAvailableCol3 == i + 13 || nextAvailableCol4 == i + 13 || nextAvailableCol5 == i + 13 || nextAvailableCol6 == i + 13 || nextAvailableCol7 == i + 13))
                    || (values[i + 13] == "2" && values[i + 26] == "2" && values[i + 39] == "2" && (nextAvailableCol1 == i || nextAvailableCol2 == i || nextAvailableCol3 == i || nextAvailableCol4 == i || nextAvailableCol5 == i || nextAvailableCol6 == i || nextAvailableCol7 == i)))
                {
                    if (i >= 39 && i <= 44)
                        aiSpotPlace = 1;
                    else if (i >= 51 && i <= 56)
                        aiSpotPlace = 2;
                    else if (i >= 63 && i <= 68)
                        aiSpotPlace = 3;
                    else if (i >= 75 && i <= 80)
                        aiSpotPlace = 4;
                    else if (i >= 87 && i <= 92)
                        aiSpotPlace = 5;
                    else if (i >= 99 && i <= 104)
                        aiSpotPlace = 6;
                    else if (i >= 111 && i <= 116)
                        aiSpotPlace = 7;
                    //ComputerRandom();
                    //ClearAll();
                }
                if ((values[i] == "2" && values[i + 12] == "2" && values[i + 24] == "2" && (nextAvailableCol1 == i + 36 || nextAvailableCol2 == i + 36 || nextAvailableCol3 == i + 36 || nextAvailableCol4 == i + 36 || nextAvailableCol5 == i + 36 || nextAvailableCol6 == i + 36 || nextAvailableCol7 == i + 36))
                    || (values[i] == "2" && values[i + 12] == "2" && values[i + 36] == "2" && (nextAvailableCol1 == i + 24 || nextAvailableCol2 == i + 24 || nextAvailableCol3 == i + 24 || nextAvailableCol4 == i + 24 || nextAvailableCol5 == i + 24 || nextAvailableCol6 == i + 24 || nextAvailableCol7 == i + 24))
                    || (values[i] == "2" && values[i + 24] == "2" && values[i + 36] == "2" && (nextAvailableCol1 == i + 12 || nextAvailableCol2 == i + 12 || nextAvailableCol3 == i + 12 || nextAvailableCol4 == i + 12 || nextAvailableCol5 == i + 12 || nextAvailableCol6 == i + 12 || nextAvailableCol7 == i + 12))
                    || (values[i + 12] == "2" && values[i + 24] == "2" && values[i + 36] == "2" && (nextAvailableCol1 == i || nextAvailableCol2 == i || nextAvailableCol3 == i || nextAvailableCol4 == i || nextAvailableCol5 == i || nextAvailableCol6 == i || nextAvailableCol7 == i)))
                {
                    if (i >= 39 && i <= 44)
                        aiSpotPlace = 1;
                    else if (i >= 51 && i <= 56)
                        aiSpotPlace = 2;
                    else if (i >= 63 && i <= 68)
                        aiSpotPlace = 3;
                    else if (i >= 75 && i <= 80)
                        aiSpotPlace = 4;
                    else if (i >= 87 && i <= 92)
                        aiSpotPlace = 5;
                    else if (i >= 99 && i <= 104)
                        aiSpotPlace = 6;
                    else if (i >= 111 && i <= 116)
                        aiSpotPlace = 7;
                    //ComputerRandom();
                    //ClearAll();
                }
                if ((values[i] == "2" && values[i + 11] == "2" && values[i + 22] == "2" && (nextAvailableCol1 == i + 33 || nextAvailableCol2 == i + 33 || nextAvailableCol3 == i + 33 || nextAvailableCol4 == i + 33 || nextAvailableCol5 == i + 33 || nextAvailableCol6 == i + 33 || nextAvailableCol7 == i + 33))
                    || (values[i] == "2" && values[i + 11] == "2" && values[i + 33] == "2" && (nextAvailableCol1 == i + 22 || nextAvailableCol2 == i + 22 || nextAvailableCol3 == i + 22 || nextAvailableCol4 == i + 22 || nextAvailableCol5 == i + 22 || nextAvailableCol6 == i + 22 || nextAvailableCol7 == i + 22))
                    || (values[i] == "2" && values[i + 22] == "2" && values[i + 33] == "2" && (nextAvailableCol1 == i + 11 || nextAvailableCol2 == i + 11 || nextAvailableCol3 == i + 11 || nextAvailableCol4 == i + 11 || nextAvailableCol5 == i + 11 || nextAvailableCol6 == i + 11 || nextAvailableCol7 == i + 11))
                    || (values[i + 11] == "2" && values[i + 22] == "2" && values[i + 33] == "2" && (nextAvailableCol1 == i || nextAvailableCol2 == i || nextAvailableCol3 == i || nextAvailableCol4 == i || nextAvailableCol5 == i || nextAvailableCol6 == i || nextAvailableCol7 == i)))
                {
                    if (i >= 39 && i <= 44)
                        aiSpotPlace = 1;
                    else if (i >= 51 && i <= 56)
                        aiSpotPlace = 2;
                    else if (i >= 63 && i <= 68)
                        aiSpotPlace = 3;
                    else if (i >= 75 && i <= 80)
                        aiSpotPlace = 4;
                    else if (i >= 87 && i <= 92)
                        aiSpotPlace = 5;
                    else if (i >= 99 && i <= 104)
                        aiSpotPlace = 6;
                    else if (i >= 111 && i <= 116)
                        aiSpotPlace = 7;
                    //ComputerRandom();
                    //ClearAll();
                }
            }
        }

        private void SwitchPlayer()
        {
            if (turn == 1)
            {
                if ((localGame == true) || (remoteGame == true))
                {
                    turn = 2;
                    lblPlayerTurn.Text = "Player 2's Turn";
                    playerColor = player2Color;
                    firstMove = false;
                }
                else
                {
                    firstMove = false;
                    ComputerWin();
                    ComputerRandom();
                }
            }
            else
            {
                turn = 1;
                lblPlayerTurn.Text = "Player 1's Turn";
                firstMove = false;
                playerColor = player1Color;
            }
        }

        private void ClearAll()
        {
            plays = new string[6][];
            for (int i = 0; i < 7; i++)
            {
                plays[i] = new string[5];
            }
            
            lblPlayerTurn.Text = "Player 1's Turn";
            ClearAllCircles();
            ClearAllRectangles();
            recButtonScreen.IsVisible = true;
            btnLocal.IsVisible = true;
            btnRemote.IsVisible = true;
            btnComputer.IsVisible = true;
            lblCodeText.IsVisible = false;
            lblGameCode.IsVisible = false;
            lblGameCode.Text = "TEST";
            btnStartGame.IsVisible = false;
            turn = 1;
            firstMove = true;
            localGame = false;
            remoteGame = false;
            aiGame = false;
        }

        private void CheckWinner()
        {
            string[] values = UnJaggedArray(plays);
            for (int i = 39; i < 117; i++)
            {
                string winner = values[i];
                if ((values[i] == "1" && values[i + 1] == "1" && values[i + 2] == "1" && values[i + 3] == "1") || (values[i] == "2" && values[i + 1] == "2" && values[i + 2] == "2" && values[i + 3] == "2"))
                {
                    WasWinner(winner);
                    break;
                }
                if ((values[i] == "1" && values[i + 13] == "1" && values[i + 26] == "1" && values[i + 39] == "1") || (values[i] == "2" && values[i + 13] == "2" && values[i + 26] == "2" && values[i + 39] == "2"))
                {
                    WasWinner(winner);
                    break;
                }
                if ((values[i] == "1" && values[i + 12] == "1" && values[i + 24] == "1" && values[i + 36] == "1") || (values[i] == "2" && values[i + 12] == "2" && values[i + 24] == "2" && values[i + 36] == "2"))
                {
                    WasWinner(winner);
                    break;
                }
                if ((values[i] == "1" && values[i + 11] == "1" && values[i + 22] == "1" && values[i + 33] == "1") || (values[i] == "2" && values[i + 11] == "2" && values[i + 22] == "2" && values[i + 33] == "2"))
                {
                    WasWinner(winner);
                    break;
                }
            }
        }

        private void WasWinner(string winner)
        {
            if (winner == "1")
                DisplayAlert("Player 1 WINNER!!!", "Game Winner!!", "OK");
            else
                if (aiGame == true)
                DisplayAlert("Computer Wins", "Game Winner!!", "OK");
            else
                DisplayAlert("Player 2 WINNER!!!", "Game Winner!!", "OK");

            ClearAll();
        }


        #region ColumnClickEvents

        /*
        private void btnCol1_Clicked(object sender, EventArgs e)
        {
            for (int i = 39; i < 45; i++)
            {
                if (values[i] == "0")
                {
                    values[i] = turn.ToString();
                    if (i == 44)
                    {
                        btnCol1.IsVisible = false;
                    }
                    break;
                }

            }
            if (values[39] != "0")
            {
                if (values[39] == "1")
                    rec39.Fill = new SolidColorBrush(playerColor);
                else
                    rec39.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol1 = 40;
            }
            if (values[40] != "0")
            {
                if (values[40] == "1")
                    rec40.Fill = new SolidColorBrush(playerColor);
                else
                    rec40.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol1 = 41;
            }
            if (values[41] != "0")
            {
                if (values[41] == "1")
                    rec41.Fill = new SolidColorBrush(playerColor);
                else
                    rec41.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol1 = 42;
            }
            if (values[42] != "0")
            {
                if (values[42] == "1")
                    rec42.Fill = new SolidColorBrush(playerColor);
                else
                    rec42.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol1 = 43;
            }
            if (values[43] != "0")
            {
                if (values[43] == "1")
                    rec43.Fill = new SolidColorBrush(playerColor);
                else
                    rec43.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol1 = 44;
            }
            if (values[44] != "0")
            {
                if (values[44] == "1")
                    rec44.Fill = new SolidColorBrush(playerColor);
                else
                    rec44.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol1 = 0;
            }
            CheckWinner();
            SwitchPlayer();
        }
        private void btnCol2_Clicked(object sender, EventArgs e)
        {
            for (int i = 51; i < 57; i++)
            {
                if (values[i] == "0")
                {
                    values[i] = turn.ToString();
                    if (i == 56)
                    {
                        btnCol2.IsVisible = false;
                    }
                    break;
                }

            }
            if (values[51] != "0")
            {
                if (values[51] == "1")
                    rec51.Fill = new SolidColorBrush(playerColor);
                else
                    rec51.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol2 = 52;
            }
            if (values[52] != "0")
            {
                if (values[52] == "1")
                    rec52.Fill = new SolidColorBrush(playerColor);
                else
                    rec52.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol2 = 53;
            }
            if (values[53] != "0")
            {
                if (values[53] == "1")
                    rec53.Fill = new SolidColorBrush(playerColor);
                else
                    rec53.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol2 = 54;
            }
            if (values[54] != "0")
            {
                if (values[54] == "1")
                    rec54.Fill = new SolidColorBrush(playerColor);
                else
                    rec54.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol2 = 55;
            }
            if (values[55] != "0")
            {
                if (values[55] == "1")
                    rec55.Fill = new SolidColorBrush(playerColor);
                else
                    rec55.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol2 = 56;
            }
            if (values[56] != "0")
            {
                if (values[56] == "1")
                    rec56.Fill = new SolidColorBrush(playerColor);
                else
                    rec56.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol2 = 0;
            }
            CheckWinner();
            SwitchPlayer();
        }

        private void btnCol3_Clicked(object sender, EventArgs e)
        {
            for (int i = 63; i < 69; i++)
            {
                if (values[i] == "0")
                {
                    values[i] = turn.ToString();
                    if (i == 68)
                    {
                        btnCol3.IsVisible = false;
                    }
                    break;
                }

            }
            if (values[63] != "0")
            {
                if (values[63] == "1")
                    rec63.Fill = new SolidColorBrush(playerColor);
                else
                    rec63.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol3 = 64;
            }
            if (values[64] != "0")
            {
                if (values[64] == "1")
                    rec64.Fill = new SolidColorBrush(playerColor);
                else
                    rec64.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol3 = 65;
            }
            if (values[65] != "0")
            {
                if (values[65] == "1")
                    rec65.Fill = new SolidColorBrush(playerColor);
                else
                    rec65.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol3 = 66;
            }
            if (values[66] != "0")
            {
                if (values[66] == "1")
                    rec66.Fill = new SolidColorBrush(playerColor);
                else
                    rec66.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol3 = 67;
            }
            if (values[67] != "0")
            {
                if (values[67] == "1")
                    rec67.Fill = new SolidColorBrush(playerColor);
                else
                    rec67.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol3 = 68;
            }
            if (values[68] != "0")
            {
                if (values[68] == "1")
                    rec68.Fill = new SolidColorBrush(playerColor);
                else
                    rec68.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol3 = 0;
            }
            CheckWinner();
            SwitchPlayer();
        }

        private void btnCol4_Clicked(object sender, EventArgs e)
        {
            for (int i = 75; i < 81; i++)
            {
                if (values[i] == "0")
                {
                    values[i] = turn.ToString();
                    if (i == 80)
                    {
                        btnCol4.IsVisible = false;
                    }
                    break;
                }

            }
            if (values[75] != "0")
            {
                if (values[75] == "1")
                    rec75.Fill = new SolidColorBrush(playerColor);
                else
                    rec75.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol4 = 76;
            }
            if (values[76] != "0")
            {
                if (values[76] == "1")
                    rec76.Fill = new SolidColorBrush(playerColor);
                else
                    rec76.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol4 = 77;
            }
            if (values[77] != "0")
            {
                if (values[77] == "1")
                    rec77.Fill = new SolidColorBrush(playerColor);
                else
                    rec77.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol4 = 78;
            }
            if (values[78] != "0")
            {
                if (values[78] == "1")
                    rec78.Fill = new SolidColorBrush(playerColor);
                else
                    rec78.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol4 = 79;
            }
            if (values[79] != "0")
            {
                if (values[79] == "1")
                    rec79.Fill = new SolidColorBrush(playerColor);
                else
                    rec79.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol4 = 80;
            }
            if (values[80] != "0")
            {
                if (values[80] == "1")
                    rec80.Fill = new SolidColorBrush(playerColor);
                else
                    rec80.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol4 = 0;
            }
            CheckWinner();
            SwitchPlayer();
        }

        private void btnCol5_Clicked(object sender, EventArgs e)
        {
            for (int i = 87; i < 93; i++)
            {
                if (values[i] == "0")
                {
                    values[i] = turn.ToString();
                    if (i == 92)
                    {
                        btnCol5.IsVisible = false;
                    }
                    break;
                }

            }
            if (values[87] != "0")
            {
                if (values[87] == "1")
                    rec87.Fill = new SolidColorBrush(playerColor);
                else
                    rec87.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol5 = 88;
            }
            if (values[88] != "0")
            {
                if (values[88] == "1")
                    rec88.Fill = new SolidColorBrush(playerColor);
                else
                    rec88.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol5 = 89;
            }
            if (values[89] != "0")
            {
                if (values[89] == "1")
                    rec89.Fill = new SolidColorBrush(playerColor);
                else
                    rec89.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol5 = 90;
            }
            if (values[90] != "0")
            {
                if (values[90] == "1")
                    rec90.Fill = new SolidColorBrush(playerColor);
                else
                    rec90.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol5 = 91;
            }
            if (values[91] != "0")
            {
                if (values[91] == "1")
                    rec91.Fill = new SolidColorBrush(playerColor);
                else
                    rec91.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol5 = 92;
            }
            if (values[92] != "0")
            {
                if (values[92] == "1")
                    rec92.Fill = new SolidColorBrush(playerColor);
                else
                    rec92.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol5 = 0;
            }
            CheckWinner();
            SwitchPlayer();
        }

        private void btnCol6_Clicked(object sender, EventArgs e)
        {
            for (int i = 99; i < 105; i++)
            {
                if (values[i] == "0")
                {
                    values[i] = turn.ToString();
                    if (i == 104)
                    {
                        btnCol6.IsVisible = false;
                    }
                    break;
                }

            }
            if (values[99] != "0")
            {
                if (values[99] == "1")
                    rec99.Fill = new SolidColorBrush(playerColor);
                else
                    rec99.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol6 = 100;
            }
            if (values[100] != "0")
            {
                if (values[100] == "1")
                    rec100.Fill = new SolidColorBrush(playerColor);
                else
                    rec100.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol6 = 101;
            }
            if (values[101] != "0")
            {
                if (values[101] == "1")
                    rec101.Fill = new SolidColorBrush(playerColor);
                else
                    rec101.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol6 = 102;
            }
            if (values[102] != "0")
            {
                if (values[102] == "1")
                    rec102.Fill = new SolidColorBrush(playerColor);
                else
                    rec102.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol6 = 103;
            }
            if (values[103] != "0")
            {
                if (values[103] == "1")
                    rec103.Fill = new SolidColorBrush(playerColor);
                else
                    rec103.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol6 = 104;
            }
            if (values[104] != "0")
            {
                if (values[104] == "1")
                    rec104.Fill = new SolidColorBrush(playerColor);
                else
                    rec104.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol6 = 0;
            }
            CheckWinner();
            SwitchPlayer();
        }

        private void btnCol7_Clicked(object sender, EventArgs e)
        {
            for (int i = 111; i < 117; i++)
            {
                if (values[i] == "0")
                {
                    values[i] = turn.ToString();
                    if (i == 116)
                    {
                        btnCol7.IsVisible = false;
                    }
                    break;
                }

            }
            if (values[111] != "0")
            {
                if (values[111] == "1")
                    rec111.Fill = new SolidColorBrush(playerColor);
                else
                    rec111.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol7 = 112;
            }
            if (values[112] != "0")
            {
                if (values[112] == "1")
                    rec112.Fill = new SolidColorBrush(playerColor);
                else
                    rec112.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol7 = 113;
            }
            if (values[113] != "0")
            {
                if (values[113] == "1")
                    rec113.Fill = new SolidColorBrush(playerColor);
                else
                    rec113.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol7 = 114;
            }
            if (values[114] != "0")
            {
                if (values[114] == "1")
                    rec114.Fill = new SolidColorBrush(playerColor);
                else
                    rec114.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol7 = 115;
            }
            if (values[115] != "0")
            {
                if (values[115] == "1")
                    rec115.Fill = new SolidColorBrush(playerColor);
                else
                    rec115.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol7 = 116;
            }
            if (values[116] != "0")
            {
                if (values[116] == "1")
                    rec116.Fill = new SolidColorBrush(playerColor);
                else
                    rec116.Fill = new SolidColorBrush(opponentColor);
                nextAvailableCol7 = 0;
            }
            CheckWinner();
            SwitchPlayer();
        }
        */

        #endregion

        #region Menu

        private void btnRemote_Clicked(object sender, EventArgs e)
        {
            lblCodeText.IsVisible = true;
            lblGameCode.IsVisible = true;
            btnStartGame.IsVisible = true;
            btnLocal.IsVisible = false;
            btnRemote.IsVisible = false;
            btnComputer.IsVisible = false;
            remoteGame = true;
            localGame = false;
            aiGame = false;
            turn = 1;
        }

        private void btnComputer_Clicked(object sender, EventArgs e)
        {
            recButtonScreen.IsVisible = false;
            btnLocal.IsVisible = false;
            btnRemote.IsVisible = false;
            btnComputer.IsVisible = false;
            aiGame = true;
            localGame = false;
            remoteGame = false;
            turn = 1;
        }

        private void btnStartGame_Clicked(object sender, EventArgs e)
        {
            recButtonScreen.IsVisible = false;
            btnStartGame.IsVisible = false;
            lblGameCode.IsVisible = false;
            lblCodeText.IsVisible = false;
        }

        private void btnLocal_Clicked(object sender, EventArgs e)
        {
            recButtonScreen.IsVisible = false;
            btnLocal.IsVisible = false;
            btnRemote.IsVisible = false;
            btnComputer.IsVisible = false;
            localGame = true;
            remoteGame = false;
            aiGame = false;
            turn = 1;
        }

        #endregion

        #region Drop Code

        private void btnDrop_Clicked(object sender, EventArgs e)
        {
            int sldValue = Convert.ToInt32(sldDrop.Value);
            ClearAllRectangles();
            switch (sldValue)
            {
                case 1:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[0][i] == "0")
                        {
                            plays[0][i] = turn.ToString();
                            int nextAvailableCol1 = 39 + i + 1;
                            
                            switch (i)
                            {
                                case 0:
                                    e6x1.Fill = new SolidColorBrush(playerColor);
                                    //r6x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x1.Fill = new SolidColorBrush(playerColor);
                                    //r5x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x1.Fill = new SolidColorBrush(playerColor);
                                    //r4x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x1.Fill = new SolidColorBrush(playerColor);
                                    //r3x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x1.Fill = new SolidColorBrush(playerColor);
                                    //r2x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x1.Fill = new SolidColorBrush(playerColor);
                                    //r1x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            EndTurn();
                        }
                        else if (i == 5)
                        {
                            DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[1][i] == "0")
                        {
                            plays[1][i] = turn.ToString();
                            int nextAvailableCol2 = 51 + i + 1;
                            
                            switch (i)
                            {
                                case 0:
                                    e6x2.Fill = new SolidColorBrush(playerColor);
                                    //r6x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x2.Fill = new SolidColorBrush(playerColor);
                                    //r5x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x2.Fill = new SolidColorBrush(playerColor);
                                    //r4x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x2.Fill = new SolidColorBrush(playerColor);
                                    //r3x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x2.Fill = new SolidColorBrush(playerColor);
                                    //r2x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x2.Fill = new SolidColorBrush(playerColor);
                                    //r1x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            EndTurn();
                        }
                        else if (i == 5)
                        {
                            DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[2][i] == "0")
                        {
                            plays[2][i] = turn.ToString();
                            int nextAvailableCol3 = 63 + i + 1;
                            
                            switch (i)
                            {
                                case 0:
                                    e6x3.Fill = new SolidColorBrush(playerColor);
                                    //r6x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x3.Fill = new SolidColorBrush(playerColor);
                                    //r5x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x3.Fill = new SolidColorBrush(playerColor);
                                    //r4x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x3.Fill = new SolidColorBrush(playerColor);
                                    //r3x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x3.Fill = new SolidColorBrush(playerColor);
                                    //r2x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x3.Fill = new SolidColorBrush(playerColor);
                                    //r1x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            EndTurn();
                        }
                        else if (i == 5)
                        {
                            DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[3][i] == "0")
                        {
                            plays[3][i] = turn.ToString();
                            int nextAvailableCol4 = 75 + i + 1;
                            
                            switch (i)
                            {
                                case 0:
                                    e6x4.Fill = new SolidColorBrush(playerColor);
                                    //r6x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x4.Fill = new SolidColorBrush(playerColor);
                                    //r5x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x4.Fill = new SolidColorBrush(playerColor);
                                    //r4x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x4.Fill = new SolidColorBrush(playerColor);
                                    //r3x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x4.Fill = new SolidColorBrush(playerColor);
                                    //r2x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x4.Fill = new SolidColorBrush(playerColor);
                                    //r1x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            EndTurn();
                        }
                        else if (i == 5)
                        {
                            DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[4][i] == "0")
                        {
                            plays[4][i] = turn.ToString();
                            int nextAvailableCol5 = 87 + i + 1;
                            
                            switch (i)
                            {
                                case 0:
                                    e6x5.Fill = new SolidColorBrush(playerColor);
                                    //r6x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x5.Fill = new SolidColorBrush(playerColor);
                                    //r5x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x5.Fill = new SolidColorBrush(playerColor);
                                    //r4x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x5.Fill = new SolidColorBrush(playerColor);
                                    //r3x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x5.Fill = new SolidColorBrush(playerColor);
                                    //r2x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x5.Fill = new SolidColorBrush(playerColor);
                                    //r1x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            EndTurn();
                        }
                        else if (i == 5)
                        {
                            DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 6:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[5][i] == "0")
                        {
                            plays[5][i] = turn.ToString();
                            int nextAvailableCol6 = 99 + i + 1;
                            
                            switch (i)
                            {
                                case 0:
                                    e6x6.Fill = new SolidColorBrush(playerColor);
                                    //r6x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x6.Fill = new SolidColorBrush(playerColor);
                                    //r5x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x6.Fill = new SolidColorBrush(playerColor);
                                    //r4x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x6.Fill = new SolidColorBrush(playerColor);
                                    //r3x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x6.Fill = new SolidColorBrush(playerColor);
                                    //r2x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x6.Fill = new SolidColorBrush(playerColor);
                                    //r1x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            EndTurn();
                        }
                        else if (i == 5)
                        {
                            DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
                case 7:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[6][i] == "0")
                        {
                            plays[6][i] = turn.ToString();
                            int nextAvailableCol7 = 111 + i + 1;

                            switch (i)
                            {
                                case 0:
                                    e6x7.Fill = new SolidColorBrush(playerColor);
                                    //r6x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    e5x7.Fill = new SolidColorBrush(playerColor);
                                    //r5x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    e4x7.Fill = new SolidColorBrush(playerColor);
                                    //r4x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    e3x7.Fill = new SolidColorBrush(playerColor);
                                    //r3x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    e2x7.Fill = new SolidColorBrush(playerColor);
                                    //r2x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    e1x7.Fill = new SolidColorBrush(playerColor);
                                    //r1x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                            EndTurn();
                        }
                        else if (i == 5)
                        {
                            DisplayAlert("Error", "Column is full", "OK");
                        }
                    }
                    break;
            }
        }

        private void sldDrop_DragCompleted(object sender, EventArgs e)
        {
            sldDrop.Value = Convert.ToInt32(sldDrop.Value);
            int sldValue = Convert.ToInt32(sldDrop.Value);
            ClearAllRectangles();
            switch (sldValue)
            {
                case 1:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[0][i] == "0")
                        {
                            //plays[0][i] = turn.ToString();
                            switch (i)
                            {
                                case 0:
                                    //e6x1.Fill = new SolidColorBrush(playerColor);
                                    r6x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    //e5x1.Fill = new SolidColorBrush(playerColor);
                                    r5x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    //e4x1.Fill = new SolidColorBrush(playerColor);
                                    r4x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    //e3x1.Fill = new SolidColorBrush(playerColor);
                                    r3x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    //e2x1.Fill = new SolidColorBrush(playerColor);
                                    r2x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    //e1x1.Fill = new SolidColorBrush(playerColor);
                                    r1x1.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                        }
                        //else if (i == 5)
                        //{
                        //    DisplayAlert("Error", "Column is full", "OK");
                        //}
                    }
                    break;
                case 2:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[1][i] == "0")
                        {
                            //plays[1][i] = turn.ToString();
                            switch (i)
                            {
                                case 0:
                                    //e6x2.Fill = new SolidColorBrush(playerColor);
                                    r6x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    //e5x2.Fill = new SolidColorBrush(playerColor);
                                    r5x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    //e4x2.Fill = new SolidColorBrush(playerColor);
                                    r4x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    //e3x2.Fill = new SolidColorBrush(playerColor);
                                    r3x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    //e2x2.Fill = new SolidColorBrush(playerColor);
                                    r2x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    //e1x2.Fill = new SolidColorBrush(playerColor);
                                    r1x2.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                        }
                        //else if (i == 5)
                        //{
                        //    DisplayAlert("Error", "Column is full", "OK");
                        //}
                    }
                    break;
                case 3:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[2][i] == "0")
                        {
                            //plays[2][i] = turn.ToString();
                            switch (i)
                            {
                                case 0:
                                    //e6x3.Fill = new SolidColorBrush(playerColor);
                                    r6x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    //e5x3.Fill = new SolidColorBrush(playerColor);
                                    r5x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    //e4x3.Fill = new SolidColorBrush(playerColor);
                                    r4x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    //e3x3.Fill = new SolidColorBrush(playerColor);
                                    r3x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    //e2x3.Fill = new SolidColorBrush(playerColor);
                                    r2x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    //e1x3.Fill = new SolidColorBrush(playerColor);
                                    r1x3.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                        }
                        //else if (i == 5)
                        //{
                        //    DisplayAlert("Error", "Column is full", "OK");
                        //}
                    }
                    break;
                case 4:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[3][i] == "0")
                        {
                            //plays[3][i] = turn.ToString();
                            switch (i)
                            {
                                case 0:
                                    //e6x4.Fill = new SolidColorBrush(playerColor);
                                    r6x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    //e5x4.Fill = new SolidColorBrush(playerColor);
                                    r5x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    //e4x4.Fill = new SolidColorBrush(playerColor);
                                    r4x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    //e3x4.Fill = new SolidColorBrush(playerColor);
                                    r3x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    //e2x4.Fill = new SolidColorBrush(playerColor);
                                    r2x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    //e1x4.Fill = new SolidColorBrush(playerColor);
                                    r1x4.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                        }
                        //else if (i == 5)
                        //{
                        //    DisplayAlert("Error", "Column is full", "OK");
                        //}
                    }
                    break;
                case 5:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[4][i] == "0")
                        {
                            //plays[4][i] = turn.ToString();
                            switch (i)
                            {
                                case 0:
                                    //e6x5.Fill = new SolidColorBrush(playerColor);
                                    r6x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    //e5x5.Fill = new SolidColorBrush(playerColor);
                                    r5x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    //e4x5.Fill = new SolidColorBrush(playerColor);
                                    r4x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    //e3x5.Fill = new SolidColorBrush(playerColor);
                                    r3x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    //e2x5.Fill = new SolidColorBrush(playerColor);
                                    r2x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    //e1x5.Fill = new SolidColorBrush(playerColor);
                                    r1x5.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                        }
                        //else if (i == 5)
                        //{
                        //    DisplayAlert("Error", "Column is full", "OK");
                        //}
                    }
                    break;
                case 6:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[5][i] == "0")
                        {
                            //plays[5][i] = turn.ToString();
                            switch (i)
                            {
                                case 0:
                                    //e6x6.Fill = new SolidColorBrush(playerColor);
                                    r6x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    //e5x6.Fill = new SolidColorBrush(playerColor);
                                    r5x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    //e4x6.Fill = new SolidColorBrush(playerColor);
                                    r4x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    //e3x6.Fill = new SolidColorBrush(playerColor);
                                    r3x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    //e2x6.Fill = new SolidColorBrush(playerColor);
                                    r2x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    //e1x6.Fill = new SolidColorBrush(playerColor);
                                    r1x6.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                        }
                        //else if (i == 5)
                        //{
                        //    DisplayAlert("Error", "Column is full", "OK");
                        //}
                    }
                    break;
                case 7:
                    for (int i = 0; i < 6; i++)
                    {
                        if (plays[6][i] == "0")
                        {
                            //plays[6][i] = turn.ToString();
                            switch (i)
                            {
                                case 0:
                                    //e6x7.Fill = new SolidColorBrush(playerColor);
                                    r6x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 1:
                                    //e5x7.Fill = new SolidColorBrush(playerColor);
                                    r5x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 2:
                                    //e4x7.Fill = new SolidColorBrush(playerColor);
                                    r4x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 3:
                                    //e3x7.Fill = new SolidColorBrush(playerColor);
                                    r3x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 4:
                                    //e2x7.Fill = new SolidColorBrush(playerColor);
                                    r2x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                                case 5:
                                    //e1x7.Fill = new SolidColorBrush(playerColor);
                                    r1x7.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                                    break;
                            }
                            i = 7;
                        }
                        //else if (i == 5)
                        //{
                        //    DisplayAlert("Error", "Column is full", "OK");
                        //}
                    }
                    break;
            }
        }

        #endregion

        private void ClearAllRectangles()
        {
            foreach (Rectangle rec in grdBoard)
            {
                //rec.Fill = new SolidColorBrush(Color.FromHex("#FFFFFF"));
                rec.Fill = null;
            }
            recBorder.Fill = boardColor;
        }
        private void ClearAllCircles()
        {
            foreach (Ellipse ell in grdBoard)
            {
                ell.Fill = new SolidColorBrush(Color.FromHex("#000000"));
            }
        }

        private void EndTurn()
        {
            ClearAllRectangles();
            CheckWinner();
            SwitchPlayer();
            /*
            if (remoteGame)
            {
                SaveBoard();
            }
            */
        }

        #region Array Conversion

        private string[] UnJaggedArray(string[][] jagged)
        {
            string[] unJagged = new string[156];
            for (int i = 0; i < 7; i++)
            {
                for (int ii = 0; ii < 6; ii++)
                {
                    int iii = 39 + ii + (i * 12);
                    unJagged[iii] = jagged[i][ii];
                }
            }
            return unJagged;
        }

        private string[][] ReJaggedArray(string[] unJagged)
        {
            string[][] jagged = new string[6][];
            jagged[0] = new string[5];
            jagged[1] = new string[5];
            jagged[2] = new string[5];
            jagged[3] = new string[5];
            jagged[4] = new string[5];
            jagged[5] = new string[5];
            jagged[6] = new string[5];
            for (int i = 0; i < 7; i++)
            {
                for (int ii = 0; ii < 6; ii++)
                {
                    int iii = 39 + ii + (i * 12);
                    jagged[i][ii] = unJagged[iii];
                }
            }
            return jagged;
        }

        #endregion

        #region Persistence

        private void LoadBoard()
        {
            string[] loadFromApi = new string[156];
            //api code here

            int player1turns = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int ii = 0; ii < 6; ii++)
                {
                    int iii = 39 + ii + (i * 12);
                    if (loadFromApi[iii] == "1")
                    {
                        player1turns++;
                    }
                }
            }

            int player2turns = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int ii = 0; ii < 6; ii++)
                {
                    int iii = 39 + ii + (i * 12);
                    if (loadFromApi[iii] == "2")
                    {
                        player2turns++;
                    }
                }
            }

            if (player1turns > player2turns)
            {
                turn = 2;
                lblPlayerTurn.Text = "Player 2's Turn";
                playerColor = player2Color;
                //if (playerNumber == 1)
                //{
                //    lblPlayerTurn.Text = "Waiting for Player 2's Turn...";
                //    btnDrop.IsEnabled = false;
                //}
            }
            else
            {
                turn = 1;
                lblPlayerTurn.Text = "Player 1's Turn";
                playerColor = player1Color;
                //if (playerNumber == 2)
                //{
                //    lblPlayerTurn.Text = "Waiting for Player 1's Turn...";
                //    btnDrop.IsEnabled = false;
                //}
            }

            plays = ReJaggedArray(loadFromApi);
            ClearAllRectangles();
            ClearAllCircles();
            LoadAllCircles();
            CheckWinner();
        }

        private void LoadAllCircles()
        {
            if (plays[0][0] == "1")
                e6x1.Fill = new SolidColorBrush(player1Color);
            else if (plays[0][0] == "2")
                e6x1.Fill = new SolidColorBrush(player2Color);
            if (plays[0][1] == "1")
                e5x1.Fill = new SolidColorBrush(player1Color);
            else if (plays[0][1] == "2")
                e5x1.Fill = new SolidColorBrush(player2Color);
            if (plays[0][2] == "1")
                e4x1.Fill = new SolidColorBrush(player1Color);
            else if (plays[0][2] == "2")
                e4x1.Fill = new SolidColorBrush(player2Color);
            if (plays[0][3] == "1")
                e3x1.Fill = new SolidColorBrush(player1Color);
            else if (plays[0][3] == "2")
                e3x1.Fill = new SolidColorBrush(player2Color);
            if (plays[0][4] == "1")
                e2x1.Fill = new SolidColorBrush(player1Color);
            else if (plays[0][4] == "2")
                e2x1.Fill = new SolidColorBrush(player2Color);
            if (plays[0][5] == "1")
                e1x1.Fill = new SolidColorBrush(player1Color);
            else if (plays[0][5] == "2")
                e1x1.Fill = new SolidColorBrush(player2Color);
            if (plays[1][0] == "1")
                e6x2.Fill = new SolidColorBrush(player1Color);
            else if (plays[1][0] == "2")
                e6x2.Fill = new SolidColorBrush(player2Color);
            if (plays[1][1] == "1")
                e5x2.Fill = new SolidColorBrush(player1Color);
            else if (plays[1][1] == "2")
                e5x2.Fill = new SolidColorBrush(player2Color);
            if (plays[1][2] == "1")
                e4x2.Fill = new SolidColorBrush(player1Color);
            else if (plays[1][2] == "2")
                e4x2.Fill = new SolidColorBrush(player2Color);
            if (plays[1][3] == "1")
                e3x2.Fill = new SolidColorBrush(player1Color);
            else if (plays[1][3] == "2")
                e3x2.Fill = new SolidColorBrush(player2Color);
            if (plays[1][4] == "1")
                e2x2.Fill = new SolidColorBrush(player1Color);
            else if (plays[1][4] == "2")
                e2x2.Fill = new SolidColorBrush(player2Color);
            if (plays[1][5] == "1")
                e1x2.Fill = new SolidColorBrush(player1Color);
            else if (plays[1][5] == "2")
                e1x2.Fill = new SolidColorBrush(player2Color);
            if (plays[2][0] == "1")
                e6x3.Fill = new SolidColorBrush(player1Color);
            else if (plays[2][0] == "2")
                e6x3.Fill = new SolidColorBrush(player2Color);
            if (plays[2][1] == "1")
                e5x3.Fill = new SolidColorBrush(player1Color);
            else if (plays[2][1] == "2")
                e5x3.Fill = new SolidColorBrush(player2Color);
            if (plays[2][2] == "1")
                e4x3.Fill = new SolidColorBrush(player1Color);
            else if (plays[2][2] == "2")
                e4x3.Fill = new SolidColorBrush(player2Color);
            if (plays[2][3] == "1")
                e3x3.Fill = new SolidColorBrush(player1Color);
            else if (plays[2][3] == "2")
                e3x3.Fill = new SolidColorBrush(player2Color);
            if (plays[2][4] == "1")
                e2x3.Fill = new SolidColorBrush(player1Color);
            else if (plays[2][4] == "2")
                e2x3.Fill = new SolidColorBrush(player2Color);
            if (plays[2][5] == "1")
                e1x3.Fill = new SolidColorBrush(player1Color);
            else if (plays[2][5] == "2")
                e1x3.Fill = new SolidColorBrush(player2Color);
            if (plays[3][0] == "1")
                e6x4.Fill = new SolidColorBrush(player1Color);
            else if (plays[3][0] == "2")
                e6x4.Fill = new SolidColorBrush(player2Color);
            if (plays[3][1] == "1")
                e5x4.Fill = new SolidColorBrush(player1Color);
            else if (plays[3][1] == "2")
                e5x4.Fill = new SolidColorBrush(player2Color);
            if (plays[3][2] == "1")
                e4x4.Fill = new SolidColorBrush(player1Color);
            else if (plays[3][2] == "2")
                e4x4.Fill = new SolidColorBrush(player2Color);
            if (plays[3][3] == "1")
                e3x4.Fill = new SolidColorBrush(player1Color);
            else if (plays[3][3] == "2")
                e3x4.Fill = new SolidColorBrush(player2Color);
            if (plays[3][4] == "1")
                e2x4.Fill = new SolidColorBrush(player1Color);
            else if (plays[3][4] == "2")
                e2x4.Fill = new SolidColorBrush(player2Color);
            if (plays[3][5] == "1")
                e1x4.Fill = new SolidColorBrush(player1Color);
            else if (plays[3][5] == "2")
                e1x4.Fill = new SolidColorBrush(player2Color);
            if (plays[4][0] == "1")
                e6x5.Fill = new SolidColorBrush(player1Color);
            else if (plays[4][0] == "2")
                e6x5.Fill = new SolidColorBrush(player2Color);
            if (plays[4][1] == "1")
                e5x5.Fill = new SolidColorBrush(player1Color);
            else if (plays[4][1] == "2")
                e5x5.Fill = new SolidColorBrush(player2Color);
            if (plays[4][2] == "1")
                e4x5.Fill = new SolidColorBrush(player1Color);
            else if (plays[4][2] == "2")
                e4x5.Fill = new SolidColorBrush(player2Color);
            if (plays[4][3] == "1")
                e3x5.Fill = new SolidColorBrush(player1Color);
            else if (plays[4][3] == "2")
                e3x5.Fill = new SolidColorBrush(player2Color);
            if (plays[4][4] == "1")
                e2x5.Fill = new SolidColorBrush(player1Color);
            else if (plays[4][4] == "2")
                e2x5.Fill = new SolidColorBrush(player2Color);
            if (plays[4][5] == "1")
                e1x5.Fill = new SolidColorBrush(player1Color);
            else if (plays[4][5] == "2")
                e1x5.Fill = new SolidColorBrush(player2Color);
            if (plays[5][0] == "1")
                e6x6.Fill = new SolidColorBrush(player1Color);
            else if (plays[5][0] == "2")
                e6x6.Fill = new SolidColorBrush(player2Color);
            if (plays[5][1] == "1")
                e5x6.Fill = new SolidColorBrush(player1Color);
            else if (plays[5][1] == "2")
                e5x6.Fill = new SolidColorBrush(player2Color);
            if (plays[5][2] == "1")
                e4x6.Fill = new SolidColorBrush(player1Color);
            else if (plays[5][2] == "2")
                e4x6.Fill = new SolidColorBrush(player2Color);
            if (plays[5][3] == "1")
                e3x6.Fill = new SolidColorBrush(player1Color);
            else if (plays[5][3] == "2")
                e3x6.Fill = new SolidColorBrush(player2Color);
            if (plays[5][4] == "1")
                e2x6.Fill = new SolidColorBrush(player1Color);
            else if (plays[5][4] == "2")
                e2x6.Fill = new SolidColorBrush(player2Color);
            if (plays[5][5] == "1")
                e1x6.Fill = new SolidColorBrush(player1Color);
            else if (plays[5][5] == "2")
                e1x6.Fill = new SolidColorBrush(player2Color);
            if (plays[6][0] == "1")
                e6x7.Fill = new SolidColorBrush(player1Color);
            else if (plays[6][0] == "2")
                e6x7.Fill = new SolidColorBrush(player2Color);
            if (plays[6][1] == "1")
                e5x7.Fill = new SolidColorBrush(player1Color);
            else if (plays[6][1] == "2")
                e5x7.Fill = new SolidColorBrush(player2Color);
            if (plays[6][2] == "1")
                e4x7.Fill = new SolidColorBrush(player1Color);
            else if (plays[6][2] == "2")
                e4x7.Fill = new SolidColorBrush(player2Color);
            if (plays[6][3] == "1")
                e3x7.Fill = new SolidColorBrush(player1Color);
            else if (plays[6][3] == "2")
                e3x7.Fill = new SolidColorBrush(player2Color);
            if (plays[6][4] == "1")
                e2x7.Fill = new SolidColorBrush(player1Color);
            else if (plays[6][4] == "2")
                e2x7.Fill = new SolidColorBrush(player2Color);
            if (plays[6][5] == "1")
                e1x7.Fill = new SolidColorBrush(player1Color);
            else if (plays[6][5] == "2")
                e1x7.Fill = new SolidColorBrush(player2Color);
        }

        private void SaveBoard()
        {
            string[] sendToApi = UnJaggedArray(plays);
            //api code here
        }

        #endregion

        private void btnStart_Clicked(object sender, EventArgs e)
        {

        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {

        }
    }
}