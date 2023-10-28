Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ram15 As New Random
        Dim result As Integer = ram15.Next(1, 15)
        Dim ram5 As New Random
        Dim result2 As Integer = ram5.Next(1, 5)
        If result = 1 Then
            Label1.Text = "Kẹo ngô (đc dùng trong lễ hội)ban đầu được gọi là 'thức ăn cho gà'."
        ElseIf result = 2 Then
            Label1.Text = "Việc khắc bí ngô nhanh nhất từ ​​trước đến nay chỉ mất 16,47 giây."
        ElseIf result = 3 Then
            Label1.Text = "Công chúa và siêu anh hùng được xếp hạng là trang phục phổ biến nhất (trong Halloween) của trẻ em."
        ElseIf result = 4 Then
            Label1.Text = "Skittles là loại kẹo Halloween hàng đầu."
        ElseIf result = 5 Then
            Label1.Text = "Harry Houdini qua đời vào ngày Halloween năm 1926."
        ElseIf result = 6 Then
            Label1.Text = "Khoảng 46% người Mỹ dự định làm đèn bí ngô vào năm 2023."
        ElseIf result = 7 Then
            Label1.Text = "Từ 'phù thủy' xuất phát từ tiếng Anh cổ wicce, có nghĩa là 'người phụ nữ khôn ngoan'."
        ElseIf result = 8 Then
            Label1.Text = "Chiếc đèn bí ngô nặng nhất thế giới nặng 2.684 pound, 2 ounce hay 1217.49862 kilograms."
        ElseIf result = 9 Then
            Label1.Text = "Người Mỹ từng ăn mừng ngày lễ bằng cách gửi thiệp Halloween."
        ElseIf result = 10 Then
            Label1.Text = "Bí ngô được xếp vào loại trái cây chứ không phải là một loại rau."
        ElseIf result = 11 Then
            Label1.Text = "Trick-or-Treat đã tồn tại từ thời trung cổ."
        ElseIf result = 12 Then
            Label1.Text = "Trick-or-Treat được lấy cảm hứng từ một truyền thống gọi là 'mumming.'"
        ElseIf result = 13 Then
            Label1.Text = "Kẹo không được tặng cho Trick-Or-TreatErs cho đến những năm 1950."
        ElseIf result = 14 Then
            Label1.Text = "Chiến tranh Thế Giới Thứ Hai chứng kiến ​​​​các món ăn Halloween được chia theo khẩu phần"
        ElseIf result = 15 Then
            Label1.Text = "Pennsylvania, tên một bộ phim mang chủ đề Halloween, là có thật"
        End If
        If result2 = 1 Then
            Me.BackgroundImage = My.Resources.one
        ElseIf result2 = 2 Then
            Me.BackgroundImage = My.Resources.two
        ElseIf result2 = 3 Then
            Me.BackgroundImage = My.Resources.three
        ElseIf result2 = 4 Then
            Me.BackgroundImage = My.Resources.four
        ElseIf result2 = 5 Then
            Me.BackgroundImage = My.Resources.five
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ram15 As New Random
        Dim result As Integer = ram15.Next(1, 15)
        Dim ram5 As New Random
        Dim result2 As Integer = ram5.Next(1, 5)
        If result = 1 Then
            Label1.Text = "Kẹo ngô (đc dùng trong lễ hội)ban đầu được gọi là 'thức ăn cho gà'."
        ElseIf result = 2 Then
            Label1.Text = "Việc khắc bí ngô nhanh nhất từ ​​trước đến nay chỉ mất 16,47 giây."
        ElseIf result = 3 Then
            Label1.Text = "Công chúa và siêu anh hùng được xếp hạng là trang phục phổ biến nhất (trong Halloween) của trẻ em."
        ElseIf result = 4 Then
            Label1.Text = "Skittles là loại kẹo Halloween hàng đầu."
        ElseIf result = 5 Then
            Label1.Text = "Harry Houdini qua đời vào ngày Halloween năm 1926."
        ElseIf result = 6 Then
            Label1.Text = "Khoảng 46% người Mỹ dự định làm đèn bí ngô vào năm 2023."
        ElseIf result = 7 Then
            Label1.Text = "Từ 'phù thủy' xuất phát từ tiếng Anh cổ wicce, có nghĩa là 'người phụ nữ khôn ngoan'."
        ElseIf result = 8 Then
            Label1.Text = "Chiếc đèn bí ngô nặng nhất thế giới nặng 2.684 pound, 2 ounce hay 1217.49862 kilograms."
        ElseIf result = 9 Then
            Label1.Text = "Người Mỹ từng ăn mừng ngày lễ bằng cách gửi thiệp Halloween."
        ElseIf result = 10 Then
            Label1.Text = "Bí ngô được xếp vào loại trái cây chứ không phải là một loại rau."
        ElseIf result = 11 Then
            Label1.Text = "Trick-or-Treat đã tồn tại từ thời trung cổ."
        ElseIf result = 12 Then
            Label1.Text = "Trick-or-Treat được lấy cảm hứng từ một truyền thống gọi là 'mumming.'"
        ElseIf result = 13 Then
            Label1.Text = "Kẹo không được tặng cho Trick-Or-TreatErs cho đến những năm 1950."
        ElseIf result = 14 Then
            Label1.Text = "Chiến tranh Thế Giới Thứ Hai chứng kiến ​​​​các món ăn Halloween được chia theo khẩu phần"
        ElseIf result = 15 Then
            Label1.Text = "Pennsylvania, tên một bộ phim mang chủ đề Halloween, là có thật"
        End If
        If result2 = 1 Then
            Me.BackgroundImage = My.Resources.one
        ElseIf result2 = 2 Then
            Me.BackgroundImage = My.Resources.two
        ElseIf result2 = 3 Then
            Me.BackgroundImage = My.Resources.three
        ElseIf result2 = 4 Then
            Me.BackgroundImage = My.Resources.four
        ElseIf result2 = 5 Then
            Me.BackgroundImage = My.Resources.five
        End If
    End Sub
End Class