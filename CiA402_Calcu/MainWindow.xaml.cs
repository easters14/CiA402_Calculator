using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Diagnostics;

namespace CiA402_Calcu
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        bool hex_input = true;
        bool command_from_button = false;

        public MainWindow()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            comboBox.Items.Add("Cyclic Synchronous Position");
            comboBox.Items.Add("Cyclic Synchronous Velocity");
            comboBox.Items.Add("Cyclic Synchronous Torque");
            comboBox.Items.Add("Profile Position");
            comboBox.Items.Add("Profile Velocity");
            comboBox.Items.Add("Profile Torque");
            comboBox.Items.Add("Homing");
            comboBox.Items.Add("Interpolated Position");
            if (hex_input)
            {
                radioButton_hex.IsChecked = true;
            }
            else
            {
                radioButton_dec.IsChecked = true;
            }

            


        }

        private void button_calculate_Click_CTW(object sender, RoutedEventArgs e)
        {
            command_from_button = true;
            try
            {               
                CTW_ClearOption();

                int CTW_dec;
                string CTW_bin;
                string CTW_hex;

                if (hex_input)
                {
                    //16==>10
                    CTW_hex = textBox_CTW.Text;
                    CTW_dec = Convert.ToInt32((textBox_CTW.Text), 16);
                    CTW_bin = Convert.ToString(CTW_dec, 2);
                }
                else
                {
                    CTW_dec = Convert.ToInt16(textBox_CTW.Text);
                    CTW_hex = CTW_bin = Convert.ToString(CTW_dec, 16);
                    CTW_bin = Convert.ToString(CTW_dec, 2);
                }


                CTW_display_hex.Text = "0x" + CTW_hex;
                CTW_display_dec.Text = Convert.ToString(CTW_dec);

                
                int Power_num = 0;
                if (CTW_dec == 0)
                {
                    CTW_display_bin.Text = "0";
                }
                while (CTW_dec > 0)
                {
                    if ((CTW_dec % 2 == 1) && (Power_num == 0))
                        radioButton_CTW0.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 1))
                        radioButton_CTW1.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 2))
                        radioButton_CTW2.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 3))
                        radioButton_CTW3.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 4))
                        radioButton_CTW4.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 5))
                        radioButton_CTW5.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 6))
                        radioButton_CTW6.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 7))
                        radioButton_CTW7.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 8))
                        radioButton_CTW8.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 9))
                        radioButton_CTW9.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 10))
                        radioButton_CTW10.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 11))
                        radioButton_CTW11.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 12))
                        radioButton_CTW12.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 13))
                        radioButton_CTW13.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 14))
                        radioButton_CTW14.IsChecked = true;
                    if ((CTW_dec % 2 == 1) && (Power_num == 15))
                        radioButton_CTW15.IsChecked = true;
                    CTW_dec /= 2;
                    Power_num++;

                    CTW_display_bin.Text = CTW_bin;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Input Invalid!" + ex.Message);
            }

            CommandCoding_cal();

            command_from_button = false;
        }

        private void button_calculate_Click_STW(object sender, RoutedEventArgs e)
        {
            command_from_button = true;
            try
            {
                STW_ClearOption();

                int STW_dec;
                string STW_bin;
                string STW_hex;

                if (hex_input)
                {
                    //16==>10
                    STW_hex = textBox_STW.Text;
                    STW_dec = Convert.ToInt32((textBox_STW.Text), 16);
                    STW_bin = Convert.ToString(STW_dec, 2);
                }
                else
                {
                    STW_dec = Convert.ToInt16(textBox_STW.Text);
                    STW_hex = Convert.ToString(STW_dec, 16);
                    STW_bin = Convert.ToString(STW_dec, 2);
                }


                STW_display_hex.Text = "0x" + STW_hex;
                STW_display_dec.Text = Convert.ToString(STW_dec);

                
                int Power_num = 0;
                if (STW_dec == 0)
                {
                    STW_display_bin.Text = "0";
                }
                while (STW_dec > 0)
                {
                    if ((STW_dec % 2 == 1) && (Power_num == 0))
                        radioButton_STW0.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 1))
                        radioButton_STW1.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 2))
                        radioButton_STW2.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 3))
                        radioButton_STW3.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 4))
                        radioButton_STW4.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 5))
                        radioButton_STW5.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 6))
                        radioButton_STW6.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 7))
                        radioButton_STW7.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 8))
                        radioButton_STW8.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 9))
                        radioButton_STW9.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 10))
                        radioButton_STW10.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 11))
                        radioButton_STW11.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 12))
                        radioButton_STW12.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 13))
                        radioButton_STW13.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 14))
                        radioButton_STW14.IsChecked = true;
                    if ((STW_dec % 2 == 1) && (Power_num == 15))
                        radioButton_STW15.IsChecked = true;
                    STW_dec /= 2;
                    Power_num++;

                    STW_display_bin.Text = STW_bin;
                }

                StateMachine_cal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input Invalid!" + ex.Message);
            }
            command_from_button = false;
        }

        private void radioButton_CTW0_Copy_Checked(object sender, RoutedEventArgs e)
        {
            hex_input = true;
        }

        private void radioButton_CTW0_Copy1_Checked(object sender, RoutedEventArgs e)
        {
            hex_input = false;
        }

        private void CTW_ClearOption()
        {           
            for (int i = 0; i < 16; i++)
            {
                var myTextBlock = (CheckBox)this.FindName("radioButton_CTW" + i);
                myTextBlock.IsChecked=false;                
            }

            command_display.Text = "";
        }

        private void STW_ClearOption()
        {
            for (int i = 0; i < 16; i++)
            {
                var myTextBlock = (CheckBox)this.FindName("radioButton_STW" + i);
                myTextBlock.IsChecked = false;
            }

            command_display.Text = "";
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                radioButton_CTW4.Content = "Bit:4 Reserved";
                radioButton_CTW5.Content = "Bit:5 Reserved";
                radioButton_CTW6.Content = "Bit:6 Reserved";
                radioButton_CTW8.Content = "Bit:8 Reserved";
                radioButton_CTW9.Content = "Bit:9 Reserved";
                radioButton_STW10.Content = "Bit:10 Reserved";
                radioButton_STW12.Content = "Bit:12 Drive follows the command value";
                radioButton_STW13.Content = "Bit:13 Following error";
            }
            if (comboBox.SelectedIndex ==1 || comboBox.SelectedIndex == 2)            
            {
                radioButton_CTW4.Content = "Bit:4 Reserved";
                radioButton_CTW5.Content = "Bit:5 Reserved";
                radioButton_CTW6.Content = "Bit:6 Reserved";
                radioButton_CTW8.Content = "Bit:8 Reserved";
                radioButton_CTW9.Content = "Bit:9 Reserved";
                radioButton_STW10.Content = "Bit:10 Reserved";
                radioButton_STW12.Content = "Bit:12 Drive follows the command value";
                radioButton_STW13.Content = "Bit:13 Reserved";
            }
            if (comboBox.SelectedIndex == 3)//pp
            {
                radioButton_CTW4.Content = "Bit:4 New setpoint";
                radioButton_CTW5.Content = "Bit:5 Change set immediately";
                radioButton_CTW6.Content = "Bit:6 Abs/Rel";
                radioButton_CTW8.Content = "Bit:8 Halt";
                radioButton_CTW9.Content = "Bit:9 Change on set-point";
                radioButton_STW10.Content = "Bit:10 Target reached";
                radioButton_STW12.Content = "Bit:12 Setpoint acknowledge";
                radioButton_STW13.Content = "Bit:13 Following error";
            }
            if (comboBox.SelectedIndex == 4)//pv
            {
                radioButton_CTW4.Content = "Bit:4 Reserved";
                radioButton_CTW5.Content = "Bit:5 Reserved";
                radioButton_CTW6.Content = "Bit:6 Reserved";
                radioButton_CTW8.Content = "Bit:8 Halt";
                radioButton_CTW9.Content = "Bit:9 Reserved";
                radioButton_STW10.Content = "Bit:10 Target reached";
                radioButton_STW12.Content = "Bit:12 Speed";
                radioButton_STW13.Content = "Bit:13 Max slippage error";
            }
            if (comboBox.SelectedIndex == 5)//pt
            {
                radioButton_CTW4.Content = "Bit:4 Reserved";
                radioButton_CTW5.Content = "Bit:5 Reserved";
                radioButton_CTW6.Content = "Bit:6 Reserved";
                radioButton_CTW8.Content = "Bit:8 Halt";
                radioButton_CTW9.Content = "Bit:9 Reserved";
                radioButton_STW10.Content = "Bit:10 Target reached";
                radioButton_STW12.Content = "Bit:12 Reserved";
                radioButton_STW13.Content = "Bit:13 Reserved";
            }
            if (comboBox.SelectedIndex == 6)//hm
            {
                radioButton_CTW4.Content = "Bit:4 Homing operation start";
                radioButton_CTW5.Content = "Bit:5 Reserved";
                radioButton_CTW6.Content = "Bit:6 Reserved";
                radioButton_CTW8.Content = "Bit:8 Halt";
                radioButton_CTW9.Content = "Bit:9 Reserved";
                radioButton_STW10.Content = "Bit:10 Target reached";
                radioButton_STW12.Content = "Bit:12 Homing attained";
                radioButton_STW13.Content = "Bit:13 Homing error";
            }
            if (comboBox.SelectedIndex == 7)//ip
            {
                radioButton_CTW4.Content = "Bit:4 Enable interpolation";
                radioButton_CTW5.Content = "Bit:5 Reserved";
                radioButton_CTW6.Content = "Bit:6 eserved";
                radioButton_CTW9.Content = "Bit:9 Reserved";
                radioButton_STW10.Content = "Bit:10 Target reached";
                radioButton_STW12.Content = "Bit:12 IP mode active";
                radioButton_STW13.Content = "Bit:13 Following error";
            }

        }

        private void StateMachine_cal()
        {
            //STW:xxxx xxxx x0xx 0000
            if (radioButton_STW0.IsChecked == false && radioButton_STW1.IsChecked == false && radioButton_STW2.IsChecked == false && radioButton_STW3.IsChecked == false && radioButton_STW6.IsChecked == false)
            {
                StateMachine_display.Text = "Not ready to switch on (STW:xxxx xxxx x0xx 0000)";
            }

            //STW:xxxx xxxx x1xx 0000
            if (radioButton_STW0.IsChecked == false && radioButton_STW1.IsChecked == false && radioButton_STW2.IsChecked == false && radioButton_STW3.IsChecked == false && radioButton_STW6.IsChecked == true)
            {
                StateMachine_display.Text = "Switch on disabled (STW:xxxx xxxx x1xx 0000)";
            }

            //STW:xxxx xxxx x01x 0001
            if (radioButton_STW0.IsChecked == true && radioButton_STW1.IsChecked == false && radioButton_STW2.IsChecked == false && radioButton_STW3.IsChecked == false && radioButton_STW5.IsChecked == true && radioButton_STW6.IsChecked == false)
            {
                StateMachine_display.Text = "Ready to switch on (STW:xxxx xxxx x01x 0001)";
            }

            //STW:xxxx xxxx x01x 0011
            if (radioButton_STW0.IsChecked == true && radioButton_STW1.IsChecked == true && radioButton_STW2.IsChecked == false && radioButton_STW3.IsChecked == false && radioButton_STW5.IsChecked == true && radioButton_STW6.IsChecked == false)
            {
                StateMachine_display.Text = "Switched on (STW:xxxx xxxx x01x 0011)";
            }

            //STW:xxxx xxxx x01x 0111
            if (radioButton_STW0.IsChecked == true && radioButton_STW1.IsChecked == true && radioButton_STW2.IsChecked == true && radioButton_STW3.IsChecked == false && radioButton_STW5.IsChecked == true && radioButton_STW6.IsChecked == false)
            {
                StateMachine_display.Text = "Operation enabled (STW:xxxx xxxx x01x 0111)";
            }

            //STW:xxxx xxxx x00x 0111
            if (radioButton_STW0.IsChecked == true && radioButton_STW1.IsChecked == true && radioButton_STW2.IsChecked == true && radioButton_STW3.IsChecked == false && radioButton_STW5.IsChecked == false && radioButton_STW6.IsChecked == false)
            {
                StateMachine_display.Text = "Quick stop active (STW:xxxx xxxx x00x 0111)";
            }

            //STW:xxxx xxxx x0xx 1111
            if (radioButton_STW0.IsChecked == true && radioButton_STW1.IsChecked == true && radioButton_STW2.IsChecked == true && radioButton_STW3.IsChecked == true && radioButton_STW6.IsChecked == false)
            {
                StateMachine_display.Text = "Fault reaction active (STW:xxxx xxxx x0xx 1111)";
            }

            //STW:xxxx xxxx x0xx 1000
            if (radioButton_STW0.IsChecked == false && radioButton_STW1.IsChecked == false && radioButton_STW2.IsChecked == false && radioButton_STW3.IsChecked == true && radioButton_STW6.IsChecked == false)
            {
                StateMachine_display.Text = "Fault (STW:xxxx xxxx x0xx 1000)";
            }
        }

        private void CommandCoding_cal()
        {
            if(radioButton_CTW0.IsChecked == false && radioButton_CTW1.IsChecked == true && radioButton_CTW2.IsChecked == true && radioButton_CTW7.IsChecked == false)
            {
                command_display.Text = "Shutdown";
            }

            if (radioButton_CTW0.IsChecked == true && radioButton_CTW1.IsChecked == true && radioButton_CTW2.IsChecked == true && radioButton_CTW3.IsChecked == false && radioButton_CTW7.IsChecked == false)
            {
                command_display.Text = "Switch on";
            }

            if (radioButton_CTW0.IsChecked == true && radioButton_CTW1.IsChecked == true && radioButton_CTW2.IsChecked == true && radioButton_CTW3.IsChecked == true && radioButton_CTW7.IsChecked == false)
            {
                command_display.Text = "Switch on + enable operation";
            }

            if (radioButton_CTW1.IsChecked == false && radioButton_CTW7.IsChecked == false)
            {
                command_display.Text = "Disable voltage";
            }

            if (radioButton_CTW1.IsChecked == true && radioButton_CTW2.IsChecked == false && radioButton_CTW7.IsChecked == false)
            {
                command_display.Text = "Quick stop";
            }

            if (radioButton_CTW0.IsChecked == true && radioButton_CTW1.IsChecked == true && radioButton_CTW2.IsChecked == true && radioButton_CTW3.IsChecked == false && radioButton_CTW7.IsChecked == false)
            {
                command_display.Text = "Disable operation";
            }

            if (radioButton_CTW0.IsChecked == true && radioButton_CTW1.IsChecked == true && radioButton_CTW2.IsChecked == true && radioButton_CTW3.IsChecked == true && radioButton_CTW7.IsChecked == false)
            {
                command_display.Text = "Enable operation";
            }

            if (radioButton_CTW7.IsChecked == true)
            {
                command_display.Text = "Fault reset";
            }

        }

        private void CTW_Changed(object sender, RoutedEventArgs e)
        {
           
            if (command_from_button == true)
            {

            }
            else
            {
                textBox_CTW.Text = "";
                int CTW_DecFromCheckBox = 0;
                for (int i=0 ; i<16 ; i++)
                {                  
                   var myTextBlock = (CheckBox)this.FindName("radioButton_CTW"+i);
                   bool checkVal = myTextBlock.IsChecked.Value;
                    CTW_DecFromCheckBox += Convert.ToInt16(checkVal) * (int)Math.Pow(2, i);                   
                }
               // MessageBox.Show(Convert.ToString(DecFromCheckBox));

                
                CTW_display_dec.Text = Convert.ToString(CTW_DecFromCheckBox);
                CTW_display_hex.Text = "0x" + Convert.ToString(CTW_DecFromCheckBox, 16);                             
                CTW_display_bin.Text = Convert.ToString(CTW_DecFromCheckBox, 2);

                CommandCoding_cal();
            }
           
        }

        private void STW_Changed(object sender, RoutedEventArgs e)
        {           
            if (command_from_button == true)
            {

            }
            else
            {
                textBox_STW.Text = "";
                int STW_DecFromCheckBox = 0;
                for (int i = 0; i < 16; i++)
                {
                    var myTextBlock = (CheckBox)this.FindName("radioButton_STW" + i);
                    bool checkVal = myTextBlock.IsChecked.Value;
                    STW_DecFromCheckBox += Convert.ToInt16(checkVal) * (int)Math.Pow(2, i);
                }
                // MessageBox.Show(Convert.ToString(DecFromCheckBox));


                STW_display_dec.Text = Convert.ToString(STW_DecFromCheckBox);
                STW_display_hex.Text = "0x" + Convert.ToString(STW_DecFromCheckBox, 16);
                STW_display_bin.Text = Convert.ToString(STW_DecFromCheckBox, 2);

                StateMachine_cal();
            }

        }

      
    }
}
