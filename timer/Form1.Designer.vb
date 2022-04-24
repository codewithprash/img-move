<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.car = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'car
        '
        Me.car.BackColor = System.Drawing.Color.Transparent
        Me.car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.car.Image = Global.timer.My.Resources.Resources.ca
        Me.car.Location = New System.Drawing.Point(166, 189)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(180, 69)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 0
        Me.car.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.timer.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(540, 304)
        Me.Controls.Add(Me.car)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "moving_car"
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents car As PictureBox
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
