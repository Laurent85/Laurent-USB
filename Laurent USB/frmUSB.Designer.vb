<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUSB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUSB))
        Me.Allumer_LED0 = New System.Windows.Forms.Button()
        Me.Eteindre_LED0 = New System.Windows.Forms.Button()
        Me.Allumer_LED1 = New System.Windows.Forms.Button()
        Me.Eteindre_LED1 = New System.Windows.Forms.Button()
        Me.Allumer_LED2 = New System.Windows.Forms.Button()
        Me.Eteindre_LED2 = New System.Windows.Forms.Button()
        Me.Allumer_LED3 = New System.Windows.Forms.Button()
        Me.Allumer_LED4 = New System.Windows.Forms.Button()
        Me.Allumer_LED5 = New System.Windows.Forms.Button()
        Me.Allumer_LED6 = New System.Windows.Forms.Button()
        Me.Allumer_LED7 = New System.Windows.Forms.Button()
        Me.Eteindre_LED6 = New System.Windows.Forms.Button()
        Me.Eteindre_LED7 = New System.Windows.Forms.Button()
        Me.Eteindre_LED5 = New System.Windows.Forms.Button()
        Me.Eteindre_LED4 = New System.Windows.Forms.Button()
        Me.Eteindre_LED3 = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Allumer_TOUT = New System.Windows.Forms.Button()
        Me.Eteindre_TOUT = New System.Windows.Forms.Button()
        Me.Reception_RE0 = New System.Windows.Forms.Button()
        Me.Etat_USB = New System.Windows.Forms.Label()
        Me.TextBox1_Ligne1 = New System.Windows.Forms.TextBox()
        Me.Envoyer_ligne1 = New System.Windows.Forms.Button()
        Me.Effacer_ligne1 = New System.Windows.Forms.Button()
        Me.Label_Ligne1 = New System.Windows.Forms.Label()
        Me.TextBox2_Ligne2 = New System.Windows.Forms.TextBox()
        Me.Label_Ligne2 = New System.Windows.Forms.Label()
        Me.Envoyer_ligne2 = New System.Windows.Forms.Button()
        Me.Effacer_ligne2 = New System.Windows.Forms.Button()
        Me.Barre_PORTA = New System.Windows.Forms.TrackBar()
        Me.PORT_A = New System.Windows.Forms.Label()
        Me.Barre_Voltage = New System.Windows.Forms.TrackBar()
        Me.VOLTAGE = New System.Windows.Forms.Label()
        Me.Effacer_LCD = New System.Windows.Forms.Button()
        Me.VOLTS_MAX = New System.Windows.Forms.Label()
        Me.Heure = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Reception_RE1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LED0 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Proteus = New System.Windows.Forms.Label()
        Me.Envoyer_2_lignes = New System.Windows.Forms.Button()
        CType(Me.Barre_PORTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Barre_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Allumer_LED0
        '
        Me.Allumer_LED0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_LED0.Location = New System.Drawing.Point(22, 65)
        Me.Allumer_LED0.Name = "Allumer_LED0"
        Me.Allumer_LED0.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_LED0.TabIndex = 0
        Me.Allumer_LED0.Text = "Allumer LED0"
        Me.Allumer_LED0.UseVisualStyleBackColor = False
        '
        'Eteindre_LED0
        '
        Me.Eteindre_LED0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_LED0.Location = New System.Drawing.Point(22, 119)
        Me.Eteindre_LED0.Name = "Eteindre_LED0"
        Me.Eteindre_LED0.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_LED0.TabIndex = 2
        Me.Eteindre_LED0.Text = "Eteindre LED0"
        Me.Eteindre_LED0.UseVisualStyleBackColor = False
        '
        'Allumer_LED1
        '
        Me.Allumer_LED1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_LED1.Location = New System.Drawing.Point(90, 65)
        Me.Allumer_LED1.Name = "Allumer_LED1"
        Me.Allumer_LED1.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_LED1.TabIndex = 3
        Me.Allumer_LED1.Text = "Allumer LED1"
        Me.Allumer_LED1.UseVisualStyleBackColor = False
        '
        'Eteindre_LED1
        '
        Me.Eteindre_LED1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_LED1.Location = New System.Drawing.Point(90, 119)
        Me.Eteindre_LED1.Name = "Eteindre_LED1"
        Me.Eteindre_LED1.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_LED1.TabIndex = 4
        Me.Eteindre_LED1.Text = "Eteindre LED1"
        Me.Eteindre_LED1.UseVisualStyleBackColor = False
        '
        'Allumer_LED2
        '
        Me.Allumer_LED2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_LED2.Location = New System.Drawing.Point(158, 65)
        Me.Allumer_LED2.Name = "Allumer_LED2"
        Me.Allumer_LED2.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_LED2.TabIndex = 5
        Me.Allumer_LED2.Text = "Allumer LED2"
        Me.Allumer_LED2.UseVisualStyleBackColor = False
        '
        'Eteindre_LED2
        '
        Me.Eteindre_LED2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_LED2.Location = New System.Drawing.Point(158, 119)
        Me.Eteindre_LED2.Name = "Eteindre_LED2"
        Me.Eteindre_LED2.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_LED2.TabIndex = 6
        Me.Eteindre_LED2.Text = "Eteindre LED2"
        Me.Eteindre_LED2.UseVisualStyleBackColor = False
        '
        'Allumer_LED3
        '
        Me.Allumer_LED3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_LED3.Location = New System.Drawing.Point(226, 65)
        Me.Allumer_LED3.Name = "Allumer_LED3"
        Me.Allumer_LED3.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_LED3.TabIndex = 7
        Me.Allumer_LED3.Text = "Allumer LED3"
        Me.Allumer_LED3.UseVisualStyleBackColor = False
        '
        'Allumer_LED4
        '
        Me.Allumer_LED4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_LED4.Location = New System.Drawing.Point(294, 65)
        Me.Allumer_LED4.Name = "Allumer_LED4"
        Me.Allumer_LED4.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_LED4.TabIndex = 8
        Me.Allumer_LED4.Text = "Allumer LED4"
        Me.Allumer_LED4.UseVisualStyleBackColor = False
        '
        'Allumer_LED5
        '
        Me.Allumer_LED5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_LED5.Location = New System.Drawing.Point(362, 65)
        Me.Allumer_LED5.Name = "Allumer_LED5"
        Me.Allumer_LED5.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_LED5.TabIndex = 9
        Me.Allumer_LED5.Text = "Allumer LED5"
        Me.Allumer_LED5.UseVisualStyleBackColor = False
        '
        'Allumer_LED6
        '
        Me.Allumer_LED6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_LED6.Location = New System.Drawing.Point(430, 65)
        Me.Allumer_LED6.Name = "Allumer_LED6"
        Me.Allumer_LED6.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_LED6.TabIndex = 10
        Me.Allumer_LED6.Text = "Allumer LED6"
        Me.Allumer_LED6.UseVisualStyleBackColor = False
        '
        'Allumer_LED7
        '
        Me.Allumer_LED7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_LED7.Location = New System.Drawing.Point(498, 65)
        Me.Allumer_LED7.Name = "Allumer_LED7"
        Me.Allumer_LED7.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_LED7.TabIndex = 11
        Me.Allumer_LED7.Text = "Allumer LED7"
        Me.Allumer_LED7.UseVisualStyleBackColor = False
        '
        'Eteindre_LED6
        '
        Me.Eteindre_LED6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_LED6.Location = New System.Drawing.Point(430, 119)
        Me.Eteindre_LED6.Name = "Eteindre_LED6"
        Me.Eteindre_LED6.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_LED6.TabIndex = 12
        Me.Eteindre_LED6.Text = "Eteindre LED6"
        Me.Eteindre_LED6.UseVisualStyleBackColor = False
        '
        'Eteindre_LED7
        '
        Me.Eteindre_LED7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_LED7.Location = New System.Drawing.Point(498, 119)
        Me.Eteindre_LED7.Name = "Eteindre_LED7"
        Me.Eteindre_LED7.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_LED7.TabIndex = 13
        Me.Eteindre_LED7.Text = "Eteindre LED7"
        Me.Eteindre_LED7.UseVisualStyleBackColor = False
        '
        'Eteindre_LED5
        '
        Me.Eteindre_LED5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_LED5.Location = New System.Drawing.Point(362, 119)
        Me.Eteindre_LED5.Name = "Eteindre_LED5"
        Me.Eteindre_LED5.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_LED5.TabIndex = 14
        Me.Eteindre_LED5.Text = "Eteindre LED5"
        Me.Eteindre_LED5.UseVisualStyleBackColor = False
        '
        'Eteindre_LED4
        '
        Me.Eteindre_LED4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_LED4.Location = New System.Drawing.Point(294, 119)
        Me.Eteindre_LED4.Name = "Eteindre_LED4"
        Me.Eteindre_LED4.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_LED4.TabIndex = 15
        Me.Eteindre_LED4.Text = "Eteindre LED4"
        Me.Eteindre_LED4.UseVisualStyleBackColor = False
        '
        'Eteindre_LED3
        '
        Me.Eteindre_LED3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_LED3.Location = New System.Drawing.Point(226, 119)
        Me.Eteindre_LED3.Name = "Eteindre_LED3"
        Me.Eteindre_LED3.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_LED3.TabIndex = 16
        Me.Eteindre_LED3.Text = "Eteindre LED3"
        Me.Eteindre_LED3.UseVisualStyleBackColor = False
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("High Tower Text", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Titre.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Titre.Location = New System.Drawing.Point(182, 6)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(368, 25)
        Me.Titre.TabIndex = 17
        Me.Titre.Text = "TABLEAU DE BORD DE LAURENT"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Allumer_TOUT
        '
        Me.Allumer_TOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Allumer_TOUT.Location = New System.Drawing.Point(566, 65)
        Me.Allumer_TOUT.Name = "Allumer_TOUT"
        Me.Allumer_TOUT.Size = New System.Drawing.Size(62, 48)
        Me.Allumer_TOUT.TabIndex = 18
        Me.Allumer_TOUT.Text = "Allumer TOUT"
        Me.Allumer_TOUT.UseVisualStyleBackColor = False
        '
        'Eteindre_TOUT
        '
        Me.Eteindre_TOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Eteindre_TOUT.Location = New System.Drawing.Point(566, 119)
        Me.Eteindre_TOUT.Name = "Eteindre_TOUT"
        Me.Eteindre_TOUT.Size = New System.Drawing.Size(62, 45)
        Me.Eteindre_TOUT.TabIndex = 19
        Me.Eteindre_TOUT.Text = "Eteindre TOUT"
        Me.Eteindre_TOUT.UseVisualStyleBackColor = False
        '
        'Reception_RE0
        '
        Me.Reception_RE0.BackColor = System.Drawing.Color.Yellow
        Me.Reception_RE0.Location = New System.Drawing.Point(634, 65)
        Me.Reception_RE0.Name = "Reception_RE0"
        Me.Reception_RE0.Size = New System.Drawing.Size(68, 48)
        Me.Reception_RE0.TabIndex = 20
        Me.Reception_RE0.Text = "Réception RE0"
        Me.Reception_RE0.UseVisualStyleBackColor = False
        '
        'Etat_USB
        '
        Me.Etat_USB.AutoSize = True
        Me.Etat_USB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etat_USB.Location = New System.Drawing.Point(19, 18)
        Me.Etat_USB.Name = "Etat_USB"
        Me.Etat_USB.Size = New System.Drawing.Size(89, 13)
        Me.Etat_USB.TabIndex = 21
        Me.Etat_USB.Text = "USB déconnecté"
        '
        'TextBox1_Ligne1
        '
        Me.TextBox1_Ligne1.Location = New System.Drawing.Point(89, 183)
        Me.TextBox1_Ligne1.MaxLength = 16
        Me.TextBox1_Ligne1.Name = "TextBox1_Ligne1"
        Me.TextBox1_Ligne1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1_Ligne1.TabIndex = 22
        '
        'Envoyer_ligne1
        '
        Me.Envoyer_ligne1.Location = New System.Drawing.Point(246, 183)
        Me.Envoyer_ligne1.Name = "Envoyer_ligne1"
        Me.Envoyer_ligne1.Size = New System.Drawing.Size(68, 20)
        Me.Envoyer_ligne1.TabIndex = 23
        Me.Envoyer_ligne1.Text = "Envoyer"
        Me.Envoyer_ligne1.UseVisualStyleBackColor = True
        '
        'Effacer_ligne1
        '
        Me.Effacer_ligne1.Location = New System.Drawing.Point(320, 183)
        Me.Effacer_ligne1.Name = "Effacer_ligne1"
        Me.Effacer_ligne1.Size = New System.Drawing.Size(67, 20)
        Me.Effacer_ligne1.TabIndex = 24
        Me.Effacer_ligne1.Text = "Effacer"
        Me.Effacer_ligne1.UseVisualStyleBackColor = True
        '
        'Label_Ligne1
        '
        Me.Label_Ligne1.AutoSize = True
        Me.Label_Ligne1.ForeColor = System.Drawing.Color.Green
        Me.Label_Ligne1.Location = New System.Drawing.Point(28, 186)
        Me.Label_Ligne1.Name = "Label_Ligne1"
        Me.Label_Ligne1.Size = New System.Drawing.Size(42, 13)
        Me.Label_Ligne1.TabIndex = 25
        Me.Label_Ligne1.Text = "Ligne 1"
        '
        'TextBox2_Ligne2
        '
        Me.TextBox2_Ligne2.Location = New System.Drawing.Point(89, 209)
        Me.TextBox2_Ligne2.MaxLength = 16
        Me.TextBox2_Ligne2.Name = "TextBox2_Ligne2"
        Me.TextBox2_Ligne2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2_Ligne2.TabIndex = 26
        '
        'Label_Ligne2
        '
        Me.Label_Ligne2.AutoSize = True
        Me.Label_Ligne2.ForeColor = System.Drawing.Color.Green
        Me.Label_Ligne2.Location = New System.Drawing.Point(28, 212)
        Me.Label_Ligne2.Name = "Label_Ligne2"
        Me.Label_Ligne2.Size = New System.Drawing.Size(42, 13)
        Me.Label_Ligne2.TabIndex = 27
        Me.Label_Ligne2.Text = "Ligne 2"
        '
        'Envoyer_ligne2
        '
        Me.Envoyer_ligne2.Location = New System.Drawing.Point(246, 209)
        Me.Envoyer_ligne2.Name = "Envoyer_ligne2"
        Me.Envoyer_ligne2.Size = New System.Drawing.Size(68, 20)
        Me.Envoyer_ligne2.TabIndex = 28
        Me.Envoyer_ligne2.Text = "Envoyer"
        Me.Envoyer_ligne2.UseVisualStyleBackColor = True
        '
        'Effacer_ligne2
        '
        Me.Effacer_ligne2.Location = New System.Drawing.Point(320, 209)
        Me.Effacer_ligne2.Name = "Effacer_ligne2"
        Me.Effacer_ligne2.Size = New System.Drawing.Size(67, 20)
        Me.Effacer_ligne2.TabIndex = 29
        Me.Effacer_ligne2.Text = "Effacer"
        Me.Effacer_ligne2.UseVisualStyleBackColor = True
        '
        'Barre_PORTA
        '
        Me.Barre_PORTA.Location = New System.Drawing.Point(497, 220)
        Me.Barre_PORTA.Maximum = 6
        Me.Barre_PORTA.Name = "Barre_PORTA"
        Me.Barre_PORTA.Size = New System.Drawing.Size(219, 42)
        Me.Barre_PORTA.TabIndex = 30
        '
        'PORT_A
        '
        Me.PORT_A.AutoSize = True
        Me.PORT_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PORT_A.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PORT_A.Location = New System.Drawing.Point(444, 220)
        Me.PORT_A.Name = "PORT_A"
        Me.PORT_A.Size = New System.Drawing.Size(47, 13)
        Me.PORT_A.TabIndex = 31
        Me.PORT_A.Text = "PORT A"
        '
        'Barre_Voltage
        '
        Me.Barre_Voltage.LargeChange = 1
        Me.Barre_Voltage.Location = New System.Drawing.Point(497, 183)
        Me.Barre_Voltage.Maximum = 254
        Me.Barre_Voltage.Name = "Barre_Voltage"
        Me.Barre_Voltage.Size = New System.Drawing.Size(219, 42)
        Me.Barre_Voltage.TabIndex = 32
        Me.Barre_Voltage.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'VOLTAGE
        '
        Me.VOLTAGE.AutoSize = True
        Me.VOLTAGE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VOLTAGE.Location = New System.Drawing.Point(434, 183)
        Me.VOLTAGE.Name = "VOLTAGE"
        Me.VOLTAGE.Size = New System.Drawing.Size(57, 13)
        Me.VOLTAGE.TabIndex = 33
        Me.VOLTAGE.Text = "VOLTAGE"
        '
        'Effacer_LCD
        '
        Me.Effacer_LCD.Location = New System.Drawing.Point(167, 235)
        Me.Effacer_LCD.Name = "Effacer_LCD"
        Me.Effacer_LCD.Size = New System.Drawing.Size(82, 21)
        Me.Effacer_LCD.TabIndex = 34
        Me.Effacer_LCD.Text = "Tout effacer"
        Me.Effacer_LCD.UseVisualStyleBackColor = True
        '
        'VOLTS_MAX
        '
        Me.VOLTS_MAX.AutoSize = True
        Me.VOLTS_MAX.ForeColor = System.Drawing.Color.Teal
        Me.VOLTS_MAX.Location = New System.Drawing.Point(704, 167)
        Me.VOLTS_MAX.Name = "VOLTS_MAX"
        Me.VOLTS_MAX.Size = New System.Drawing.Size(38, 13)
        Me.VOLTS_MAX.TabIndex = 35
        Me.VOLTS_MAX.Text = "5 volts"
        '
        'Heure
        '
        Me.Heure.AutoSize = True
        Me.Heure.ForeColor = System.Drawing.Color.Maroon
        Me.Heure.Location = New System.Drawing.Point(662, 9)
        Me.Heure.Name = "Heure"
        Me.Heure.Size = New System.Drawing.Size(30, 13)
        Me.Heure.TabIndex = 36
        Me.Heure.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Reception_RE1
        '
        Me.Reception_RE1.BackColor = System.Drawing.Color.Yellow
        Me.Reception_RE1.Location = New System.Drawing.Point(634, 119)
        Me.Reception_RE1.Name = "Reception_RE1"
        Me.Reception_RE1.Size = New System.Drawing.Size(68, 45)
        Me.Reception_RE1.TabIndex = 37
        Me.Reception_RE1.Text = "Réception RE1"
        Me.Reception_RE1.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LED0, Me.LED1, Me.LED7, Me.LED6, Me.LED5, Me.LED4, Me.LED3, Me.LED2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(798, 266)
        Me.ShapeContainer1.TabIndex = 38
        Me.ShapeContainer1.TabStop = False
        '
        'LED0
        '
        Me.LED0.AccessibleName = ""
        Me.LED0.BackColor = System.Drawing.Color.Transparent
        Me.LED0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LED0.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LED0.Location = New System.Drawing.Point(40, 40)
        Me.LED0.Name = "LED0"
        Me.LED0.Size = New System.Drawing.Size(23, 23)
        '
        'LED1
        '
        Me.LED1.BackColor = System.Drawing.Color.Transparent
        Me.LED1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LED1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LED1.Location = New System.Drawing.Point(109, 39)
        Me.LED1.Name = "LED1"
        Me.LED1.Size = New System.Drawing.Size(23, 23)
        '
        'LED7
        '
        Me.LED7.BackColor = System.Drawing.Color.Transparent
        Me.LED7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LED7.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LED7.Location = New System.Drawing.Point(516, 39)
        Me.LED7.Name = "LED7"
        Me.LED7.Size = New System.Drawing.Size(23, 23)
        '
        'LED6
        '
        Me.LED6.BackColor = System.Drawing.Color.Transparent
        Me.LED6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LED6.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LED6.Location = New System.Drawing.Point(447, 39)
        Me.LED6.Name = "LED6"
        Me.LED6.Size = New System.Drawing.Size(23, 23)
        '
        'LED5
        '
        Me.LED5.BackColor = System.Drawing.Color.Transparent
        Me.LED5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LED5.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LED5.Location = New System.Drawing.Point(380, 39)
        Me.LED5.Name = "LED5"
        Me.LED5.Size = New System.Drawing.Size(23, 23)
        '
        'LED4
        '
        Me.LED4.BackColor = System.Drawing.Color.Transparent
        Me.LED4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LED4.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LED4.Location = New System.Drawing.Point(311, 39)
        Me.LED4.Name = "LED4"
        Me.LED4.Size = New System.Drawing.Size(23, 23)
        '
        'LED3
        '
        Me.LED3.BackColor = System.Drawing.Color.Transparent
        Me.LED3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LED3.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LED3.Location = New System.Drawing.Point(244, 39)
        Me.LED3.Name = "LED3"
        Me.LED3.Size = New System.Drawing.Size(23, 23)
        '
        'LED2
        '
        Me.LED2.BackColor = System.Drawing.Color.Transparent
        Me.LED2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LED2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LED2.Location = New System.Drawing.Point(176, 39)
        Me.LED2.Name = "LED2"
        Me.LED2.Size = New System.Drawing.Size(23, 23)
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'Proteus
        '
        Me.Proteus.AutoSize = True
        Me.Proteus.ForeColor = System.Drawing.Color.Gray
        Me.Proteus.Location = New System.Drawing.Point(623, 39)
        Me.Proteus.Name = "Proteus"
        Me.Proteus.Size = New System.Drawing.Size(172, 13)
        Me.Proteus.TabIndex = 39
        Me.Proteus.Text = "Pilotage 18F4550 avec PROTEUS"
        '
        'Envoyer_2_lignes
        '
        Me.Envoyer_2_lignes.Location = New System.Drawing.Point(79, 235)
        Me.Envoyer_2_lignes.Name = "Envoyer_2_lignes"
        Me.Envoyer_2_lignes.Size = New System.Drawing.Size(82, 21)
        Me.Envoyer_2_lignes.TabIndex = 40
        Me.Envoyer_2_lignes.Text = "Tout envoyer"
        Me.Envoyer_2_lignes.UseVisualStyleBackColor = True
        '
        'frmUSB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 266)
        Me.Controls.Add(Me.Envoyer_2_lignes)
        Me.Controls.Add(Me.Proteus)
        Me.Controls.Add(Me.Reception_RE1)
        Me.Controls.Add(Me.Heure)
        Me.Controls.Add(Me.VOLTS_MAX)
        Me.Controls.Add(Me.Effacer_LCD)
        Me.Controls.Add(Me.VOLTAGE)
        Me.Controls.Add(Me.Barre_Voltage)
        Me.Controls.Add(Me.PORT_A)
        Me.Controls.Add(Me.Barre_PORTA)
        Me.Controls.Add(Me.Effacer_ligne2)
        Me.Controls.Add(Me.Envoyer_ligne2)
        Me.Controls.Add(Me.Label_Ligne2)
        Me.Controls.Add(Me.TextBox2_Ligne2)
        Me.Controls.Add(Me.Label_Ligne1)
        Me.Controls.Add(Me.Effacer_ligne1)
        Me.Controls.Add(Me.Envoyer_ligne1)
        Me.Controls.Add(Me.TextBox1_Ligne1)
        Me.Controls.Add(Me.Etat_USB)
        Me.Controls.Add(Me.Reception_RE0)
        Me.Controls.Add(Me.Eteindre_TOUT)
        Me.Controls.Add(Me.Allumer_TOUT)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.Eteindre_LED3)
        Me.Controls.Add(Me.Eteindre_LED4)
        Me.Controls.Add(Me.Eteindre_LED7)
        Me.Controls.Add(Me.Eteindre_LED6)
        Me.Controls.Add(Me.Allumer_LED7)
        Me.Controls.Add(Me.Allumer_LED6)
        Me.Controls.Add(Me.Allumer_LED5)
        Me.Controls.Add(Me.Allumer_LED4)
        Me.Controls.Add(Me.Allumer_LED3)
        Me.Controls.Add(Me.Eteindre_LED2)
        Me.Controls.Add(Me.Allumer_LED2)
        Me.Controls.Add(Me.Eteindre_LED1)
        Me.Controls.Add(Me.Allumer_LED1)
        Me.Controls.Add(Me.Eteindre_LED0)
        Me.Controls.Add(Me.Allumer_LED0)
        Me.Controls.Add(Me.Eteindre_LED5)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(500, 480)
        Me.Name = "frmUSB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Panneau de contrôle"
        CType(Me.Barre_PORTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Barre_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Allumer_LED0 As System.Windows.Forms.Button
    Friend WithEvents Eteindre_LED0 As System.Windows.Forms.Button
    Friend WithEvents Allumer_LED1 As System.Windows.Forms.Button
    Friend WithEvents Eteindre_LED1 As System.Windows.Forms.Button
    Friend WithEvents Allumer_LED2 As System.Windows.Forms.Button
    Friend WithEvents Eteindre_LED2 As System.Windows.Forms.Button
    Friend WithEvents Allumer_LED3 As System.Windows.Forms.Button
    Friend WithEvents Allumer_LED4 As System.Windows.Forms.Button
    Friend WithEvents Allumer_LED5 As System.Windows.Forms.Button
    Friend WithEvents Allumer_LED6 As System.Windows.Forms.Button
    Friend WithEvents Allumer_LED7 As System.Windows.Forms.Button
    Friend WithEvents Eteindre_LED6 As System.Windows.Forms.Button
    Friend WithEvents Eteindre_LED7 As System.Windows.Forms.Button
    Friend WithEvents Eteindre_LED5 As System.Windows.Forms.Button
    Friend WithEvents Eteindre_LED4 As System.Windows.Forms.Button
    Friend WithEvents Eteindre_LED3 As System.Windows.Forms.Button
    Friend WithEvents Titre As System.Windows.Forms.Label
    Friend WithEvents Allumer_TOUT As System.Windows.Forms.Button
    Friend WithEvents Eteindre_TOUT As System.Windows.Forms.Button
    Friend WithEvents Reception_RE0 As System.Windows.Forms.Button
    Friend WithEvents Etat_USB As System.Windows.Forms.Label
    Friend WithEvents TextBox1_Ligne1 As System.Windows.Forms.TextBox
    Friend WithEvents Envoyer_ligne1 As System.Windows.Forms.Button
    Friend WithEvents Effacer_ligne1 As System.Windows.Forms.Button
    Friend WithEvents Label_Ligne1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2_Ligne2 As System.Windows.Forms.TextBox
    Friend WithEvents Label_Ligne2 As System.Windows.Forms.Label
    Friend WithEvents Envoyer_ligne2 As System.Windows.Forms.Button
    Friend WithEvents Effacer_ligne2 As System.Windows.Forms.Button
    Friend WithEvents PORT_A As System.Windows.Forms.Label
    Public WithEvents Barre_PORTA As System.Windows.Forms.TrackBar
    Friend WithEvents Barre_Voltage As System.Windows.Forms.TrackBar
    Friend WithEvents VOLTAGE As System.Windows.Forms.Label
    Friend WithEvents Effacer_LCD As System.Windows.Forms.Button
    Friend WithEvents VOLTS_MAX As System.Windows.Forms.Label
    Friend WithEvents Heure As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Reception_RE1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LED2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LED1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LED7 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LED6 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LED5 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LED4 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LED3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LED0 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Proteus As System.Windows.Forms.Label
    Friend WithEvents Envoyer_2_lignes As System.Windows.Forms.Button

End Class
