using System.ComponentModel;

namespace ManagementPerpustakaan.Layouts;

partial class MainForm
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
        System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dashboard");
        System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Manajemen Buku");
        System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Manajemen Kategori");
        statusStrip1 = new System.Windows.Forms.StatusStrip();
        toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        logout_btn = new System.Windows.Forms.Button();
        treeView1 = new System.Windows.Forms.TreeView();
        label1 = new System.Windows.Forms.Label();
        statusStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
        statusStrip1.Location = new System.Drawing.Point(0, 424);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new System.Drawing.Size(800, 26);
        statusStrip1.TabIndex = 0;
        statusStrip1.Text = "statusStrip1";
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Size = new System.Drawing.Size(86, 20);
        toolStripStatusLabel1.Text = "Sistem Siap";
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(logout_btn);
        splitContainer1.Panel1.Controls.Add(treeView1);
        splitContainer1.Panel1.Controls.Add(label1);
        splitContainer1.Size = new System.Drawing.Size(800, 424);
        splitContainer1.SplitterDistance = 266;
        splitContainer1.TabIndex = 1;
        splitContainer1.Text = "splitContainer1";
        // 
        // logout_btn
        // 
        logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        logout_btn.BackColor = System.Drawing.Color.Red;
        logout_btn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        logout_btn.ForeColor = System.Drawing.Color.White;
        logout_btn.Location = new System.Drawing.Point(-5, 363);
        logout_btn.Name = "logout_btn";
        logout_btn.Size = new System.Drawing.Size(271, 60);
        logout_btn.TabIndex = 2;
        logout_btn.Text = "Logout";
        logout_btn.UseVisualStyleBackColor = false;
        logout_btn.Click += logout_btn_Click;
        // 
        // treeView1
        // 
        treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        treeView1.Location = new System.Drawing.Point(0, 35);
        treeView1.Name = "treeView1";
        treeNode1.Name = "DashboardAdmin_NODE";
        treeNode1.Text = "Dashboard";
        treeNode2.Name = "MBAdmin_NODE";
        treeNode2.Text = "Manajemen Buku";
        treeNode3.Name = "MKAdmin_NODE";
        treeNode3.Text = "Manajemen Kategori";
        treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3 });
        treeView1.Size = new System.Drawing.Size(266, 389);
        treeView1.TabIndex = 1;
        treeView1.AfterSelect += treeView1_AfterSelect;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.Highlight;
        label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        label1.ForeColor = System.Drawing.Color.White;
        label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
        label1.Location = new System.Drawing.Point(2, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(265, 32);
        label1.TabIndex = 0;
        label1.Text = "NAVIGASI";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(splitContainer1);
        Controls.Add(statusStrip1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "MANAJEMEN PERPUSTAKAAN";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        splitContainer1.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button logout_btn;

    private System.Windows.Forms.TreeView treeView1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.SplitContainer splitContainer1;

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    #endregion
}