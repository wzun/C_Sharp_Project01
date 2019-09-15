using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Mybikes.bus;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace Mybikes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 //initialization
        int index;
        List<Bikes> Bikelist = new List<Bikes>();
        List<MountainBikes> Mountainlist = new List<MountainBikes>();
        List<RoadBikes> Roadlist = new List<RoadBikes>();

 //form1 load
        private void Form1_Load(object sender, EventArgs e)
        {
            // color
            foreach (EnumColor color in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(color);
            }
            this.comboBoxColor.Text = Convert.ToString(comboBoxColor.Items[0]);

            // wheel
            foreach (EnumWheel wheel in Enum.GetValues(typeof(EnumWheel)))
            {
                this.comboBoxWheel.Items.Add(wheel);
            }
            this.comboBoxWheel.Text = Convert.ToString(comboBoxWheel.Items[0]);

            // speed
            foreach (EnumSpeed speed in Enum.GetValues(typeof(EnumSpeed)))
            {
                this.comboBoxSpeed.Items.Add(speed);
            }
            this.comboBoxSpeed.Text = Convert.ToString(comboBoxSpeed.Items[0]);

            // type of suspension
            foreach (EnumSuspension suspension in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBoxTFS.Items.Add(suspension);
            }
            this.comboBoxTFS.Text = Convert.ToString(comboBoxTFS.Items[0]);
        }
 //button add
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                MountainBikes M1 = new MountainBikes()
                {
                    SerialNumber = Convert.ToInt32(textBoxSn.Text),
                    Model = textBoxModel.Text,
                    Band = textBoxBrand.Text,
                    Weight = Convert.ToInt32(textBoxWeight.Text),

                    Color = (EnumColor)this.comboBoxColor.SelectedItem,
                    Wheel = (EnumWheel)this.comboBoxWheel.SelectedItem,
                    Speed = (EnumSpeed)this.comboBoxSpeed.SelectedItem,

                    Height_from_ground = Convert.ToInt32(textBoxHFG.Text),
                    Suspension = (EnumSuspension)this.comboBoxTFS.SelectedItem,
                };
                Date madedate = new Date
                {
                    Year = Convert.ToInt32(textBoxYear.Text),
                    Month = Convert.ToInt32(textBoxMonth.Text),
                    Day = Convert.ToInt32(textBoxDay.Text)
                };
                M1.MadeDate = madedate;
                Bikes B1 = M1;
                Bikelist.Add(B1);
                Mountainlist.Add(M1);
            }
            else if (radioButtonRoad.Checked == true)
            {
                RoadBikes R1 = new RoadBikes()
                {
                    SerialNumber = Convert.ToInt32(textBoxSn.Text),
                    Model = textBoxModel.Text,
                    Band = textBoxBrand.Text,
                    Weight = Convert.ToInt32(textBoxWeight.Text),

                    Color = (EnumColor)this.comboBoxColor.SelectedItem,
                    Wheel = (EnumWheel)this.comboBoxWheel.SelectedItem,
                    Speed = (EnumSpeed)this.comboBoxSpeed.SelectedItem,

                    SeatHight = Convert.ToInt32(textBoxSeatH.Text)
                };
                Date madedate = new Date
                {
                    Year = (Convert.ToInt32(textBoxYear.Text)),
                    Month = (Convert.ToInt32(textBoxMonth.Text)),
                    Day = (Convert.ToInt32(textBoxDay.Text))
                };
                R1.MadeDate = madedate;

                Bikes B1 = R1;
                Bikelist.Add(B1);
                Roadlist.Add(R1);
            }
        }
 //button reset
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            foreach (Control aControl in Controls)
            {
                if (aControl is TextBox)
                {
                    aControl.Text = "";
                }
            }
            comboBoxColor.Text = Convert.ToString(EnumColor.undefined);
            comboBoxWheel.Text = Convert.ToString(EnumWheel.undefined);
            comboBoxSpeed.Text = Convert.ToString(EnumSpeed.undefined);
            comboBoxTFS.Text = Convert.ToString(EnumSuspension.undefined);

            textBoxSn.Focus();
            Display.Items.Clear();
            ButtonAdd.Enabled = true;

            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
 //button update
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                this.Mountainlist[index].SerialNumber = Convert.ToInt32(textBoxSn.Text);
                this.Mountainlist[index].Model = textBoxModel.Text;
                this.Mountainlist[index].Band = textBoxBrand.Text;
                this.Mountainlist[index].Weight = Convert.ToInt32(textBoxWeight.Text);

                this.Mountainlist[index].Color = (EnumColor)this.comboBoxColor.SelectedItem;
                this.Mountainlist[index].Wheel = (EnumWheel)this.comboBoxWheel.SelectedItem;
                this.Mountainlist[index].Speed = (EnumSpeed)this.comboBoxSpeed.SelectedIndex;

                this.Mountainlist[index].MadeDate.Year = Convert.ToInt32(textBoxYear.Text);
                this.Mountainlist[index].MadeDate.Month = Convert.ToInt32(textBoxMonth.Text);
                this.Mountainlist[index].MadeDate.Day = Convert.ToInt32(textBoxDay.Text);

                this.Mountainlist[index].Height_from_ground = Convert.ToInt32(textBoxHFG.Text);
                this.Mountainlist[index].Suspension = (EnumSuspension)this.comboBoxTFS.SelectedItem;
                ShowMountainbike(this.Mountainlist, this.Display);
            }
            else if (radioButtonRoad.Checked == true)
            {
                this.Mountainlist[index].SerialNumber = Convert.ToInt32(textBoxSn.Text);
                this.Mountainlist[index].Model = textBoxModel.Text;
                this.Mountainlist[index].Band = textBoxBrand.Text;
                this.Mountainlist[index].Weight = Convert.ToInt32(textBoxWeight.Text);

                this.Mountainlist[index].Color = (EnumColor)this.comboBoxColor.SelectedItem;
                this.Mountainlist[index].Wheel = (EnumWheel)this.comboBoxWheel.SelectedItem;
                this.Mountainlist[index].Speed = (EnumSpeed)this.comboBoxSpeed.SelectedIndex;

                this.Mountainlist[index].MadeDate.Year = Convert.ToInt32(textBoxYear.Text);
                this.Mountainlist[index].MadeDate.Month = Convert.ToInt32(textBoxMonth.Text);
                this.Mountainlist[index].MadeDate.Day = Convert.ToInt32(textBoxDay.Text);

                this.Roadlist[index].SeatHight = Convert.ToInt32(textBoxSeatH.Text);
                ShowRoadbike(this.Roadlist, this.Display);
            }

        }
 //button remove
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                this.Mountainlist.RemoveAt(index);
                ShowMountainbike(Mountainlist, Display);
            }
            else if (radioButtonRoad.Checked == true)
            {
                this.Roadlist.RemoveAt(index);
                ShowRoadbike(Roadlist, Display);
            }
        }
 //button search
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                int temp = Convert.ToInt32(textBoxSearch.Text);

                bool found = false;
                MountainBikes searchedM = new MountainBikes();

                foreach (MountainBikes item in this.Mountainlist)
                {
                    if (item.SerialNumber == temp)
                    {
                        found = true;
                        searchedM = item;
                        break;
                    }
                }

                if (found)
                {
                    MessageBox.Show("Mountianbike Found....\n" + searchedM);
                }
                else
                {
                    MessageBox.Show("Mountainbike Not Found");
                }
            }
            else if (radioButtonRoad.Checked == true)
            {
                int temp = Convert.ToInt32(textBoxSearch.Text);

                bool found = false;

                RoadBikes searchedR = new RoadBikes();

                foreach (RoadBikes item in this.Roadlist)
                {
                    if (item.SerialNumber == temp)
                    {
                        found = true;
                        searchedR = item;
                        break;
                    }
                }

                if (found)
                {
                    MessageBox.Show("Roadbike Found....\n" + searchedR);
                }
                else
                {
                    MessageBox.Show("Roadbike Not Found");
                }
            }
        }
 //button exit
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("End of application !");
            this.Close();
        }
 //display choosed index
        private void Display_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = Display.SelectedIndex;
            MessageBox.Show("Index Number is " + index);

            if (radioButtonMountain.Checked == true)
            {
                textBoxSn.Text = Convert.ToString(Mountainlist[index].SerialNumber);
                textBoxModel.Text = this.Mountainlist[index].Model;
                textBoxBrand.Text = this.Mountainlist[index].Band;
                textBoxWeight.Text = Convert.ToString(Mountainlist[index].Weight);

                comboBoxColor.Text = Convert.ToString(this.Mountainlist[index].Color);
                comboBoxWheel.Text = Convert.ToString(this.Mountainlist[index].Wheel);
                comboBoxSpeed.Text = Convert.ToString(this.Mountainlist[index].Speed);

                textBoxYear.Text = Convert.ToString(this.Mountainlist[index].MadeDate.Year);
                textBoxMonth.Text = Convert.ToString(this.Mountainlist[index].MadeDate.Month);
                textBoxDay.Text = Convert.ToString(this.Mountainlist[index].MadeDate.Day);

                textBoxHFG.Text = Convert.ToString(this.Mountainlist[index].Height_from_ground);
                comboBoxTFS.Text = Convert.ToString(this.Mountainlist[index].Suspension);
            }
            else if (radioButtonRoad.Checked == true)
            {
                textBoxSn.Text = Convert.ToString(Mountainlist[index].SerialNumber);
                textBoxModel.Text = this.Mountainlist[index].Model;
                textBoxBrand.Text = this.Mountainlist[index].Band;
                textBoxWeight.Text = Convert.ToString(Mountainlist[index].Weight);

                comboBoxColor.Text = Convert.ToString(this.Mountainlist[index].Color);
                comboBoxWheel.Text = Convert.ToString(this.Mountainlist[index].Wheel);
                comboBoxSpeed.Text = Convert.ToString(this.Mountainlist[index].Speed);

                textBoxYear.Text = Convert.ToString(this.Mountainlist[index].MadeDate.Year);
                textBoxMonth.Text = Convert.ToString(this.Mountainlist[index].MadeDate.Month);
                textBoxDay.Text = Convert.ToString(this.Mountainlist[index].MadeDate.Day);

                textBoxSeatH.Text = Convert.ToString(this.Roadlist[index].SeatHight);
            }
        }

 //show list data into listbox
        public void ShowContent(List<MountainBikes> Mountainlist, ListBox ListBox1)
        {
            ListBox1.Items.Clear();
            if (this.Mountainlist.Capacity != 0)
            {
                foreach (MountainBikes item in this.Mountainlist)
                {
                    ListBox1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No data in list..");
            }
            textBoxSn.Focus();
        }
        public void ShowContent(List<RoadBikes> Roadlist, ListBox ListBox1)
        {
            ListBox1.Items.Clear();
            if (this.Roadlist.Capacity != 0)
            {
                foreach (RoadBikes item in this.Roadlist)
                {
                    ListBox1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No data in list..");
            }
            textBoxSn.Focus();
        }
 //display bikes
        private void ShowMountainbike(List<MountainBikes> Mountainlist, ListBox listBox)
        {
            this.Display.Items.Clear();

            if (this.Mountainlist.Capacity != 0)
            {
                foreach (MountainBikes list in this.Mountainlist)
                {
                    this.Display.Items.Add(list);
                }
            }
            else
            {
                MessageBox.Show("No Date !");
                textBoxSn.Focus();
            }
        }
        private void ShowRoadbike(List<RoadBikes> Roadlist, ListBox listbox)
        {
            this.Display.Items.Clear();
            if (this.Roadlist.Capacity != 0)
            {
                foreach (RoadBikes list in this.Roadlist)
                {
                    this.Display.Items.Add(list);
                }
            }
            else
            {
                MessageBox.Show("No Date !");
                textBoxSn.Focus();
            }
        }
 //button display mountain bikes
        private void ButtonDisplayMountain_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {

                ShowMountainbike(Mountainlist, Display);
            }
        }
 //button display road bikes
        private void ButtonDisplayRoad_Click(object sender, EventArgs e)
        {

            if (radioButtonRoad.Checked == true)
            {
                ShowRoadbike(Roadlist, Display);
            }
        }
 //button display all
        private void ButtonDisplayall_Click(object sender, EventArgs e)
        {
            foreach (Bikes B1 in Bikelist)
            {
                Display.Items.Add(B1);
            }


        }
 
 
 //write bin file
        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            //FileHandler fh = new FileHandler();
            //FileHandler.WriteToBinFile(this.Bikelist);

            if (radioButtonMountain.Checked == true)
            {
                FileHandler fhM = new FileHandler();
                FileHandler.WriteToBinFileM(Mountainlist);
            }

            else if (radioButtonRoad.Checked == true)
            {
                FileHandler fhR = new FileHandler();
                FileHandler.WriteToBinFileR(Roadlist);
            }

            
        }
 //read bin file
        private void ButtonRead_Click(object sender, EventArgs e)
        {
            //this.Bikelist.Clear(); 

            //this.Bikelist = FileHandler.ReadFromBinFile();

            //foreach (Bikes item in Bikelist)
            //{
            //    this.Display.Items.Add(item);
            //}

            if (radioButtonMountain.Checked == true)
            {
                this.Mountainlist.Clear();

                this.Mountainlist = FileHandler.ReadFromBinFileM();

                foreach (MountainBikes item in Mountainlist)
                {
                    this.Display.Items.Add(item);
                }
            }
            else if (radioButtonRoad.Checked == true)
            {
                this.Roadlist.Clear();

                this.Roadlist = FileHandler.ReadFromBinFileR();

                foreach (RoadBikes item in Roadlist)
                {
                    this.Display.Items.Add(item);
                }
            }
        }
 
//check change mountain
        private void RadioButtonMountain_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHFG.Enabled = true;
            comboBoxTFS.Enabled = true;
            textBoxSeatH.Enabled = false;
            buttonDisplayR.Enabled = false;
            buttonDisplayM.Enabled = true;
            labelTOS2.Visible = true;
            labelHFG2.Visible = true;
            labelSH2.Visible = false;
        }
//check change mountain
        private void RadioButtonRoad_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHFG.Enabled = false;
            comboBoxTFS.Enabled = false;
            textBoxSeatH.Enabled = true;
            buttonDisplayR.Enabled = true;
            buttonDisplayM.Enabled = false;
            labelTOS2.Visible = false;
            labelHFG2.Visible = false;
            labelSH2.Visible = true;
        }

        #region Validatation(TextChange and keyPress)
        private void TextBoxSn_TextChanged(object sender, EventArgs e)
        {
            if (!(Validator.IsDigit(textBoxSn.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                textBoxSn.Clear();
                textBoxSn.Focus();
            }
            else errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void TextBoxWeight_TextChanged(object sender, EventArgs e)
        {
            if (!(Validator.IsDigit(textBoxWeight.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                errorProvider2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                textBoxWeight.Clear();
                textBoxWeight.Focus();
            }
            else errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!(Validator.IsDigit(textBoxSearch.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                errorProvider3.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                textBoxSearch.Clear();
                textBoxSearch.Focus();
            }
            else errorProvider3.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (!(Validator.IsDigit(textBoxYear.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                errorProvider4.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                textBoxYear.Clear();
                textBoxYear.Focus();
            }
            else errorProvider4.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void TextBoxMonth_TextChanged(object sender, EventArgs e)
        {
            if (!(Validator.IsDigit(textBoxMonth.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                errorProvider5.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                textBoxMonth.Clear();
                textBoxMonth.Focus();
            }
            else errorProvider5.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void TextBoxDay_TextChanged(object sender, EventArgs e)
        {
            if (!(Validator.IsDigit(textBoxDay.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                errorProvider6.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                textBoxDay.Clear();
                textBoxDay.Focus();
            }
            else errorProvider6.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
//Keypress
        private void TextBoxBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(" input must be letter..");
                e.Handled = true;
                textBoxBrand.Clear();
                textBoxBrand.Focus();
            }
        }
       
        #endregion

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                IBikes m1 = new MountainBikes();
                String inter = m1.Start();
                MessageBox.Show(inter);
            }
            else if(radioButtonRoad.Checked == true)
            {
                IBikes r1 = new RoadBikes();
                String inter = r1.Start();
                MessageBox.Show(inter);
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                IBikes m1 = new MountainBikes();
                String inter = m1.Stop();
                MessageBox.Show(inter);
            }
            else if (radioButtonRoad.Checked == true)
            {
                IBikes r1 = new RoadBikes();
                String inter = r1.Stop();
                MessageBox.Show(inter);
            }
        }

        private void buttonAcce_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                IBikes m1 = new MountainBikes();
                String inter = m1.Accelerate();
                MessageBox.Show(inter);
            }
            else if (radioButtonRoad.Checked == true)
            {
                IBikes r1 = new RoadBikes();
                String inter = r1.Accelerate();
                MessageBox.Show(inter);
            }
        }

        private void buttonBrake_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                IBikes m1 = new MountainBikes();
                String inter = m1.Brake();
                MessageBox.Show(inter);
            }
            else if (radioButtonRoad.Checked == true)
            {
                IBikes r1 = new RoadBikes();
                String inter = r1.Brake();
                MessageBox.Show(inter);
            }
        }
    }
}
