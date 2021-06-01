Public Class Form1

    Dim put As Class1 = New Class1
    Public dx, dy, a, b, h As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Процедура, которая предназначена для выполнения табулирования функции и вывода данных в элементы ListBox
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Объявление переменных
        Dim x, y, ymax, ymin, xm, xn, xr, yr As Double
        Dim n As Integer
        put.inputF()

        'Округление чисел после запятой
        a = Math.Round(put.a, 1)
        b = Math.Round(put.b, 1)
        h = Math.Round(put.h, 1)

        'Преобразование числовой переменной в строковую переменную
        TextBox1.Text = CStr(a)
        TextBox2.Text = CStr(b)
        TextBox3.Text = CStr(h)

        'Присваивание значений для максимальных и минимальных значений "x" и "y"
        ymax = 0 : ymin = 0

        'Расчёт количества отрезков табулирования
        n = (b - a) / h

        'Вычисление значений для переменной "x"
        x = a - h

        'Создание цикла для
        For i As Integer = 1 To n
            x = Math.Round(x + h, 1)

            'Формула нахождения значений
            y = 2 * x + 1
            xr = Math.Round(x, 1) : yr = Math.Round(y, 1)

            'Вывод значений в ListBox
            ListBox1.Items.Add(i)
            ListBox2.Items.Add(xr)
            ListBox3.Items.Add(yr)
        Next
    End Sub

    'Процедура, которая даёт возможность переходить на вторую форму Form2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub


    'Процедура для кнопки "Выход", которая предназначена для завершения работы программы
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

End Class

