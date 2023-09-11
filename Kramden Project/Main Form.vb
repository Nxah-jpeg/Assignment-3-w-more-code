' Name:         Kramden Project
' Purpose:      Calculates and displays the total cost of expense allowances.
' Programmer:   Noah Wheeler on 9/11/2023


Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the total cost of the expenses allowances.
        Dim intSalesPeople As Integer
        Dim decAllowance As Decimal
        Dim decTotalCost As Decimal

        Integer.TryParse(txtSalespeople.Text, intSalesPeople)
        Decimal.TryParse(txtAllowance.Text, decAllowance)
        decTotalCost = intSalesPeople * decAllowance

        lblTotalCost.Text = decTotalCost.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtAllowance_Enter(sender As Object, e As EventArgs) Handles txtAllowance.Enter
        txtAllowance.SelectAll()

    End Sub

    Private Sub txtAllowance_TextChanged(sender As Object, e As EventArgs) Handles txtAllowance.TextChanged
        lblTotalCost.Text = String.Empty

    End Sub

    Private Sub txtSalespeople_Enter(sender As Object, e As EventArgs) Handles txtSalespeople.Enter
        txtSalespeople.SelectAll()

    End Sub

    Private Sub txtSalespeople_TextChanged(sender As Object, e As EventArgs) Handles txtSalespeople.TextChanged
        lblTotalCost.Text = String.Empty

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSalespeople.Text = ""
        txtAllowance.Text = String.Empty
        lblTotalCost.Text = ""

    End Sub
End Class
