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
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        Logout_btn = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        treeView1 = new System.Windows.Forms.TreeView();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        splitContainer1.Location = new System.Drawing.Point(0, 5);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(Logout_btn);
        splitContainer1.Panel1.Controls.Add(label1);
        splitContainer1.Panel1.Controls.Add(treeView1);
        splitContainer1.Size = new System.Drawing.Size(800, 444);
        splitContainer1.SplitterDistance = 266;
        splitContainer1.TabIndex = 1;
        splitContainer1.Text = "splitContainer1";
        // 
        // Logout_btn
        // 
        Logout_btn.BackColor = System.Drawing.Color.Red;
        Logout_btn.Font = new System.Drawing.Font("Segoe UI", 16F);
        Logout_btn.Location = new System.Drawing.Point(0, 387);
        Logout_btn.Name = "Logout_btn";
        Logout_btn.Size = new System.Drawing.Size(265, 54);
        Logout_btn.TabIndex = 2;
        Logout_btn.Text = "Logout";
        Logout_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        Logout_btn.UseVisualStyleBackColor = false;
        Logout_btn.Click += Logout_btn_Click;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
        label1.Font = new System.Drawing.Font("Segoe UI", 12F);
        label1.Location = new System.Drawing.Point(3, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(261, 32);
        label1.TabIndex = 1;
        label1.Text = "NAVIGASI";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // treeView1
        // 
        treeView1.Location = new System.Drawing.Point(1, 32);
        treeView1.Name = "treeView1";
        treeNode1.Name = "DashboardAdmin_node";
        treeNode1.Text = "Dashboard";
        treeNode2.Name = "MBAdmin_node";
        treeNode2.Text = "Manajemen Buku";
        treeNode3.Name = "MKAdmin_node";
        treeNode3.Text = "Manajemen Kategori";
        treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3 });
        treeView1.Size = new System.Drawing.Size(264, 359);
        treeView1.TabIndex = 0;
        treeView1.AfterSelect += treeView1_AfterSelect_1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(splitContainer1);
        Location = new System.Drawing.Point(19, 19);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        splitContainer1.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button Logout_btn;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion
}