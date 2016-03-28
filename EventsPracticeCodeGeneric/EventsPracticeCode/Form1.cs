using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsPracticeCode
{
    public partial class Form1 : Form
    {

        Subject mainSubject;
        Observer1 o1;
        Observer2 o2;
        Observer3 o3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             mainSubject = new Subject();
             o1 = new Observer1(mainSubject);
             o2 = new Observer2(mainSubject);
             o3 = new Observer3(mainSubject);
        }

        private void btnRaiseTheEvent_Click(object sender, EventArgs e)
        {
            mainSubject.OnNumberEvent();
        }
    }
}
