Public Class frmUSB
    ' vendor and product IDs
    Private Const VendorID As Short = &H3       'VID du périphérique USB (HID terminal - MikroC)
    Private Const ProductID As Short = &H2345   'PID du périphérique USB (HID terminal - MikroC)

    ' read and write buffers
    Private Const BufferInSize As Short = 64    'Taille des données arrivant au PC
    Private Const BufferOutSize As Short = 64   'Taille des données sortant au PC
    Dim lecture_PIC(BufferInSize) As Byte       'Stockage des données reçues - le 1er bit n'est pas utilisé
    Dim ecriture_PIC(BufferOutSize) As Byte     'Stockage des données envoyées - le 1er bit doit être 0
    Dim Stringlen1 As Integer
    Dim Stringlen2 As Integer

    ' ****************************************************************
    ' when the form loads, connect to the HID controller - pass
    ' the form window handle so that you can receive notification
    ' events...
    '*****************************************************************
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' do not remove!
        ConnectToHID(Me)
    End Sub

    '*****************************************************************
    ' disconnect from the HID controller...
    '*****************************************************************
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        DisconnectFromHID()
    End Sub

    '*****************************************************************
    ' Un périphérique USB a été connecté...
    '*****************************************************************
    Public Sub OnPlugged(ByVal pHandle As Integer)
        If hidGetVendorID(pHandle) = VendorID And hidGetProductID(pHandle) = ProductID Then
            ' ** TON CODE ICI... **
            'Font("POLICE",TAILLE,STYLE)
            Dim f As New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
            'affectation du nouveau font
            Etat_USB.Font = f
            Etat_USB.ForeColor = Color.Red
            Etat_USB.Text = "USB connecté"
            'ecriture_PIC(1) = 0
            'ecriture_PIC(34) = 0
            'hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        End If
    End Sub

    '*****************************************************************
    ' Un périphérique USB a été déconnecté...
    '*****************************************************************
    Public Sub OnUnplugged(ByVal pHandle As Integer)
        If hidGetVendorID(pHandle) = VendorID And hidGetProductID(pHandle) = ProductID Then
            hidSetReadNotify(hidGetHandle(VendorID, ProductID), False)
            ' ** TON CODE ICI... **
            LED0.BackColor = Color.Transparent
            LED1.BackColor = Color.Transparent
            LED2.BackColor = Color.Transparent
            LED3.BackColor = Color.Transparent
            LED4.BackColor = Color.Transparent
            LED5.BackColor = Color.Transparent
            LED6.BackColor = Color.Transparent
            LED7.BackColor = Color.Transparent
            'Font("POLICE",TAILLE,STYLE)
            Dim g As New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            'affectation du nouveau font
            Etat_USB.Font = g
            Etat_USB.ForeColor = Color.Black
            Etat_USB.Text = "USB déconnecté"
        End If
    End Sub

    '*****************************************************************
    ' S'exécute à chaque fois que le périphérique USB
    ' se connecte ou se déconnecte
    '*****************************************************************
    Public Sub OnChanged()
        ' get the handle of the device we are interested in, then set
        ' its read notify flag to true - this ensures you get a read
        ' notification message when there is some data to read...
        Dim pHandle As Integer
        pHandle = hidGetHandle(VendorID, ProductID)
        hidSetReadNotify(hidGetHandle(VendorID, ProductID), True)
    End Sub

    '*****************************************************************
    ' A la lecture d'un événement...Du PIC vers le PC
    '*****************************************************************
    Public Sub OnRead(ByVal pHandle As Integer)
        ' Lecture des données (On saute lecture_PIC(0))...
        If hidRead(pHandle, lecture_PIC(0)) Then
            ' ** TON CODE ICI... **
            If lecture_PIC(41) = 20 Then
                Reception_RE0.BackColor = Color.Red
                Reception_RE0.Text = "RE0 allumé !"
            Else : Reception_RE0.BackColor = Color.Yellow
                : Reception_RE0.Text = "RE0  éteint"
                If lecture_PIC(41) = 25 Then
                    Reception_RE1.BackColor = Color.Red
                    Reception_RE1.Text = "RE1 allumé !"
                Else : Reception_RE1.BackColor = Color.Yellow
                    : Reception_RE1.Text = "RE1  éteint"

                    If lecture_PIC(2) = 1 Then
                        LED0.BackColor = Color.Blue
                    Else : LED0.BackColor = Color.Transparent
                    End If
                    If lecture_PIC(3) = 3 Then
                        LED1.BackColor = Color.Blue
                    Else : LED1.BackColor = Color.Transparent
                    End If
                    If lecture_PIC(4) = 5 Then
                        LED2.BackColor = Color.Blue
                    Else : LED2.BackColor = Color.Transparent
                    End If
                    If lecture_PIC(5) = 7 Then
                        LED3.BackColor = Color.Blue
                    Else : LED3.BackColor = Color.Transparent
                    End If
                    If lecture_PIC(6) = 9 Then
                        LED4.BackColor = Color.Blue
                    Else : LED4.BackColor = Color.Transparent
                    End If
                    If lecture_PIC(7) = 11 Then
                        LED5.BackColor = Color.Blue
                    Else : LED5.BackColor = Color.Transparent
                    End If
                    If lecture_PIC(8) = 13 Then
                        LED6.BackColor = Color.Blue
                    Else : LED6.BackColor = Color.Transparent
                    End If
                    If lecture_PIC(9) = 15 Then
                        LED7.BackColor = Color.Blue
                    Else : LED7.BackColor = Color.Transparent
                    End If
                End If
            End If
            ' first byte is the report ID, e.g. lecture_PIC(0)
            ' the other bytes are the data from the microcontroller...
        End If
    End Sub

    '*****************************************************************
    ' Ecriture d'un événement...Du PC vers le PIC
    '*****************************************************************
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_LED0.Click
        ecriture_PIC(41) = 1
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(41) = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_LED0.Click
        ecriture_PIC(41) = 2
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(41) = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_LED1.Click
        ecriture_PIC(42) = 3
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(42) = 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_LED1.Click
        ecriture_PIC(42) = 4
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(42) = 0
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_LED2.Click
        ecriture_PIC(43) = 5
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(43) = 0
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_LED2.Click
        ecriture_PIC(43) = 6
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(43) = 0
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_LED3.Click
        ecriture_PIC(44) = Val(7)
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(44) = 0
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_LED3.Click
        ecriture_PIC(44) = 8
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(44) = 0
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_LED4.Click
        ecriture_PIC(45) = 9
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(45) = 0
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_LED4.Click
        ecriture_PIC(45) = 10
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_LED5.Click
        ecriture_PIC(46) = 11
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(46) = 0
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_LED5.Click
        ecriture_PIC(46) = 12
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(46) = 0
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_LED6.Click
        ecriture_PIC(47) = 13
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(47) = 0
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_LED6.Click
        ecriture_PIC(47) = 14
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(47) = 0
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_LED7.Click
        ecriture_PIC(48) = 15
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(48) = 0
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_LED7.Click
        ecriture_PIC(48) = 16
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(48) = 0
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allumer_TOUT.Click
        ecriture_PIC(49) = 17
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(49) = 0
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eteindre_TOUT.Click
        ecriture_PIC(49) = 18
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        ecriture_PIC(49) = 0
    End Sub

    Private Sub Button19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reception_RE0.Click

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reception_RE1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1_Ligne1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2_Ligne2.TextChanged

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Envoyer_ligne1.Click
        Dim i As Integer
        Dim h As Integer
        Stringlen1 = Len(TextBox1_Ligne1.Text) + 1
        For i = 2 To Stringlen1
            h = i - 1
            ecriture_PIC(i) = Asc(Mid(TextBox1_Ligne1.Text, h, 1))
            hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        Next i
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Effacer_ligne1.Click
        Dim i As Integer
        Dim h As Integer
        TextBox1_Ligne1.Text = "                "
        Stringlen1 = Len(TextBox1_Ligne1.Text) + 1
        For i = 2 To Stringlen1
            h = i - 1
            ecriture_PIC(i) = Asc(Mid(TextBox1_Ligne1.Text, h, 1))
            hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        Next i
        TextBox1_Ligne1.Text = ""
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Envoyer_ligne2.Click
        Dim k As Integer
        Dim j As Integer
        Stringlen2 = Len(TextBox2_Ligne2.Text) + 17

        For j = 18 To Stringlen2
            k = j - 17
            ecriture_PIC(j) = Asc(Mid(TextBox2_Ligne2.Text, k, 1))
            hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        Next j
    End Sub


    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Effacer_ligne2.Click
        Dim k As Integer
        Dim j As Integer
        TextBox2_Ligne2.Text = "                "
        Stringlen2 = Len(TextBox2_Ligne2.Text) + 17

        For j = 18 To Stringlen2
            k = j - 17
            ecriture_PIC(j) = Asc(Mid(TextBox2_Ligne2.Text, k, 1))
            hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        Next j
        TextBox2_Ligne2.Text = ""
    End Sub

    Private Sub Envoyer_2_lignes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Envoyer_2_lignes.Click
        Dim i As Integer
        Dim h As Integer
        Stringlen1 = Len(TextBox1_Ligne1.Text) + 1
        For i = 2 To Stringlen1
            h = i - 1
            ecriture_PIC(i) = Asc(Mid(TextBox1_Ligne1.Text, h, 1))
            hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        Next i
        Dim k As Integer
        Dim j As Integer
        Stringlen2 = Len(TextBox2_Ligne2.Text) + 17

        For j = 18 To Stringlen2
            k = j - 17
            ecriture_PIC(j) = Asc(Mid(TextBox2_Ligne2.Text, k, 1))
            hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        Next j
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Effacer_LCD.Click
        Dim i As Integer
        Dim h As Integer
        TextBox1_Ligne1.Text = "                "
        Stringlen1 = Len(TextBox1_Ligne1.Text) + 1
        For i = 2 To Stringlen1
            h = i - 1
            ecriture_PIC(i) = Asc(Mid(TextBox1_Ligne1.Text, h, 1))
            hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        Next i
        TextBox1_Ligne1.Text = ""
        Dim k As Integer
        Dim j As Integer
        TextBox2_Ligne2.Text = "                "
        Stringlen2 = Len(TextBox2_Ligne2.Text) + 17

        For j = 18 To Stringlen2
            k = j - 17
            ecriture_PIC(j) = Asc(Mid(TextBox2_Ligne2.Text, k, 1))
            hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
        Next j
        TextBox2_Ligne2.Text = ""
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Barre_Voltage.Scroll
        Dim tension As Single
        tension = ((Barre_Voltage.Value / 254) * 5)
        VOLTAGE.Text = Format(tension, "0.00") & "Volts"
        ecriture_PIC(50) = Barre_Voltage.Value
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Barre_PORTA.Scroll
        Dim valeur As Integer
        valeur = Barre_PORTA.Value - 1
        If Barre_PORTA.Value = 0 Then
            PORT_A.Text = "PORTA"
        Else : PORT_A.Text = "RA" & valeur
        End If
        ecriture_PIC(54) = Barre_PORTA.Value
        hidWriteEx(VendorID, ProductID, ecriture_PIC(0))
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PORT_A.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOLTAGE.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Heure.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Heure.Text = Now()
        Heure.Refresh()
    End Sub

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LED2.Click, LED1.Click, LED7.Click, LED6.Click, LED5.Click, LED4.Click, LED3.Click, LED0.Click

    End Sub

    Private Sub Proteus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proteus.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Proteus.ForeColor = Color.Gray Then
            Proteus.ForeColor = Proteus.BackColor
        Else
            Proteus.ForeColor = Color.Gray    ' met ici ta couleur habituelle d'écriture
        End If
    End Sub

    Private Sub Etat_USB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Etat_USB.Click

    End Sub

End Class