using System.ComponentModel;

namespace ManagementPerpustakaan.UserControl.Admin;

partial class MBAdmin
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
        components = new System.ComponentModel.Container();
        label1 = new System.Windows.Forms.Label();
        AllBukuGrid = new System.Windows.Forms.DataGridView();
        EditDeleteMenu = new System.Windows.Forms.ContextMenuStrip(components);
        deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
        TambahBuku_btn = new System.Windows.Forms.Button();
        updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)AllBukuGrid).BeginInit();
        EditDeleteMenu.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.Highlight;
        label1.Font = new System.Drawing.Font("Segoe UI", 24F);
        label1.ForeColor = System.Drawing.Color.White;
        label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        label1.Location = new System.Drawing.Point(3, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(897, 139);
        label1.TabIndex = 0;
        label1.Text = "Manajemen Buku";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // AllBukuGrid
        // 
        AllBukuGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        AllBukuGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        AllBukuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        AllBukuGrid.ContextMenuStrip = EditDeleteMenu;
        AllBukuGrid.Location = new System.Drawing.Point(3, 174);
        AllBukuGrid.Name = "AllBukuGrid";
        AllBukuGrid.RowHeadersWidth = 51;
        AllBukuGrid.Size = new System.Drawing.Size(895, 296);
        AllBukuGrid.TabIndex = 1;
        AllBukuGrid.Text = "dataGridView1";
        // 
        // EditDeleteMenu
        // 
        EditDeleteMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
        EditDeleteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { deleteMenu, updateToolStripMenuItem });
        EditDeleteMenu.Name = "EditDeleteMenu";
        EditDeleteMenu.Size = new System.Drawing.Size(211, 80);
        // 
        // deleteMenu
        // 
        deleteMenu.Name = "deleteMenu";
        deleteMenu.Size = new System.Drawing.Size(210, 24);
        deleteMenu.Text = "Delete";
        deleteMenu.Click += deleteMenu_Click;
        // 
        // TambahBuku_btn
        // 
        TambahBuku_btn.BackColor = System.Drawing.SystemColors.Highlight;
        TambahBuku_btn.Font = new System.Drawing.Font("Segoe UI", 11F);
        TambahBuku_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        TambahBuku_btn.Location = new System.Drawing.Point(0, 489);
        TambahBuku_btn.Name = "TambahBuku_btn";
        TambahBuku_btn.Size = new System.Drawing.Size(135, 50);
        TambahBuku_btn.TabIndex = 2;
        TambahBuku_btn.Text = "Tambah Buku";
        TambahBuku_btn.UseVisualStyleBackColor = false;
        TambahBuku_btn.Click += TambahBuku_btn_Click;
        // 
        // updateToolStripMenuItem
        // 
        updateToolStripMenuItem.Name = "updateToolStripMenuItem";
        updateToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
        updateToolStripMenuItem.Text = "Update";
        updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
        // 
        // MBAdmin
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(TambahBuku_btn);
        Controls.Add(AllBukuGrid);
        Controls.Add(label1);
        Size = new System.Drawing.Size(901, 759);
        Load += MBAdmin_Load;
        ((System.ComponentModel.ISupportInitialize)AllBukuGrid).EndInit();
        EditDeleteMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;

    private System.Windows.Forms.ContextMenuStrip EditDeleteMenu;
    private System.Windows.Forms.ToolStripMenuItem deleteMenu;

    private System.Windows.Forms.Button TambahBuku_btn;

    private System.Windows.Forms.DataGridView AllBukuGrid;

    private System.Windows.Forms.Label label1;

    #endregion
}