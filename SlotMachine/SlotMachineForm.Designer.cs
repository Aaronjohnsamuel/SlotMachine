namespace SlotMachine
{
    partial class SlotMachineForm
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
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            this.picBoxSlotMachine = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalCredits = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnIncreaseBet = new System.Windows.Forms.Button();
            this.btnDecreaseBet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblWinning = new System.Windows.Forms.Label();
            this.lblJackport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlotMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Black;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(289, 367);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // picBoxSlotMachine
            // 
            this.picBoxSlotMachine.Image = global::SlotMachine.Properties.Resources.slotmachine;
            this.picBoxSlotMachine.Location = new System.Drawing.Point(12, 12);
            this.picBoxSlotMachine.Name = "picBoxSlotMachine";
            this.picBoxSlotMachine.Size = new System.Drawing.Size(364, 436);
            this.picBoxSlotMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSlotMachine.TabIndex = 7;
            this.picBoxSlotMachine.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.White;
            this.picBox1.Location = new System.Drawing.Point(58, 214);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(66, 70);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 8;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(160, 214);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(66, 70);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 9;
            this.picBox2.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(264, 214);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(66, 70);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 10;
            this.picBox3.TabStop = false;
            // 
            // lblTotalCredits
            // 
            this.lblTotalCredits.AutoSize = true;
            this.lblTotalCredits.BackColor = System.Drawing.Color.Black;
            this.lblTotalCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredits.ForeColor = System.Drawing.Color.White;
            this.lblTotalCredits.Location = new System.Drawing.Point(81, 322);
            this.lblTotalCredits.Name = "lblTotalCredits";
            this.lblTotalCredits.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCredits.TabIndex = 11;
            this.lblTotalCredits.Text = "1000";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Black;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.White;
            this.lblBet.Location = new System.Drawing.Point(186, 322);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(14, 13);
            this.lblBet.TabIndex = 12;
            this.lblBet.Text = "0";
            // 
            // btnIncreaseBet
            // 
            this.btnIncreaseBet.BackColor = System.Drawing.Color.Lime;
            this.btnIncreaseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseBet.Location = new System.Drawing.Point(49, 367);
            this.btnIncreaseBet.Name = "btnIncreaseBet";
            this.btnIncreaseBet.Size = new System.Drawing.Size(105, 23);
            this.btnIncreaseBet.TabIndex = 13;
            this.btnIncreaseBet.Text = "Increase Bet";
            this.btnIncreaseBet.UseVisualStyleBackColor = false;
            this.btnIncreaseBet.Click += new System.EventHandler(this.btnIncreaseBet_Click);
            // 
            // btnDecreaseBet
            // 
            this.btnDecreaseBet.BackColor = System.Drawing.Color.Turquoise;
            this.btnDecreaseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseBet.Location = new System.Drawing.Point(49, 392);
            this.btnDecreaseBet.Name = "btnDecreaseBet";
            this.btnDecreaseBet.Size = new System.Drawing.Size(105, 23);
            this.btnDecreaseBet.TabIndex = 14;
            this.btnDecreaseBet.Text = "Decrease Bet";
            this.btnDecreaseBet.UseVisualStyleBackColor = false;
            this.btnDecreaseBet.Click += new System.EventHandler(this.btnDecreaseBet_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(189, 367);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(189, 392);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 16;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblWinning
            // 
            this.lblWinning.AutoSize = true;
            this.lblWinning.BackColor = System.Drawing.Color.Black;
            this.lblWinning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinning.ForeColor = System.Drawing.Color.White;
            this.lblWinning.Location = new System.Drawing.Point(286, 322);
            this.lblWinning.Name = "lblWinning";
            this.lblWinning.Size = new System.Drawing.Size(14, 13);
            this.lblWinning.TabIndex = 17;
            this.lblWinning.Text = "0";
            // 
            // lblJackport
            // 
            this.lblJackport.AutoSize = true;
            this.lblJackport.BackColor = System.Drawing.Color.Black;
            this.lblJackport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJackport.ForeColor = System.Drawing.Color.White;
            this.lblJackport.Location = new System.Drawing.Point(183, 147);
            this.lblJackport.Name = "lblJackport";
            this.lblJackport.Size = new System.Drawing.Size(35, 13);
            this.lblJackport.TabIndex = 18;
            this.lblJackport.Text = "5000";
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(397, 460);
            this.Controls.Add(this.lblJackport);
            this.Controls.Add(this.lblWinning);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDecreaseBet);
            this.Controls.Add(this.btnIncreaseBet);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblTotalCredits);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.SpinPictureBox);
            this.Controls.Add(this.picBoxSlotMachine);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SlotMachineForm";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlotMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox picBoxSlotMachine;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Label lblTotalCredits;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnIncreaseBet;
        private System.Windows.Forms.Button btnDecreaseBet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblWinning;
        private System.Windows.Forms.Label lblJackport;
    }
}