using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjBlackJack
{
    public partial class Form1 : Form
    {
        /********************
         ****OUR VARIABLES****
         ***values may vary***
         ********************/
        Random r = new Random();

        String playerName = "";
        String cardPath = "";

        Boolean cpuStay = true;
        Boolean winDecide = false;

        int userBet = 0;
        int cpuBet = 0;
        int randUserCard1 = 0;
        int randUserCard2 = 0;
        int randUserCard3 = 0;
        int randUserCard4 = 0;
        int randUserCard5 = 0;
        int randCpuCard1 = 0;
        int randCpuCard2 = 0;
        int randCpuCard3 = 0;
        int randCpuCard4 = 0;
        int randCpuCard5 = 0;
        int cardValue = 0;
        int userMoney = 0;
        int cpuMoney = 0;
        int cpuScore = 0;
        int userScore = 0;
        int userHits = 2;
        int cpuHits = 2;


        public Form1()
        {
            InitializeComponent();
        }


        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Opens the "About" page
            Form3 frm = new Form3();
            frm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /*This section here gets the playerName input from Form2 and displays it here in Form1*/
            //Start
            playerName = Form2.playerName;
            if (playerName == "")
            {
                playerName = "Player";
            }
            lblName.Text = playerName + "'s Hand";
            //End

            //sets the amount of money you have to $100
            userMoney = 100;
            cpuMoney = 100;

            //Displays the Computer's money and the Players money
            lblUserMoney.Text = ("$" + Convert.ToString(userMoney));
            lblCpuMoney.Text = ("$" + Convert.ToString(cpuMoney));

            //Disables some buttons to prevent unwanted results
            btnDeal.Enabled = false;
            btnHit.Enabled = false;
            btnStay.Enabled = false;
            btnNext.Enabled = false;            
        }


        private void txtBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this code prevents all characters except for numbers to be input in txtBet.Text
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtBet_TextChanged(object sender, EventArgs e)
        {
            //this code prevents all characters except for numbers to be input in txtBet.Text
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBet.Text, "  ^ [0-9]"))
            {
                txtBet.Text = "";
            }
        }
     

        private void btnDeal_Click(object sender, EventArgs e)
        {
            
            /*****************************************************************DEAL  2 CARDS TO USER****************************************************************/
            //Get a card i.e. a random number.
            randUserCard1 = r.Next(1, 53); //Gets Value of User Card #1
            cardPath = Convert.ToString("pictures/cards/card" + randUserCard1 + ".png"); //Uses the Value of User Card #1 find the correct file path to the appropriate card

            //Construct the filename from the number.
            cardPath = "pictures/cards/card" + randUserCard1 + ".png";

            //Show the card using this filename.         
            picUserCard1.Image = Image.FromFile(cardPath); //Selects User Card #1 to be changed
            
            //Determine the true value of the card.
            cardValue = randUserCard1 % 13;

            //Check to see if we have drawn a King, Queen or Jack and assign it a value of 10.
            if (cardValue >= 11 || cardValue == 0)
            {
                cardValue = 10;
            }
            //Display the true value of the card.
            userScore = userScore + cardValue;
            lblUserScore.Text = userScore + "";

            /**************************************************************************Deal 2nd card**************************************************************/
            //Gets an original card value
            randUserCard2 = r.Next(1, 53);
            while (randUserCard2 == randUserCard1)
            {
                randUserCard2 = r.Next(1, 53);
            }

            cardPath = "pictures/cards/card" + randUserCard2 + ".png"; //Uses the Value of User Card #2 find the correct file path to the appropriate card

            picUserCard2.Image = Image.FromFile(cardPath); //Selects User Card #2 to be changed

            cardValue = randUserCard2 % 13;
          
            if (cardValue >= 11 || cardValue == 0)
            {
                cardValue = 10;
            }
         
            userScore = userScore + cardValue;
            lblUserScore.Text = userScore + "";


            /*****************************************************DEAL 2 CARDS TO COMPUTER*****************************************************/
            //Get a card i.e. a random number.
            //Gets an original card value
            randCpuCard1 = r.Next(1, 53);
            while (randCpuCard1 == randUserCard1 || randCpuCard1 == randUserCard2)
            {
                randCpuCard1 = r.Next(1, 53);
            }
            //Construct the filename from the number.
            cardPath = "pictures/cards/card" + randCpuCard1 + ".png";
            //Show the card using this filename.
            picCpuCard1.Image = Image.FromFile(cardPath); //Selects User Card #1 to be changed
            //Determine the true value of the card.
            cardValue = randCpuCard1 % 13;
            /*% will give you the remainder when the first number is divided by the second.*/
            //Check to see if we have drawn a King, Queen or Jack and assign it a value of 10.
            if (cardValue >= 11 || cardValue == 0)
            {
                cardValue = 10;
            }

            //Display the true value of the card.
            cpuScore = cpuScore + cardValue;
            lblCpuScore.Text = cpuScore + "";

            /***************************************************Deal 2nd card****************************************************/
            //Gets an original card value
            randCpuCard2 = r.Next(1, 53);
            while (randCpuCard2 == randUserCard1 || randCpuCard2 == randUserCard2 || randCpuCard2 == randCpuCard1)
            {
                randCpuCard2 = r.Next(1, 53);
            }
            cardPath = "pictures/cards/card" + randCpuCard2 + ".png";

            picCpuCard2.Image = Image.FromFile(cardPath); //Selects CPU Card #2 to be changed

            cardValue = randCpuCard2 % 13;

            if (cardValue >= 11 || cardValue == 0)
            {
                cardValue = 10;
            }

            cpuScore = cpuScore + cardValue;
            lblCpuScore.Text = cpuScore + "";

            btnHit.Enabled = true;
            btnStay.Enabled = true;
            btnDeal.Enabled = false;
        }


        private void btnBet_Click(object sender, EventArgs e)
        {
            //Tests if txtBet.Text is valid.
            //If txtbet.Text is blank, then tells the player to enter a bet.
            //Else, then sets txtBet.Text equal to betAmount. (This is to prevent an error)
            //Start
            if (txtBet.Text == "")
            {
                lblStatus.Text = "You must enter a bet!";
            }
            else
            {
                userBet = Convert.ToInt16(txtBet.Text);
            }
            //End

            //Tests if betAmount is valid.
            //If betAmout is greater than userMoney or betAmount = 0, then tells the player that the bet is not valid.
            //Start
            if (userBet > userMoney || userBet <= 0)
            {
                lblStatus.Text = "You must enter a valid bet!"; ;
            }
            else
            {                
                userMoney = userMoney - userBet;
                cpuBet = r.Next(1, cpuMoney + 1);
                cpuMoney = cpuMoney - cpuBet;
                lblCpuMoney.Text = "$" + Convert.ToString(cpuMoney);
                lblUserMoney.Text = "$" + Convert.ToString(userMoney);
                lblStatus.Text = "You bet $" + Convert.ToString(userBet) +", Computer bet $" + (Convert.ToString(cpuBet));


                btnBet.Enabled = false;
                txtBet.Enabled = false;
                btnDeal.Enabled = true;
            }
            //End
        }


        private void txtBet_KeyDown(object sender, KeyEventArgs e)
        {
            //Tests if txtBet.Text is valid.
            //If txtbet.Text is blank, then tells the player to enter a bet.
            //Else, then sets txtBet.Text equal to betAmount. (This is to prevent an error)
            //Start
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBet.Text == "")
                {
                    lblStatus.Text = "You must enter a bet!";
                }
                else
                {
                    userBet = Convert.ToInt16(txtBet.Text);
                }
                //End

                //Tests if betAmount is valid.
                //If betAmout is greater than userMoney or betAmount = 0, then tells the player that the bet is not valid.
                //Start
                if (userBet > userMoney || userBet <= 0)
                {
                    lblStatus.Text = "You must enter a valid bet!";
                }
                else
                {
                    userMoney = userMoney - userBet;
                    cpuBet = r.Next(1, cpuMoney + 1);
                    cpuMoney = cpuMoney - cpuBet;
                    lblCpuMoney.Text = "$" + Convert.ToString(cpuMoney);
                    lblUserMoney.Text = "$" + Convert.ToString(userMoney);
                    lblStatus.Text = "You bet $" + Convert.ToString(userBet) + ", Computer bet $" + (Convert.ToString(cpuBet));
                    btnBet.Enabled = false;
                    txtBet.Enabled = false;
                    btnDeal.Enabled = true;
                }
                //End
            }
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            this.Close(); //to turn off current app
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.Close(); //to turn off current app
                Application.Exit();
                System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            }
        }


        private void btnHit_Click(object sender, EventArgs e)
        {
            /*The variables userHits and cpuHits are used to determine which card in the hand to flip over
             * ie cpuHits == 3, flip over card 3 in the cpu's hand.
             * The variables start at 2 and are increased by 1 whenever the hit button is clicked. 
             * They don't start at 0, because both the user and computer already have 2 cards when the hit button is pressed.*/


            /****************************************************Code to deal a card to the user****************************************************/
            userHits++;
            //randNum = r.Next(1, 53);
            //cardPath = "pictures/cards/card" + randNum + ".png";

            if (userHits == 3)
            {
                //Gets an original card value
                randUserCard3 = r.Next(1, 53);
                while (randUserCard3 == randUserCard1 || randUserCard3 == randUserCard2 || randUserCard3 == randCpuCard1 || randUserCard3 == randCpuCard2)
                {
                    randUserCard3 = r.Next(1, 53);
                }
                cardPath = "pictures/cards/card" + randUserCard3 + ".png"; 
                picUserCard3.Image = Image.FromFile(cardPath);//Selects User Card #3 to be changed
                cardValue = randUserCard3 % 13;
            }
            else if (userHits == 4)
            {
                //Gets an original card value
                randUserCard4 = r.Next(1, 53);
                while (randUserCard4 == randUserCard1 || randUserCard4 == randUserCard2 || randUserCard4 == randCpuCard1 || randUserCard4 == randCpuCard2 || randUserCard4 == randUserCard3 || randUserCard4 == randCpuCard3)
                {
                    randUserCard4 = r.Next(1, 53);
                }
                cardPath = "pictures/cards/card" + randUserCard4 + ".png"; 
                picUserCard4.Image = Image.FromFile(cardPath);//Selects User Card #4 to be changed
                cardValue = randUserCard4 % 13;
            }
            else if (userHits == 5)
            {
                //Gets an original card value
                randUserCard5 = r.Next(1, 53);
                while (randUserCard5 == randUserCard1 || randUserCard5 == randUserCard2 || randUserCard5 == randCpuCard1 || randUserCard5 == randCpuCard2 || randUserCard5 == randUserCard3 || randUserCard5 == randUserCard4 || randUserCard5 == randCpuCard3 || randUserCard5 == randCpuCard4)
                {
                    randUserCard5 = r.Next(1, 53);
                }
                cardPath = "pictures/cards/card" + randUserCard5 + ".png"; 
                picUserCard5.Image = Image.FromFile(cardPath);//Selects User Card #5 to be changed
                cardValue = randUserCard5 % 13;
            }
            //cardValue = randNum % 13;

            if (cardValue >= 11 || cardValue == 0)
            {
                cardValue = 10;
            }

            userScore += cardValue;
            lblUserScore.Text = userScore + "";

            //CPU AI: if cpuScore is less than equal to 16, then it hits. Otherwise, it stays.
            if (cpuScore <= 16)
            {
                cpuStay = false;
            }
            else
            {
                cpuStay = true;
            }


            if (cpuStay == false)
            {
                /****************************************************Code to deal a card to the computer****************************************************/
                cpuHits++;
                
                if (cpuHits == 3)
                {
                    //Gets an original card value
                    randCpuCard3 = r.Next(1, 53);
                    while (randCpuCard3 == randUserCard1 || randCpuCard3 == randUserCard2 || randCpuCard3 == randCpuCard1 || randCpuCard3 == randCpuCard2 || randCpuCard3 == randUserCard3)
                    {
                        randCpuCard3 = r.Next(1, 53);
                    }
                    
                    cardPath = "pictures/cards/card" + randCpuCard3 + ".png"; 
                    picCpuCard3.Image = Image.FromFile(cardPath);//Selects CPU Card #3 to be changed
                    cardValue = randCpuCard3 % 13;
                }
                else if (cpuHits == 4)
                {
                    //Gets an original card value
                    randCpuCard4 = r.Next(1, 53);
                    while (randCpuCard4 == randUserCard1 || randCpuCard4 == randUserCard2 || randCpuCard4 == randCpuCard1 || randCpuCard4 == randCpuCard2 || randCpuCard4 == randUserCard3 || randCpuCard4 == randCpuCard3 || randCpuCard4 == randUserCard4)
                    {
                        randCpuCard4 = r.Next(1, 53);
                    }
                    cardPath = "pictures/cards/card" + randCpuCard4 + ".png"; 
                    picCpuCard4.Image = Image.FromFile(cardPath);//Selects CPU Card #4 to be changed
                    cardValue = randCpuCard4 % 13;
                }
                else if (cpuHits == 5)
                {
                    //Gets an original card value
                    randCpuCard5 = r.Next(1, 53);
                    while (randCpuCard5 == randUserCard1 || randCpuCard5 == randUserCard2 || randCpuCard5 == randCpuCard1 || randCpuCard5 == randCpuCard2 || randCpuCard5 == randUserCard3 || randCpuCard5 == randCpuCard3 || randCpuCard5 == randUserCard4 || randCpuCard5 == randCpuCard4 || randCpuCard5 == randUserCard5)
                    {
                        randCpuCard5 = r.Next(1, 53);
                    }
                    cardPath = "pictures/cards/card" + randCpuCard5 + ".png"; 
                    picCpuCard5.Image = Image.FromFile(cardPath);//Selects CPU Card #5 to be changed
                    cardValue = randCpuCard5 % 13;
                }
                //cardValue = randNum % 13;
                if (cardValue >= 11 || cardValue == 0)
                {
                    cardValue = 10;
                }

                cpuScore += cardValue;
                lblCpuScore.Text = cpuScore + "";
            }

            /************Check if either score is over 21 or if userHits is greater than equal to 5, then give all the money that was betted to the winner.**************/

            if (userScore > 21 && cpuScore > 21)
            {
                if (userScore == cpuScore)
                {
                    lblStatus.Text = "It's a draw!"; //lblStatus update: "It's a draw!"
                    cpuMoney += cpuBet; //CPU bets given back to CPU
                    userMoney += userBet; //Player bets given back to Player
                    lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                    lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
                }
                else if (cpuScore < userScore)
                {
                    lblStatus.Text = "Computer's score is closer to 21! You lose!"; //lblStatus update: "Computer's score is closer to 21! You lose!"
                    cpuMoney += cpuBet + userBet; //CPU bets and Player bets given to CPU
                    lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                    winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
                }
                else if (cpuScore > userScore)
                {
                    lblStatus.Text = "Your score is closer to 21! You win!"; //lblStatus update: ""Your score is closer to 21! You win!""
                    userMoney += cpuBet + userBet; //CPU bets and Player bets given to Player
                    lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
                    winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
                }
            }
            else if (userScore > 21)
            {
                lblStatus.Text = "Your score is over 21! You lose!"; //lblStatus update: "Your score is over 21! You lose!"
                cpuMoney += cpuBet + userBet; //CPU bets and Player bets given to CPU
                lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
            }
            else if (cpuScore > 21)
            {
                lblStatus.Text = "Computer's score is over 21! You win!"; //lblStatus update: "Computer's score is over 21! You win!"
                userMoney += cpuBet + userBet; //CPU bets and Player bets given to Player
                lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
                winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
            }
            else if (userHits >= 5)
            {
                if (userScore == cpuScore)
                {
                    lblStatus.Text = "It's a draw!"; //lblStatus update: "It's a draw!"
                    cpuMoney += cpuBet; //CPU bets given back to CPU
                    userMoney += userBet; //Player bets given back to Player
                    lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                    lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
                }
                else if (cpuScore < userScore)
                {
                    lblStatus.Text = "Your score is closer to 21! You win!"; //lblStatus update: ""Your score is closer to 21! You win!""
                    userMoney += cpuBet + userBet; //CPU bets and Player bets given to Player
                    lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
                    winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
                }
                else if (cpuScore > userScore)
                {
                    lblStatus.Text = "Computer's score is closer to 21! You lose!"; //lblStatus update: "Computer's score is closer to 21! You lose!"
                    cpuMoney += cpuBet + userBet; //CPU bets and Player bets given to CPU
                    lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                    winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
                }
            }


            /**********************************Check if either player has lost all their money, then declare the winner and offer a new game**********************************/

            if (winDecide == true || userHits >= 5) //This if statment ensures that this code is not executed unless a winner has been decided or if user hits is greater than equal to 5.
            {
                if (userMoney == 0)
                {
                    lblStatus.Text = "You ran out of money! You lose!"; //lblStatus update: "You ran out of money! You lose!"
                    Form5 frm = new Form5();
                    frm.Show();
                    btnNext.Enabled = false;
                }
                else if (cpuMoney == 0)
                {
                    lblStatus.Text = "The computer ran out of money! You win!"; //lblStatus update: "The computer ran out of money! You win!"
                    Form6 frm = new Form6();
                    frm.Show();
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnHit.Enabled = false;
                    btnStay.Enabled = false;
                    winDecide = false;
                }
             }
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            //CPU AI: if cpuScore is less than equal to 16, then it hits. Otherwise, it stays.


            //Come back to this so the computer can hit as many times as he wants until he is greater than 16

            while (cpuScore <= 16)
            {
                /****************************************************Code to deal a card to the computer****************************************************/
                cpuHits++;
                //randNum = r.Next(1, 53);
                //cardPath = "pictures/cards/card" + randNum + ".png";
                if (cpuHits == 3)
                {
                    //Gets an original card value
                    randCpuCard3 = r.Next(1, 53);
                    while (randCpuCard3 == randUserCard1 || randCpuCard3 == randUserCard2 || randCpuCard3 == randCpuCard1 || randCpuCard3 == randCpuCard2 || randCpuCard3 == randUserCard3 || randCpuCard3 == randCpuCard5 || randCpuCard3 == randUserCard4 || randCpuCard3 == randCpuCard4 || randCpuCard3 == randUserCard5)
                    {
                        randCpuCard3 = r.Next(1, 53);
                    }
                    cardPath = "pictures/cards/card" + randCpuCard3 + ".png";
                    picCpuCard3.Image = Image.FromFile(cardPath);//Selects CPU Card #3 to be changed
                    cardValue = randCpuCard3 % 13;
                }
                else if (cpuHits == 4)
                {
                    //Gets an original card value
                    randCpuCard4 = r.Next(1, 53);
                    while (randCpuCard4 == randUserCard1 || randCpuCard4 == randUserCard2 || randCpuCard4 == randCpuCard1 || randCpuCard4 == randCpuCard2 || randCpuCard4 == randUserCard3 || randCpuCard4 == randCpuCard3 || randCpuCard4 == randUserCard4 || randCpuCard4 == randCpuCard5 || randCpuCard4 == randUserCard5)
                    {
                        randCpuCard4 = r.Next(1, 53);
                    }
                    cardPath = "pictures/cards/card" + randCpuCard4 + ".png";
                    picCpuCard4.Image = Image.FromFile(cardPath);//Selects CPU Card #4 to be changed
                    cardValue = randCpuCard4 % 13;
                }
                else if (cpuHits == 5)
                {
                    //Gets an original card value
                    randCpuCard5 = r.Next(1, 53);
                    while (randCpuCard5 == randUserCard1 || randCpuCard5 == randUserCard2 || randCpuCard5 == randCpuCard1 || randCpuCard5 == randCpuCard2 || randCpuCard5 == randUserCard3 || randCpuCard5 == randCpuCard3 || randCpuCard5 == randUserCard4 || randCpuCard5 == randCpuCard4 || randCpuCard5 == randUserCard5)
                    {
                        randCpuCard5 = r.Next(1, 53);
                    }
                    cardPath = "pictures/cards/card" + randCpuCard5 + ".png";
                    picCpuCard5.Image = Image.FromFile(cardPath);//Selects CPU Card #5 to be changed
                    cardValue = randCpuCard5 % 13;
                }
                if (cardValue >= 11 || cardValue == 0)
                {
                    cardValue = 10;
                }

                cpuScore += cardValue;
                lblCpuScore.Text = cpuScore + "";
            }

            //Checks if the CPU went over 21 and decides a winner

            if (cpuScore > 21)
            {
                lblStatus.Text = "The computer's score is over 21! You win!"; //lblStatus update: "The computer's score is over 21! You win!"
                userMoney += cpuBet + userBet; //CPU bets and Player bets given to Player
                lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
            }
            else if (cpuScore == userScore)
            {
                lblStatus.Text = "It's a draw!"; //lblStatus update: "It's a draw!"
                cpuMoney += cpuBet; //CPU bets given back to CPU
                userMoney += userBet; //Player bets given back to Player
                lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
            }
            else if (cpuScore > userScore)
            {
                lblStatus.Text = "The computers' score is greater than yours! You lose!"; //lblStatus update: "The computers' score is greater than yours! You lose!"
                cpuMoney += cpuBet + userBet; //CPU bets and Player bets given to CPU
                lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
            }
            else if (cpuScore < userScore)
            {
                lblStatus.Text = "Your score is greater than the computer's! You win!"; //lblStatus update: "Your score is greater than the computer's! You win!"
                userMoney += cpuBet + userBet; //CPU bets and Player bets given to Player
                lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
            }

            if (userScore > 21 && cpuScore > 21)
            {
                if (userScore == cpuScore)
                {
                    lblStatus.Text = "Both players Went Over 21 And Drawed!"; //lblStatus update: "Both players Went Over 21 And Drawed!"
                    cpuMoney += cpuBet; //CPU bets given back to CPU
                    userMoney += userBet; //Player bets given back to Player
                    lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                    lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
                    winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
                }
                else if (cpuScore < userScore)
                {
                    lblStatus.Text = "Computer's Score Is Closer To 21! You Lose!"; //lblStatus update: "Computer's Score Is Closer To 21! You Lose!"
                    cpuMoney += cpuBet + userBet; //CPU bets and Player bets given to CPU
                    lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                    winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
                }
                else if (cpuScore > userScore)
                {
                    lblStatus.Text = "Your Score Is Closer To 21! You Win!"; //lblStatus update: "Your Score Is Closer To 21! You Win!"
                    userMoney += cpuBet + userBet; //CPU bets and Player bets given to Player
                    lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
                    winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
                }
            }
            else if (userScore > 21)
            {
                lblStatus.Text = "You Went Over 21, You Lose!"; //lblStatus update: "You went over 21, you lose!"
                cpuMoney += cpuBet + userBet; //CPU bets and Player bets given to CPU
                lblCpuMoney.Text = "$" + cpuMoney; //lblCpuMoney update: "$" + updated cpuMoney
                winDecide = true; //This enables later code to to be executed. (checking if player lost all money)
            }
            else if (cpuScore > 21)
            {
                lblStatus.Text = "The Computer Went Over 21, You Win!"; //lblStatus update: "The Computer went over 21, you win!"
                userMoney += cpuBet + userBet; //CPU bets and Player bets given to Player
                lblUserMoney.Text = "$" + userMoney; //lblUserMoney update: "$" + updated userMoney
                winDecide = true; //This enables later code to to be executed. (checking if player lost all money)


                /******************Check if either player has lost all their money, then declare the winner and offer a new game********************/

                if (userMoney == 0)
                {
                    lblStatus.Text = "You ran out of money! You lose!"; //lblStatus update: "You ran out of money! You lose!"
                    Form5 frm = new Form5();
                    frm.Show();
                    btnNext.Enabled = false;
                }
                else if (cpuMoney == 0)
                {
                    lblStatus.Text = "The computer ran out of money! You win!"; //lblStatus update: "The computer ran out of money! You win!"
                    Form6 frm = new Form6();
                    frm.Show();
                    btnNext.Enabled = false;
                }
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            /***************************************************Reset all bets and scores, change card images to the back***************************************************/
            txtBet.Text = "";
            cpuBet = 0;
            userBet = 0;
            cpuScore = 0;
            userScore = 0;
            cpuHits = 2;
            userHits = 2;
            picCpuCard1.Image = Image.FromFile("pictures/cards/card55.png");
            picCpuCard2.Image = Image.FromFile("pictures/cards/card55.png");
            picCpuCard3.Image = Image.FromFile("pictures/cards/card55.png");
            picCpuCard4.Image = Image.FromFile("pictures/cards/card55.png");
            picCpuCard5.Image = Image.FromFile("pictures/cards/card55.png");
            picUserCard1.Image = Image.FromFile("pictures/cards/card55.png");
            picUserCard2.Image = Image.FromFile("pictures/cards/card55.png");
            picUserCard3.Image = Image.FromFile("pictures/cards/card55.png");
            picUserCard4.Image = Image.FromFile("pictures/cards/card55.png");
            picUserCard5.Image = Image.FromFile("pictures/cards/card55.png");
            btnDeal.Enabled = false;
            btnBet.Enabled = true;
            btnHit.Enabled = false;
            btnStay.Enabled = false;
            btnNext.Enabled = false;
            txtBet.Enabled = true;
            lblStatus.Text = "Place Bet...";
            lblUserScore.Text = "-";
            lblCpuScore.Text = "-";
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sdsscomputers.com/SahagianMatthew/Assignments/Completed/BlackjackHowToPlay.html");//Opens the website's "How to Play" page
        }
    }
}