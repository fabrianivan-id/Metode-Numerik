Public Class Form1
    Function equation(x As Double, y As Double) As Double
        Return (Math.Sin(x * y ^ 2))
    End Function
    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        Dim i As Integer = 0
        Dim count As Integer = -1
        Dim result As Double
        Dim lower As Double = Double.Parse(TextBoxXbawah.Text)
        Dim upper As Double = Double.Parse(TextBoxXAtas.Text)
        Dim y1 As Double = Double.Parse(TextBoxy1.Text)
        Dim h As Double = Double.Parse(TextBoxh.Text)
        Dim search As Double = Double.Parse(TextBoxXsearch.Text)
        Dim functione(20) As Double
        Dim final As Double
        Dim xvalue(20) As Double
        Dim yvalue(20) As Double

        xvalue(i) = lower
        yvalue(i) = y1

        While (xvalue(i) <= upper)
            xvalue(i + 1) = xvalue(i) + h
            i = i + 1
        End While
        i = 0

        While (xvalue(i) <= upper)
            result = equation(xvalue(i), yvalue(i))
            yvalue(i + 1) = yvalue(i) + (h * result)
            i = i + 1
        End While
        i = 0

        DataGridIXYF.Rows.Clear()
        While xvalue(i) <= upper
            functione(i) = equation(xvalue(i), yvalue(i))
            Dim iprint As String = i
            Dim xprint As String = xvalue(i)
            Dim yprint As String = yvalue(i)
            Dim fprint As String = functione(i)
            DataGridIXYF.Rows.Add(New String() {iprint, xprint, yprint, fprint})
            count = count + 1
            i = i + 1
        End While
        i = 0

        yvalue(search) = yvalue(count) + (h / 24) * ((-9 * functione(count - 3)) + (37 * functione(count - 2)) - (59 * functione(count - 1)) + (55 * functione(count)))
        final = equation(search, yvalue(search))
        yvalue(search) = yvalue(count) + (h / 24) * ((functione(count - 2)) - (5 * functione(count - 1)) + (19 * functione(count)) + (9 * final))

        TextBoxNilaiPerkiraan.Text = yvalue(search)

    End Sub
End Class
