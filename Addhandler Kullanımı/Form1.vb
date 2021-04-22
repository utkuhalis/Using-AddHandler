Public Class Form1
    Dim button As New Button 'Yeni bir buton oluşturuyoruz.

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        button.BackColor = Color.DeepSkyBlue  'Oluşturulan button'a Arkaplanı DeppSkyBlue Yapıyoruz.
        button.ForeColor = Color.White  'Oluşturulan button'a Yazı Rengini White Yapıyoruz.
        button.FlatStyle = FlatStyle.Flat 'Oluşturulan button'a Flat Style'yi Flat Yapıyoruz.
        button.Text = "Rastgele Sayı" 'Oluşturulan button'a Yaızısını "Rastgele Sayı" Yapıyoruz.
        button.Size = New Size(132, 42) 'Oluşturulan button'a boyutunu 132, 42 Yapıyoruz.
        button.Location = New Point(158, 141) 'Oluşturulan button'a form'da çıkacağı yeri ayarlıyoruz
        Me.Controls.Add(button) 'Butonu Form'a Ekliyoruz

        AddHandler button.Click, AddressOf mesaj 'Butona Click Eventi Çalışınca Mesaj Bölümündeki kodları çalıştırmasını tanıttık.
    End Sub

    Private Sub mesaj()
        MsgBox("Rastgele Sayı: " & Int(Rnd(100) * (1000)), MsgBoxStyle.Information) 'Ve MsgBox
    End Sub
End Class
