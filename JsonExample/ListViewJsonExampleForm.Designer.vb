<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListViewJsonExampleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SavePositionsButton = New System.Windows.Forms.Button()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.upButton1 = New System.Windows.Forms.Button()
        Me.downButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SavePositionsButton
        '
        Me.SavePositionsButton.Location = New System.Drawing.Point(538, 313)
        Me.SavePositionsButton.Name = "SavePositionsButton"
        Me.SavePositionsButton.Size = New System.Drawing.Size(44, 40)
        Me.SavePositionsButton.TabIndex = 8
        Me.SavePositionsButton.Text = "Save"
        Me.SavePositionsButton.UseVisualStyleBackColor = True
        '
        'listView1
        '
        Me.listView1.HideSelection = False
        Me.listView1.Location = New System.Drawing.Point(14, 18)
        Me.listView1.MultiSelect = False
        Me.listView1.Name = "listView1"
        Me.listView1.OwnerDraw = True
        Me.listView1.Size = New System.Drawing.Size(513, 292)
        Me.listView1.TabIndex = 7
        Me.listView1.UseCompatibleStateImageBehavior = False
        '
        'upButton1
        '
        Me.upButton1.Image = Global.JsonExample.My.Resources.Resources.UpArrow
        Me.upButton1.Location = New System.Drawing.Point(536, 91)
        Me.upButton1.Name = "upButton1"
        Me.upButton1.Size = New System.Drawing.Size(44, 40)
        Me.upButton1.TabIndex = 9
        Me.upButton1.UseVisualStyleBackColor = True
        '
        'downButton1
        '
        Me.downButton1.Image = Global.JsonExample.My.Resources.Resources.DnArrow
        Me.downButton1.Location = New System.Drawing.Point(536, 137)
        Me.downButton1.Name = "downButton1"
        Me.downButton1.Size = New System.Drawing.Size(44, 40)
        Me.downButton1.TabIndex = 10
        Me.downButton1.UseVisualStyleBackColor = True
        '
        'ListViewJsonExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 370)
        Me.Controls.Add(Me.downButton1)
        Me.Controls.Add(Me.upButton1)
        Me.Controls.Add(Me.SavePositionsButton)
        Me.Controls.Add(Me.listView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ListViewJsonExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Json source move rows up/down and save"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents SavePositionsButton As Button
    Private WithEvents listView1 As ListView
    Friend WithEvents upButton1 As Button
    Friend WithEvents downButton1 As Button
End Class
