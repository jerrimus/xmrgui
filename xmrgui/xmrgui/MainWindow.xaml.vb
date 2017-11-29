Class MainWindow 

    Dim psave As Integer
    Dim pfetch As Integer
    Dim wal As String

    Private Property pres As Integer

    Private Property fileloc As String

    Private Property txcol As Color

    Private Property fed As String

    Private Property slid As String

    Private Property Ming As Integer

    Private Property winhid As Integer



    Private Sub strop_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles strop.Click


        If pres = 0 Then
            pres = 1

            Label4.Content = "Running"
            Dim wal As String = TextBox1.Text
            Dim pool As String = TextBox2.Text
            Dim port As String = TextBox3.Text


            Dim twrit As System.IO.TextWriter
            twrit = System.IO.File.CreateText("config.txt")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("cpu_threads_conf")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(":")

            twrit.WriteLine("[")
            twrit.Write("{")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("low_power_mode")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(" : ")
            If psave = 1 Then twrit.Write(" true, ")
            If psave = 0 Then twrit.Write(" false, ")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("no_prefetch")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(" : ")
            If pfetch = 1 Then twrit.Write(" true, ")
            If pfetch = 0 Then twrit.Write(" false, ")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("affine_to_cpu")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(" : false")

            twrit.WriteLine("},")




            If slid = 2 Then
                twrit.Write("{")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write("low_power_mode")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write(" : ")
                If psave = 1 Then twrit.Write(" true, ")
                If psave = 0 Then twrit.Write(" false, ")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write("no_prefetch")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write(" : ")
                If pfetch = 1 Then twrit.Write(" true, ")
                If pfetch = 0 Then twrit.Write(" false, ")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write("affine_to_cpu")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write(" : false")
                twrit.WriteLine("},")
            End If

            If slid = 3 Then
                twrit.Write("{")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write("low_power_mode")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write(" : ")
                If psave = 1 Then twrit.Write(" true, ")
                If psave = 0 Then twrit.Write(" false, ")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write("no_prefetch")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write(" : ")
                If pfetch = 1 Then twrit.Write(" true, ")
                If pfetch = 0 Then twrit.Write(" false, ")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write("affine_to_cpu")
                twrit.Write(Microsoft.VisualBasic.Chr(34))
                twrit.Write(" : false")
                twrit.WriteLine("},")
            End If
            twrit.Write("]")
            twrit.WriteLine(",")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("use_slow_memory")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(" : ")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("warn")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(",")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("nicehash_nonce")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": false,")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("aes_override")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": null,")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("use_tls")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": false,")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("tls_secure_algo")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": true,")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("tls_fingerprint")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(" : ")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(",")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("wallet_address")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(" : ")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(wal)
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(",")



            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("pool_address")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(" : ")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(pool)
            twrit.Write(":")
            twrit.Write(port)
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(",")


            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("pool_password")
            twrit.Write(Microsoft.VisualBasic.Chr(34))

            twrit.Write(" : ")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(",")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("call_timeout")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": 10,")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("retry_time")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": 10,")



            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("giveup_limit")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": 0,")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("verbose_level")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": 3,")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("h_print_time")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": 30,")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("daemon_mode")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": false,")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("output_file")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(" : ")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(",")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("httpd_port")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": 0,")

            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.Write("prefer_ipv4")
            twrit.Write(Microsoft.VisualBasic.Chr(34))
            twrit.WriteLine(": true,")
            twrit.Flush()
            twrit.Close()
            If winhid = 1 Then


                Dim ProcessProperties As New ProcessStartInfo

                ProcessProperties.FileName = "xmr-stak-cpu"

                ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden

                Dim myProcess As Process = Process.Start(ProcessProperties)
                Ming = 1
            End If
            If winhid = 0 Then


                Process.Start("xmr-stak-cpu.exe")
                Ming = 1
            End If


        Else
            pres = 0
            Label4.Content = "Stopped"


            If Ming = 1 Then

                For Each P As Process In System.Diagnostics.Process.GetProcessesByName("xmr-stak-cpu")
                    P.Kill()
                Next
                System.IO.File.Delete("config.txt")
            End If
            Ming = 0







        End If

    End Sub

    Private Sub lp_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles lp.Checked
        psave = 1
    End Sub

    Private Sub prefetch_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles prefetch.Checked
        pfetch = 1
    End Sub

    Private Sub prefetch_Unchecked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles prefetch.Unchecked
        pfetch = 0
    End Sub

    Private Sub lp_Unchecked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles lp.Unchecked
        psave = 0
    End Sub

    Private Sub TextBox1_TextInput(ByVal sender As System.Object, ByVal e As System.Windows.Input.TextCompositionEventArgs) Handles TextBox1.TextInput

    End Sub

    Private Sub wl(ByVal p1 As Integer)
        Throw New NotImplementedException
    End Sub

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
  

    End Sub

    Private Sub ex_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles ex.Click
     
        If Ming = 1 Then

            For Each P As Process In System.Diagnostics.Process.GetProcessesByName("xmr-stak-cpu")
                P.Kill()
            Next

            System.IO.File.Delete("config.txt")
        End If
        End
    End Sub

    Private Function ccore() As Object
        Throw New NotImplementedException
    End Function

    Private Function corenum() As Integer
        Throw New NotImplementedException
    End Function

    Private Sub one_Selected(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)

    End Sub


    Private Sub strop_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles strop.Loaded
        Dim ccore = 0
    End Sub

    Private Sub c2_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)

    End Sub

    Private Sub c3_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)

    End Sub

    Private Sub Slider1_ValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles Slider1.ValueChanged
        slid = Slider1.Value.ToString()


      
    End Sub

    Private Sub CheckBox1_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles CheckBox1.Checked
        winhid = 1
    End Sub

    Private Sub CheckBox1_Unchecked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles CheckBox1.Unchecked
        winhid = 0
    End Sub
End Class
