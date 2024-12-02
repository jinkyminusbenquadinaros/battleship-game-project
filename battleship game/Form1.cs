using System.Diagnostics;

namespace battleship_game
{
    public partial class Form1 : Form
    {
        List<Button> playerPositionButtons;
        List<Button> enemyPositionButtons;
        Random Random = new Random();

        int ships = 3;
        int round = 10;
        int playerScore;
        int enemyScore;

        public Form1()
        {
            InitializeComponent();
            Restartthedamngame();
        }

        private void EnemyPlayTimerEvent(object sender, EventArgs e)
        {

            round -= 1;
            txtRounds.Text = "round - " + round;

            int integer = Random.Next(playerPositionButtons.Count);
            // randomly selects something with the playerbuttons as its parameter
            if ((string)playerPositionButtons[integer].Tag == "playerShip")
            {
                playerPositionButtons[integer].BackgroundImage = Properties.Resources.fireIcon;
                // if they hit it shows a fire picture thats been imported that counts as file handling right
                enemyMove.Text = playerPositionButtons[integer].Text;
                playerPositionButtons[integer].Enabled = false;
                // if it gets hit it gets disabled
                playerPositionButtons[integer].BackColor = Color.Black;

            }



        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {
            if (EnemyLocationListBox.Text != "")
            {
                var attackPosition = EnemyLocationListBox.Text.ToLower();
                // reason we put it to lower is because we want to compare this to the names of the buttons whiich are lower case
                int integer = enemyPositionButtons.FindIndex(a => a.Name == attackPosition);
                // integer going to store a number which is the number where attack position is at
                // the local variable stuff was gotten from stack overflow it just checks if the name of the variable is equal to attackposition
                // not fully sure what this does as im doing a final skim of this bit but it works

                if (enemyPositionButtons[integer].Enabled && round > 0)
                {
                    round -= 1;
                    // take one away as this round would have gone away
                    txtRounds.Text = "round - " + round;
                    // shows what the round is
                    if ((string)enemyPositionButtons[integer].Tag == "enemyShip")
                    {
                        enemyPositionButtons[integer].Enabled = false;
                        // if the button is enemy ship it gets disabled
                        enemyPositionButtons[integer].BackgroundImage = Properties.Resources.fireIcon;
                        // shows that its been hit with the png thats been imported i tried to use picture box and do it in with files but that ended in tragedy
                        enemyPositionButtons[integer].BackColor = Color.Black;
                        playerScore += 1;
                        // just adds one to playerscore as they hit something
                        txtPlayer.Text = playerScore.ToString();
                        // makes the score the text
                        EnemyPlayTimer.Start();


                    }
                    else 
                    {
                        enemyPositionButtons[integer].Enabled = false;
                        enemyPositionButtons[integer].BackgroundImage = Properties.Resources.missIcon;
                        // same as the fire but this time it didnt hit a ship so
                        enemyPositionButtons[integer].BackColor = Color.Black;
                        EnemyPlayTimer.Start();
                    }

                }
            }
            else
            {
                MessageBox.Show("Choose a location from the dropdown first", "IMPORTANT NOTICE");
                // doesnt let people attack without selecting something as that would probably break it or do something peculiar that im not trying t0 deal with 
                // this sucked to find out how to do when its so easy
            }
        }

        private void PlayerPositionButtonEvent(object sender, EventArgs e)
        {
            if (ships > 0)
            {
                var button = (Button)sender;
                // i crate a variable called button and then we identify whicever button was pressed as the sender event
                button.Enabled = false;
                button.Tag = "playership";
                button.BackColor = Color.Orange;
                // disabled the button and tagged it as player ship
                // the fact we have to spell colour as color is not cool at all
                ships -= 1;
                // you can see it just takes away one from the ship counter
            }
            if (ships == 0)
            {
                btnAttack.Enabled = true;
                btnAttack.BackColor = Color.Red;
                // just want a menacing colour that isnt orange so i picked red
                btnAttack.ForeColor = Color.White;

                txtHelp.Text = " now finally pick the attack position from the drop down menu and press attack";
            }



        }
        private void Restartthedamngame()
        {
            // planning to have near enough entire game in here so i have to keep track of the least amount of things will see how things go 
            playerPositionButtons = new List<Button>{w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4};
            enemyPositionButtons = new List<Button>{a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4};
            // each list holds the co ordinates of the grid
            EnemyLocationListBox.Items.Clear();
            // clears the list box everytime game restars so doesnt get clunky asf
            EnemyLocationListBox.Text = null;
            //we dont want any text to show up yet
            txtHelp.Text = "click on 3 buttons to start the game";
            for (int i = 0; i < enemyPositionButtons.Count; i++) //iterates through each button 
            {
                enemyPositionButtons[i].Enabled = true;
                enemyPositionButtons[i].Tag = null;
                //when enemy selects a location we link it to their ship with tag this needs to be nullified at the start
                enemyPositionButtons[i].BackColor = Color.White;
                //just sets the colour to white
                enemyPositionButtons[i].BackgroundImage = null;
                // theres going to be a flame png or x png when it either hits something or hits nish currently its neither so its null
                EnemyLocationListBox.Items.Add(enemyPositionButtons[i].Text);
                // adds to the list the text of the buttons its iterating through so each one is listed and can then be selected to attack :o
            }
            for (int i = 0; i < playerPositionButtons.Count; i++)
            {
                playerPositionButtons[i].Enabled = true;
                playerPositionButtons[i].Tag = null;
                playerPositionButtons[i] .BackColor = Color.White;
                playerPositionButtons[i].BackgroundImage = null;
                // same as before but this time we aint adding anything to the list
            }
            playerScore = 0;
            enemyScore = 0;
            round = 10;
            ships = 3;
            txtPlayer.Text = playerScore.ToString();
            txtEnemy.Text = enemyScore.ToString();
            // changing the text of the scores into their scores so you cna actually see how well youre doing 
            enemyMove.Text = "A1";
            btnAttack.Enabled = false;
            // dont want them to attack just yet
            enemyLocationPicker();
        }
        private void enemyLocationPicker()
        {
           
            
            for (int i = 0; i < 3; i++)
            {
                int integer = Random.Next(enemyPositionButtons.Count);
                if (enemyPositionButtons[integer].Enabled == true && (string)enemyPositionButtons[integer].Tag == null)
                {
                    enemyPositionButtons[integer].Tag = "enemyShip";
                    Debug.WriteLine("Enemy position: " + enemyPositionButtons[integer].Text);
                    // stole this from stack overflow in the debug menu it should show the 3 locations that it has picked so the person in control can see
                    // with this condition i can win whenever i want and hustle people as they dont realise i can see the positions in the bottom right if i so choose
                }
                else
                {
                    integer = Random.Next(enemyPositionButtons.Count);
                    // if we run into something that is enabled but it has a tag it redos this until it gets to 3
                }
            }
        }
    }
}
