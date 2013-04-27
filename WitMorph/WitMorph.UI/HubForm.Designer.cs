﻿namespace WitMorph.UI
{
    partial class HubForm
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
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.TextBox textBox2;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.TextBox textBox3;
            System.Windows.Forms.TextBox textBox4;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.RadioButton radioButton3;
            System.Windows.Forms.RadioButton radioButton2;
            System.Windows.Forms.RadioButton radioButton1;
            System.Windows.Forms.Button button5;
            System.Windows.Forms.Button button6;
            System.Windows.Forms.TextBox textBox5;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.TextBox textBox6;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Button button7;
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            textBox5 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            textBox6 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            button7 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "CurrentCollectionUri", true));
            textBox1.Location = new System.Drawing.Point(116, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(269, 20);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "CurrentProjectName", true));
            textBox2.Location = new System.Drawing.Point(116, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(269, 20);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(262, 71);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(123, 23);
            button1.TabIndex = 7;
            button1.Text = "Select Team Project";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.SelectCurrentTeamProject_Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(291, 94);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(123, 23);
            button2.TabIndex = 12;
            button2.Text = "Select Team Project";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.SelectGoalTeamProject_Click);
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "GoalProjectName", true));
            textBox3.Location = new System.Drawing.Point(145, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(269, 20);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "GoalCollectionUri", true));
            textBox4.Location = new System.Drawing.Point(145, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(269, 20);
            textBox4.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(535, 114);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Team Project to convert to a new process";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 13);
            label2.TabIndex = 5;
            label2.Text = "Project Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 3;
            label1.Text = "Collection Uri:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new System.Drawing.Point(12, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(535, 380);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Process to convert to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(35, 71);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 13);
            label3.TabIndex = 10;
            label3.Text = "Project Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(35, 45);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 13);
            label4.TabIndex = 8;
            label4.Text = "Collection Uri:";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Enabled = false;
            radioButton3.Location = new System.Drawing.Point(9, 168);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(223, 17);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Use process template from folder or zip file";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Location = new System.Drawing.Point(9, 145);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(198, 17);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Use process template from collection";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(9, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(195, 17);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Use process from an existing project";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(665, 50);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(207, 23);
            button5.TabIndex = 11;
            button5.Text = "Apply Actions from File";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(665, 239);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(207, 23);
            button6.TabIndex = 12;
            button6.Text = "Open Actions viewer/editor";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "ProcessMapFile", true));
            textBox5.Location = new System.Drawing.Point(116, 222);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(269, 20);
            textBox5.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 225);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 13);
            label5.TabIndex = 13;
            label5.Text = "Process Map File:";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(262, 316);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(123, 23);
            button4.TabIndex = 16;
            button4.Text = "Select Output File";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(this.SelectOutputFile_Click);
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(262, 248);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(123, 23);
            button3.TabIndex = 15;
            button3.Text = "Select Process Map";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.SelectProcessMap_Click);
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "OutputActionsFile", true));
            textBox6.Location = new System.Drawing.Point(116, 290);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(269, 20);
            textBox6.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 293);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 13);
            label6.TabIndex = 17;
            label6.Text = "Output Actions File:";
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(406, 351);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(123, 23);
            button7.TabIndex = 19;
            button7.Text = "Generate Actions";
            button7.UseVisualStyleBackColor = true;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(WitMorph.UI.HubViewModel);
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 524);
            this.Controls.Add(button6);
            this.Controls.Add(button5);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Name = "HubForm";
            this.Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource modelBindingSource;
    }
}
