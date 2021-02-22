Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO

Public Class Form1
    Dim directoryPath As String = ""
    Dim nombreArchivo As String = ""
    Dim valorComprension As Long = 0
    Dim diferencia As Integer = 0
    Dim restante As Integer = 0
    Dim progreso As Integer = 0
    Dim contador As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnprefijo_Click(sender As Object, e As EventArgs)
        txRuta.Text = Directory.GetCurrentDirectory()
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txRuta.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
        Dim codec As ImageCodecInfo
        For Each codec In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next codec
        Return Nothing
    End Function
    Private Sub VaryQualityLevel()
        If txRuta.Text.Length > 1 Then
            directoryPath = txRuta.Text

            Dim Final As Integer = TrackBar1.Value & 0
            valorComprension = (100 - Final)

            BackgroundWorker1.WorkerSupportsCancellation = True
            BackgroundWorker1.WorkerReportsProgress = True

            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim files As String() = Directory.GetFiles(directoryPath, "*.JPG", SearchOption.AllDirectories)
        Dim total As Integer = files.Length

        For Each s As String In files
            directoryPath = Path.GetDirectoryName(s)
            nombreArchivo = Path.GetFileName(s)

            Using bmp1 As New Bitmap(s)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
                Dim myEncoderparameters As New EncoderParameters(1)

                Dim myEncoderParameter As New EncoderParameter(myEncoder, valorComprension&)
                myEncoderparameters.Param(0) = myEncoderParameter
                bmp1.Save(directoryPath & "\" & txPrefijo.Text & nombreArchivo, jpgEncoder, myEncoderparameters)

            End Using
            contador = contador + 1
            diferencia = total
            restante = ((CInt(diferencia) - contador) / diferencia) * 100
            progreso = 100 - restante

            BackgroundWorker1.ReportProgress(CInt(progreso), "Running..." & progreso.ToString)




        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        LabelProcesado.Text = e.ProgressPercentage.ToString & " % Completado"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Cancelled Then
            MessageBox.Show("Tarea cancelada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Terminado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txPrefijo.Text.Length > 0 Then
            VaryQualityLevel()
        Else
            MessageBox.Show("Ingrese texto en renombrar Imagenes", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class

