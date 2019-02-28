using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace UEBuildFromSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\\Epic Games\\Unreal Engine\\Builds");
            if (key != null)
            {
                foreach (var v in key.GetValueNames())
                {
                   //Console.WriteLine(key.GetValue(v));
                   EngineVersions.Items.Add(key.GetValue(v));
                }
            }
            //RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Software\\Epic Games\\Unreal Engine\\");
            //if (key != null)
            //{
            //    foreach (var v in key.GetValueNames())
            //    {
            //        Console.WriteLine(key.GetValue(v));
            //        EngineVersions.Items.Add(key.GetValue(v));
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Key was null");

            //}




            string text = File.ReadAllText("A:\\Wuerth\\Warehouse\\UE4\\WarehouseVRsssssssssss\\WuerthTrainingDemo.uproject", Encoding.UTF8);
            string[] allLines = text.Split('{');
            var version = allLines[2];
            allLines = version.Split('}');
            version = allLines[0];

            test.Text = version;
            //Console.Write(allLines[1]);
            //Console.Wte(allLines[2]);
            //Console.Write(allLines[3]);
            //Console.Write(allLines[4]);
            Console.Write(version);
            //Console.Write(allLines[6]);






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string text = File.ReadAllText(projectPath.Text, Encoding.UTF8);
            //string[] allLines = text.Split('\"');
            //var version = allLines[3];


            //Console.Write(version);



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=JR29YVVMEG54Y&source=url
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
