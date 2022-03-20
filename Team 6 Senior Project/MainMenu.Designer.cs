namespace Team_6_Senior_Project;

partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.openExistingButton = new System.Windows.Forms.Button();
            this.btnSpecimens = new System.Windows.Forms.Button();
            this.btnTemplates = new System.Windows.Forms.Button();
            this.btnSpecimensSummary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openExistingButton
            // 
            this.openExistingButton.Location = new System.Drawing.Point(96, 364);
            this.openExistingButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.openExistingButton.Name = "openExistingButton";
            this.openExistingButton.Size = new System.Drawing.Size(770, 132);
            this.openExistingButton.TabIndex = 0;
            this.openExistingButton.Text = "Open Existing";
            this.openExistingButton.UseVisualStyleBackColor = true;
            this.openExistingButton.Click += new System.EventHandler(this.OpenExistingButton_Click);
            // 
            // btnSpecimens
            // 
            this.btnSpecimens.Location = new System.Drawing.Point(96, 514);
            this.btnSpecimens.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSpecimens.Name = "btnSpecimens";
            this.btnSpecimens.Size = new System.Drawing.Size(770, 132);
            this.btnSpecimens.TabIndex = 1;
            this.btnSpecimens.Text = "Specimens";
            this.btnSpecimens.UseVisualStyleBackColor = true;
            this.btnSpecimens.Click += new System.EventHandler(this.BtnSpecimens_Click);
            // 
            // btnTemplates
            // 
            this.btnTemplates.Location = new System.Drawing.Point(96, 684);
            this.btnTemplates.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(770, 132);
            this.btnTemplates.TabIndex = 2;
            this.btnTemplates.Text = "Templates";
            this.btnTemplates.UseVisualStyleBackColor = true;
            this.btnTemplates.Click += new System.EventHandler(this.BtnTemplates_Click);
            // 
            // btnSpecimensSummary
            // 
            this.btnSpecimensSummary.Location = new System.Drawing.Point(96, 856);
            this.btnSpecimensSummary.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSpecimensSummary.Name = "btnSpecimensSummary";
            this.btnSpecimensSummary.Size = new System.Drawing.Size(770, 132);
            this.btnSpecimensSummary.TabIndex = 3;
            this.btnSpecimensSummary.Text = "Specimens Summary";
            this.btnSpecimensSummary.UseVisualStyleBackColor = true;
            this.btnSpecimensSummary.Click += new System.EventHandler(this.BtnSpecimensSummary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 1042);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Team 6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 1128);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpecimensSummary);
            this.Controls.Add(this.btnTemplates);
            this.Controls.Add(this.btnSpecimens);
            this.Controls.Add(this.openExistingButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MainMenu";
            this.Text = "Eagle Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button openExistingButton;
    private System.Windows.Forms.Button btnSpecimens;
    private System.Windows.Forms.Button btnTemplates;
    private System.Windows.Forms.Button btnSpecimensSummary;
    private Label label1;
    private PictureBox pictureBox1;
}


