namespace TI_LAB_2;

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
            this.RegisterTextBox = new System.Windows.Forms.TextBox();
            this.LabelRegister = new System.Windows.Forms.Label();
            this.PlainLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.LabelCipherText = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PlainTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.ClearItems = new System.Windows.Forms.Button();
            this.CipherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterTextBox
            // 
            this.RegisterTextBox.Location = new System.Drawing.Point(23, 80);
            this.RegisterTextBox.Multiline = true;
            this.RegisterTextBox.Name = "RegisterTextBox";
            this.RegisterTextBox.Size = new System.Drawing.Size(314, 42);
            this.RegisterTextBox.TabIndex = 4;
            this.RegisterTextBox.TextChanged += new System.EventHandler(this.RegisterTextBox_TextChanged);
            // 
            // LabelRegister
            // 
            this.LabelRegister.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelRegister.Location = new System.Drawing.Point(29, 35);
            this.LabelRegister.Name = "LabelRegister";
            this.LabelRegister.Size = new System.Drawing.Size(308, 29);
            this.LabelRegister.TabIndex = 5;
            this.LabelRegister.Text = "Состояние регистров (30 состояний):";
            this.LabelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlainLabel
            // 
            this.PlainLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlainLabel.Location = new System.Drawing.Point(19, 168);
            this.PlainLabel.Name = "PlainLabel";
            this.PlainLabel.Size = new System.Drawing.Size(171, 29);
            this.PlainLabel.TabIndex = 7;
            this.PlainLabel.Text = "Исходный текст:";
            this.PlainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyLabel
            // 
            this.KeyLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLabel.Location = new System.Drawing.Point(451, 168);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(206, 29);
            this.KeyLabel.TabIndex = 9;
            this.KeyLabel.Text = "Сгенерированный ключ:";
            this.KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(23, 398);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.ReadOnly = true;
            this.CipherTextBox.Size = new System.Drawing.Size(399, 190);
            this.CipherTextBox.TabIndex = 10;
            // 
            // LabelCipherText
            // 
            this.LabelCipherText.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCipherText.Location = new System.Drawing.Point(28, 366);
            this.LabelCipherText.Name = "LabelCipherText";
            this.LabelCipherText.Size = new System.Drawing.Size(197, 29);
            this.LabelCipherText.TabIndex = 11;
            this.LabelCipherText.Text = "Зашифрованный текст:";
            this.LabelCipherText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LengthLabel
            // 
            this.LengthLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LengthLabel.Location = new System.Drawing.Point(20, 125);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(249, 41);
            this.LengthLabel.TabIndex = 12;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.Location = new System.Drawing.Point(23, 200);
            this.PlainTextBox.Multiline = true;
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.ReadOnly = true;
            this.PlainTextBox.Size = new System.Drawing.Size(399, 163);
            this.PlainTextBox.TabIndex = 6;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(455, 200);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.ReadOnly = true;
            this.KeyTextBox.Size = new System.Drawing.Size(395, 163);
            this.KeyTextBox.TabIndex = 8;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.Location = new System.Drawing.Point(512, 387);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(265, 65);
            this.OpenFileButton.TabIndex = 17;
            this.OpenFileButton.Text = "Прочитать из файла";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFileButton.Location = new System.Drawing.Point(512, 461);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(265, 65);
            this.SaveFileButton.TabIndex = 18;
            this.SaveFileButton.Text = "Сохранить результат в файл";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // ClearItems
            // 
            this.ClearItems.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearItems.Location = new System.Drawing.Point(512, 532);
            this.ClearItems.Name = "ClearItems";
            this.ClearItems.Size = new System.Drawing.Size(265, 65);
            this.ClearItems.TabIndex = 19;
            this.ClearItems.Text = "Очистить поля";
            this.ClearItems.UseVisualStyleBackColor = true;
            this.ClearItems.Click += new System.EventHandler(this.ClearItems_Click);
            // 
            // CipherButton
            // 
            this.CipherButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherButton.Location = new System.Drawing.Point(455, 57);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(265, 65);
            this.CipherButton.TabIndex = 20;
            this.CipherButton.Text = "Зашифровать/дешифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(882, 604);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.ClearItems);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.PlainTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.PlainLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.LabelCipherText);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.RegisterTextBox);
            this.Controls.Add(this.LabelRegister);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;

    private System.Windows.Forms.Label LengthLabel;

    private System.Windows.Forms.Label LabelCipherText;

    private System.Windows.Forms.TextBox CipherTextBox;

    private System.Windows.Forms.Label KeyLabel;

    private System.Windows.Forms.Label PlainLabel;

    private System.Windows.Forms.Label LabelRegister;

    private System.Windows.Forms.TextBox RegisterTextBox;

    #endregion

    private System.Windows.Forms.TextBox PlainTextBox;
    private System.Windows.Forms.TextBox KeyTextBox;
    private System.Windows.Forms.Button OpenFileButton;
    private System.Windows.Forms.Button SaveFileButton;
    private System.Windows.Forms.Button ClearItems;
    private System.Windows.Forms.Button CipherButton;
}