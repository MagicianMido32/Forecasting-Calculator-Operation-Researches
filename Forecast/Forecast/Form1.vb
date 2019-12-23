Public Class Form1


    Private Shared rtr As String
    Public Shared Property returnedWeights() As String
        Get
            Return rtr
        End Get
        Set(value As String)
            rtr = value
        End Set
    End Property

    Sub NaieveForecast()
        Dim I As Integer = 0
        Try
            'naieve forecast
            Dim numberOfItems As Integer = Grdnaieve.Rows.Count - 1
            Dim nums(numberOfItems - 1) As Integer
            For I = 0 To nums.GetUpperBound(0)
                nums(I) = Grdnaieve.Item(1, I).Value
            Next
            For x = 0 To numberOfItems - 2
                Grdnaieve.Item(2, x + 1).Value = nums(x)
                ' Grdnaieve.Item("clmError", x + 1).Value = Grdnaieve.Item("clmDemand", x + 1).Value - Grdnaieve.Item("clm", x + 1).Value
            Next
            Grdnaieve.Update()
            Grdnaieve.Refresh()
        Catch ex As Exception
            MsgBox("Error at cell " & I + 1 & " Please Check your entries", MsgBoxStyle.Critical, "Error ! ")
        End Try

    End Sub

    Sub MovingAvarageForecast()
        Dim I As Integer
        'Try
        Dim numberOfItems As Integer = GrdMovingA.Rows.Count - 1
        Dim PeriodsNum As Integer
        For I = 0 To numberOfItems - 1

            If GrdMovingA.Item("clmPeriodsMA", I).Value <> "" Then
                PeriodsNum = GrdMovingA.Item("clmPeriodsMA", I).Value
                Dim sum As Double = 0
                For x = I - 1 To I - PeriodsNum Step -1

                    sum += GrdMovingA.Item("clmDemandMA", x).Value
                Next

                Dim MovedAvagrage As Double = sum / PeriodsNum
                GrdMovingA.Item("clmForecastMA", I).Value = MovedAvagrage
            End If

        Next
        GrdMovingA.Update()
        GrdMovingA.Refresh()
        'Catch ex As ArgumentException
        '    MsgBox("Error at cell " & I + 1 & vbCrLf & _
        '       " You have set the number of periods to forecast larger than the number of previous periods " _
        '    '           , MsgBoxStyle.Critical, "Error !")
        'Catch ex As Exception
        '    MsgBox("Error at cell " & I + 1 & " Please Check your entries", MsgBoxStyle.Critical, "Error !")
        'End Try
    End Sub

    Sub WeightedMovingAvrageForecast()
        Dim I As Integer
        '  Try
        Dim numberOfItems As Integer = GrdWightedMovingA.Rows.Count - 1
        Dim PeriodsNum As Integer
        For I = 0 To numberOfItems - 1

            If GrdWightedMovingA.Item("clmPeriodsWMA", I).Value <> "" Then
                ''call form ask for weights
                Dim DemansItems As String = ""
                PeriodsNum = GrdWightedMovingA.Item("clmPeriodsWMA", I).Value
                Dim sum As Double = 0
                For x = I - 1 To I - PeriodsNum Step -1
                    DemansItems = GrdWightedMovingA.Item("clmNameWMA", x).Value & "," & DemansItems
                Next
                DemansItems.Remove(DemansItems.Length - 2, 1)
                FrmAskForWeight.Demands = DemansItems
                FrmAskForWeight.ShowDialog()
                Dim weights As String() = returnedWeights.Split(","c)
                Dim countP As Integer = weights.Length - 1
                Dim sumofweights As Double = 0
                For x = I - 1 To I - PeriodsNum Step -1
                    sumofweights += weights(countP)
                    sum += GrdWightedMovingA.Item("clmDemandWMA", x).Value * weights(countP)
                    countP -= 1
                Next
                If sumofweights <> 1 Then
                    Throw New overweightException 'error
                End If
                Dim WeightedMovedAvagrage As Double = sum
                GrdWightedMovingA.Item("clmForecastWMA", I).Value = WeightedMovedAvagrage
            End If
        Next

        'Catch ex As overweightException
        '    MsgBox("Error , summation of weights must equal exactly 1", MsgBoxStyle.Critical, "Error !")
        'Catch ex As ArgumentException
        '    MsgBox("Error at cell " & I + 1 & vbCrLf & _
        '       " You have set the number of periods to forecast larger than the number of previous periods " _
        '           , MsgBoxStyle.Critical, "Error !")
        'Catch ex As Exception
        '    MsgBox("Error at cell " & I + 1 & " Please Check your entries", MsgBoxStyle.Critical, "Error !")
        'End Try

        GrdWightedMovingA.Update()
        GrdWightedMovingA.Refresh()
    End Sub

    Sub ExponentialSmoothForecast()
        Dim I As Integer
        '   Try
        Dim numberOfItems As Integer = GrdExponSmooth.Rows.Count - 1
        Dim nums(numberOfItems - 1) As Integer

        Dim Alpha As Double = 0
        If Not Double.TryParse(TxtAlpha.Text, Alpha) OrElse Alpha > 1 OrElse Alpha < 0 Then
            Throw New overweightException
        End If

        Dim Dt As Double = 0
        Dim Ft As Double = 0
        Dim Forecast As Double = 0
        If GrdExponSmooth.Item("clmForecastEx", 0).Value = "" Then
            GrdExponSmooth.Item("clmForecastEx", 0).Value = GrdExponSmooth.Item("clmDemandEx", 0).Value
        End If
        For I = 1 To nums.GetUpperBound(0)
            Try
                If GrdExponSmooth.Item("clmForecastEx", I).Value = "" Then
                    Dt = GrdExponSmooth.Item("clmDemandEx", I - 1).Value
                    Ft = GrdExponSmooth.Item("clmForecastEx", I - 1).Value
                    Forecast = Alpha * Dt + (1 - Alpha) * Ft
                    GrdExponSmooth.Item("clmForecastEx", I).Value = Forecast
                End If
            Catch ex As Exception
            End Try
        Next
        'Catch ex As overweightException
        '    MsgBox("Smoothing Constant (Alpha) must be a fraction between 1 and zero ", MsgBoxStyle.Critical, "Error !")
        'Catch ex As Exception
        '    MsgBox("Error at cell " & I & " Please Check your entries", MsgBoxStyle.Critical, "Error !")
        'End Try
        GrdExponSmooth.Update()
        GrdExponSmooth.Refresh()
    End Sub

    Sub AdjustedExponentialSmoothingForecast()
        Dim I As Integer
        '  Try
        Dim numberOfItems As Integer = GrdAdjExponential.Rows.Count - 1
        Dim nums(numberOfItems - 1) As Integer

        Dim Alpha As Double = 0
        If Not Double.TryParse(txtAlphaAdj.Text, Alpha) OrElse Alpha > 1 OrElse Alpha < 0 Then
            Throw New overweightException
        End If
        Dim Beta As Double = 0
        If Not Double.TryParse(txtBetaAdj.Text, Beta) OrElse Beta > 1 OrElse Beta < 0 Then
            Throw New overweightException
        End If

        Dim Dt As Double = 0
        Dim Ft As Double = 0
        Dim Tt As Double = 0
        Dim Trender As Double = 0
        Dim Forecast As Double = 0
        Dim AdjustedForecast As Double = 0

        If GrdAdjExponential.Item("clmForecastAdjEx", 0).Value = "" Then
            GrdAdjExponential.Item("clmForecastAdjEx", 0).Value = GrdAdjExponential.Item("clmDemandAdjEx", 0).Value
        End If
        If GrdAdjExponential.Item("clmTrendAdjEx", 0).Value = "" Then
            GrdAdjExponential.Item("clmTrendAdjEx", 0).Value = 0
        End If

        For I = 1 To nums.GetUpperBound(0)
            If GrdAdjExponential.Item("clmForecastAdjEx", I).Value = "" Then

                Dt = GrdAdjExponential.Item("clmDemandAdjEx", I - 1).Value
                Ft = GrdAdjExponential.Item("clmForecastAdjEx", I - 1).Value
                Tt = GrdAdjExponential.Item("clmTrendAdjEx", I - 1).Value

                Forecast = Alpha * Dt + (1 - Alpha) * (Ft + Tt)
                Trender = Beta * (Forecast - Ft) + (1 - Beta) * Tt
                AdjustedForecast = Forecast + Trender
                GrdAdjExponential.Item("clmTrendAdjEx", I).Value = Trender
                GrdAdjExponential.Item("clmForecastAdjEx", I).Value = Forecast
                GrdAdjExponential.Item("clmAdjForecastAdjEx", I).Value = AdjustedForecast
            End If
        Next
        'Catch ex As overweightException
        '    MsgBox("Smoothing Constant (Alpha) and Trend Constant (Beta) must be a fraction between 1 and zero ", MsgBoxStyle.Critical, "Error !")
        'Catch ex As Exception
        '    MsgBox("Error at cell " & I & " Please Check your entries", MsgBoxStyle.Critical, "Error !")
        'End Try
        GrdAdjExponential.Update()
        GrdAdjExponential.Refresh()
    End Sub

    Sub RegressionForecast()
        Dim I As Integer
        '  Try
        Dim numberOfItems As Integer = GrdRegression.Rows.Count - 1
        Dim PeriodsNum As Integer
        For I = 0 To numberOfItems - 1

            If GrdRegression.Item("clmPeriodsRg", I).Value <> "" Then
                PeriodsNum = GrdRegression.Item("clmPeriodsRg", I).Value
                Dim t As Double = I
                Dim sumy As Double = 0
                Dim sumt As Double = 0
                Dim sumty As Double = 0
                Dim sumt2 As Double = 0
                Dim sumtAll2 As Double = 0

                For x = I - 1 To I - PeriodsNum Step -1
                    sumt += GrdRegression.Item("clmNameRg", x).Value
                    sumy += GrdRegression.Item("clmDemandRg", x).Value
                    sumty += GrdRegression.Item("clmNameRg", x).Value * GrdRegression.Item("clmDemandRg", x).Value
                    sumt2 += GrdRegression.Item("clmNameRg", x).Value * GrdRegression.Item("clmNameRg", x).Value
                Next
                sumtAll2 = sumt * sumt

                Dim b As Double = (PeriodsNum * sumty - sumt * sumy) / (PeriodsNum * sumt2 - sumtAll2)
                Dim a As Double = (sumy - b * sumt) / PeriodsNum
                Dim Forecast As Double = a + b * (t + 1)
                GrdRegression.Item("clmForecastRg", I).Value = Forecast
            End If

        Next
        GrdRegression.Update()
        GrdRegression.Refresh()
        'Catch ex As ArgumentException
        '    MsgBox("Error at cell " & I + 1 & vbCrLf & _
        '       " You have set the number of periods to forecast larger than the number of previous periods " _
        '           , MsgBoxStyle.Critical, "Error !")
        'Catch ex As Exception
        '    MsgBox("Error at cell " & I + 1 & " Please Check your entries", MsgBoxStyle.Critical, "Error !")
        'End Try
    End Sub
    Sub clear()

        If Tabz.SelectedTab Is Tabnaive Then
            Grdnaieve.Rows.Clear()
            Grdnaieve.Refresh()
        ElseIf Tabz.SelectedTab Is TabmovingAverage Then
            GrdMovingA.Rows.Clear()
            GrdMovingA.Refresh()
        ElseIf Tabz.SelectedTab Is TabwightedMoving Then
            GrdWightedMovingA.Rows.Clear()
            GrdWightedMovingA.Refresh()
        ElseIf Tabz.SelectedTab Is TabExponenSmooth Then
            TxtAlpha.Text = ""
            GrdExponSmooth.Rows.Clear()
            GrdExponSmooth.Refresh()
        ElseIf Tabz.SelectedTab Is TabAdjExponSmoth Then
            GrdAdjExponential.Rows.Clear()
            GrdAdjExponential.Refresh()
            txtAlphaAdj.Text = ""
            txtBetaAdj.Text = ""
        ElseIf Tabz.SelectedTab Is TabRegression Then
            GrdRegression.Rows.Clear()
            GrdRegression.Refresh()
        End If

    End Sub

    Private Sub BtnForecast_Click_1(sender As Object, e As EventArgs) Handles BtnForecast.Click
        Tabz.Refresh()
        Tabz.Update()
        LblFocus.Focus() 'set focus away so you can update entring cell
        If Tabz.SelectedTab Is Tabnaive Then
            NaieveForecast()
        ElseIf Tabz.SelectedTab Is TabmovingAverage Then
            MovingAvarageForecast()
        ElseIf Tabz.SelectedTab Is TabwightedMoving Then
            WeightedMovingAvrageForecast()
        ElseIf Tabz.SelectedTab Is TabExponenSmooth Then
            ExponentialSmoothForecast()
        ElseIf Tabz.SelectedTab Is TabAdjExponSmoth Then
            AdjustedExponentialSmoothingForecast()
        ElseIf Tabz.SelectedTab Is TabRegression Then
            RegressionForecast()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

End Class
<System.Serializable> Class overweightException
    Inherits Exception
End Class