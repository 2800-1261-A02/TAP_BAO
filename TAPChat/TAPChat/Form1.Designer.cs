namespace TAPChat;

partial class TAPCHAT
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        UI_Message_Lbl = new Label();
        UI_Message_TxtBox = new TextBox();
        UI_DGV = new DataGridView();
        UI_TargetAddress_Lbl = new Label();
        UI_TargetAddress_TxtBox = new TextBox();
        UI_Nickname_Lbl = new Label();
        UI_Nickname_TxtBox = new TextBox();
        UI_KnownHosts_Lbl = new Label();
        UI_KnownHosts_ListBox = new ListBox();
        ((System.ComponentModel.ISupportInitialize)UI_DGV).BeginInit();
        SuspendLayout();
        // 
        // UI_Message_Lbl
        // 
        UI_Message_Lbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        UI_Message_Lbl.Location = new Point(12, 9);
        UI_Message_Lbl.Name = "UI_Message_Lbl";
        UI_Message_Lbl.Size = new Size(107, 39);
        UI_Message_Lbl.TabIndex = 0;
        UI_Message_Lbl.Text = "Chat Text";
        UI_Message_Lbl.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // UI_Message_TxtBox
        // 
        UI_Message_TxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        UI_Message_TxtBox.Location = new Point(118, 19);
        UI_Message_TxtBox.Name = "UI_Message_TxtBox";
        UI_Message_TxtBox.Size = new Size(752, 23);
        UI_Message_TxtBox.TabIndex = 1;
        // 
        // UI_DGV
        // 
        UI_DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        UI_DGV.Location = new Point(210, 60);
        UI_DGV.Name = "UI_DGV";
        UI_DGV.Size = new Size(660, 502);
        UI_DGV.TabIndex = 2;
        // 
        // UI_TargetAddress_Lbl
        // 
        UI_TargetAddress_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        UI_TargetAddress_Lbl.Location = new Point(12, 60);
        UI_TargetAddress_Lbl.Name = "UI_TargetAddress_Lbl";
        UI_TargetAddress_Lbl.Size = new Size(156, 37);
        UI_TargetAddress_Lbl.TabIndex = 3;
        UI_TargetAddress_Lbl.Text = "Target Address:";
        // 
        // UI_TargetAddress_TxtBox
        // 
        UI_TargetAddress_TxtBox.Location = new Point(12, 100);
        UI_TargetAddress_TxtBox.Name = "UI_TargetAddress_TxtBox";
        UI_TargetAddress_TxtBox.Size = new Size(182, 23);
        UI_TargetAddress_TxtBox.TabIndex = 4;
        // 
        // UI_Nickname_Lbl
        // 
        UI_Nickname_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        UI_Nickname_Lbl.Location = new Point(12, 145);
        UI_Nickname_Lbl.Name = "UI_Nickname_Lbl";
        UI_Nickname_Lbl.Size = new Size(156, 37);
        UI_Nickname_Lbl.TabIndex = 5;
        UI_Nickname_Lbl.Text = "Nickname:";
        // 
        // UI_Nickname_TxtBox
        // 
        UI_Nickname_TxtBox.Location = new Point(12, 185);
        UI_Nickname_TxtBox.Name = "UI_Nickname_TxtBox";
        UI_Nickname_TxtBox.Size = new Size(182, 23);
        UI_Nickname_TxtBox.TabIndex = 6;
        // 
        // UI_KnownHosts_Lbl
        // 
        UI_KnownHosts_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        UI_KnownHosts_Lbl.Location = new Point(12, 240);
        UI_KnownHosts_Lbl.Name = "UI_KnownHosts_Lbl";
        UI_KnownHosts_Lbl.Size = new Size(156, 37);
        UI_KnownHosts_Lbl.TabIndex = 7;
        UI_KnownHosts_Lbl.Text = "Known Hosts";
        // 
        // UI_KnownHosts_ListBox
        // 
        UI_KnownHosts_ListBox.FormattingEnabled = true;
        UI_KnownHosts_ListBox.ItemHeight = 15;
        UI_KnownHosts_ListBox.Location = new Point(12, 271);
        UI_KnownHosts_ListBox.Name = "UI_KnownHosts_ListBox";
        UI_KnownHosts_ListBox.SelectionMode = SelectionMode.MultiSimple;
        UI_KnownHosts_ListBox.Size = new Size(182, 289);
        UI_KnownHosts_ListBox.TabIndex = 8;
        // 
        // TAPCHAT
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 574);
        Controls.Add(UI_KnownHosts_ListBox);
        Controls.Add(UI_KnownHosts_Lbl);
        Controls.Add(UI_Nickname_TxtBox);
        Controls.Add(UI_Nickname_Lbl);
        Controls.Add(UI_TargetAddress_TxtBox);
        Controls.Add(UI_TargetAddress_Lbl);
        Controls.Add(UI_DGV);
        Controls.Add(UI_Message_TxtBox);
        Controls.Add(UI_Message_Lbl);
        Name = "TAPCHAT";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)UI_DGV).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ListBox UI_KnownHosts_ListBox;

    private System.Windows.Forms.Label UI_KnownHosts_Lbl;

    private System.Windows.Forms.TextBox UI_Nickname_TxtBox;

    private System.Windows.Forms.Label UI_Nickname_Lbl;

    private System.Windows.Forms.TextBox UI_TargetAddress_TxtBox;

    private System.Windows.Forms.Label UI_TargetAddress_Lbl;

    private System.Windows.Forms.DataGridView UI_DGV;

    private System.Windows.Forms.TextBox UI_Message_TxtBox;

    private System.Windows.Forms.Label UI_Message_Lbl;

    #endregion
}