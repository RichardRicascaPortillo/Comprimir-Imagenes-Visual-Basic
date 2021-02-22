<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelProcesado = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.txRuta = New System.Windows.Forms.TextBox()
        Me.txPrefijo = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRuta
        '
        Me.btnRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuta.Location = New System.Drawing.Point(653, 245)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(121, 44)
        Me.btnRuta.TabIndex = 0
        Me.btnRuta.Text = "Examinar ..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(653, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Comprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ruta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Renombrar Imagenes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nivel de comprension"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 375)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Procesado"
        '
        'LabelProcesado
        '
        Me.LabelProcesado.AutoSize = True
        Me.LabelProcesado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProcesado.Location = New System.Drawing.Point(200, 375)
        Me.LabelProcesado.Name = "LabelProcesado"
        Me.LabelProcesado.Size = New System.Drawing.Size(40, 24)
        Me.LabelProcesado.TabIndex = 7
        Me.LabelProcesado.Text = "0 %"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(48, 169)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(726, 56)
        Me.TrackBar1.TabIndex = 9
        '
        'txRuta
        '
        Me.txRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRuta.Location = New System.Drawing.Point(129, 35)
        Me.txRuta.Name = "txRuta"
        Me.txRuta.Size = New System.Drawing.Size(645, 30)
        Me.txRuta.TabIndex = 10
        '
        'txPrefijo
        '
        Me.txPrefijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPrefijo.Location = New System.Drawing.Point(243, 98)
        Me.txPrefijo.Name = "txPrefijo"
        Me.txPrefijo.Size = New System.Drawing.Size(531, 30)
        Me.txPrefijo.TabIndex = 11
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txPrefijo)
        Me.Controls.Add(Me.txRuta)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.LabelProcesado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnRuta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRuta As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelProcesado As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents txRuta As TextBox
    Friend WithEvents txPrefijo As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
