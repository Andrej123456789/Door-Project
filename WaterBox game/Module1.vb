Module Module1
    Sub Speed1()
        Form1.gboxWater.Location = New Point(7, 40)
        Form1.Timer1.Enabled = True
    End Sub

    Sub WaterIce()
        Form1.ProgressBar1.Value = (50)
        Form1.ProgressBar2.Value = (50)

        Form1.gboxWater.Location = New Point(50, 40)
        Form1.gboxIce.Location = New Point(150, 40)

        Form1.gboxExtraWater.Visible = True
    End Sub

    Sub WaterFire()
        Form1.ProgressBar1.Value = (50)
        Form1.ProgressBar3.Value = (50)

        Form1.gboxWater.Location = New Point(50, 40)
        Form1.gboxFire.Location = New Point(200, 40)
        Form1.gboxIce.Visible = False

        Form1.gboxExtraWater.Visible = True

        Form1.PictureBox4.BackColor = Color.Blue
        Form1.PictureBox5.BackColor = Color.Red
    End Sub

    Sub WaterWater()
        Form1.ProgressBar1.Value = (60)
        Form1.gboxExtraWater.Visible = True
    End Sub

    Sub IceFire()
        Form1.ProgressBar2.Value = (75)
        Form1.ProgressBar3.Value = (60)

        Form1.gboxIce.Location = New Point(150, 20)

        Form1.gboxExtraWater.Visible = True

        Form1.PictureBox4.BackColor = Color.Red
        Form1.PictureBox5.BackColor = Color.DarkRed
    End Sub

    Sub IceIce()
        Form1.ProgressBar2.Value = (75)

        Form1.gboxExtraWater.Visible = True
    End Sub

    Sub FireFire()
        Form1.ProgressBar3.Value = (60)
        Form1.ProgressBar1.Value = (75)
        Form1.ProgressBar2.Value = (75)

        Form1.gboxExtraWater.Visible = True

        Form1.PictureBox4.BackColor = Color.Red
        Form1.PictureBox5.BackColor = Color.DarkRed
    End Sub
End Module

'For Form2'

Module Module2

End Module