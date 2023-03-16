Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtEnter_TextChanged(sender As Object, e As EventArgs) Handles txtEnter.TextChanged

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNum As Integer
        Dim decResult As Decimal

        If IsNumeric(txtEnter.Text) Then
            intNum = Convert.ToInt32(txtEnter.Text)
            If intNum >= 0 Then
                If RBtnInchtoMeter.Checked Then
                    decResult = intNum * 0.0254
                    lblShow.Text = intNum.ToString + " inches is " + decResult.ToString + " meters."
                ElseIf RBtnMetersToInches.Checked Then
                    decResult = intNum * 39.3701
                    lblShow.Text = intNum.ToString + " meters is " + decResult.ToString + " inches."
                End If
            Else
                MsgBox("Enter a positive number")
                txtEnter.Clear()
                lblShow.Text = " "
            End If
        Else
            MsgBox("Enter a number")
            txtEnter.Clear()
            lblShow.Text = " "

        End If


        'lblShow.Text = decResult
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEnter.Clear()
        lblShow.Text = " "
        RBtnMetersToInches.Checked = False
        RBtnInchtoMeter.Checked = True
    End Sub

    Private Sub lblShow_Click(sender As Object, e As EventArgs) Handles lblShow.Click

    End Sub
End Class
