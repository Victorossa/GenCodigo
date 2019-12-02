Public Class FrmInicio
    Dim aleatorio As Integer

    Public Sub ImagenesAleatorias()
        If aleatorio = 1 Then
            PictureBox1.Image = Image.FromFile("C:\www\GenCodigo\GenCodigoConBD\GenCodigo\PLE\Recursos\FondoPLE0.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If aleatorio = 1 Then
            PictureBox1.Image = Image.FromFile("C:\www\GenCodigo\GenCodigoConBD\GenCodigo\PLE\Recursos\FondoPLE1.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If aleatorio = 2 Then
            PictureBox1.Image = Image.FromFile("C:\www\GenCodigo\GenCodigoConBD\GenCodigo\PLE\Recursos\FondoPLE2.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If aleatorio = 3 Then
            PictureBox1.Image = Image.FromFile("C:\www\GenCodigo\GenCodigoConBD\GenCodigo\PLE\Recursos\FondoPLE3.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If aleatorio = 4 Then
            PictureBox1.Image = Image.FromFile("C:\www\GenCodigo\GenCodigoConBD\GenCodigo\PLE\Recursos\FondoPLE4.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        aleatorio = (Rnd() * 4)
        ImagenesAleatorias()
    End Sub

    Private Sub CreaciònDePlantillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaciònDePlantillasToolStripMenuItem.Click
        FrmPlantillas.Show()
        FrmPlantillas.MdiParent = Me
        FrmPlantillas.BringToFront()
        PictureBox1.SendToBack()
    End Sub

    Private Sub GeneraciònDeProyectosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraciònDeProyectosToolStripMenuItem.Click
        FrmGeneracionDeProyectos.Show()
        FrmGeneracionDeProyectos.MdiParent = Me
        FrmGeneracionDeProyectos.BringToFront()
        PictureBox1.SendToBack()
    End Sub
End Class