using System;

namespace WindowsFormsApp2
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
            this.listView = new System.Windows.Forms.ListView();
            this.listViewDemolabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputlabel = new System.Windows.Forms.Label();
            this.Quitbutton = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(240, 92);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(121, 97);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDemolabel
            // 
            this.listViewDemolabel.AutoSize = true;
            this.listViewDemolabel.Location = new System.Drawing.Point(261, 54);
            this.listViewDemolabel.Name = "listViewDemolabel";
            this.listViewDemolabel.Size = new System.Drawing.Size(69, 13);
            this.listViewDemolabel.TabIndex = 1;
            this.listViewDemolabel.Text = "listviewDemo";
            this.listViewDemolabel.Click += new System.EventHandler(this.listViewDemolabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Location = new System.Drawing.Point(69, 69);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(37, 13);
            this.outputlabel.TabIndex = 3;
            this.outputlabel.Text = "output";
            // 
            // Quitbutton
            // 
            this.Quitbutton.Location = new System.Drawing.Point(61, 107);
            this.Quitbutton.Name = "Quitbutton";
            this.Quitbutton.Size = new System.Drawing.Size(75, 23);
            this.Quitbutton.TabIndex = 4;
            this.Quitbutton.Text = "Quit";
            this.Quitbutton.UseVisualStyleBackColor = true;
            this.Quitbutton.Click += new System.EventHandler(this.Quitbutton_Click);
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(61, 152);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(75, 23);
            this.printbutton.TabIndex = 5;
            this.printbutton.Text = "print";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.Quitbutton);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDemolabel);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listViewDemolabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label listViewDemolabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.Button Quitbutton;
        private System.Windows.Forms.Button printbutton;
    }
}

