namespace Team9.Connect4.MAUI
{
    public partial class MainPage : ContentPage
    {
        string[] values = new string[156];
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
        Color opponentColor = Color.FromRgb(255, 255, 0);

        public MainPage()
        {
            InitializeComponent();

            ClearAll();
        }

        #region ComputerRandom
        private void ComputerRandom()
        {
            turn = 2;
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
            if (choice == 1)
            {
                if (values[39] == "0")
                {
                    values[39] = "2";
                    rec39.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol1 = 40;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[40] == "0")
                {
                    values[40] = "2";
                    rec40.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol1 = 41;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[41] == "0")
                {
                    values[41] = "2";
                    rec41.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol1 = 42;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[42] == "0")
                {
                    values[42] = "2";
                    rec42.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol1 = 43;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[43] == "0")
                {
                    values[43] = "2";
                    rec43.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol1 = 44;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[44] == "0")
                {
                    values[44] = "2";
                    rec44.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol1 = 0;
                    btnCol1.IsVisible = false;
                    CheckWinner();
                    SwitchPlayer();
                }
                else
                {
                    btnCol1.IsVisible = false;
                    aiSpotPlace = 2;
                    ComputerRandom();
                }
            }
            else if (choice == 2)
            {
                if (values[51] == "0")
                {
                    values[51] = "2";
                    rec51.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol2 = 52;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[52] == "0")
                {
                    values[52] = "2";
                    rec52.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol2 = 53;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[53] == "0")
                {
                    values[53] = "2";
                    rec53.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol2 = 54;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[54] == "0")
                {
                    values[54] = "2";
                    rec54.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol2 = 55;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[55] == "0")
                {
                    values[55] = "2";
                    rec55.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol2 = 56;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[56] == "0")
                {
                    values[56] = "2";
                    rec56.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol2 = 0;
                    btnCol2.IsVisible = false;
                    CheckWinner();
                    SwitchPlayer();
                }
                else
                {
                    btnCol2.IsVisible = false;
                    aiSpotPlace = 3;
                    ComputerRandom();
                }
            }
            else if (choice == 3)
            {
                if (values[63] == "0")
                {
                    values[63] = "2";
                    rec63.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol3 = 64;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[64] == "0")
                {
                    values[64] = "2";
                    rec64.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol3 = 65;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[65] == "0")
                {
                    values[65] = "2";
                    rec65.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol3 = 66;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[66] == "0")
                {
                    values[66] = "2";
                    rec66.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol3 = 67;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[67] == "0")
                {
                    values[67] = "2";
                    rec67.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol3 = 68;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[68] == "0")
                {
                    values[68] = "2";
                    rec68.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol3 = 0;
                    btnCol3.IsVisible = false;
                    CheckWinner();
                    SwitchPlayer();
                }
                else
                {
                    btnCol3.IsVisible = false;
                    aiSpotPlace = 4;
                    ComputerRandom();
                }
            }
            else if (choice == 4)
            {
                if (values[75] == "0")
                {
                    values[75] = "2";
                    rec75.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol4 = 76;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[76] == "0")
                {
                    values[76] = "2";
                    rec76.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol4 = 77;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[77] == "0")
                {
                    values[77] = "2";
                    rec77.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol4 = 78;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[78] == "0")
                {
                    values[78] = "2";
                    rec78.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol4 = 79;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[79] == "0")
                {
                    values[79] = "2";
                    rec79.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol4 = 80;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[80] == "0")
                {
                    values[80] = "2";
                    rec80.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol4 = 0;
                    btnCol4.IsVisible = false;
                    CheckWinner();
                    SwitchPlayer();
                }
                else
                {
                    btnCol4.IsVisible = false;
                    aiSpotPlace = 5;
                    ComputerRandom();
                }
            }
            else if (choice == 5)
            {
                if (values[87] == "0")
                {
                    values[87] = "2";
                    rec87.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol5 = 88;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[88] == "0")
                {
                    values[88] = "2";
                    rec88.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol5 = 89;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[89] == "0")
                {
                    values[89] = "2";
                    rec89.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol5 = 90;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[90] == "0")
                {
                    values[90] = "2";
                    rec90.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol5 = 91;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[91] == "0")
                {
                    values[91] = "2";
                    rec91.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol5 = 92;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[92] == "0")
                {
                    values[92] = "2";
                    rec92.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol5 = 0;
                    btnCol5.IsVisible = false;
                    CheckWinner();
                    SwitchPlayer();
                }
                else
                {
                    btnCol5.IsVisible = false;
                    aiSpotPlace = 6;
                    ComputerRandom();
                }
            }
            else if (choice == 6)
            {
                if (values[99] == "0")
                {
                    values[99] = "2";
                    rec99.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol6 = 100;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[100] == "0")
                {
                    values[100] = "2";
                    rec100.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol6 = 101;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[101] == "0")
                {
                    values[101] = "2";
                    rec101.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol6 = 102;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[102] == "0")
                {
                    values[102] = "2";
                    rec102.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol6 = 103;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[103] == "0")
                {
                    values[103] = "2";
                    rec103.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol6 = 104;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[104] == "0")
                {
                    values[104] = "2";
                    rec104.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol6 = 0;
                    btnCol6.IsVisible = false;
                    CheckWinner();
                    SwitchPlayer();
                }
                else
                {
                    btnCol6.IsVisible = false;
                    aiSpotPlace = 7;
                    ComputerRandom();
                }
            }
            else if (choice == 7)
            {
                if (values[111] == "0")
                {
                    values[111] = "2";
                    rec111.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol7 = 112;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[112] == "0")
                {
                    values[112] = "2";
                    rec112.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol7 = 113;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[113] == "0")
                {
                    values[113] = "2";
                    rec113.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol7 = 114;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[114] == "0")
                {
                    values[114] = "2";
                    rec114.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol7 = 115;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[115] == "0")
                {
                    values[115] = "2";
                    rec115.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol7 = 116;
                    CheckWinner();
                    SwitchPlayer();
                }
                else if (values[116] == "0")
                {
                    values[116] = "2";
                    rec116.Fill = new SolidColorBrush(opponentColor);
                    nextAvailableCol7 = 0;
                    CheckWinner();
                    SwitchPlayer();
                }
                else
                {
                    btnCol7.IsVisible = false;
                    aiSpotPlace = 1;
                    ComputerRandom();
                }
            }
        }
        #endregion

        private void ComputerWin()
        {
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
                    ComputerRandom();
                    ClearAll();
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
                    ComputerRandom();
                    ClearAll();
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
                    ComputerRandom();
                    ClearAll();
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
                    ComputerRandom();
                    ClearAll();
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
                }
                else
                {
                    if (firstMove == false)
                        ComputerWin();
                    ComputerRandom();
                }

            }
            else
            {
                turn = 1;
                lblPlayerTurn.Text = "Player 1's Turn";
                firstMove = false;
            }
        }

        private void ClearAll()
        {
            for (int i = 0; i < 156; i++)
            {
                values[i] = "0";
            }
            rec44.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec43.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec42.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec41.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec40.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec39.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec56.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec55.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec54.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec53.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec52.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec51.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec68.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec67.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec66.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec65.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec64.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec63.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec80.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec79.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec78.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec77.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec76.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec75.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec92.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec91.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec90.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec89.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec88.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec87.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec104.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec103.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec102.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec101.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec100.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec99.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec116.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec115.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec114.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec113.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec112.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            rec111.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            lblPlayerTurn.Text = "Player 1's Turn";
            btnCol1.IsVisible = true;
            btnCol2.IsVisible = true;
            btnCol3.IsVisible = true;
            btnCol4.IsVisible = true;
            btnCol5.IsVisible = true;
            btnCol6.IsVisible = true;
            btnCol7.IsVisible = true;
            recButtonScreen.IsVisible = true;
            btnLocal.IsVisible = true;
            btnRemote.IsVisible = true;
            btnComputer.IsVisible = true;
            turn = 1;
            firstMove = true;
            localGame = false;
            remoteGame = false;
            aiGame = false;
            nextAvailableCol1 = 39;
            nextAvailableCol2 = 51;
            nextAvailableCol3 = 63;
            nextAvailableCol4 = 75;
            nextAvailableCol5 = 87;
            nextAvailableCol6 = 99;
            nextAvailableCol7 = 111;
            aiSpotPlace = 0;
        }

        private void CheckWinner()
        {
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
        #endregion

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
    }
}