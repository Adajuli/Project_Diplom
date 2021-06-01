Public Class Class1

    'Добавление элементов без ограничения доступа

    Public a1, b1, h1

    'Проверка на правильность ввода начального значения функции

    Public ReadOnly Property a() As Single

        Get

            'Возращение значения a1

            Return a1

        End Get

    End Property

    Public ReadOnly Property b() As Single

        Get

            'Возращение значения b1

            Return b1

        End Get

    End Property

    Public ReadOnly Property h() As Single

        Get

            'Возращение значения h1

            Return h1

        End Get

    End Property

    Public Sub inputF()

        'Проверка на правильность ввода начального значения функции

        a1 = CSng(InputBox("Введите начальное значение функции"))

        'Проверка на правильность ввода конечного значения функции

        b1 = CSng(InputBox("Введите конечное значение функции"))

        'Проверка на правильность ввода шага

        h1 = CSng(InputBox("Введите шаг"))

    End Sub

End Class