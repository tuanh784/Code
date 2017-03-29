using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            List<int> ascii = new List<int>();

            string embedString = inputBox.Text;
            int bitmapx = 0;
            int bitmapy = 0;
            Color c;
            Color freshcolor;
            int red;
            //put every char from the user input into a list as ascii int value
            for (int i = 0; i < embedString.Length; i++)
            {
                Char x = embedString[i];
                int y = x;
                ascii.Add(y);
            }

            foreach (int asciinum in ascii)
            {
                string binaryhalf = Convert.ToString(asciinum, 2);
                //change every ascii value into a binary string
                string binaryrep = binaryhalf.PadLeft(8, '0');
                for (int i = 0; i < 8; i++)
                {
                    string singlebit = Convert.ToString(binaryrep[i]);
                    int setbit = Convert.ToInt32(singlebit);
                    if (bitmapy < bmp.Height)
                    {
                        if (bitmapx < bmp.Width)
                        {
                            c = bmp.GetPixel(bitmapx, bitmapy);
                            if (setbit == 0)
                            {
                                red = c.R & 254;
                                freshcolor = Color.FromArgb(red, c.G, c.B);
                                bmp.SetPixel(bitmapx, bitmapy, freshcolor);
                                bitmapx++;
                            }

                            else
                            {
                                red = c.R | 1;
                                freshcolor = Color.FromArgb(red, c.G, c.B);
                                bmp.SetPixel(bitmapx, bitmapy, freshcolor);
                                bitmapx++;
                            }
                        }
                        //go to next row in picture once bound is hit
                        else
                        {
                            bitmapx = 0;
                            bitmapy++;
                            c = bmp.GetPixel(bitmapx, bitmapy);
                            if (setbit == 0)
                            {
                                red = c.R & 254;
                                freshcolor = Color.FromArgb(red, c.G, c.B);
                                bmp.SetPixel(bitmapx, bitmapy, freshcolor);
                                bitmapx++;
                            }

                            else
                            {
                                red = c.R | 1;
                                freshcolor = Color.FromArgb(red, c.G, c.B);
                                bmp.SetPixel(bitmapx, bitmapy, freshcolor);
                                bitmapx++;
                            }
                        }
                    }
                    //user input message was too long
                    else
                    {
                        Console.WriteLine("Your message is too long");
                    }
                }
            }
            //ending the message with 8 0's
            for (int i = 0; i < 8; i++)
            {
                if (bitmapy < bmp.Height)
                {
                    if (bitmapx < bmp.Width)
                    {
                        c = bmp.GetPixel(bitmapx, bitmapy);
                        red = c.R & 254;
                        freshcolor = Color.FromArgb(red, c.G, c.B);
                        bmp.SetPixel(bitmapx, bitmapy, freshcolor);
                        bitmapx++;
                    }

                    else
                    {
                        bitmapx = 0;
                        bitmapy++;
                        c = bmp.GetPixel(bitmapx, bitmapy);
                        red = c.R & 254;
                        freshcolor = Color.FromArgb(red, c.G, c.B);
                        bmp.SetPixel(bitmapx, bitmapy, freshcolor);
                        bitmapx++;
                    }


                }
                else
                {
                    Console.WriteLine("Your message is too long");
                }
            }
            pictureBox1.Image = bmp;
            pictureBox1.Invalidate();
            saveImage();
        }

        //need to change so it changes picturebox's source image
        private void saveImage()
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);

            if (System.IO.File.Exists("test.bmp"))
                System.IO.File.Delete("test.bmp");

            bmp1.Save("test.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            // Dispose of the image files.
            bmp1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int bitmapx = 0;
            int bitmapy = 0;
            Color d;
            string decodebyte = null;
            string message = null;
            Boolean done = false;
            while (done != true)
            {
                //pull 8 pixels out
                for (int i = 0; i < 8; i++)
                {
                    if (bitmapy < bmp.Height)
                    {
                        if (bitmapx < bmp.Width)
                        {
                            //for each pixel check if it's last bit is 1 or 0 then add that to a string
                            d = bmp.GetPixel(bitmapx, bitmapy);
                            int decodedbit = d.R % 2;
                            string letterbit = Convert.ToString(decodedbit);
                            decodebyte += letterbit;
                            bitmapx++;
                        }

                        else
                        {
                            bitmapx = 0;
                            bitmapy++;
                            d = bmp.GetPixel(bitmapx, bitmapy);
                            int decodedbit = d.R % 2;
                            string letterbit = Convert.ToString(decodedbit);
                            decodebyte += letterbit;
                            bitmapx++;
                        }
                    }


                }
                //if the binary string is not the end symbol then convert that binary string into an int then into a char and add that to decoding string
                if (!decodebyte.Equals("00000000"))
                {
                    int binarytoint = Convert.ToInt32(decodebyte, 2);
                    char letter = Convert.ToChar(binarytoint);
                    decodebyte = null;
                    message += letter;
                }

                else
                {
                    done = true;
                    decodedTxt.Text = message;
                }
            }
        }
    }
}
