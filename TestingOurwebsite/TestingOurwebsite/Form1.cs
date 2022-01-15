using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Threading;
using OpenQA.Selenium.Firefox;


// /This code run just at google chrome V.85
// /This code run just at google chrome V.85
// /This code run just at google chrome V.85


namespace TestingOurwebsite
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private ChromeDriver drv;
        private Thread th;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxChanged(object sender, EventArgs e)
        {
            if (Username.Text != " " && Password.Text != " " && NameCard.Text != " " && CardNumber.Text != " " && Year.Text != " " && Month.Text != " " && CVV.Text != " ")
            {
                LoginBTN.ForeColor = Color.Aqua;
                LoginBTN.Cursor = Cursors.Hand;
            }
            else
            {
                LoginBTN.ForeColor = Color.Red;
                LoginBTN.Cursor = Cursors.No;

            }
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (LoginBTN.Cursor == Cursors.Hand)
            {
                th = new Thread(Result);
                th.Start();

            }
        }

        private void Result()
        {
           LoginBTN.ForeColor=Color.Blue;
           LoginBTN.UseWaitCursor = true;
          // LoginBTN.Text = "Testing.";
           OpenSelenium();
           Thread.Sleep(3000);
           Login(Username.Text, Password.Text,NameCard.Text,CardNumber.Text,Year.Text,Month.Text,CVV.Text);

        }

        private void Login(string username, string password,string nameoncard,string numbercard,string year,string month,string cvv)
        {
            try
            {
                // /This code run just at google chrome V.85
                // /This code run just at google chrome V.85
                // /This code run just at google chrome V.85



                //Login Test
                drv.FindElements(By.XPath("//input[@class='form-control']"))[0].SendKeys(username); //Fill Email Field
                Thread.Sleep(1000);
                drv.FindElements(By.XPath("//input[@class='form-control']"))[1].SendKeys(password); //Fill Password field
                Thread.Sleep(1000);
                drv.FindElement(By.XPath("//button[@class='btn btn-primary btn-block']")).Click(); //Click at login button


                //Make Appointment Test
                Thread.Sleep(1000);
                drv.FindElement(By.XPath("//html/body/div[2]/main/section[2]/div/div/div[1]/div[2]/a")).Click(); //Click at All Doctors
                Thread.Sleep(1000);
                drv.FindElement(By.XPath("// html / body / div[2] / main / div[1] / div[2] / div / div[1] / div[2] / div[2] / div[2] / a")).Click(); //Choose doctor
                Thread.Sleep(1000);
                drv.FindElement(By.XPath("// html / body / div[2] / main / div / div / div / div / div[2] / div / div / div / ul / li[4] / a[2]")).Click(); //Click at book now
                Thread.Sleep(1000);
                drv.FindElements(By.XPath("//input[@class='form-control']"))[0].SendKeys(nameoncard); //Fill Name On Card
                Thread.Sleep(1000);
                drv.FindElements(By.XPath("//input[@class='form-control']"))[1].SendKeys(numbercard); //Fill Card Number
                Thread.Sleep(1000);
                drv.FindElements(By.XPath("//input[@class='form-control']"))[2].SendKeys(year); //Fill Year Expiry
                Thread.Sleep(1000);
                drv.FindElements(By.XPath("//input[@class='form-control']"))[3].SendKeys(month); //Fill Month Expiry
                Thread.Sleep(1000);
                drv.FindElements(By.XPath("//input[@class='form-control']"))[4].SendKeys(cvv); //Fill CVV
                Thread.Sleep(1000);
                drv.FindElement(By.XPath("// html / body / div[2] / main / div / div / div / div[1] / div / div / form / div / input")).Click();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


           

        }

        private void OpenSelenium()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            drv = new OpenQA.Selenium.Chrome.ChromeDriver(service);
            //driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            drv.Navigate().GoToUrl("https://localhost:44395/Identity/Account/Login");

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseSelenium();
        }

        private void CloseSelenium()
        {
            drv.Quit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
