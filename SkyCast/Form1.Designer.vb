<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SkyCast
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SkyCast))
        TextBox1 = New TextBox()
        Button1 = New Button()
        TextBoxForecast3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        TextBoxForecast2 = New TextBox()
        TextBoxForecast1 = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Constantia", 11.78182F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(231, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = " Enter Place"
        TextBox1.Size = New Size(398, 31)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Azure
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Constantia", 11.78182F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(627, 47)
        Button1.Name = "Button1"
        Button1.Size = New Size(65, 31)
        Button1.TabIndex = 1
        Button1.Text = "Go"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBoxForecast3
        ' 
        TextBoxForecast3.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxForecast3.Location = New Point(627, 695)
        TextBoxForecast3.Name = "TextBoxForecast3"
        TextBoxForecast3.Size = New Size(230, 40)
        TextBoxForecast3.TabIndex = 8
        TextBoxForecast3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Copperplate Gothic Light", 72F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(300, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(600, 130)
        Label1.TabIndex = 10
        Label1.Text = "SkyCast"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Copperplate Gothic Light", 11.78182F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(336, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 21)
        Label2.TabIndex = 11
        Label2.Text = "Condition"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Copperplate Gothic Light", 11.78182F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(336, 313)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 21)
        Label3.TabIndex = 12
        Label3.Text = "Precipitation"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Copperplate Gothic Light", 11.78182F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(336, 339)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 21)
        Label4.TabIndex = 13
        Label4.Text = "Humidity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Copperplate Gothic Light", 15.70909F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(86, 452)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 30)
        Label5.TabIndex = 14
        Label5.Text = "Forecast's"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(57, 123)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(268, 275)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' TextBoxForecast2
        ' 
        TextBoxForecast2.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxForecast2.Location = New Point(356, 695)
        TextBoxForecast2.Name = "TextBoxForecast2"
        TextBoxForecast2.Size = New Size(241, 40)
        TextBoxForecast2.TabIndex = 7
        TextBoxForecast2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxForecast1
        ' 
        TextBoxForecast1.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxForecast1.Location = New Point(87, 695)
        TextBoxForecast1.Name = "TextBoxForecast1"
        TextBoxForecast1.Size = New Size(236, 40)
        TextBoxForecast1.TabIndex = 6
        TextBoxForecast1.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(107, 502)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(193, 183)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(379, 502)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(193, 183)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(643, 502)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(193, 183)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Copperplate Gothic Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.ImageAlign = ContentAlignment.MiddleRight
        Label6.Location = New Point(329, 134)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 37)
        Label6.TabIndex = 19
        Label6.Text = "Place"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' SkyCast
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(919, 780)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxForecast3)
        Controls.Add(TextBoxForecast2)
        Controls.Add(TextBoxForecast1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "SkyCast"
        Text = "SkyCast"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxForecast3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxForecast2 As TextBox
    Friend WithEvents TextBoxForecast1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
End Class
