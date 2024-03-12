using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbpltw_2
{
    public partial class Form1 : Form
    { } }
      
         

 public partial class Form1 : Form

        //CHANGE THE VALUE OF ALL FACE CARDS TO 10, AND THE ACE TO 11

        List<Card> cardList = new List<Card>()
        List<Card> playercardList = new List<Card>()
        {
            new Card() { Value  = 0, Name = "null", Image = "null" }
        };

        int cardSum = 0;

        List<Card> bankercardList = new List<Card>()
        {
            new Card() { Value  = 0, Name = "null", Image = "null" }
        };

        int playercardSum = 0;
        int bankercardSum = 0;
        Random random = new Random();
        List<int> usedCards = new List<int>();

        List<PictureBox> bankerbox = new List<PictureBox>();
        List<PictureBox> playerbox = new List<PictureBox>();


     

        List<Card> deck = new List<Card>()
 private void Form1_Load(object sender, EventArgs e)
            resetGame();
        }

         private void dealButton_Click(object sender, EventArgs e)
        //start the game 
         private void startButton_Click(object sender, EventArgs e)
        {
            if (cardSum > 0)
            if (playercardSum > 0)
            {
                    resultLabel.Text = String.Format
                    ("Click Reset");
                    ("Already started.");
            }

            else
            {
                displayCardBack(pictureBox3);

                cardSum = 0;
                playercardSum = 0;
                bankercardSum = 0;

                
                int randomCard1 = selectRandomCard();
                Card card1 = deck[randomCard1];
                usedCards.Add(randomCard1);
                int randomCard2 = selectRandomCard();

                if (randomCard1 == randomCard2) selectRandomCard();
                else randomCard2 = 1 * randomCard2;

                while (usedCards.Contains(randomCard2))
                {
                    randomCard2 = selectRandomCard();
                }
                randomCard2 = 1 * randomCard2;

                Card card2 = deck[randomCard2];
                usedCards.Add(randomCard2);

                cardList.Add(card1);
                cardList.Add(card2);
                playercardList.Add(card1);
                playercardList.Add(card2);

                pictureBox1.ImageLocation = card1.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox2.ImageLocation = card2.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

                sumCards();
                if (cardSum > 21)
                #endregion
                #region init banker
                int randomCard3 = selectRandomCard();
                while (usedCards.Contains(randomCard3))
                {
                    resultLabel.Text = String.Format
                        ("The sum of the cards is: {0}, you lose! Click Reset", cardSum);
                    randomCard3 = selectRandomCard();
                }
                randomCard3 = 1 * randomCard3;
                Card card3 = deck[randomCard3];
                usedCards.Add(randomCard3);

                bankercardList.Add(card3);

                pictureBox4.ImageLocation = card3.Image;
                pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;

              

                sumPlayerCards();

                else if (cardSum == 21)
                //sumCards();

                if (playercardSum == 21)
                {
                    resultLabel.Text = String.Format("The sum of the cards is: {0}, you win!",
                   cardSum);
                    resultLabel.Text = String.Format
                        ("The sum of your cards is: {0}, you win!", playercardSum);
                    MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetGame();
                }
                else
                    resultLabel.Text = String.Format("The sum of the cards is: {0}",
                       cardSum);


            }
        }

 private int selectRandomCard()
            return randomCard;
        }

        private int sumCards()
        private void sumPlayerCards()
        {
            playercardSum = 0;
            for (int i = 0; i < playercardList.Count; i++)
            {
                playercardSum += playercardList[i].Value;
            }

            for (int i = 0; i < cardList.Count; i++)
            if(playercardSum > 21)
            {
                cardSum += cardList[i].Value;
                foreach(Card c in playercardList)
                {
                    if(c.Value == 11)
                    {
                        playercardSum -= 10;
                        if(playercardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
            return cardSum;
        }

        private void hitMeButton_Click(object sender, EventArgs e)
        private void sumBankerCards()
        {
            bankercardSum = 0;
            for (int i = 0; i < bankercardList.Count; i++)
            {
                bankercardSum += bankercardList[i].Value;
            }
            if (bankercardSum > 21)
            {
                foreach (Card c in bankercardList)
                {
                    if (c.Value == 11)
                    {
                        bankercardSum -= 10;
                        if (bankercardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }
        // give one card to player
        private void DealButton_Click(object sender, EventArgs e)
        {
            if (cardSum == 0)
            if (playercardSum == 0)
            {
                resultLabel.Text = "Click the Deal button...";
                displayCardBack(pictureBox3);
                resultLabel.Text = "Click the Start button...";
                //displayCardBack(pictureBox3);
            }

            else
            {
                if (cardSum > 100)
                if (playercardSum > 100) //to be changed
                {
                    resetGame();
                    resultLabel.Text = "Resetting game... Click Deal when ready";
                    resultLabel.Text = "Resetting game...";
                }

                else
                {
                    cardSum = 0;
                    playercardSum = 0;
                    int randomCard = selectRandomCard();
                    Card card = deck[randomCard];
                    usedCards.Add(randomCard);

                    if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
                    else randomCard = 1 * randomCard;

                    pictureBox3.ImageLocation = card.Image;
                    pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
                    cardList.Add(card);
                    cardSum = sumCards();
                    if (cardSum > 21)

                    //player new card
                    PictureBox p3 = new PictureBox();
                    p3.Width = 71;
                    p3.Height = 96;
                    p3.Location = new Point(154 + 77 + playerbox.Count * 77, 137 );
                    p3.ImageLocation = card.Image;
                    p3.SizeMode = PictureBoxSizeMode.AutoSize;
                    this.Controls.Add(p3);

                    playerbox.Add(p3);

                    playercardList.Add(card);
                    sumPlayerCards();
                    if (playercardSum > 21)
                    {
                        resultLabel.Text = String.Format
                            ("The sum of the cards is: {0}, you lose! Click Reset", cardSum);
                            ("The sum of your cards is: {0}, you lose!", playercardSum);
                        MessageBox.Show("You lose!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resetGame();
                    }

                    else if (cardSum == 21)
                    else if (playercardSum == 21)
                    {
                        resultLabel.Text = String.Format
                            ("The sum of the cards is: {0}, you win!", cardSum);
                            ("The sum of your cards is: {0}, you win!", playercardSum);
                        MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resetGame();
                    }
                    else
                        resultLabel.Text = String.Format
                            ("The sum of the cards is: {0}", cardSum);
                }
            }
        }
 private void resetGame()

            displayCardBack(pictureBox1);
            displayCardBack(pictureBox2);
            displayCardBack(pictureBox3);

            cardSum = 0;
            cardList.Clear();
            //displayCardBack(pictureBox3);
            displayCardBack(pictureBox4);
            //displayCardBack(pictureBox6);
            foreach(PictureBox pb in playerbox)
            {
                this.Controls.Remove(pb);
            }
            playerbox = new List<PictureBox>();
            foreach (PictureBox pb in bankerbox)
            {
                this.Controls.Remove(pb);
            }
            bankerbox = new List<PictureBox>();

            playercardSum = 0;
            bankercardSum = 0;
            playercardList.Clear();
            bankercardList.Clear();
            usedCards.Clear();
            resultLabel.Text = "Click Deal when ready";
            resultLabel.Text = "Player choice";
        }

        private void displayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = "b1fv.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        // palyer stop move
        private void PlayerStopButton_Click(object sender, EventArgs e)
        {
            if (playercardSum == 0)
            {
                resultLabel.Text = "Click the Start button...";
                return;
            }
            sumBankerCards();

            //banker move
            while (bankercardSum <= 16)
            {
                int randomCard = selectRandomCard();
                Card card = deck[randomCard];
                usedCards.Add(randomCard);

                if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
                else randomCard = 1 * randomCard;

                PictureBox p4 = new PictureBox();
                p4.Width = 71;
                p4.Height = 96;
                p4.Location = new Point(154 + bankerbox.Count * 77, 12);
                p4.ImageLocation = card.Image;
                p4.SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(p4);


                bankerbox.Add(p4);

                bankercardList.Add(card);
                sumBankerCards();
            }

            if (bankercardSum > 21)
            {
                resultLabel.Text = String.Format
                    ("The sum of banker cards is: {0}, you lose!", bankercardSum);
                MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else if (playercardSum <= bankercardSum)
            {
                resultLabel.Text = String.Format
                    ("The sum of your cards is: {0}, you lose!", playercardSum);
                MessageBox.Show("You lose!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else
            {
                resultLabel.Text = String.Format
                    ("The sum of your cards is: {0}, you win!", playercardSum);
                MessageBox.Show("You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }

        }








    }
}
