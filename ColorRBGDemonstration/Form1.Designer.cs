using ColorRBGDemonstration;

namespace DecentColour_Mach2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.graph3 = new ColorRBGDemonstration.Graph();
            this.graph2 = new ColorRBGDemonstration.Graph();
            this.graph1 = new ColorRBGDemonstration.Graph();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pick Colour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "RGB: Null";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(264, 248);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 117);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 248);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(93, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Visual Explanation";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // graph3
            // 
            this.graph3.BackColor = System.Drawing.Color.White;
            this.graph3.Location = new System.Drawing.Point(12, 267);
            this.graph3.Name = "graph3";
            this.graph3.PointColor = System.Drawing.Color.Black;
            this.graph3.PointLocation = new System.Drawing.Point(255, 255);
            this.graph3.Size = new System.Drawing.Size(290, 249);
            this.graph3.TabIndex = 2;
            this.graph3.Text = "graph3";
            this.graph3.XAxisColor = System.Drawing.Color.Red;
            this.graph3.YAxisColor = System.Drawing.Color.Green;
            this.graph3.Click += new System.EventHandler(this.graph3_Click);
            // 
            // graph2
            // 
            this.graph2.BackColor = System.Drawing.Color.White;
            this.graph2.Location = new System.Drawing.Point(308, 267);
            this.graph2.Name = "graph2";
            this.graph2.PointColor = System.Drawing.Color.Black;
            this.graph2.PointLocation = new System.Drawing.Point(0, 249);
            this.graph2.Size = new System.Drawing.Size(290, 249);
            this.graph2.TabIndex = 1;
            this.graph2.Text = "graph2";
            this.graph2.XAxisColor = System.Drawing.Color.Red;
            this.graph2.YAxisColor = System.Drawing.Color.Green;
            // 
            // graph1
            // 
            this.graph1.BackColor = System.Drawing.Color.White;
            this.graph1.Location = new System.Drawing.Point(308, 12);
            this.graph1.Name = "graph1";
            this.graph1.PointColor = System.Drawing.Color.Black;
            this.graph1.PointLocation = new System.Drawing.Point(0, 249);
            this.graph1.Size = new System.Drawing.Size(290, 249);
            this.graph1.TabIndex = 0;
            this.graph1.Text = "graph1";
            this.graph1.XAxisColor = System.Drawing.Color.Red;
            this.graph1.YAxisColor = System.Drawing.Color.Green;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 521);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.graph3);
            this.Controls.Add(this.graph2);
            this.Controls.Add(this.graph1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RGB Color Demonstration ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Graph graph1;
        private Graph graph2;
        private Graph graph3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

