// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let sum x y = x+y
let pr x y = x*y
let p f x y = f x y

let rec vich f n =
        match n with 
        | 1 -> 1
        | _ ->  let v = vich f (n-1) in
                p f n v 

let p9_3 =
    let b = System.Convert.ToInt32(System.Console.ReadLine())
    (vich sum b,vich pr b)


[<EntryPoint>]
let main argv = 
    
    
    let Ans = p9_3
    System.Console.Write(Ans)
    let z = System.Console.ReadKey()
    
    0 // return an integer exit code
