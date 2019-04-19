using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class View : Form,IObserver
    {
        public View(Controller controller)
        {
            InitializeComponent();
        }

        public void Update(object arg0, object arg1)
        {
           throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
