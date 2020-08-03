namespace GitHubExperiment
{
     partial class Form1
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
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
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               this.button1 = new System.Windows.Forms.Button();
               this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
               this.label1 = new System.Windows.Forms.Label();
               this.timer1 = new System.Windows.Forms.Timer(this.components);
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(34, 205);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 23);
               this.button1.TabIndex = 0;
               this.button1.Text = "Show Info";
               this.toolTip1.SetToolTip(this.button1, "Click This Button To Show Some Interesting Information\r\nAbout GitHub");
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // toolTip1
               // 
               this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(31, 35);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(35, 13);
               this.label1.TabIndex = 1;
               this.label1.Text = "label1";
               // 
               // timer1
               // 
               this.timer1.Enabled = true;
               this.timer1.Interval = 10000;
               this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::GitHubExperiment.Properties.Resources.GitHub;
               this.pictureBox1.Location = new System.Drawing.Point(310, 105);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(148, 158);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 2;
               this.pictureBox1.TabStop = false;
               // 
               // dateTimePicker1
               // 
               this.dateTimePicker1.Location = new System.Drawing.Point(258, 12);
               this.dateTimePicker1.Name = "dateTimePicker1";
               this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
               this.dateTimePicker1.TabIndex = 3;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(470, 275);
               this.Controls.Add(this.dateTimePicker1);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.button1);
               this.Name = "Form1";
               this.Text = "GitHub Sample";
               this.Load += new System.EventHandler(this.Form1_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.ToolTip toolTip1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Timer timer1;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.DateTimePicker dateTimePicker1;
     }
}

