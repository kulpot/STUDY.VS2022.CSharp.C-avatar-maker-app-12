using C__heromaker_10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//------------------ C# avatar maker app 01 How to use checkboxes tutorial -----------------------------
//ref link:https://www.youtube.com/watch?v=UgbzxnlckxY&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=15

// label(Hero's Name), textbox(MessageBox), groupbox, checkbox x8(abilities[0-7], button(btn_create), status_message

//----------------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------
//ref link:https://www.youtube.com/watch?v=ihBNF1j5qNU&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=14

// listbox(Item Collection)(SelectionMode:MultiSimple), label(Office Locations)

//----------------- C# avatar maker app 03 How to use radio buttons tutorial ------------------------------
//ref link:https://www.youtube.com/watch?v=0Byuvm4acFM&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=14

// Radio button x4, groupbox(Preferred Transport), radio button x4(rdo prefix)(JetPack:Property->Checked->True,

//----------------- C# heromaker app 04 How to use scrollbars in Winforms -----------------------------------
//ref link:https://www.youtube.com/watch?v=dKXTx0swVUU&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=13

// Scroolbars(LimitSpedd+Stamina+Strength to a maximum of 100totalPts, GroupBox(Speed-Stamina-Strength), HScrollBar x3(width300height15),label x6(Speed/Stamina/Strength/lbl_speed/stamina/strenght), trackBar,

//---------------- C# hermaker app 05 How to program a date picker in C# -------------------------------------
//ref link:https://www.youtube.com/watch?v=mq0lEliFY0E&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=11

// GroupBox, DateTimePicker x3, Label x3,

//--------------- C# avatar maker app 06 How to use a number picker ------------------------------------------------
//ref link:https://www.youtube.com/watch?v=3tZNK3WPOW4&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=12

// label, numericalUpDown(name:num_year_experience), \n

//-------------- C# avatar maker app 07 How to use the color picker ----------------------------------------------
//ref link:https://www.youtube.com/watch?v=_XBet_gEycg&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=11

// label(Cape Color), pictureBox, 

//------------- C# avatar maker app 08 How to use the trackbar control -------------------------------------------
//ref link:https://www.youtube.com/watch?v=H5cPurr1EeE&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=10

// label(Dark Side Propensity),label(0/lbl_dark_side), trackBar(minimum:-10/largeChange:3), 

//------------- C# heromaker part 09 Picturebox control Visual Studio -------------------------------
//ref link:https://www.youtube.com/watch?v=inK--sPEgws&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=7

// groupBox(portrait), pictureBox(sizeMode:Zoom), 

//-------------- C# heromaker 10 hero object ---------------------------------------------------------
//ref link:https://www.youtube.com/watch?v=8zXxow4OZiY&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=6

// created Hero.cs(HeroProperties/HeroConstructorMethod), 

namespace HeroMaker
{
    public partial class Form1 : Form
    {
        //----START------- C# heromaker part 09 Picturebox control Visual Studio -------------------------------
        // picture of hero
        string picture_of_hero = "";
        //----END------- C# heromaker part 09 Picturebox control Visual Studio -------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        //------START---------- C# avatar maker app 01 How to use checkboxes tutorial -----------------------------

        private void btn_create_Click(object sender, EventArgs e)
        {
            //-----START------- C# heromaker 10 hero object ---------------------------------------------------------
            string heroName = txt_name.Text;
            //-----END------- C# heromaker 10 hero object ---------------------------------------------------------


            bool[] abilities = {false, false, false, false, false, false, false, false };

            abilities[0] = chk_fly.Checked;
            abilities[1] = chk_xray.Checked;
            abilities[2] = chk_invisible.Checked;
            abilities[3] = chk_energy.Checked;
            abilities[4] = chk_luck.Checked;
            abilities[5] = chk_fart.Checked;
            abilities[6] = chk_water_breath.Checked;
            abilities[7] = chk_timecontrol.Checked;

            //----START--------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------
            // listbox
            // cities
            // array or list?
            List<String> cities = new List<String>();

            // add the selected items to cities
            foreach(String s in lst_cities.SelectedItems)
            {
                cities.Add(s);
            }
            //-----END---------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------

            //-----START---------- C# avatar maker app 03 How to use radio buttons tutorial ------------------------------
            // preferred transport
            // use a single string since only one mode can be the preferred transport.

            string preferred_transport = " ";

            if (rdo_jetpack.Checked)
                preferred_transport = "Jet Pack";
            if (rdo_landspeeder.Checked)
                preferred_transport = "Land Speeder";
            if (rdo_teleport.Checked)
                preferred_transport = "Teleport";
            if (rdo_batmobile.Checked)
                preferred_transport = "Batmobile";
            //------END--------- C# avatar maker app 03 How to use radio buttons tutorial ------------------------------

            //-----START---------- C# heromaker app 04 How to use scrollbars in Winforms -----------------------------------
            int speed = scroll_speed.Value;
            int stamina = scroll_stamina.Value;
            int strength = scroll_strength.Value;
            if(speed + stamina + strength > 100)
            {
                MessageBox.Show("You cannot have more than 100 total points for speed, stamina, strength");
                Close();
            }
            //-------END-------- C# heromaker app 04 How to use scrollbars in Winforms -----------------------------------

            //------START-------- C# hermaker app 05 How to program a date picker in C# -------------------------------------
            // dates

            DateTime birthday = date_birthday.Value;
            DateTime superPowerDiscovery = date_power_discovery.Value;
            DateTime fatefulDay = date_fate.Value;
            //------END-------- C# hermaker app 05 How to program a date picker in C# -------------------------------------

            //-----START-------- C# avatar maker app 06 How to use a number picker ------------------------------------------------
            // years experience

            decimal years_experience = num_years_experience.Value;
            //-----END-------- C# avatar maker app 06 How to use a number picker ------------------------------------------------

            //----START------- C# avatar maker app 08 How to use the trackbar control -------------------------------------------
            // dark side
            int dark_side = 0;
            dark_side = trk_dark_side.Value;
            //-----END------ C# avatar maker app 08 How to use the trackbar control -------------------------------------------

            //------START---------- C# avatar maker app 01 How to use checkboxes tutorial -----------------------------
            string status_message = "Your new hero is " + txt_name.Text + "." +
                " \nYou have selected the following abilities: ";

            if (abilities[0])
                status_message += "Fly, ";
            if (abilities[1])
                status_message += "xRay Vision, ";
            if (abilities[2])
                status_message += "Invisibility, ";
            if (abilities[3])
                status_message += "Absorb Energy, ";
            if (abilities[4])
                status_message += "Extreme Luck, ";
            if (abilities[5])
                status_message += "Explosive Farts, ";
            if (abilities[6])
                status_message += "Water Breathing, ";
            if (abilities[7])
                status_message += "Time Control, ";
            //------END---------- C# avatar maker app 01 How to use checkboxes tutorial -----------------------------

            //----START--------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------
            //listbox
            status_message += "\nThe hero works in these cities: "; 
            foreach(String city in cities)
            {
                status_message += city + ", ";
            }
            //-----END---------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------

            //-----START---------- C# avatar maker app 03 How to use radio buttons tutorial ------------------------------
            status_message += " \nYour hero prefers to travel by " + preferred_transport + ".";
            //-----END---------- C# avatar maker app 03 How to use radio buttons tutorial ------------------------------

            //-----START---------- C# heromaker app 04 How to use scrollbars in Winforms -----------------------------------
            status_message += " \nSpeed: " + speed + " Stamina: " + stamina + " Strength: " + strength + ".";
            //-----END---------- C# heromaker app 04 How to use scrollbars in Winforms -----------------------------------

            //------START-------- C# hermaker app 05 How to program a date picker in C# -------------------------------------
            status_message += " \nYour hero was born on " + birthday;
            status_message += " \nThe hero discovered super powers on " + superPowerDiscovery;
            status_message += " \nThe fateful day for this person is " + fatefulDay;
            //------END-------- C# hermaker app 05 How to program a date picker in C# -------------------------------------

            //-----START-------- C# avatar maker app 06 How to use a number picker ------------------------------------------------
            status_message += " \nYears experience: " + years_experience;
            //-----END-------- C# avatar maker app 06 How to use a number picker ------------------------------------------------

            //-----START------- C# avatar maker app 07 How to use the color picker ----------------------------------------------
            status_message += "\nThe cape color for your hero is " + pic_cape_color.BackColor.ToString();
            //-----END------- C# avatar maker app 07 How to use the color picker ----------------------------------------------

            //----START------- C# avatar maker app 08 How to use the trackbar control -------------------------------------------
            status_message += "\nThe dark side probability for your hero is " + dark_side;
            //-----END------ C# avatar maker app 08 How to use the trackbar control -------------------------------------------

            //----START------- C# heromaker part 09 Picturebox control Visual Studio -------------------------------
            status_message += " \n The picture of the heros is: " + picture_of_hero;
            //----END------- C# heromaker part 09 Picturebox control Visual Studio -------------------------------

            //------START---------- C# avatar maker app 01 How to use checkboxes tutorial -----------------------------
            MessageBox.Show(status_message);
            //------END---------- C# avatar maker app 01 How to use checkboxes tutorial -----------------------------

            //-----START------- C# heromaker 10 hero object ---------------------------------------------------------
            Hero hero = new Hero(heroName, abilities, cities, 
                preferred_transport, speed, stamina, strength, 
                birthday, superPowerDiscovery, fatefulDay, years_experience, 
                pic_cape_color.BackColor.ToString(),
                dark_side, 
                picture_of_hero);
            //-----END------- C# heromaker 10 hero object ---------------------------------------------------------

        }

        //--------START------- C# heromaker app 04 How to use scrollbars in Winforms -----------------------------------

        private void scroll_speed_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_speed.Text = scroll_speed.Value.ToString();
        }

        private void scroll_stamina_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_stamina.Text = scroll_stamina.Value.ToString();
        }

        private void scroll_strength_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_strength.Text = scroll_strength.Value.ToString();
        }
        //------END--------- C# heromaker app 04 How to use scrollbars in Winforms -----------------------------------

        //-----START------- C# avatar maker app 07 How to use the color picker ----------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                pic_cape_color.BackColor = colorPicker.Color;
            }
        }
        //------END------- C# avatar maker app 07 How to use the color picker ----------------------------------------------

        //----START------- C# avatar maker app 08 How to use the trackbar control -------------------------------------------
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_dark_side.Text = trk_dark_side.Value.ToString();
        }
        //-----END------ C# avatar maker app 08 How to use the trackbar control -------------------------------------------

        //----START------- C# heromaker part 09 Picturebox control Visual Studio -------------------------------
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog portraitPicker = new OpenFileDialog();

            if(portraitPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(portraitPicker.FileName);

                picture_of_hero = portraitPicker.FileName;
            }
        }
        //-----END------ C# heromaker part 09 Picturebox control Visual Studio -------------------------------


        //------END---------- C# avatar maker app 01 How to use checkboxes tutorial -----------------------------
    }
}
