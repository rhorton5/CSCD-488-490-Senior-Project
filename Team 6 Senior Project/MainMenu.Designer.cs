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
            this.openExistingButton = new System.Windows.Forms.Button();
            this.btnSpecimens = new System.Windows.Forms.Button();
            this.btnTemplates = new System.Windows.Forms.Button();
            this.btnSpecimensSummary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openExistingButton
            // 
            this.openExistingButton.Location = new System.Drawing.Point(55, 136);
            this.openExistingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openExistingButton.Name = "openExistingButton";
            this.openExistingButton.Size = new System.Drawing.Size(513, 88);
            this.openExistingButton.TabIndex = 0;
            this.openExistingButton.Text = "Open Existing";
            this.openExistingButton.UseVisualStyleBackColor = true;
            this.openExistingButton.Click += new System.EventHandler(this.OpenExistingButton_Click);
            // 
            // btnSpecimens
            // 
            this.btnSpecimens.Location = new System.Drawing.Point(55, 236);
            this.btnSpecimens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpecimens.Name = "btnSpecimens";
            this.btnSpecimens.Size = new System.Drawing.Size(513, 88);
            this.btnSpecimens.TabIndex = 3;
            this.btnSpecimens.Text = "Specimens";
            this.btnSpecimens.UseVisualStyleBackColor = true;
            this.btnSpecimens.Click += new System.EventHandler(this.BtnSpecimens_Click);
            // 
            // btnTemplates
            // 
            this.btnTemplates.Location = new System.Drawing.Point(55, 349);
            this.btnTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(513, 88);
            this.btnTemplates.TabIndex = 4;
            this.btnTemplates.Text = "Templates";
            this.btnTemplates.UseVisualStyleBackColor = true;
            this.btnTemplates.Click += new System.EventHandler(this.BtnTemplates_Click);
            // 
            // btnSpecimensSummary
            // 
            this.btnSpecimensSummary.Location = new System.Drawing.Point(55, 464);
            this.btnSpecimensSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpecimensSummary.Name = "btnSpecimensSummary";
            this.btnSpecimensSummary.Size = new System.Drawing.Size(513, 88);
            this.btnSpecimensSummary.TabIndex = 5;
            this.btnSpecimensSummary.Text = "Specimens Summary";
            this.btnSpecimensSummary.UseVisualStyleBackColor = true;
            this.btnSpecimensSummary.Click += new System.EventHandler(this.BtnSpecimensSummary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 726);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Team 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Logo";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 798);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpecimensSummary);
            this.Controls.Add(this.btnTemplates);
            this.Controls.Add(this.btnSpecimens);
            this.Controls.Add(this.openExistingButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "CSCD 488/490 Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button openExistingButton;
    private System.Windows.Forms.Button btnSpecimens;
    private System.Windows.Forms.Button btnTemplates;
    private System.Windows.Forms.Button btnSpecimensSummary;
    private Label label1;
    private Label label2;
    private Label label3;
}


