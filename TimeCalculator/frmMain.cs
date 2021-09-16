using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculator
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
      CalculateTimeDifference();
    }

    private void CalculateTimeDifference(object sender = null, EventArgs e = null)
    {
      TimeSpan result = dtpEnd.Value - dtpStart.Value;

      lResult.Text = result.ToString();
    }
  }
}
