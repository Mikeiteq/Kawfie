Imports Discord

Public Class Form1

    Dim WithEvents discord As New DiscordClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            discord.Connect("MzUxMTMyODcwMjU5MTEzOTg0.DIT1-g.qqIEft3YKe1H_vnXw3Np_q4UfBU", TokenType.Bot)
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class
