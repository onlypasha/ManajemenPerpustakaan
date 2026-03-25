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
        dgv_admin = new System.Windows.Forms.DataGridView();
        RefreshButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgv_admin).BeginInit();
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
        // dgv_admin
        // 
        dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_admin.Location = new System.Drawing.Point(8, 236);
        dgv_admin.Name = "dgv_admin";
        dgv_admin.RowHeadersWidth = 51;
        dgv_admin.Size = new System.Drawing.Size(849, 302);
        dgv_admin.TabIndex = 1;
        dgv_admin.Text = "dataGridView1";
        // 
        // RefreshButton
        // 
        RefreshButton.BackColor = System.Drawing.Color.LightCoral;
        RefreshButton.Location = new System.Drawing.Point(736, 166);
        RefreshButton.Name = "RefreshButton";
        RefreshButton.Size = new System.Drawing.Size(109, 49);
        RefreshButton.TabIndex = 2;
        RefreshButton.Text = "Refresh Data";
        RefreshButton.UseVisualStyleBackColor = false;
        RefreshButton.Click += RefreshButton_Click;
        // 
        // DashboardAdmin
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(RefreshButton);
        Controls.Add(dgv_admin);
        Controls.Add(label1);
        Size = new System.Drawing.Size(860, 642);
        ((System.ComponentModel.ISupportInitialize)dgv_admin).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgv_admin;
    private System.Windows.Forms.Button RefreshButton;

    private System.Windows.Forms.Label label1;

    #endregion
}