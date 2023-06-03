using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calendar
{
    public class Calendar : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MonthCalendar mc1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.Container components = null;

        public Calendar()
        {
            InitializeComponent();
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.mc1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mc1
            // 
            this.mc1.FirstDayOfWeek = System.Windows.Forms.Day.Thursday;
            this.mc1.Location = new System.Drawing.Point(16, 16);
            this.mc1.Name = "mc1";
            this.mc1.ShowTodayCircle = false;
            this.mc1.ShowWeekNumbers = true;
            this.mc1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "tarih butonu olcak";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Takvim kutusu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(289, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mc1);
            this.Name = "Calendar";
            this.Text = "Takvim";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);

        }
        #endregion

        static void Main()
        {
            Application.Run(new Calendar());
        }

        private void Calendar_Load(object sender, System.EventArgs e)
        {
            string str = mc1.Text.ToString();
        }
        private void button1_Click_1(object sender, System.EventArgs e)
        {
         //burası tarih bulma fonksiyonu
        }
    }
}
