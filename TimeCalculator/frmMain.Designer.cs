
namespace TimeCalculator
{
  partial class frmMain
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.dtpEnd = new System.Windows.Forms.DateTimePicker();
      this.lResult = new System.Windows.Forms.Label();
      this.dtpStart = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Start Time";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(126, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "End Time";
      // 
      // dtpEnd
      // 
      this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpEnd.Location = new System.Drawing.Point(126, 41);
      this.dtpEnd.Name = "dtpEnd";
      this.dtpEnd.ShowUpDown = true;
      this.dtpEnd.Size = new System.Drawing.Size(90, 23);
      this.dtpEnd.TabIndex = 3;
      this.dtpEnd.Value = new System.DateTime(1991, 9, 9, 0, 0, 0, 0);
      this.dtpEnd.ValueChanged += new System.EventHandler(this.CalculateTimeDifference);
      // 
      // lResult
      // 
      this.lResult.AutoSize = true;
      this.lResult.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lResult.Location = new System.Drawing.Point(12, 101);
      this.lResult.Name = "lResult";
      this.lResult.Size = new System.Drawing.Size(0, 28);
      this.lResult.TabIndex = 4;
      // 
      // dtpStart
      // 
      this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpStart.Location = new System.Drawing.Point(12, 41);
      this.dtpStart.Name = "dtpStart";
      this.dtpStart.ShowUpDown = true;
      this.dtpStart.Size = new System.Drawing.Size(90, 23);
      this.dtpStart.TabIndex = 5;
      this.dtpStart.Value = new System.DateTime(1991, 9, 9, 0, 0, 0, 0);
      this.dtpStart.ValueChanged += new System.EventHandler(this.CalculateTimeDifference);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(12, 76);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "Result";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 165);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dtpStart);
      this.Controls.Add(this.lResult);
      this.Controls.Add(this.dtpEnd);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmMain";
      this.Text = "Time Calculator";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtpEnd;
    private System.Windows.Forms.Label lResult;
    private System.Windows.Forms.DateTimePicker dtpStart;
    private System.Windows.Forms.Label label3;
  }
}

