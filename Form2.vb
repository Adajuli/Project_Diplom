Public Class Form2
    Private Sub Form2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        'Создание переменной GF для вызова графических объектов
        Dim GF As System.Drawing.Graphics
        GF = PictureBox1.CreateGraphics

        'Использование красного пера для вычерчивания линий и эллипсов
        Dim PenColor As New System.Drawing.Pen(System.Drawing.Color.Red)

        'Изменение осей координат соответственно декартовой системе 
        GF.ScaleTransform(1, -1)

        'Перенос начала координат в центр PictureBox
        GF.TranslateTransform(300, -300)

        'Объявление переменной со значением равным половине ширины PictireBox
        Dim HalfWidth As Integer = PictureBox1.Width / 2

        'Рисуем ось x
        GF.DrawLine(PenColor, -300, 0, 300, 0)

        'Добавляем подписи оси x
        GF.DrawString("x", PictureBox1.Font, Brushes.DarkRed, PictureBox1.Width - 20, PictureBox1.Height \ 2 - 20)

        'Рисуем ось y
        GF.DrawLine(PenColor, 0, -300, 0, 300)

        'Добавляем подпись оси y
        GF.DrawString("y", PictureBox1.Font, Brushes.DarkRed, HalfWidth + 10, 0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Объявление переменных
        Dim a, b, h, n, x, y As Double
        Dim xa, ya As Integer
        Dim GF As System.Drawing.Graphics
        GF = PictureBox1.CreateGraphics
        Dim PenColor As New System.Drawing.Pen(System.Drawing.Color.Red)

        'Импорт введённых значений
        a = Form1.a
        b = Form1.b
        h = Form1.h

        'Определение количества точек
        n = (b - a) / h

        'Форма для вычисления значения переменной "x"
        x = a - h

        'Переход в декартовую систему 
        GF.ScaleTransform(1, -1)

        'Перенос начала координат в PictureBox
        GF.TranslateTransform(PictureBox1.Height / 2, -PictureBox1.Width / 2)

        'Цикл для вычерчивания точек в границах PictureBox
        For i As Integer = 1 To n
            x = Math.Round(x + h, 1)

            'Избегание неопределённости
            y = 2 * x + 1

            'Масшабирование точек
            xa = x * (600 / 8) : ya = y * (600 / 8)

            'Заполнение внутренней части PictureBox
            GF.FillEllipse(Brushes.Black, xa, ya, 7, 7)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
