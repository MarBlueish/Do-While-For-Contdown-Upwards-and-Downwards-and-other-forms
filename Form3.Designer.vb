<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Txtin = New TextBox()
        Txtfin = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(170, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 46)
        Label1.TabIndex = 0
        Label1.Text = "Ciclos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(4, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 26)
        Label2.TabIndex = 1
        Label2.Text = "Número Inicial"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(23, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 26)
        Label3.TabIndex = 2
        Label3.Text = "Número Final"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(54, 190)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 52)
        Button1.TabIndex = 3
        Button1.Text = "While do"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(234, 190)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 52)
        Button2.TabIndex = 4
        Button2.Text = "For"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Txtin
        ' 
        Txtin.Location = New Point(219, 78)
        Txtin.Name = "Txtin"
        Txtin.Size = New Size(100, 23)
        Txtin.TabIndex = 5
        ' 
        ' Txtfin
        ' 
        Txtfin.Location = New Point(219, 142)
        Txtfin.Name = "Txtfin"
        Txtfin.Size = New Size(100, 23)
        Txtfin.TabIndex = 6
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(413, 305)
        Controls.Add(Txtfin)
        Controls.Add(Txtin)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Txtin As TextBox
    Friend WithEvents Txtfin As TextBox
End Class
