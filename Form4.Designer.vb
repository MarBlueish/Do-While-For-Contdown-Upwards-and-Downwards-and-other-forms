<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        cmd_addItem = New Button()
        cmd_limpa = New Button()
        lab_list = New Label()
        ListView1 = New ListView()
        cmd_add10 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' cmd_addItem
        ' 
        cmd_addItem.Location = New Point(30, 27)
        cmd_addItem.Name = "cmd_addItem"
        cmd_addItem.Size = New Size(150, 23)
        cmd_addItem.TabIndex = 0
        cmd_addItem.Text = "Add Item"
        cmd_addItem.UseVisualStyleBackColor = True
        ' 
        ' cmd_limpa
        ' 
        cmd_limpa.Location = New Point(349, 27)
        cmd_limpa.Name = "cmd_limpa"
        cmd_limpa.Size = New Size(174, 23)
        cmd_limpa.TabIndex = 1
        cmd_limpa.Text = "Limpa ListView"
        cmd_limpa.UseVisualStyleBackColor = True
        ' 
        ' lab_list
        ' 
        lab_list.AutoSize = True
        lab_list.Location = New Point(30, 107)
        lab_list.Name = "lab_list"
        lab_list.Size = New Size(50, 15)
        lab_list.TabIndex = 2
        lab_list.Text = "ListView"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(30, 136)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(493, 97)
        ListView1.TabIndex = 3
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' cmd_add10
        ' 
        cmd_add10.Location = New Point(30, 69)
        cmd_add10.Name = "cmd_add10"
        cmd_add10.Size = New Size(150, 23)
        cmd_add10.TabIndex = 4
        cmd_add10.Text = "Inserir 10 números"
        cmd_add10.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(349, 103)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 23)
        Button1.TabIndex = 5
        Button1.Text = "Add 10 Numeros _2"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(349, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 6
        Label1.Text = "Indicar nº inicial"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(349, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 7
        Label2.Text = "Indicar nº Final"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(545, 260)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(cmd_add10)
        Controls.Add(ListView1)
        Controls.Add(lab_list)
        Controls.Add(cmd_limpa)
        Controls.Add(cmd_addItem)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmd_addItem As Button
    Friend WithEvents cmd_limpa As Button
    Friend WithEvents lab_list As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents cmd_add10 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
