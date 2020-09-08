Public Class FrmInicio
    Dim aleatorio As Integer

    Public Sub ImagenesAleatorias()
        If aleatorio = 1 Then
            PictureBox1.Image = Image.FromFile("C:\Users\programador1\source\repos\Nueva carpeta\GenCodigo\GeneradorCod\Recursos\FondoPLE0.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If aleatorio = 1 Then
            PictureBox1.Image = Image.FromFile("C:\Users\programador1\source\repos\Nueva carpeta\GenCodigo\GeneradorCod\Recursos\FondoPLE1.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If aleatorio = 2 Then
            PictureBox1.Image = Image.FromFile("C:\Users\programador1\source\repos\Nueva carpeta\GenCodigo\GeneradorCod\Recursos\FondoPLE2.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If aleatorio = 3 Then
            PictureBox1.Image = Image.FromFile("C:\Users\programador1\source\repos\Nueva carpeta\GenCodigo\GeneradorCod\Recursos\FondoPLE3.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If aleatorio = 4 Then
            PictureBox1.Image = Image.FromFile("C:\Users\programador1\source\repos\Nueva carpeta\GenCodigo\GeneradorCod\Recursos\FondoPLE4.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        aleatorio = (Rnd() * 4)
        ImagenesAleatorias()
    End Sub

    Private Sub CreaciònDePlantillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaciònDePlantillasToolStripMenuItem.Click
        FrmTecnologias.Show()
        FrmTecnologias.MdiParent = Me
        FrmTecnologias.BringToFront()
        PictureBox1.SendToBack()
    End Sub

    Private Sub GeneraciònDeProyectosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraciònDeProyectosToolStripMenuItem.Click
        FrmReplace.Show()
        FrmReplace.MdiParent = Me
        FrmReplace.BringToFront()
        PictureBox1.SendToBack()
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        FrmConfiguracion.Show()
        FrmConfiguracion.MdiParent = Me
        FrmConfiguracion.BringToFront()
        PictureBox1.SendToBack()
    End Sub
    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Reportes.Show()
        Reportes.MdiParent = Me
        Reportes.BringToFront()
        PictureBox1.SendToBack()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FormularioPruebas.Show()
        FormularioPruebas.MdiParent = Me
        FormularioPruebas.BringToFront()
        FormularioPruebas.SendToBack()
    End Sub
End Class