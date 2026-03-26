using System.ComponentModel;

namespace ManagementPerpustakaan.CustomForms;

partial class InsertBukuForms
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
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        JudulBuku_field = new System.Windows.Forms.TextBox();
        Penulis_field = new System.Windows.Forms.TextBox();
        TahunTerbit_field = new System.Windows.Forms.TextBox();
        Kategori_field = new System.Windows.Forms.ComboBox();
        Stok_field = new System.Windows.Forms.TextBox();
        Deskripsi_field = new System.Windows.Forms.RichTextBox();
        Insert_btn = new System.Windows.Forms.Button();
        Cancel_btn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(20, 27);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(87, 22);
        label1.TabIndex = 0;
        label1.Text = "Judul Buku";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(20, 62);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(87, 22);
        label2.TabIndex = 1;
        label2.Text = "Penulis";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(0, 97);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(107, 22);
        label3.TabIndex = 2;
        label3.Text = "Tahun Terbit";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(20, 132);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(87, 22);
        label4.TabIndex = 3;
        label4.Text = "Kategori";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(20, 165);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(87, 22);
        label5.TabIndex = 4;
        label5.Text = "Stok";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(20, 199);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(87, 22);
        label6.TabIndex = 5;
        label6.Text = "Deskripsi";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // JudulBuku_field
        // 
        JudulBuku_field.Location = new System.Drawing.Point(123, 33);
        JudulBuku_field.Name = "JudulBuku_field";
        JudulBuku_field.Size = new System.Drawing.Size(305, 27);
        JudulBuku_field.TabIndex = 6;
        // 
        // Penulis_field
        // 
        Penulis_field.Location = new System.Drawing.Point(123, 66);
        Penulis_field.Name = "Penulis_field";
        Penulis_field.Size = new System.Drawing.Size(305, 27);
        Penulis_field.TabIndex = 7;
        // 
        // TahunTerbit_field
        // 
        TahunTerbit_field.Location = new System.Drawing.Point(123, 99);
        TahunTerbit_field.Name = "TahunTerbit_field";
        TahunTerbit_field.Size = new System.Drawing.Size(305, 27);
        TahunTerbit_field.TabIndex = 8;
        // 
        // Kategori_field
        // 
        Kategori_field.FormattingEnabled = true;
        Kategori_field.Location = new System.Drawing.Point(123, 137);
        Kategori_field.Name = "Kategori_field";
        Kategori_field.Size = new System.Drawing.Size(305, 28);
        Kategori_field.TabIndex = 9;
        // 
        // Stok_field
        // 
        Stok_field.Location = new System.Drawing.Point(123, 171);
        Stok_field.Name = "Stok_field";
        Stok_field.Size = new System.Drawing.Size(305, 27);
        Stok_field.TabIndex = 10;
        // 
        // Deskripsi_field
        // 
        Deskripsi_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
        Deskripsi_field.Location = new System.Drawing.Point(123, 204);
        Deskripsi_field.Name = "Deskripsi_field";
        Deskripsi_field.Size = new System.Drawing.Size(640, 234);
        Deskripsi_field.TabIndex = 12;
        Deskripsi_field.Text = "";
        // 
        // Insert_btn
        // 
        Insert_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
        Insert_btn.Font = new System.Drawing.Font("Segoe UI", 16F);
        Insert_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
        Insert_btn.Location = new System.Drawing.Point(123, 468);
        Insert_btn.Name = "Insert_btn";
        Insert_btn.Size = new System.Drawing.Size(119, 46);
        Insert_btn.TabIndex = 13;
        Insert_btn.Text = "Insert";
        Insert_btn.UseVisualStyleBackColor = false;
        Insert_btn.Click += Insert_btn_Click;
        // 
        // Cancel_btn
        // 
        Cancel_btn.BackColor = System.Drawing.Color.Red;
        Cancel_btn.Font = new System.Drawing.Font("Segoe UI", 16F);
        Cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
        Cancel_btn.Location = new System.Drawing.Point(259, 468);
        Cancel_btn.Name = "Cancel_btn";
        Cancel_btn.Size = new System.Drawing.Size(119, 46);
        Cancel_btn.TabIndex = 14;
        Cancel_btn.Text = "Cancel";
        Cancel_btn.UseVisualStyleBackColor = false;
        Cancel_btn.Click += Cancel_btn_Click;
        // 
        // InsertBukuForms
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(842, 589);
        Controls.Add(Cancel_btn);
        Controls.Add(Insert_btn);
        Controls.Add(Deskripsi_field);
        Controls.Add(Stok_field);
        Controls.Add(Kategori_field);
        Controls.Add(TahunTerbit_field);
        Controls.Add(Penulis_field);
        Controls.Add(JudulBuku_field);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Insert Buku";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button Insert_btn;
    private System.Windows.Forms.Button Cancel_btn;

    private System.Windows.Forms.TextBox Stok_field;
    private System.Windows.Forms.RichTextBox Deskripsi_field;

    private System.Windows.Forms.ComboBox Kategori_field;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox JudulBuku_field;
    private System.Windows.Forms.TextBox Penulis_field;
    private System.Windows.Forms.TextBox TahunTerbit_field;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}