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

        public MainPage()
        {
            InitializeComponent();

            ClearAll();
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

        //private void CheckWinner()
        //{
        //    for (int i = 39; i < 117; i++)
        //    {
        //        string winner = values[i];
        //        if ((values[i] == "1" && values[i + 1] == "1" && values[i + 2] == "1" && values[i + 3] == "1") || (values[i] == "2" && values[i + 1] == "2" && values[i + 2] == "2" && values[i + 3] == "2"))
        //        {
        //            WasWinner(winner);
        //            break;
        //        }
        //        if ((values[i] == "1" && values[i + 13] == "1" && values[i + 26] == "1" && values[i + 39] == "1") || (values[i] == "2" && values[i + 13] == "2" && values[i + 26] == "2" && values[i + 39] == "2"))
        //        {
        //            WasWinner(winner);
        //            break;
        //        }
        //        if ((values[i] == "1" && values[i + 12] == "1" && values[i + 24] == "1" && values[i + 36] == "1") || (values[i] == "2" && values[i + 12] == "2" && values[i + 24] == "2" && values[i + 36] == "2"))
        //        {
        //            WasWinner(winner);
        //            break;
        //        }
        //        if ((values[i] == "1" && values[i + 11] == "1" && values[i + 22] == "1" && values[i + 33] == "1") || (values[i] == "2" && values[i + 11] == "2" && values[i + 22] == "2" && values[i + 33] == "2"))
        //        {
        //            WasWinner(winner);
        //            break;
        //        }
        //    }
        //}

        //private void ComputerWin()
        //{
        //    for (int i = 39; i < 117; i++)
        //    {
        //        string winner = values[i];
        //        if ((values[i] == "2" && values[i + 1] == "2" && values[i + 2] == "2" && (nextAvailableCol1 == i + 3 || nextAvailableCol2 == i + 3 || nextAvailableCol3 == i + 3 || nextAvailableCol4 == i + 3 || nextAvailableCol5 == i + 3 || nextAvailableCol6 == i + 3 || nextAvailableCol7 == i + 3))
        //            || (values[i] == "2" && values[i + 1] == "2" && values[i + 3] == "2" && (nextAvailableCol1 == i + 2 || nextAvailableCol2 == i + 2 || nextAvailableCol3 == i + 2 || nextAvailableCol4 == i + 2 || nextAvailableCol5 == i + 2 || nextAvailableCol6 == i + 2 || nextAvailableCol7 == i + 2))
        //            || (values[i] == "2" && values[i + 2] == "2" && values[i + 3] == "2" && (nextAvailableCol1 == i + 1 || nextAvailableCol2 == i + 1 || nextAvailableCol3 == i + 1 || nextAvailableCol4 == i + 1 || nextAvailableCol5 == i + 1 || nextAvailableCol6 == i + 1 || nextAvailableCol7 == i + 1))
        //            || (values[i + 1] == "2" && values[i + 2] == "2" && values[i + 3] == "2" && (nextAvailableCol1 == i || nextAvailableCol2 == i || nextAvailableCol3 == i || nextAvailableCol4 == i || nextAvailableCol5 == i || nextAvailableCol6 == i || nextAvailableCol7 == i)))
        //        {
        //            if (i >= 39 && i <= 44)
        //                aiSpotPlace = 1;
        //            else if (i >= 51 && i <= 56)
        //                aiSpotPlace = 2;
        //            else if (i >= 63 && i <= 68)
        //                aiSpotPlace = 3;
        //            else if (i >= 75 && i <= 80)
        //                aiSpotPlace = 4;
        //            else if (i >= 87 && i <= 92)
        //                aiSpotPlace = 5;
        //            else if (i >= 99 && i <= 104)
        //                aiSpotPlace = 6;
        //            else if (i >= 111 && i <= 116)
        //                aiSpotPlace = 7;
        //            ComputerRandom();
        //            ClearAll();
        //        }
        //        if ((values[i] == "2" && values[i + 13] == "2" && values[i + 26] == "2" && (nextAvailableCol1 == i + 39 || nextAvailableCol2 == i + 39 || nextAvailableCol3 == i + 39 || nextAvailableCol4 == i + 39 || nextAvailableCol5 == i + 39 || nextAvailableCol6 == i + 39 || nextAvailableCol7 == i + 39))
        //            || (values[i] == "2" && values[i + 13] == "2" && values[i + 39] == "2" && (nextAvailableCol1 == i + 26 || nextAvailableCol2 == i + 26 || nextAvailableCol3 == i + 26 || nextAvailableCol4 == i + 26 || nextAvailableCol5 == i + 26 || nextAvailableCol6 == i + 26 || nextAvailableCol7 == i + 26))
        //            || (values[i] == "2" && values[i + 13] == "2" && values[i + 26] == "2" && (nextAvailableCol1 == i + 13 || nextAvailableCol2 == i + 13 || nextAvailableCol3 == i + 13 || nextAvailableCol4 == i + 13 || nextAvailableCol5 == i + 13 || nextAvailableCol6 == i + 13 || nextAvailableCol7 == i + 13))
        //            || (values[i + 13] == "2" && values[i + 26] == "2" && values[i + 39] == "2" && (nextAvailableCol1 == i || nextAvailableCol2 == i || nextAvailableCol3 == i || nextAvailableCol4 == i || nextAvailableCol5 == i || nextAvailableCol6 == i || nextAvailableCol7 == i)))
        //        {
        //            if (i >= 39 && i <= 44)
        //                aiSpotPlace = 1;
        //            else if (i >= 51 && i <= 56)
        //                aiSpotPlace = 2;
        //            else if (i >= 63 && i <= 68)
        //                aiSpotPlace = 3;
        //            else if (i >= 75 && i <= 80)
        //                aiSpotPlace = 4;
        //            else if (i >= 87 && i <= 92)
        //                aiSpotPlace = 5;
        //            else if (i >= 99 && i <= 104)
        //                aiSpotPlace = 6;
        //            else if (i >= 111 && i <= 116)
        //                aiSpotPlace = 7;
        //            ComputerRandom();
        //            ClearAll();
        //        }
        //        if ((values[i] == "2" && values[i + 12] == "2" && values[i + 24] == "2" && (nextAvailableCol1 == i + 36 || nextAvailableCol2 == i + 36 || nextAvailableCol3 == i + 36 || nextAvailableCol4 == i + 36 || nextAvailableCol5 == i + 36 || nextAvailableCol6 == i + 36 || nextAvailableCol7 == i + 36))
        //            || (values[i] == "2" && values[i + 12] == "2" && values[i + 36] == "2" && (nextAvailableCol1 == i + 24 || nextAvailableCol2 == i + 24 || nextAvailableCol3 == i + 24 || nextAvailableCol4 == i + 24 || nextAvailableCol5 == i + 24 || nextAvailableCol6 == i + 24 || nextAvailableCol7 == i + 24))
        //            || (values[i] == "2" && values[i + 24] == "2" && values[i + 36] == "2" && (nextAvailableCol1 == i + 12 || nextAvailableCol2 == i + 12 || nextAvailableCol3 == i + 12 || nextAvailableCol4 == i + 12 || nextAvailableCol5 == i + 12 || nextAvailableCol6 == i + 12 || nextAvailableCol7 == i + 12))
        //            || (values[i + 12] == "2" && values[i + 24] == "2" && values[i + 36] == "2" && (nextAvailableCol1 == i || nextAvailableCol2 == i || nextAvailableCol3 == i || nextAvailableCol4 == i || nextAvailableCol5 == i || nextAvailableCol6 == i || nextAvailableCol7 == i)))
        //        {
        //            if (i >= 39 && i <= 44)
        //                aiSpotPlace = 1;
        //            else if (i >= 51 && i <= 56)
        //                aiSpotPlace = 2;
        //            else if (i >= 63 && i <= 68)
        //                aiSpotPlace = 3;
        //            else if (i >= 75 && i <= 80)
        //                aiSpotPlace = 4;
        //            else if (i >= 87 && i <= 92)
        //                aiSpotPlace = 5;
        //            else if (i >= 99 && i <= 104)
        //                aiSpotPlace = 6;
        //            else if (i >= 111 && i <= 116)
        //                aiSpotPlace = 7;
        //            ComputerRandom();
        //            ClearAll();
        //        }
        //        if ((values[i] == "2" && values[i + 11] == "2" && values[i + 22] == "2" && (nextAvailableCol1 == i + 33 || nextAvailableCol2 == i + 33 || nextAvailableCol3 == i + 33 || nextAvailableCol4 == i + 33 || nextAvailableCol5 == i + 33 || nextAvailableCol6 == i + 33 || nextAvailableCol7 == i + 33))
        //            || (values[i] == "2" && values[i + 11] == "2" && values[i + 33] == "2" && (nextAvailableCol1 == i + 22 || nextAvailableCol2 == i + 22 || nextAvailableCol3 == i + 22 || nextAvailableCol4 == i + 22 || nextAvailableCol5 == i + 22 || nextAvailableCol6 == i + 22 || nextAvailableCol7 == i + 22))
        //            || (values[i] == "2" && values[i + 22] == "2" && values[i + 33] == "2" && (nextAvailableCol1 == i + 11 || nextAvailableCol2 == i + 11 || nextAvailableCol3 == i + 11 || nextAvailableCol4 == i + 11 || nextAvailableCol5 == i + 11 || nextAvailableCol6 == i + 11 || nextAvailableCol7 == i + 11))
        //            || (values[i + 11] == "2" && values[i + 22] == "2" && values[i + 33] == "2" && (nextAvailableCol1 == i || nextAvailableCol2 == i || nextAvailableCol3 == i || nextAvailableCol4 == i || nextAvailableCol5 == i || nextAvailableCol6 == i || nextAvailableCol7 == i)))
        //        {
        //            if (i >= 39 && i <= 44)
        //                aiSpotPlace = 1;
        //            else if (i >= 51 && i <= 56)
        //                aiSpotPlace = 2;
        //            else if (i >= 63 && i <= 68)
        //                aiSpotPlace = 3;
        //            else if (i >= 75 && i <= 80)
        //                aiSpotPlace = 4;
        //            else if (i >= 87 && i <= 92)
        //                aiSpotPlace = 5;
        //            else if (i >= 99 && i <= 104)
        //                aiSpotPlace = 6;
        //            else if (i >= 111 && i <= 116)
        //                aiSpotPlace = 7;
        //            ComputerRandom();
        //            ClearAll();
        //        }
        //    }
        //}

        private void btnCol1_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCol2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCol4_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCol5_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCol6_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCol7_Clicked(object sender, EventArgs e)
        {

        }

        private void btnLocal_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRemote_Clicked(object sender, EventArgs e)
        {

        }

        private void btnComputer_Clicked(object sender, EventArgs e)
        {

        }
    }
}