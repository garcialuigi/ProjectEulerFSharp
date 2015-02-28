open System.Collections.Generic

let printList (l : List<_>) =
    printfn "l.Count: %i, l.Capacity: %i" l.Count l.Capacity
    printfn "Items:"
    l |> Seq.iteri (fun index item ->
        printfn "    l.[%i]: %d" index l.[index])
    printfn "-----------"

let myList = new List<int>()
myList.Add(0)
myList.Add(1)

while myList.[myList.Count - 1] < 4000000 do
   myList.Add(myList.[myList.Count - 1] + myList.[myList.Count - 2])

myList.RemoveAt(myList.Count - 1)

printList myList

myList 
|> Seq.filter (fun x -> x % 2 = 0)
|> Seq.sum
