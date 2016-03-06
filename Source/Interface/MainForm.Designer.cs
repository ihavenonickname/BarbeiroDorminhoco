namespace Sleepyhead
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbLastSpawn = new System.Windows.Forms.Label();
            this.lbQueue = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbHair = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbTime);
            this.groupBox1.Controls.Add(this.lbLastSpawn);
            this.groupBox1.Controls.Add(this.lbQueue);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barber shop";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(6, 61);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(14, 13);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "#";
            // 
            // lbLastSpawn
            // 
            this.lbLastSpawn.AutoSize = true;
            this.lbLastSpawn.Location = new System.Drawing.Point(6, 41);
            this.lbLastSpawn.Name = "lbLastSpawn";
            this.lbLastSpawn.Size = new System.Drawing.Size(14, 13);
            this.lbLastSpawn.TabIndex = 2;
            this.lbLastSpawn.Text = "#";
            // 
            // lbQueue
            // 
            this.lbQueue.AutoSize = true;
            this.lbQueue.Location = new System.Drawing.Point(6, 20);
            this.lbQueue.Name = "lbQueue";
            this.lbQueue.Size = new System.Drawing.Size(14, 13);
            this.lbQueue.TabIndex = 1;
            this.lbQueue.Text = "#";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(6, 48);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(14, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "#";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbStatus);
            this.groupBox3.Controls.Add(this.lbHair);
            this.groupBox3.Location = new System.Drawing.Point(12, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Barber";
            // 
            // lbHair
            // 
            this.lbHair.AutoSize = true;
            this.lbHair.Location = new System.Drawing.Point(6, 25);
            this.lbHair.Name = "lbHair";
            this.lbHair.Size = new System.Drawing.Size(14, 13);
            this.lbHair.TabIndex = 1;
            this.lbHair.Text = "#";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 205);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sleepyhead Barber";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbLastSpawn;
        private System.Windows.Forms.Label lbQueue;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbHair;
        private System.Windows.Forms.Label lbStatus;
    }
}

