Public Class Form1

    Dim icebrush = Brushes.Blue
    Dim firebrush = Brushes.Red

    Dim down = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Location = New Point(270, 138)
    End Sub

    Private Sub txtStatus_TextChanged(sender As Object, e As EventArgs) Handles txtStatus.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        gboxFire.Visible = False
        gboxWater.Visible = False
        gboxIce.Visible = False
        gboxFire.Visible = True
        gboxFire.Visible = False
    End Sub

    Private Sub WaterBoxManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterBoxManualToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PictureBox1.BackColor = Color.DarkRed
            PictureBox3.BackColor = Color.DarkBlue
        End If

        If CheckBox1.Checked = False Then
            PictureBox1.BackColor = Color.Gray
            PictureBox3.BackColor = Color.Gray
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        gboxFire.Visible = True
        gboxWater.Visible = True
        gboxIce.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExitFromSecondFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitFromSecondFormToolStripMenuItem.Click
        Form2.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gboxWater.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gboxIce.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        gboxFire.Visible = True
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        gboxGame.BackColor = Color.DarkOrange
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        txtStatus.Text = "Error...!!"
    End Sub

    Private Sub gboxIce_Enter(sender As Object, e As EventArgs) Handles gboxIce.Enter

    End Sub

    Private Sub gboxGame_Enter(sender As Object, e As EventArgs) Handles gboxGame.Enter

    End Sub

    Private Sub AnimationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimationToolStripMenuItem.Click

    End Sub

    Private Sub SpeedSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeedSettingsToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer1'
        Timer1.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer1.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer2'
        Timer2.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer2.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer3'
        Timer3.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer3.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub gboxWater_Enter(sender As Object, e As EventArgs) Handles gboxWater.Enter

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click, ProgressBar3.Click, ProgressBar2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer1.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer2.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim closeMsg = MessageBox.Show("Version 1.0, Door-project: 60%, ringwormGO: 40%", "Version", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TutorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialToolStripMenuItem.Click
        txtStatus.Text = "Be sure to you can see boxes of water, ice, fire, ...   Auto start:ON" & vbNewLine & "You need to draw ice and fire."
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ProgressBar3.Increment(1)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer3.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        gboxWater.Location = New Point(7, 20)
        gboxIce.Location = New Point(213, 20)
        gboxFire.Location = New Point(419, 20)
        gboxExtraWater.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        down = False
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        If down = True Then
            PictureBox3.CreateGraphics.FillEllipse(icebrush, e.X, e.Y, 10, 10)
        End If
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        down = True
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        down = True
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        down = False
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If down = True Then
            PictureBox1.CreateGraphics.FillEllipse(firebrush, e.X, e.Y, 10, 10)
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        gboxWater.Location = New Point(7, 40)
        Timer4.Enabled = True

        'Timer4'
        Timer4.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer4.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer5'
        Timer5.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer5.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer6'
        Timer6.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer6.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer4.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ProgressBar2.Increment(10)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer5.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        ProgressBar3.Increment(10)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer6.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer7'
        Timer7.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer7.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer8'
        Timer8.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer8.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer9'
        Timer9.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer9.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        ProgressBar1.Increment(9)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer7.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        ProgressBar2.Increment(9)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer8.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        ProgressBar3.Increment(9)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer9.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer10'
        Timer10.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer10.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer11'
        Timer11.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer11.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer12'
        Timer12.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer12.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        ProgressBar1.Increment(8)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer10.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        ProgressBar2.Increment(8)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer11.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        ProgressBar3.Increment(8)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer12.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer13'
        Timer13.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer13.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer14'
        Timer14.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer14.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer15'
        Timer15.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer15.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        ProgressBar1.Increment(7)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer13.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        ProgressBar2.Increment(7)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer14.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        ProgressBar3.Increment(7)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer15.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer16'
        Timer16.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer16.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer17'
        Timer17.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer17.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer18'
        Timer18.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer18.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer18_Tick(sender As Object, e As EventArgs) Handles Timer18.Tick
        ProgressBar3.Increment(6)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer18.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer16_Tick(sender As Object, e As EventArgs) Handles Timer16.Tick
        ProgressBar1.Increment(6)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer16.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer17_Tick(sender As Object, e As EventArgs) Handles Timer17.Tick
        ProgressBar2.Increment(6)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer17.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer19'
        Timer19.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer19.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer20'
        Timer20.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer20.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer21'
        Timer21.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer21.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer19_Tick(sender As Object, e As EventArgs) Handles Timer19.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer19.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer20_Tick(sender As Object, e As EventArgs) Handles Timer20.Tick
        ProgressBar2.Increment(5)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer20.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub Timer21_Tick(sender As Object, e As EventArgs) Handles Timer21.Tick
        ProgressBar3.Increment(5)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer21.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer22'
        Timer22.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer22.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer23'
        Timer23.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer23.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer24'
        Timer24.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer24.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer22_Tick(sender As Object, e As EventArgs) Handles Timer22.Tick
        ProgressBar1.Increment(4)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer22.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer23_Tick(sender As Object, e As EventArgs) Handles Timer23.Tick
        ProgressBar2.Increment(4)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer23.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub Timer24_Tick(sender As Object, e As EventArgs) Handles Timer24.Tick
        ProgressBar3.Increment(4)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer24.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer25'
        Timer25.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer25.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer26'
        Timer26.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer26.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer27'
        Timer27.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer27.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer25_Tick(sender As Object, e As EventArgs) Handles Timer25.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer25.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer26_Tick(sender As Object, e As EventArgs) Handles Timer26.Tick
        ProgressBar2.Increment(3)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer26.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub Timer27_Tick(sender As Object, e As EventArgs) Handles Timer27.Tick
        ProgressBar3.Increment(3)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer27.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        gboxWater.Location = New Point(7, 40)
        Timer1.Enabled = True

        'Timer28'
        Timer28.Start()
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer28.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If

        'Timer29'
        Timer29.Start()
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer29.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If

        'Timer30'
        Timer30.Start()
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer30.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub Timer28_Tick(sender As Object, e As EventArgs) Handles Timer28.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = (50) Then
            gboxWater.Location = New Point(7, 60)
        ElseIf ProgressBar1.Value = (75) Then
            gboxWater.Location = New Point(7, 80)
        ElseIf ProgressBar1.Value = (100) Then
            Timer28.Stop()
            gboxWater.Location = New Point(7, 150)
            ProgressBar1.Value = (0)
        End If
    End Sub

    Private Sub Timer29_Tick(sender As Object, e As EventArgs) Handles Timer29.Tick
        ProgressBar2.Increment(2)
        If ProgressBar2.Value = (50) Then
            gboxIce.Location = New Point(213, 60)
        ElseIf ProgressBar2.Value = (75) Then
            gboxIce.Location = New Point(213, 80)
        ElseIf ProgressBar2.Value = (100) Then
            Timer29.Stop()
            gboxIce.Location = New Point(213, 150)
            ProgressBar2.Value = (0)
        End If
    End Sub

    Private Sub Timer30_Tick(sender As Object, e As EventArgs) Handles Timer30.Tick
        ProgressBar3.Increment(2)
        If ProgressBar3.Value = (50) Then
            gboxFire.Location = New Point(419, 60)
        ElseIf ProgressBar3.Value = (75) Then
            gboxFire.Location = New Point(419, 80)
        ElseIf ProgressBar3.Value = (100) Then
            Timer30.Stop()
            gboxFire.Location = New Point(419, 150)
            ProgressBar3.Value = (0)
        End If
    End Sub

    Private Sub WaterIceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterIceToolStripMenuItem.Click
        Call WaterIce()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, PictureBox5.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gboxExtraWater.Enter

    End Sub

    Private Sub WaterFireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterFireToolStripMenuItem.Click
        Call WaterFire()
    End Sub

    Private Sub WaterWaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterWaterToolStripMenuItem.Click
        Call WaterWater()
    End Sub

    Private Sub IceFireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IceFireToolStripMenuItem.Click
        Call IceFire()
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        firebrush = Brushes.Yellow
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        firebrush = Brushes.Orange
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        firebrush = Brushes.DarkRed
    End Sub

    Private Sub RedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem1.Click
        firebrush = Brushes.Red
    End Sub

    Private Sub IceIceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IceIceToolStripMenuItem.Click
        Call IceIce()
    End Sub

    Private Sub FireFireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FireFireToolStripMenuItem.Click
        Call FireFire()
    End Sub

    Private Sub ExplosionWaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExplosionWaterToolStripMenuItem.Click
        gboxWater.Visible = False
    End Sub

    Private Sub ExplosionIceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExplosionIceToolStripMenuItem.Click
        gboxIce.Visible = False
    End Sub

    Private Sub ExplosionFireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExplosionFireToolStripMenuItem.Click
        gboxFire.Visible = False
    End Sub
End Class