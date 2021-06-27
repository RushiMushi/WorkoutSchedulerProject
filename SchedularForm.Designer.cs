namespace Individual_Project
{
    partial class SchedularForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.strengthRB = new System.Windows.Forms.RadioButton();
            this.massRB = new System.Windows.Forms.RadioButton();
            this.daytwo = new System.Windows.Forms.ListBox();
            this.daythree = new System.Windows.Forms.ListBox();
            this.dayone = new System.Windows.Forms.ListBox();
            this.dayonemove = new System.Windows.Forms.Button();
            this.daytwomove = new System.Windows.Forms.Button();
            this.daythreemove = new System.Windows.Forms.Button();
            this.refreshschedule = new System.Windows.Forms.Button();
            this.legscb = new System.Windows.Forms.CheckBox();
            this.armscb = new System.Windows.Forms.CheckBox();
            this.chestcb = new System.Windows.Forms.CheckBox();
            this.backcb = new System.Windows.Forms.CheckBox();
            this.abscb = new System.Windows.Forms.CheckBox();
            this.createschedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Goal:";
            // 
            // strengthRB
            // 
            this.strengthRB.AutoSize = true;
            this.strengthRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthRB.Location = new System.Drawing.Point(291, 148);
            this.strengthRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strengthRB.Name = "strengthRB";
            this.strengthRB.Size = new System.Drawing.Size(107, 29);
            this.strengthRB.TabIndex = 8;
            this.strengthRB.TabStop = true;
            this.strengthRB.Text = "Strength";
            this.strengthRB.UseVisualStyleBackColor = true;
            // 
            // massRB
            // 
            this.massRB.AutoSize = true;
            this.massRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massRB.Location = new System.Drawing.Point(291, 181);
            this.massRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.massRB.Name = "massRB";
            this.massRB.Size = new System.Drawing.Size(81, 29);
            this.massRB.TabIndex = 9;
            this.massRB.TabStop = true;
            this.massRB.Text = "Mass";
            this.massRB.UseVisualStyleBackColor = true;
            // 
            // daytwo
            // 
            this.daytwo.FormattingEnabled = true;
            this.daytwo.ItemHeight = 16;
            this.daytwo.Location = new System.Drawing.Point(724, 110);
            this.daytwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daytwo.Name = "daytwo";
            this.daytwo.Size = new System.Drawing.Size(184, 180);
            this.daytwo.TabIndex = 13;
            this.daytwo.SelectedIndexChanged += new System.EventHandler(this.Daytwo_SelectedIndexChanged);
            // 
            // daythree
            // 
            this.daythree.FormattingEnabled = true;
            this.daythree.ItemHeight = 16;
            this.daythree.Location = new System.Drawing.Point(928, 110);
            this.daythree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daythree.Name = "daythree";
            this.daythree.Size = new System.Drawing.Size(189, 180);
            this.daythree.TabIndex = 14;
            this.daythree.SelectedIndexChanged += new System.EventHandler(this.Daythree_SelectedIndexChanged);
            // 
            // dayone
            // 
            this.dayone.FormattingEnabled = true;
            this.dayone.ItemHeight = 16;
            this.dayone.Location = new System.Drawing.Point(509, 110);
            this.dayone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayone.Name = "dayone";
            this.dayone.Size = new System.Drawing.Size(181, 180);
            this.dayone.TabIndex = 15;
            this.dayone.SelectedIndexChanged += new System.EventHandler(this.Dayone_SelectedIndexChanged_1);
            // 
            // dayonemove
            // 
            this.dayonemove.Location = new System.Drawing.Point(509, 306);
            this.dayonemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayonemove.Name = "dayonemove";
            this.dayonemove.Size = new System.Drawing.Size(183, 50);
            this.dayonemove.TabIndex = 16;
            this.dayonemove.Text = "Move to Day One";
            this.dayonemove.UseVisualStyleBackColor = true;
            this.dayonemove.Click += new System.EventHandler(this.Dayonemove_Click);
            // 
            // daytwomove
            // 
            this.daytwomove.Location = new System.Drawing.Point(724, 306);
            this.daytwomove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daytwomove.Name = "daytwomove";
            this.daytwomove.Size = new System.Drawing.Size(185, 50);
            this.daytwomove.TabIndex = 17;
            this.daytwomove.Text = "Move to Day Two";
            this.daytwomove.UseVisualStyleBackColor = true;
            this.daytwomove.Click += new System.EventHandler(this.Daytwomove_Click);
            // 
            // daythreemove
            // 
            this.daythreemove.Location = new System.Drawing.Point(928, 306);
            this.daythreemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daythreemove.Name = "daythreemove";
            this.daythreemove.Size = new System.Drawing.Size(191, 50);
            this.daythreemove.TabIndex = 18;
            this.daythreemove.Text = "Move to Day Three";
            this.daythreemove.UseVisualStyleBackColor = true;
            this.daythreemove.Click += new System.EventHandler(this.Daythreemove_Click);
            // 
            // refreshschedule
            // 
            this.refreshschedule.Location = new System.Drawing.Point(665, 415);
            this.refreshschedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshschedule.Name = "refreshschedule";
            this.refreshschedule.Size = new System.Drawing.Size(212, 53);
            this.refreshschedule.TabIndex = 21;
            this.refreshschedule.Text = "Clear Schedule";
            this.refreshschedule.UseVisualStyleBackColor = true;
            this.refreshschedule.Click += new System.EventHandler(this.Refreshschedule_Click);
            // 
            // legscb
            // 
            this.legscb.AutoSize = true;
            this.legscb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legscb.Location = new System.Drawing.Point(16, 169);
            this.legscb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.legscb.Name = "legscb";
            this.legscb.Size = new System.Drawing.Size(68, 24);
            this.legscb.TabIndex = 25;
            this.legscb.Text = "Legs";
            this.legscb.UseVisualStyleBackColor = true;
            // 
            // armscb
            // 
            this.armscb.AutoSize = true;
            this.armscb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armscb.Location = new System.Drawing.Point(16, 201);
            this.armscb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.armscb.Name = "armscb";
            this.armscb.Size = new System.Drawing.Size(71, 24);
            this.armscb.TabIndex = 26;
            this.armscb.Text = "Arms";
            this.armscb.UseVisualStyleBackColor = true;
            // 
            // chestcb
            // 
            this.chestcb.AutoSize = true;
            this.chestcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestcb.Location = new System.Drawing.Point(16, 233);
            this.chestcb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chestcb.Name = "chestcb";
            this.chestcb.Size = new System.Drawing.Size(75, 24);
            this.chestcb.TabIndex = 27;
            this.chestcb.Text = "Chest";
            this.chestcb.UseVisualStyleBackColor = true;
            // 
            // backcb
            // 
            this.backcb.AutoSize = true;
            this.backcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backcb.Location = new System.Drawing.Point(16, 297);
            this.backcb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backcb.Name = "backcb";
            this.backcb.Size = new System.Drawing.Size(69, 24);
            this.backcb.TabIndex = 28;
            this.backcb.Text = "Back";
            this.backcb.UseVisualStyleBackColor = true;
            // 
            // abscb
            // 
            this.abscb.AutoSize = true;
            this.abscb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abscb.Location = new System.Drawing.Point(16, 265);
            this.abscb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.abscb.Name = "abscb";
            this.abscb.Size = new System.Drawing.Size(60, 24);
            this.abscb.TabIndex = 29;
            this.abscb.Text = "Abs";
            this.abscb.UseVisualStyleBackColor = true;
            // 
            // createschedule
            // 
            this.createschedule.Location = new System.Drawing.Point(92, 378);
            this.createschedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createschedule.Name = "createschedule";
            this.createschedule.Size = new System.Drawing.Size(155, 49);
            this.createschedule.TabIndex = 30;
            this.createschedule.Text = "Create Schedule";
            this.createschedule.UseVisualStyleBackColor = true;
            this.createschedule.Click += new System.EventHandler(this.Createschedule_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 64);
            this.label1.TabIndex = 31;
            this.label1.Text = "Muscle Groups \r\nTo Target:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "Day One:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 39);
            this.label4.TabIndex = 33;
            this.label4.Text = "Day Two:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(920, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 39);
            this.label5.TabIndex = 34;
            this.label5.Text = "Day Three:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 39);
            this.label6.TabIndex = 35;
            this.label6.Text = "Workout Scheduler";
            // 
            // SchedularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 559);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createschedule);
            this.Controls.Add(this.abscb);
            this.Controls.Add(this.backcb);
            this.Controls.Add(this.chestcb);
            this.Controls.Add(this.armscb);
            this.Controls.Add(this.legscb);
            this.Controls.Add(this.refreshschedule);
            this.Controls.Add(this.daythreemove);
            this.Controls.Add(this.daytwomove);
            this.Controls.Add(this.dayonemove);
            this.Controls.Add(this.dayone);
            this.Controls.Add(this.daythree);
            this.Controls.Add(this.daytwo);
            this.Controls.Add(this.massRB);
            this.Controls.Add(this.strengthRB);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SchedularForm";
            this.Text = "Schedular Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton strengthRB;
        private System.Windows.Forms.RadioButton massRB;
        private System.Windows.Forms.ListBox daytwo;
        private System.Windows.Forms.ListBox daythree;
        private System.Windows.Forms.ListBox dayone;
        private System.Windows.Forms.Button dayonemove;
        private System.Windows.Forms.Button daytwomove;
        private System.Windows.Forms.Button daythreemove;
        private System.Windows.Forms.Button refreshschedule;
        private System.Windows.Forms.CheckBox legscb;
        private System.Windows.Forms.CheckBox armscb;
        private System.Windows.Forms.CheckBox chestcb;
        private System.Windows.Forms.CheckBox backcb;
        private System.Windows.Forms.CheckBox abscb;
        private System.Windows.Forms.Button createschedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

