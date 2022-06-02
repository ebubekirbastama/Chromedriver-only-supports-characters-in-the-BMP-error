using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows.Forms;

namespace ChromeDriver_only_supports_characters_in_the_BMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ChromeDriver drv;
        string GoogleUrl = "https://www.google.com.tr/";
        string EBSJS = "var elm = arguments[0], txt = arguments[1]; elm.value += txt;elm.dispatchEvent(new Event('change'));";

        public string Xpath = "//*[@class='gLFyf gsfi']";

        private void button1_Click(object sender, EventArgs e)
        {
            //drv.FindElement(By.XPath("//*[@class='gLFyf gsfi']")).SendKeys(richTextBox1.Text); !error code!
            //OpenQA.Selenium.WebDriverException: 'unknown error: ChromeDriver only supports characters in the BMP(Session info: chrome = 102.0.5005.63)' 

            //error free code

            var EBSElement = drv.FindElement(By.XPath(Xpath));
            drv.ExecuteScript(EBSJS, EBSElement, richTextBox1.Text);
            
            //error free code
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drv = new ChromeDriver();
            drv.Navigate().GoToUrl(GoogleUrl);
        }
    }
}
