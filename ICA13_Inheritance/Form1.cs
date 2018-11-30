using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA13_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap pic1 = new Bitmap(@"c:\users\rmak2\documents\visual studio 2015\Projects\ICA13_Inheritance\ICA13_Inheritance\Resources\futurama01.jpg");
            Bitmap pic2 = new Bitmap(@"c:\users\rmak2\documents\visual studio 2015\Projects\ICA13_Inheritance\ICA13_Inheritance\Resources\Zapp_Brannigan.png");
            DerivedCDrawer canvas1 = new DerivedCDrawer(pic1);
            DerivedCDrawer canvas2 = new DerivedCDrawer(pic2);
            //CDrawer nullcanvas = new DerivedCDrawer();
            
        }

        /***ICA13 Questions*****
        1: What do you get if you don't add any codes at all
        A: You just get the default CDrawer.

        2: Is it absolutely necessary to call a base class constructor with the CDrawer type? Why?
        A: No.  It calls the default values of the base class.  If a class does not have a default constructor
           it does not compile.

        3: The Zapp image looks different in the drawer than the editor.  Why?
        A: The background is transparent.  Since the background of the CDrawer is black, it's just black.
        */
    }

}
