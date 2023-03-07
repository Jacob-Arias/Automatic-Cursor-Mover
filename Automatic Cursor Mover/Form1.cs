using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Automatic_Cursor_Mover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        int x;
        int y;
        int RIGHTDOWN = 0x0002;
        int RIGHTUP = 0x0004;


        private bool is_On = false;
        private int timerClock = -1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private int j = 0;
        private int movementPx = 100; //this is how far it will move right, up, left, and down

        private async void StartBTN_Click(object sender, EventArgs e)
        {
            x = 1920 / 2 - 190;
            y = 1080 / 2 - 150;
            int delayTime = 63; //63 = 1 min rotation
            int breakCounter = 0;
            timerClock = 0;


            if (myValue == "")
            {
                MessageBox.Show("You can't run the program without setting it up");
            }

            is_On = true;
            if (is_On == true)
            {
                if ((string)myValue == "yes")
                {
                    do
                    {
                        //Moves the mouse right by 100px
                        for (j = 0; j < movementPx; j++)
                        {
                            SetCursorPos(x + j, y);
                            await Task.Delay(delayTime);
                        }
                        //Moves the mouse back to OG Postition
                        for (j = movementPx - 1; j >= 0; j--)
                        {
                            SetCursorPos(x + j, y);
                            await Task.Delay(delayTime);
                        }

                        mouse_event(RIGHTDOWN, 0, 0, 0, 0);

                        //Moves the mouse up by 100px
                        for (j = 0; j < movementPx; j++)
                        {
                            SetCursorPos(x, y + j);
                            await Task.Delay(delayTime);
                        }
                        //Moves the mouse back to Og Position
                        for (j = movementPx - 1; j >= 0; j--)
                        {
                            SetCursorPos(x, y + j);
                            await Task.Delay(delayTime);
                        }

                        mouse_event(RIGHTUP, 0, 0, 0, 0);

                        //Moves the mouse left by 100px
                        for (j = 0; j < movementPx; j++)
                        {
                            SetCursorPos(x - j, y);
                            await Task.Delay(delayTime);
                        }

                        mouse_event(RIGHTDOWN, 0, 0, 0, 0);

                        //Moves the mouse back to OG Postition
                        for (j = movementPx - 1; j >= 0; j--)
                        {
                            SetCursorPos(x - j, y);
                            await Task.Delay(delayTime);
                        }
                        //Moves the mouse down by 100px
                        for (j = 0; j < movementPx; j++)
                        {
                            SetCursorPos(x, y - j);
                            await Task.Delay(delayTime);
                        }

                        mouse_event(RIGHTUP, 0, 0, 0, 0);

                        //Moves the mouse back to Og Position
                        for (j = movementPx - 1; j >= 0; j--)
                        {
                            SetCursorPos(x, y - j);
                            await Task.Delay(delayTime);
                        }
                    } while (timerClock == 0);
                }

                else
                {
                    for (int i = 0; i < timeLength; i++)
                    {
                        //Moves the mouse right by 100px
                        for (j = 0; j < movementPx; j++)
                        {
                            SetCursorPos(x + j, y);
                            await Task.Delay(delayTime);
                        }
                        //Moves the mouse back to OG Postition
                        for (j = movementPx - 1; j >= 0; j--)
                        {
                            SetCursorPos(x + j, y);
                            await Task.Delay(delayTime);
                        }

                        mouse_event(RIGHTDOWN, 0, 0, 0, 0);

                        //Moves the mouse up by 100px
                        for (j = 0; j < movementPx; j++)
                        {
                            SetCursorPos(x, y + j);
                            await Task.Delay(delayTime);
                        }
                        //Moves the mouse back to Og Position
                        for (j = movementPx - 1; j >= 0; j--)
                        {
                            SetCursorPos(x, y + j);
                            await Task.Delay(delayTime);
                        }

                        mouse_event(RIGHTUP, 0, 0, 0, 0);

                        //Moves the mouse left by 100px
                        for (j = 0; j < movementPx; j++)
                        {
                            SetCursorPos(x - j, y);
                            await Task.Delay(delayTime);
                        }

                        mouse_event(RIGHTDOWN, 0, 0, 0, 0);

                        //Moves the mouse back to OG Postition
                        for (j = movementPx - 1; j >= 0; j--)
                        {
                            SetCursorPos(x - j, y);
                            await Task.Delay(delayTime);
                        }
                        //Moves the mouse down by 100px
                        for (j = 0; j < movementPx; j++)
                        {
                            SetCursorPos(x, y - j);
                            await Task.Delay(delayTime);
                        }

                        mouse_event(RIGHTUP, 0, 0, 0, 0);

                        //Moves the mouse back to Og Position
                        for (j = movementPx - 1; j >= 0; j--)
                        {
                            SetCursorPos(x, y - j);
                            await Task.Delay(delayTime);
                        }

                        breakCounter++;

                        if(breakCounter == timeLength / breaks && breaks != 0)
                        {
                            for(int j = 0; j < breakLength * 60000; j += 5000)
                            {
                                mouse_event(RIGHTDOWN, 0, 0, 0, 0);
                                await Task.Delay(breakLength * 5000);
                                breakCounter = 0;
                                mouse_event(RIGHTUP, 0, 0, 0, 0);
                            }
                            breakCounter = 0;
                        }
                    }
                }
            }
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            is_On = false;
        }
    

        private void TimerBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
                if (keyData==(Keys.Q))
                {
                    Application.Exit();
                return true;
                }
                
            return base.ProcessCmdKey(ref msg, keyData);    
        }

        private int timeLength = 0;
        private int breaks = 0;
        private int breakLength = 0;
        private string message, title, myValue = "", myValue2 = "", myValue3 = "", myValue4 = "";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void setupBTN_Click(object sender, EventArgs e)
        {
            bool is_Allowed = false;

            message = "Do you want to run the program forever? (yes to run it forever, and no to set a time)";

            title = "Automatic Cursor Mover Setup";

            
            do
            {
                myValue = Interaction.InputBox(message, title);
                myValue.ToLower();


                if ((string)myValue == "yes")
                {
                    is_Allowed = true;
                    MessageBox.Show("Press start to run the program forever, when ready to stop press Q to end program");
                }
                else if ((string)myValue == "no")
                {
                    is_Allowed = true;
                    message = "How many minutes do you want to run the program for? (Not including time stopped for breaks)";
                    title = "Automatic Cursor Mover Setup";

                    myValue2 = Interaction.InputBox(message, title);
                    timeLength = int.Parse(myValue2);


                    message = "How many breaks do you want";
                    title = "Automatic Cursor Mover Setup";

                    myValue3 = Interaction.InputBox(message, title);
                    breaks = int.Parse(myValue3);

                    if(breaks != 0)
                    {
                        message = "How many minutes do you want the breaks to be";
                        title = "Automatic Cursor Mover Setup";

                        myValue4 = Interaction.InputBox(message, title);
                        breakLength = int.Parse(myValue4);
                    }

                }
                else
                {
                    MessageBox.Show("What you entered is not allowed, you can only enter yes or no");
                }
            } while (is_Allowed == false);
        }
    }
}
