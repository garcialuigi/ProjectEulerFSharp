let targetNum = 999
let range = [1..targetNum]

let testAndSum (predicate) (x:list<int>) = 
    x |> List.filter (predicate) 
      |> List.sum 

// solution 1
let result = range |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0) 
                   |> List.sum

// solution 2
range 
|> testAndSum (fun x -> x % 3 = 0 || x % 5 = 0)
|> printfn "The sum is %d"
