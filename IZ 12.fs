open System
let rec insert i = function
| h::t -> min h i::(insert (max h i) t)
| _ ->[i]

let insertionSort l = List.foldBack insert l []

[<EntryPoint>]
let main argv =
    let list = [2; 5; 4; 9; 7; 3; 10; 8; 6; 1 ]
    let result= insertionSort list

    printfn "Изначальный список:      %A" list
    printfn "Отсортированный список:  %A" result

    System.Console.Read()
    0//