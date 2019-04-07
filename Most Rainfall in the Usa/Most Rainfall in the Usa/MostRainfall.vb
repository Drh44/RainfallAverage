Public Class MostRainfall
    Private Sub btnRainfall_Click(sender As Object, e As EventArgs) Handles btnRainfall.Click
        'The btnRainfall event accepts and displays up to 8 rain fall values
        'and then calculates and displays the average rain fall per month

        Dim strRainFall As String
        Dim decRainFall As Decimal
        Dim averageRainFall As Decimal
        Dim decTotalRainFall As Decimal = 0D
        Dim strInputMessage As String = "Enter the rain fall for the 1st month"
        Dim strInputHeading As String = "Rain fall"
        Dim strNormalMessage As String = "Enter the rain fall for month # "
        Dim strNonNumericError As String = "Error- Enter a number for the rain fall of month #"
        Dim strNegativeError As String = "Error - Enter a positive number for the rain fall of month # "

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        'This loop will allow the user to enter up to 8 rainfall amount 
        strRainFall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainFall = strCancelClicked
            If IsNumeric(strRainFall) Then

                decRainFall = Convert.ToDecimal(strRainFall)
                If decRainFall > 0 Then

                    RainAmount.Items.Add(decRainFall)
                    decTotalRainFall += decRainFall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage

                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainFall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
        ' Calculates and displays average rain fall
        If intNumberOfEntries > 1 Then
            lblRainfallAmount.Visible = True
            averageRainFall = decTotalRainFall / (intNumberOfEntries - 1)
            lblRainfallAmount.Text = "Average rain fall is " &
                averageRainFall.ToString("F1") & " inches"
        End If
        btnRainfall.Enabled = False

    End Sub

    Private Sub lblRainfallAmount_Click(sender As Object, e As EventArgs) Handles lblRainfallAmount.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        RainAmount.Items.Clear()
        lblRainfallAmount.Visible = False
        btnRainfall.Enabled = True
    End Sub
End Class
