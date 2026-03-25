using System.ComponentModel;

namespace ManagementPerpustakaan;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        UsernameTextBox = new System.Windows.Forms.TextBox();
        PasswordTextBox = new System.Windows.Forms.TextBox();
        LihatPasswordChk = new System.Windows.Forms.CheckBox();
        LoginBtn = new System.Windows.Forms.Button();
        KembaliBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 34F);
        label1.Location = new System.Drawing.Point(191, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(451, 77);
        label1.TabIndex = 0;
        label1.Text = "Selamat Datang";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F);
        label2.Location = new System.Drawing.Point(191, 100);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(434, 44);
        label2.TabIndex = 1;
        label2.Text = "Di sistem managemen digital perpustakaan x";
        label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(211, 166);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(146, 28);
        label3.TabIndex = 2;
        label3.Text = "Username";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(211, 236);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(146, 28);
        label4.TabIndex = 3;
        label4.Text = "Password";
        // 
        // UsernameTextBox
        // 
        UsernameTextBox.Location = new System.Drawing.Point(211, 197);
        UsernameTextBox.Name = "UsernameTextBox";
        UsernameTextBox.Size = new System.Drawing.Size(295, 27);
        UsernameTextBox.TabIndex = 4;
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.Location = new System.Drawing.Point(211, 267);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new System.Drawing.Size(295, 27);
        PasswordTextBox.TabIndex = 5;
        PasswordTextBox.UseSystemPasswordChar = true;
        // 
        // LihatPasswordChk
        // 
        LihatPasswordChk.Location = new System.Drawing.Point(371, 307);
        LihatPasswordChk.Name = "LihatPasswordChk";
        LihatPasswordChk.Size = new System.Drawing.Size(134, 29);
        LihatPasswordChk.TabIndex = 6;
        LihatPasswordChk.Text = "Lihat Password";
        LihatPasswordChk.UseVisualStyleBackColor = true;
        LihatPasswordChk.CheckedChanged += LihatPasswordChk_CheckedChanged;
        // 
        // LoginBtn
        // 
        LoginBtn.BackColor = System.Drawing.Color.DodgerBlue;
        LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
        LoginBtn.Location = new System.Drawing.Point(211, 344);
        LoginBtn.Name = "LoginBtn";
        LoginBtn.Size = new System.Drawing.Size(101, 41);
        LoginBtn.TabIndex = 7;
        LoginBtn.Text = "Login";
        LoginBtn.UseVisualStyleBackColor = false;
        LoginBtn.Click += LoginBtn_Click;
        // 
        // KembaliBtn
        // 
        KembaliBtn.BackColor = System.Drawing.Color.Red;
        KembaliBtn.ForeColor = System.Drawing.Color.White;
        KembaliBtn.Location = new System.Drawing.Point(318, 344);
        KembaliBtn.Name = "KembaliBtn";
        KembaliBtn.Size = new System.Drawing.Size(101, 41);
        KembaliBtn.TabIndex = 8;
        KembaliBtn.Text = "Kembali";
        KembaliBtn.UseVisualStyleBackColor = false;
        KembaliBtn.Click += KembaliBtn_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(KembaliBtn);
        Controls.Add(LoginBtn);
        Controls.Add(LihatPasswordChk);
        Controls.Add(PasswordTextBox);
        Controls.Add(UsernameTextBox);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "LoginForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.CheckBox LihatPasswordChk;
    private System.Windows.Forms.Button LoginBtn;
    private System.Windows.Forms.Button KembaliBtn;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox UsernameTextBox;
    private System.Windows.Forms.TextBox PasswordTextBox;

    private System.Windows.Forms.Label label1;

    #endregion
}