using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pong
{
    public partial class Form1 : Form
    {
        public int fart_horisontell; //Farten som är horisontell.
        public int fart_upp; //Farten som är vertikal.
        public int poäng = 0; //Poängen startar från 0;
        public int liv = 3; //Starta med tre liv.
        bool mute = false;
        public int högpoäng = 0;
        Random slump = new Random();
                     
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true; //Startar spelet
            Cursor.Hide();
            fart_horisontell = slump.Next(-5, 11); //Sätter farten mellan 5 och 10.
            fart_upp = slump.Next(-5, 11); //Sätter farten mellan 5 och 10.
            this.FormBorderStyle = FormBorderStyle.None; //Tar bort alla ramar så att spelet ser mer "clean" ut.           
            this.Bounds = Screen.PrimaryScreen.Bounds; //Spelet är alltid i fullskärm.
            rack.Top = spelplan.Bottom - 25; //Sätter rackets positition vid bottnen.

        }        
        private void timer1_Tick(object sender, EventArgs e)
        {
            rack.Left = Cursor.Position.X;

            boll.Left += fart_horisontell; //Gör så att "bollen" rör sig från början.
            boll.Top += fart_upp; // -II-

            if (boll.Bottom >= rack.Top && boll.Bottom <= rack.Bottom && boll.Left >= rack.Left && boll.Right <= rack.Right) //Gör så att bollen får mer fart per studs,                                                                                                                            //samt att den fastnar i botten då man förlorar (så att den inte bara fortsätter att åka i "oändlighet".
            {
                fart_upp += 2;
                fart_horisontell += 2;
                poäng += 1;
                lblPoäng.Text = "Oliverskrik: " + poäng;
                fart_upp = -fart_upp; //Ändrar riktningen på "bollen" så att den studsar uppåt istället för att fortsätta nedåt.
                if (mute == false)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Pong\oliverhoppG.wav");
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Pong\oliverhoppG.wav");
                    player.Stop();
                }
            }
            if (boll.Left <= spelplan.Left)
            {
                fart_horisontell = -fart_horisontell; //Vid varje studs mot en vägg måste riktningen ändras.
            }
            if (boll.Right >= spelplan.Right)
            {
                fart_horisontell = -fart_horisontell; //Vid varje studs mot en vägg måste riktningen ändras.
            }
            if (boll.Top <= spelplan.Top)
            {
                fart_upp = -fart_upp;       //Vid varje studs mot en vägg måste riktningen ändras.      
            }
            if (boll.Bottom >= spelplan.Bottom) //Då bollen rör golvet är spelet över.
            {
                liv--;
                boll.Left = slump.Next(10,1001);
                boll.Top = 60;
                fart_horisontell = slump.Next(-5, 11);
                fart_upp = slump.Next(-5, 11);
                timer1.Enabled = true;
                lblMeny.Visible = false;
                lblPoäng.Text = "Oliverskrik: " + poäng;
                if (mute == false)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Pong\Roblox.wav");
                    player.Play();
                }                             
            }
            if (liv == 3)
            {
                liv1PCB.Visible = true;
                liv2PCB.Visible = true;
                liv3PCB.Visible = true;
            }
            else if (liv == 2)
            {
                liv1PCB.Visible = true;
                liv2PCB.Visible = true;
                liv3PCB.Visible = false;
            }
            else if (liv == 1)
            {
                liv1PCB.Visible = true;
                liv2PCB.Visible = false;
                liv3PCB.Visible = false;
            }
            else if (liv == 0)
            {
                liv1PCB.Visible = false;
                liv2PCB.Visible = false;
                liv3PCB.Visible = false;
                timer1.Enabled = false;

                lblMeny.Visible = true; //Visa "menyn" då spelet är över.
                lblMeny.Text = "ESC - Stäng av " + "\n" + " R - Starta om" + "\n" + " Z - Lycka till " + "\n" + " M - Stäng av ljud ";
                lblPoäng.Visible = false;
                rack.Visible = false;
                boll.Visible = false;
                if (mute == false)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Pong\TadaOliver123.wav");
                    player.Play();
                    spelplan.BackgroundImage = Pong.Properties.Resources.oliverxd;
                }
                else if (mute == true)
                {
                    spelplan.BackgroundImage = Pong.Properties.Resources.OliverChill;
                }
            }
            if (poäng % 2 == 0) //Då poängen är jämn så visas bollen som "oliverjackshitmannen.jpg" och när poängen är udda visas bollen som "oliver3.jpg".
            {
                boll.Image = Pong.Properties.Resources.oliverjackshitmannen;
            }
            else
            {
                boll.Image = Pong.Properties.Resources.oliver3;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); //Klicka på escape så stängs spelet av.
            }

            if (e.KeyCode == Keys.R) //Sätt "bollen" vid startpositionen
            {
                boll.Left = slump.Next(10, 1001);
                boll.Top = 60;
                poäng = 0;
                fart_horisontell = slump.Next(-5, 11); //Sätter farten mellan -5 och 10.
                fart_upp = slump.Next(-5, 11); //Sätter farten mellan -5 och 10.
                lblPoäng.Visible = true;
                rack.Visible = true;
                boll.Visible = true;
                timer1.Enabled = true;
                lblMeny.Visible = false;
                lblPoäng.Text = "Oliverskrik: " + poäng;
                mute = false;
                liv = 3;
                spelplan.BackgroundImage = null; //Sätter tillbaka bakgrunden till den gråa ifrån olivers ansikte.
            }
            if (e.KeyCode == Keys.F1) //Sätt bollen vid startpositionen men med en högre utgångsfart
            {
                boll.Left = slump.Next(10,1001);
                boll.Top = 60;
                poäng = 0;
                fart_horisontell = slump.Next(-5, 11); //Sätter farten mellan -5 och 10.
                fart_upp = slump.Next(-5, 11); //Sätter farten mellan -5 och 10.
                timer1.Enabled = true;
                lblMeny.Visible = false;
                lblPoäng.Text = "Oliverskrik: " + poäng;
                mute = false;
                liv = 1;
            }
            if (e.KeyCode == Keys.M) //Stäng av ljudet
            {
                mute = true;
            }
            
        }

        
    }
}
        
