Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = (Me.ClientSize.Width - Label1.Width) / 2
    End Sub

    Private Async Function GetValorantPUUIDAsync(playerName As String, playerTag As String) As Task(Of String)
        Using client As New HttpClient()
            Dim url As String = $"https://api.henrikdev.xyz/valorant/v1/account/{playerName}/{playerTag}"
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                    Dim json As JObject = JObject.Parse(responseBody)
                    Return json("data")("puuid").ToString()
                Else
                    Return "Error: " & response.ReasonPhrase
                End If
            Catch e As Exception
                Return "Exception: " & e.Message
            End Try
        End Using
    End Function

    Private Async Function GetValorantUsernameAsync(puuid As String) As Task(Of String)
        Using client As New HttpClient()
            Dim url As String = $"https://api.henrikdev.xyz/valorant/v1/by-puuid/account/{puuid}?force=true"
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                    Dim json As JObject = JObject.Parse(responseBody)
                    Return $"{json("data")("name")}#{json("data")("tag")}"
                Else
                    Return "Error: " & response.ReasonPhrase
                End If
            Catch e As Exception
                Return "Exception: " & e.Message
            End Try
        End Using
    End Function

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextInput.Text.Trim()
        Dim output As String = String.Empty

        ' Regex pattern to match UUID format
        Dim uuidPattern As String = "^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$"

        If input.Contains("#") Then
            Dim parts As String() = input.Split("#"c)
            If parts.Length = 2 Then
                output = Await GetValorantPUUIDAsync(parts(0), parts(1))
            Else
                output = "Invalid input format for username."
            End If
        ElseIf Regex.IsMatch(input, uuidPattern) Then
            output = Await GetValorantUsernameAsync(input)
        Else
            output = "Invalid input format for PUUID."
        End If

        TextOutput.Text = output
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextOutput.Text <> String.Empty Then
            Clipboard.SetText(TextOutput.Text)
        Else
            MessageBox.Show("There is no text to copy.", "Info")
        End If
    End Sub

End Class
