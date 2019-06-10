<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_horas = New System.Windows.Forms.Label()
        Me.lbl_minutos = New System.Windows.Forms.Label()
        Me.lbl_segundos = New System.Windows.Forms.Label()
        Me.timer_horas = New System.Windows.Forms.Label()
        Me.timer_minutos = New System.Windows.Forms.Label()
        Me.timer_segundos = New System.Windows.Forms.Label()
        Me.btn_pause = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'lbl_horas
        '
        Me.lbl_horas.AutoSize = True
        Me.lbl_horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_horas.Location = New System.Drawing.Point(55, 23)
        Me.lbl_horas.Name = "lbl_horas"
        Me.lbl_horas.Size = New System.Drawing.Size(103, 37)
        Me.lbl_horas.TabIndex = 0
        Me.lbl_horas.Text = "Horas"
        '
        'lbl_minutos
        '
        Me.lbl_minutos.AutoSize = True
        Me.lbl_minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minutos.Location = New System.Drawing.Point(233, 23)
        Me.lbl_minutos.Name = "lbl_minutos"
        Me.lbl_minutos.Size = New System.Drawing.Size(129, 37)
        Me.lbl_minutos.TabIndex = 1
        Me.lbl_minutos.Text = "Minutos"
        '
        'lbl_segundos
        '
        Me.lbl_segundos.AutoSize = True
        Me.lbl_segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_segundos.Location = New System.Drawing.Point(432, 23)
        Me.lbl_segundos.Name = "lbl_segundos"
        Me.lbl_segundos.Size = New System.Drawing.Size(161, 37)
        Me.lbl_segundos.TabIndex = 2
        Me.lbl_segundos.Text = "Segundos"
        '
        'timer_horas
        '
        Me.timer_horas.AutoSize = True
        Me.timer_horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer_horas.Location = New System.Drawing.Point(10, 23)
        Me.timer_horas.Name = "timer_horas"
        Me.timer_horas.Size = New System.Drawing.Size(35, 37)
        Me.timer_horas.TabIndex = 3
        Me.timer_horas.Text = "0"
        '
        'timer_minutos
        '
        Me.timer_minutos.AutoSize = True
        Me.timer_minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer_minutos.Location = New System.Drawing.Point(188, 23)
        Me.timer_minutos.Name = "timer_minutos"
        Me.timer_minutos.Size = New System.Drawing.Size(35, 37)
        Me.timer_minutos.TabIndex = 4
        Me.timer_minutos.Text = "0"
        '
        'timer_segundos
        '
        Me.timer_segundos.AutoSize = True
        Me.timer_segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer_segundos.Location = New System.Drawing.Point(387, 23)
        Me.timer_segundos.Name = "timer_segundos"
        Me.timer_segundos.Size = New System.Drawing.Size(35, 37)
        Me.timer_segundos.TabIndex = 5
        Me.timer_segundos.Text = "0"
        '
        'btn_pause
        '
        Me.btn_pause.BackgroundImage = Global.Timer.My.Resources.Resources.iconfinder_icon_pause_211871
        Me.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_pause.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pause.Location = New System.Drawing.Point(453, 102)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(62, 51)
        Me.btn_pause.TabIndex = 8
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.BackgroundImage = Global.Timer.My.Resources.Resources.iconfinder_ic_stop_48px_352144
        Me.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stop.Location = New System.Drawing.Point(531, 102)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(62, 51)
        Me.btn_stop.TabIndex = 7
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_play
        '
        Me.btn_play.BackgroundImage = Global.Timer.My.Resources.Resources.iconfinder_ic_play_arrow_48px_352072__1_
        Me.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_play.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_play.Location = New System.Drawing.Point(375, 102)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(62, 51)
        Me.btn_play.TabIndex = 6
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 177)
        Me.Controls.Add(Me.btn_pause)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.timer_segundos)
        Me.Controls.Add(Me.timer_minutos)
        Me.Controls.Add(Me.timer_horas)
        Me.Controls.Add(Me.lbl_segundos)
        Me.Controls.Add(Me.lbl_minutos)
        Me.Controls.Add(Me.lbl_horas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer As Windows.Forms.Timer
    Friend WithEvents lbl_horas As Label
    Friend WithEvents lbl_minutos As Label
    Friend WithEvents lbl_segundos As Label
    Friend WithEvents timer_horas As Label
    Friend WithEvents timer_minutos As Label
    Friend WithEvents timer_segundos As Label
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_pause As Button
End Class
