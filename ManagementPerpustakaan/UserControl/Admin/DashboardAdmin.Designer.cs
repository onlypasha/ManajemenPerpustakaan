using System.ComponentModel;

namespace ManagementPerpustakaan.UserControl.Admin;

partial class DashboardAdmin
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        jumlah_buku = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        jb_label = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        label3 = new System.Windows.Forms.Label();
        jk_label = new System.Windows.Forms.Label();
        jumlah_buku.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
        label1.Font = new System.Drawing.Font("Segoe UI", 24F);
        label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Location = new System.Drawing.Point(8, 13);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(849, 138);
        label1.TabIndex = 0;
        label1.Text = "DASHBOARD ADMIN";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // jumlah_buku
        // 
        jumlah_buku.BackColor = System.Drawing.Color.HotPink;
        jumlah_buku.Controls.Add(label2);
        jumlah_buku.Controls.Add(jb_label);
        jumlah_buku.Location = new System.Drawing.Point(8, 171);
        jumlah_buku.Name = "jumlah_buku";
        jumlah_buku.Size = new System.Drawing.Size(140, 111);
        jumlah_buku.TabIndex = 1;
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.SystemColors.Highlight;
        label2.Font = new System.Drawing.Font("Segoe UI", 11F);
        label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
        label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        label2.Location = new System.Drawing.Point(0, 83);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(140, 28);
        label2.TabIndex = 1;
        label2.Text = "Buku";
        label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // jb_label
        // 
        jb_label.Font = new System.Drawing.Font("Segoe UI", 20F);
        jb_label.Location = new System.Drawing.Point(2, 7);
        jb_label.Name = "jb_label";
        jb_label.Size = new System.Drawing.Size(137, 67);
        jb_label.TabIndex = 0;
        jb_label.Text = "0";
        jb_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.HotPink;
        panel1.Controls.Add(label3);
        panel1.Controls.Add(jk_label);
        panel1.Location = new System.Drawing.Point(181, 171);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(140, 111);
        panel1.TabIndex = 2;
        // 
        // label3
        // 
        label3.BackColor = System.Drawing.SystemColors.Highlight;
        label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
        label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        label3.Location = new System.Drawing.Point(0, 83);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(140, 28);
        label3.TabIndex = 1;
        label3.Text = "Kategori";
        label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // jk_label
        // 
        jk_label.Font = new System.Drawing.Font("Segoe UI", 20F);
        jk_label.Location = new System.Drawing.Point(2, 7);
        jk_label.Name = "jk_label";
        jk_label.Size = new System.Drawing.Size(137, 67);
        jk_label.TabIndex = 0;
        jk_label.Text = "0";
        jk_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // DashboardAdmin
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(panel1);
        Controls.Add(jumlah_buku);
        Controls.Add(label1);
        Size = new System.Drawing.Size(860, 642);
        Load += DashboardAdmin_Load;
        jumlah_buku.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label jk_label;

    private System.Windows.Forms.Label jb_label;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Panel jumlah_kategori;

    private System.Windows.Forms.Panel jumlah_buku;

    private System.Windows.Forms.DataGridView dgv_admin;

    private System.Windows.Forms.Label label1;

    #endregion
}