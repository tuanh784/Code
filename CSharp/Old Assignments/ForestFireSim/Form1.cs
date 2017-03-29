using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestFireSim
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        //[columns, rows]
        int[,] forest = new int[150, 150];
        Brush greenB = new SolidBrush(Color.Green);
        Brush blackB = new SolidBrush(Color.Black);
        Brush redB = new SolidBrush(Color.Red);
        LinkList toBurn = new LinkList();
        LinkList burning = new LinkList();
        Boolean isActive;

        public Form1()
        {
            InitializeComponent();
        }
        //set up the forest using the density from textbox
        private void setupBtn_Click(object sender, EventArgs e)
        {
            string InputDensity = treeDensity.Text;
            double density = Convert.ToDouble(InputDensity) *100;
            forest = new int[150, 150];
            for (int column = 0; column < 150; column++)
            {
                for (int row = 0; row < 150; row++)
                {
                    if (rng.Next(1,100) <= density)
                        forest[column, row] = 1;
                }
            }
            isActive = true;
            timer1.Stop();
            pictureBox1.Invalidate();
        }
        //start the fire from the left side of the forest and start the timer which will iterate the burning
        private void fireBtn_Click(object sender, EventArgs e){
            for (int row = 0; row < 150; row++){
                if (forest[0, row] == 1){
                    toBurn.add(0, row);
                }
            }
            timer1.Start();
        }
        //drawing the forest
        private void pictureBox1_paint(object sender, PaintEventArgs e){
            Graphics g = e.Graphics;
            for (int column = 0; column < 150; column++){
                for (int row = 0; row < 150; row++){
                    if (forest[row, column] == 1){
                        g.FillRectangle(greenB, row * 4, column * 4, 4, 4);
                    }
                    else if (forest[row, column] == 0){
                        g.FillRectangle(blackB, row * 4, column * 4, 4, 4);
                    }
                    else if (forest[row, column] == 2){
                        g.FillRectangle(redB, row * 4, column * 4, 4, 4);
                    }
                }
            }
        }

        //method for turning red burning squares to zero, clearings
        public void burningOut(){
            while (burning.isEmpty() != true){
                Node temp = burning.remove();
                int x = temp.getRow();
                int y = temp.getColumn();
                forest[x, y] = 0;
            }
        }
        //check if surrounding area is a burnable tree and add into a link list to be burned
        public void setFire(){
            LinkList templist = new LinkList();
            while (toBurn.isEmpty() != true){
                Node temp = toBurn.remove();
                int x = temp.getRow();
                int y = temp.getColumn();
                if (forest[x, y] == 1){
                    forest[x, y] = 2;
                    burning.add(x, y);

                    if (x + 1 < 150){
                        templist.add(x + 1, y);
                    }

                    if (x - 1 >= 0){
                        templist.add(x - 1, y);
                    }

                    if (y + 1 < 150){
                        templist.add(x, y + 1);
                    }

                    if (y - 1 >= 0){
                        templist.add(x, y - 1);
                    }

                    if (windCheckBox.CheckState == CheckState.Checked){
                        int chances = rng.Next(1, 100);
                        if (x + 2 < 150){
                            if (chances <= 50){
                                templist.add(x + 2, y);
                            }
                        }
                        if (x + 3 < 150){
                            if (chances <= 25){
                                templist.add(x + 3, y);
                            }
                        }
                    }
                }
            }
            toBurn = templist;
            if(burning.isEmpty() == true){
                isActive = false;
            }
        }

        //timer will run the methods that check what will burn from the fire then update the forest picture
        private void timer1_tick(object sender, EventArgs e){
            if (isActive == true){
                burningOut();
                setFire();
                pictureBox1.Invalidate();
            }

            else{
                timer1.Stop();
            }
        }
    }
}
