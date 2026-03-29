using System.ComponentModel;

namespace ManagementPerpustakaan.CustomForms;

partial class UpdateBukuForms
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
        Stok_field = new System.Windows.Forms.TextBox();
        Deskripsi_field = new System.Windows.Forms.RichTextBox();
        SimpanEdit_btn = new System.Windows.Forms.Button();
        Batal_btn = new System.Windows.Forms.Button();
        Kategori_field = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 21);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(110, 24);
        label1.TabIndex = 0;
        label1.Text = "Judul buku";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(12, 60);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(110, 24);
        label2.TabIndex = 1;
        label2.Text = "Penulis";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(12, 100);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(110, 24);
        label3.TabIndex = 2;
        label3.Text = "Tahun Terbit";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(12, 133);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(110, 31);
        label4.TabIndex = 3;
        label4.Text = "Kategori";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(12, 164);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(110, 24);
        label5.TabIndex = 4;
        label5.Text = "Stok";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(12, 210);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(110, 24);
        label6.TabIndex = 5;
        label6.Text = "Deskripsi";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // JudulBuku_field
        // 
        JudulBuku_field.Location = new System.Drawing.Point(128, 21);
        JudulBuku_field.Name = "JudulBuku_field";
        JudulBuku_field.Size = new System.Drawing.Size(266, 27);
        JudulBuku_field.TabIndex = 6;
        // 
        // Penulis_field
        // 
        Penulis_field.Location = new System.Drawing.Point(128, 60);
        Penulis_field.Name = "Penulis_field";
        Penulis_field.Size = new System.Drawing.Size(266, 27);
        Penulis_field.TabIndex = 7;
        // 
        // TahunTerbit_field
        // 
        TahunTerbit_field.Location = new System.Drawing.Point(128, 100);
        TahunTerbit_field.Name = "TahunTerbit_field";
        TahunTerbit_field.Size = new System.Drawing.Size(266, 27);
        TahunTerbit_field.TabIndex = 8;
        // 
        // Stok_field
        // 
        Stok_field.Location = new System.Drawing.Point(128, 168);
        Stok_field.Name = "Stok_field";
        Stok_field.Size = new System.Drawing.Size(266, 27);
        Stok_field.TabIndex = 10;
        // 
        // Deskripsi_field
        // 
        Deskripsi_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
        Deskripsi_field.Location = new System.Drawing.Point(128, 212);
        Deskripsi_field.Name = "Deskripsi_field";
        Deskripsi_field.Size = new System.Drawing.Size(615, 194);
        Deskripsi_field.TabIndex = 11;
        Deskripsi_field.Text = "";
        // 
        // SimpanEdit_btn
        // 
        SimpanEdit_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
        SimpanEdit_btn.Font = new System.Drawing.Font("Segoe UI", 16F);
        SimpanEdit_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
        SimpanEdit_btn.Location = new System.Drawing.Point(129, 429);
        SimpanEdit_btn.Name = "SimpanEdit_btn";
        SimpanEdit_btn.Size = new System.Drawing.Size(130, 53);
        SimpanEdit_btn.TabIndex = 12;
        SimpanEdit_btn.Text = "Simpan";
        SimpanEdit_btn.UseVisualStyleBackColor = false;
        // 
        // Batal_btn
        // 
        Batal_btn.BackColor = System.Drawing.Color.Red;
        Batal_btn.Font = new System.Drawing.Font("Segoe UI", 16F);
        Batal_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
        Batal_btn.Location = new System.Drawing.Point(265, 429);
        Batal_btn.Name = "Batal_btn";
        Batal_btn.Size = new System.Drawing.Size(130, 53);
        Batal_btn.TabIndex = 13;
        Batal_btn.Text = "Batal";
        Batal_btn.UseVisualStyleBackColor = false;
        Batal_btn.Click += Batal_btn_Click;
        // 
        // Kategori_field
        // 
        Kategori_field.FormattingEnabled = true;
        Kategori_field.Location = new System.Drawing.Point(128, 136);
        Kategori_field.Name = "Kategori_field";
        Kategori_field.Size = new System.Drawing.Size(266, 28);
        Kategori_field.TabIndex = 14;
        // 
        // UpdateBukuForms
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(894, 537);
        Controls.Add(Kategori_field);
        Controls.Add(Batal_btn);
        Controls.Add(SimpanEdit_btn);
        Controls.Add(Deskripsi_field);
        Controls.Add(Stok_field);
        Controls.Add(TahunTerbit_field);
        Controls.Add(Penulis_field);
        Controls.Add(JudulBuku_field);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Update Buku";
        Load += UpdateBukuForms_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button SimpanEdit_btn;
    private System.Windows.Forms.Button Batal_btn;

    private System.Windows.Forms.TextBox JudulBuku_field;
    private System.Windows.Forms.TextBox Penulis_field;
    private System.Windows.Forms.TextBox TahunTerbit_field;
    private System.Windows.Forms.ComboBox Kategori_field;
    private System.Windows.Forms.TextBox Stok_field;
    private System.Windows.Forms.RichTextBox Deskripsi_field;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    #endregion
}