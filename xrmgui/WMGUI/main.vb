Public Class main

    Private Property cdata As String

    Private Property gdata As String

    Private Property minestat As Integer

    Private Property cpucount As Object

    Private Property psave As Integer

    Private Property pfetch As Integer

    Private Property cfg As Object

    Private Property slid As Decimal

    Private Property cointype As String

    Private Property nice As String

    Private Property wstats As String

    Private Property winhid As Integer

    Private Property gpt As String

    Private Property word As String

    Private Property intsn As String


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub gpulist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cpulist_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpulist.SelectedValueChanged
        cdata = cpulist.Text.ToString
        If cdata = "Aeon" Then
            gpulist.Text = cdata
        End If
        If cdata = "Monero" Then
            gpulist.Text = cdata
        End If
        If cdata = "Zcash" Then
            gpulist.Text = cdata
        End If


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gpulist_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then intens.Enabled = True
        If CheckBox5.Checked = False Then
            intens.Enabled = False
            intens.Text = "512"
        End If


    End Sub

    Private Sub gpulist_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpulist.SelectedIndexChanged
        gdata = gpulist.Text.ToString
        If gdata = "Aeon" Then
            cpulist.Text = gdata
            gpunum.Maximum = 6
        End If
        If gdata = "Monero" Then
            cpulist.Text = gdata
            gpunum.Maximum = 6
        End If
        If gdata = "Zcash" Then
            cpulist.Text = gdata
            gpunum.Maximum = 1
            gpunum.Value = 1
        End If


    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then wsize.Enabled = True
        If CheckBox6.Checked = False Then
            wsize.Enabled = False
            wsize.Text = "64"
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If minestat = 0 Then
            cointype = cdata
            If cdata = "Aeon" Then cfg = 0
            If cdata = "Monero" Then cfg = 0
            If cdata = "Zcash" Then cfg = 1
            Dim word = wsize.Text.ToString
            Dim wal As String = userbox.Text
            Dim pool As String = poolbox.Text
            Dim port As String = portbox.Text
            Dim intsn As String = intens.Text
            Dim slid = cpunum.Value
            Dim slid2 = gpunum.Value


            Convert.ToInt32(slid)


            If cfg = 0 Then

                Dim wt As System.IO.TextWriter
                wt = System.IO.File.CreateText("cpu.txt")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("cpu_threads_conf")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(":")

                wt.WriteLine("[")
                wt.Write("{")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("low_power_mode")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                If psave = 1 Then wt.Write(" true, ")
                If psave = 0 Then wt.Write(" false, ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("no_prefetch")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                If pfetch = 1 Then wt.Write(" true, ")
                If pfetch = 0 Then wt.Write(" false, ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("affine_to_cpu")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : false")

                wt.WriteLine("},")

                If slid > 1 Then
                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("low_power_mode")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If psave = 1 Then wt.Write(" true, ")
                    If psave = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("no_prefetch")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If pfetch = 1 Then wt.Write(" true, ")
                    If pfetch = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If

                If slid > 2 Then
                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("low_power_mode")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If psave = 1 Then wt.Write(" true, ")
                    If psave = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("no_prefetch")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If pfetch = 1 Then wt.Write(" true, ")
                    If pfetch = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If
                If slid > 3 Then
                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("low_power_mode")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If psave = 1 Then wt.Write(" true, ")
                    If psave = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("no_prefetch")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If pfetch = 1 Then wt.Write(" true, ")
                    If pfetch = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If
                If slid > 4 Then
                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("low_power_mode")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If psave = 1 Then wt.Write(" true, ")
                    If psave = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("no_prefetch")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If pfetch = 1 Then wt.Write(" true, ")
                    If pfetch = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If
                If slid = 6 Then
                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("low_power_mode")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If psave = 1 Then wt.Write(" true, ")
                    If psave = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("no_prefetch")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If pfetch = 1 Then wt.Write(" true, ")
                    If pfetch = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If
                If slid = 8 Then
                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("low_power_mode")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If psave = 1 Then wt.Write(" true, ")
                    If psave = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("no_prefetch")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If pfetch = 1 Then wt.Write(" true, ")
                    If pfetch = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If
                If slid = 8 Then
                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("low_power_mode")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If psave = 1 Then wt.Write(" true, ")
                    If psave = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("no_prefetch")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    If pfetch = 1 Then wt.Write(" true, ")
                    If pfetch = 0 Then wt.Write(" false, ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If
                wt.Write("]")
                wt.WriteLine(",")

                wt.Flush()
                wt.Close()

                wt = System.IO.File.CreateText("config.txt")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("pool_list")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(" :")
                wt.WriteLine("[")
                wt.Write("{")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("pool_address")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(pool)
                wt.Write(":")
                wt.Write(port)
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(",")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("wallet_address")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(wal)
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(",")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("pool_password")
                wt.Write(Microsoft.VisualBasic.Chr(34))

                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(",")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("use_nicehash")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(": ")
                wt.Write(nice)
                wt.Write(",")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("use_tls")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(": false,")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("tls_fingerprint")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(",")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("pool_weight")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.WriteLine("1 },")

                wt.Write("]")
                wt.WriteLine(",")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("currency")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(cointype)
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(",")



                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("call_timeout")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": 10,")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("retry_time")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": 10,")



                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("giveup_limit")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": 0,")


                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("verbose_level")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": 3,")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("print_motd")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": true,")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("h_print_time")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": 30,")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("aes_override")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": null,")





                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("use_slow_memory")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("warn")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(",")


                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("tls_secure_algo")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": true,")


                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("daemon_mode")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": false,")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("flush_stdout")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": false,")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("output_file")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(",")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("httpd_port")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": 0,")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("http_login")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(",")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("http_pass")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(",")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("prefer_ipv4")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(": true,")
                wt.Flush()
                wt.Close()

                wt = System.IO.File.CreateText("amd.txt")

                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("gpu_threads_conf")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.WriteLine(":")
                wt.WriteLine("[")



                wt.Write("{")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("index")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : 0,")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("intensity")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(intsn)
                wt.Write(",")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("worksize")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : ")
                wt.Write(word)
                wt.Write(",")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("affine_to_cpu")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : false")
                wt.WriteLine("},")

                If slid2 > 1 Then

                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("index")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : 1,")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("intensity")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(intsn)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("worksize")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(word)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If

                If slid2 > 2 Then

                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("index")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : 2,")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("intensity")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(intsn)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("worksize")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(word)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If

                If slid2 > 3 Then

                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("index")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : 3,")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("intensity")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(intsn)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("worksize")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(word)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If

                If slid2 > 4 Then

                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("index")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : 4,")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("intensity")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(intsn)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("worksize")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(word)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If

                If slid2 > 5 Then

                    wt.Write("{")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("index")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : 5,")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("intensity")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(intsn)
                    wt.Write(",")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("worksize")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : ")
                    wt.Write(word)
                    wt.Write(", ")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write("affine_to_cpu")
                    wt.Write(Microsoft.VisualBasic.Chr(34))
                    wt.Write(" : false")
                    wt.WriteLine("},")
                End If


                wt.WriteLine("],")


                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write("platform_index")
                wt.Write(Microsoft.VisualBasic.Chr(34))
                wt.Write(" : 0,")

                wt.Flush()
                wt.Close()

                If System.IO.File.Exists("nvidia.txt") Then
                    System.IO.File.Delete("nvidia.txt")
                End If
                System.IO.File.Copy("amd.txt", "nvidia.txt")

                Button1.Text = "Stop"
                status.Text = "Mining"
                minestat = 1


                If winhid = 1 Then


                    Dim ProcessProperties As New ProcessStartInfo

                    ProcessProperties.FileName = "xmr-stak"

                    ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden

                    Dim myProcess As Process = Process.Start(ProcessProperties)

                End If
                If winhid = 0 Then


                    Process.Start("xmr-stak.exe")

                End If
            End If

            If cfg = 1 Then
                Button1.Text = "Stop"
                status.Text = "Mining"
                minestat = 1
                Dim wt As System.IO.TextWriter
                wt = System.IO.File.CreateText("go.bat")
                wt.Write("nheqminer -l ")
                wt.Write(pool)
                wt.Write(":")
                wt.Write(port)
                wt.Write(" -u ")
                wt.Write(wal)
                wt.Write(" -t ")
                wt.Write(slid)
                wt.Write(" -")
                wt.Write(gpt)
                wt.WriteLine(" 0")


                wt.Flush()
                wt.Close()

                If winhid = 1 Then


                    Dim btf As New ProcessStartInfo

                    btf.FileName = "go.bat"
                    btf.UseShellExecute = True
                    btf.WindowStyle = ProcessWindowStyle.Hidden

                    Dim myProcess As Process = Process.Start(btf)

                End If
                If winhid = 0 Then

                    Dim btf As New ProcessStartInfo

                    btf.FileName = "go.bat"
                    btf.UseShellExecute = True
                    btf.WindowStyle = ProcessWindowStyle.Normal

                    Dim myProcess As Process = Process.Start(btf)

                End If
            End If
        ElseIf minestat = 1 Then
            If cfg = 0 Then

                For Each P As Process In System.Diagnostics.Process.GetProcessesByName("xmr-stak")
                    P.Kill()
                Next
                Button1.Text = "Start"
                status.Text = "Stopped Mining"
                minestat = 0
            End If
            If cfg = 0 Then

                For Each P As Process In System.Diagnostics.Process.GetProcessesByName("nheqminer")
                    P.Kill()
                Next
                Button1.Text = "Start"
                status.Text = "Stopped Mining"
                minestat = 0
            End If
        End If
    End Sub


    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then psave = 1
        If CheckBox9.Checked = False Then psave = 0

    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then pfetch = 1
        If CheckBox10.Checked = False Then pfetch = 0
    End Sub

    Private Sub cpunum_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpunum.Scroll
        cslid.Text = cpunum.Value
    End Sub

    Private Sub gpunum_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpunum.Scroll
        gslid.Text = gpunum.Value

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then nice = "true"
        If CheckBox3.Checked = False Then nice = "false"
    End Sub

    Private Sub CheckBox4_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckStateChanged
        If CheckBox4.Checked = True Then wstats = "true"
        If CheckBox4.Checked = False Then wstats = "false"
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then winhid = 0
        If CheckBox8.Checked = False Then winhid = 1

    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gpt = "od"
        nice = "false"
        winhid = "1"
        wstats = ("false")
        psave = 0
        pfetch = "0"
        intsn = "512"
        word = "64"
    End Sub




    Private Sub CheckBox12_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckStateChanged
        If CheckBox12.Checked = True Then gpt = "cd"
        If CheckBox12.Checked = False Then gpt = "od"

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then pwbox.Enabled = False
        If CheckBox2.Checked = False Then pwbox.Enabled = True
    End Sub
End Class
