open System
open System.Windows.Forms
open System.Drawing

// Установка главной формы

let window = new Form(Width = 600, Height = 200, Text = "Кнопочка и КО")

// Ползунок

let scrollBar = new TrackBar(Left = 10, Top = 10, Maximum = 560, Value = 560/2, Width = 560)
window.Controls.Add(scrollBar) // Добавляем настроенный ползунок на формочку

// Кнопочка

let button = new Button(Left = 10, Top = 70, Width = scrollBar.Value, Text = "Кнопочка")
window.Controls.Add(button) // Кнопочку аналогично
//
let change _ = button.Width <- scrollBar.Value
do scrollBar.ValueChanged.Add(change)

do Application.Run(window)

[<EntryPoint>]
let main argv =
    0 // return an integer exit code
