namespace Snake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.GameGrid = new System.Windows.Forms.Panel();
            this.KeyboardButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SnakeDirection = new System.Windows.Forms.Timer(this.components);
            this.GameGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameGrid
            // 
            this.GameGrid.Controls.Add(this.KeyboardButton);
            this.GameGrid.Controls.Add(this.StartButton);
            this.GameGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameGrid.Location = new System.Drawing.Point(0, 0);
            this.GameGrid.Name = "GameGrid";
            this.GameGrid.Size = new System.Drawing.Size(909, 385);
            this.GameGrid.TabIndex = 0;
            // 
            // KeyboardButton
            // 
            this.KeyboardButton.Location = new System.Drawing.Point(26, 12);
            this.KeyboardButton.Name = "KeyboardButton";
            this.KeyboardButton.Size = new System.Drawing.Size(94, 29);
            this.KeyboardButton.TabIndex = 1;
            this.KeyboardButton.Text = "Keyboard";
            this.KeyboardButton.UseVisualStyleBackColor = true;
            this.KeyboardButton.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(294, 134);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(188, 90);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SnakeDirection
            // 
            this.SnakeDirection.Enabled = true;
            this.SnakeDirection.Tick += new System.EventHandler(this.SnakeDirection_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 385);
            this.Controls.Add(this.GameGrid);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.GameGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel GameGrid;
        private Button StartButton;
        private Button KeyboardButton;
        private System.Windows.Forms.Timer SnakeDirection;
    }
}